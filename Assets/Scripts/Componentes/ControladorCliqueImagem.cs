using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/*
 * Componente responsável por gerenciar a interação do usuário
 * com uma imagem de múltiplos pontos de clique, como é o caso
 * da implementação da carta 9
 */
public class ControladorCliqueImagem : MonoBehaviour{
    
    /*
     * Variável responsável por indexar em ordem, todos os objetos
     * tocáveis na imagem
     */
    public GameObject[] objetos;

    /*
     * Para evitar fazer o carregamento das imagens via código, é
     * indexada todas as imagens através do Unity, na mesma ordem 
     * inserida no vetor de objetos
     */
    public Sprite[] imagens;

    /*
     * Variavel reponsável por armazenar todas as informações de
     * estática, como família, gênero e afins
     */
    private RepositorioConteudo repositorioConteudo;

    /*
     * Variável que armazena o painel do dinossauro, onde são 
     * exibidas todas as informações carregadas a cada clique
     */
    private GameObject pnDinossauro;

    /*
     * Método chamado ao carregar a cena, onde é indexado o 
     * painel de dinossauro e criado o repositório de conteúdo
     */
    void Start(){
        pnDinossauro = GameObject.FindGameObjectWithTag(TagsUI.CenaJogo.PnDinossauro);
        repositorioConteudo = new RepositorioConteudo(imagens);
    }

    /*
     * Método chamado a cada atualização de frame, responsável por ouvir
     * os toques do touch na tela do usuário, verificando se o usuário
     * tocou em algum ponto adicionado na imagem
     */
    void Update(){
        if(!pnDinossauro.GetComponent<AnimadorAbrirFechar>().isAberto()) {

            /*
             * trecho de código usado para debug dentro do unity
             * pois capta a interação do mouse em vez do touch
             */

            /*
            if (Input.GetMouseButtonDown(0)) {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit)) {
                    string nome = hit.transform.name;
                    for (int i = 0; i < objetos.Length; i++) {
                        if (objetos[i].name.Equals(nome)) {
                            onClickGeneroDinossauro(i);
                        }
                    }
                }
            }
            */
            if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began) {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit)) {
                    string nome = hit.transform.name;
                    for (int i = 0; i < objetos.Length; i++) {
                        if (objetos[i].name.Equals(nome)) {
                            onClickGeneroDinossauro(i);
                        }
                    }
                }
            }
        }
    }

    /*
     * Método chamado passando o indice do objeto que foi clicado na tela,
     * fazendo o carregamento do gênero e abrindo a janela para visualização
     */
    public void onClickGeneroDinossauro(int index) {
        setGeneroDinossauro(repositorioConteudo.get(index));
        pnDinossauro.GetComponent<AnimadorAbrirFechar>().abrir();
        GameObject.FindGameObjectWithTag(TagsUI.CenaJogo.PnDinossauro).GetComponent<AnimadorAbrirFechar>().abrir();
    }

    /*
     * Método responsável por setar as informações nos elementos visuais do painel do dinossauro
     */
    public void setGeneroDinossauro(GeneroDinossauro dinossauro){
        GameObject.FindGameObjectWithTag(TagsUI.CenaJogo.ImgDinossauro).GetComponent<Image>().sprite = dinossauro.getSprite();
        GameObject.FindGameObjectWithTag(TagsUI.CenaJogo.TxtGenero).GetComponent<Text>().text = dinossauro.getNomeGenero().ToUpper();
        GameObject.FindGameObjectWithTag(TagsUI.CenaJogo.TxtFamilia).GetComponent<Text>().text = dinossauro.getFamilia().ToUpper();
        GameObject.FindGameObjectWithTag(TagsUI.CenaJogo.TxtDescricao).GetComponent<TextMeshProUGUI>().text = dinossauro.getDescricao();
    }
}

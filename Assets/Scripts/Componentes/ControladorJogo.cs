using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Componente responsável por gerenciar as interações da interface principal da cena de jogo,
 * além de resgatar as informações dadasa na cena de menu
 */
public class ControladorJogo : MonoBehaviour{

    /*
     * vetor para os peões usados como targets no vuforia,
     * inseridos atraves do unity
     */
    public GameObject[] peoes;

    /*
     * vetor para os dinossauros usados como personagens
     * atrelados aos peões dinamicamente apos a seleção
     * do menu principal
     */
    public GameObject[] personagens;

    /*
     * Assim que a classe é instanciada, as variáveis de seleção
     * do dino e do peão são carregadas, e atrelado, para que possa 
     * ser reconhecido pelo vuforia
     */
    void Start() {
        if (personagens.Length > 0 && peoes.Length > 0) {
            int indexPersonagem = ControladorCenas.getParametro(ControladorCenas.PERSONAGEM);
            int indexPeao = ControladorCenas.getParametro(ControladorCenas.PEAO);
            personagens[indexPersonagem].transform.parent = peoes[indexPeao].transform;
        }
    }
    /*
     * Caso clique no botão de voltar, carrega a cena do menu
     * de seleção
     */
    public void OnClickVoltar() {
        GameObject pnDinossauro = GameObject.FindGameObjectWithTag(TagsUI.CenaJogo.PnDinossauro);
        if (pnDinossauro.GetComponent<AnimadorAbrirFechar>().isAberto()) {
            pnDinossauro.GetComponent<AnimadorAbrirFechar>().fechar();
        } else {
            ControladorCenas.carregaCena(ControladorCenas.CENA_MENU);
        }
    }

    /*
     * Se clicar no botão de abrir/fechar o painel de instruções,
     * acessa o controlador de estados do botao, e se houver, faz
     * a mudança de estado, e acessa o painel alterando sua visibilidade
     */
    public void OnClickInstrucao() {
        GameObject PnDinossauro = GameObject.FindGameObjectWithTag(TagsUI.CenaJogo.PnDinossauro);
        if(PnDinossauro != null) {
            if (!PnDinossauro.GetComponent<AnimadorAbrirFechar>().isAberto()) {
                GameObject btnInstrucao = GameObject.FindWithTag(TagsUI.CenaJogo.BtnInstrucao);
                if (btnInstrucao != null) {
                    ControladorEstadosBotao controladorEstadosBotao = btnInstrucao.GetComponent<ControladorEstadosBotao>();
                    if (controladorEstadosBotao != null) {
                        controladorEstadosBotao.mudarEstado();
                    }
                }
                GameObject pnInstrucao = GameObject.FindGameObjectWithTag(TagsUI.CenaJogo.PnInstrucao);
                if (pnInstrucao != null) {
                    pnInstrucao.GetComponent<AnimadorAbrirFechar>().abrirOuFechar();
                }
            }
        }
    }
}

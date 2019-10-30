using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

/*
 * Componente responsável por realizar o controle sobre os objetos 
 * que serão trocados quando é interagido com o botão virtual, posicionado
 * na carta
 */
public class ControladorBotaoRA : MonoBehaviour, IVirtualButtonEventHandler{

    /*
     * Variável pública para ser indexada através do Unity,
     * sendo usado para indexar todos os objetos que serão 
     * trocados a cada interação. 
     */
    public GameObject[] objetos;

    /*
     * Variável pública para ser indexada através do Unity,
     * sendo usado para indexar o botão que realizará a ação,
     * para que possa ser manipulado suas animações de pressionar
     * e soltar
     */
    public GameObject prefBotao;

    /*
     * Variável responsável por armazenar os objetos que serão
     * trocados e também por gerenciá-los, permitindo realizar a troca
     * apenas com chamadas de métodos
     */
    private CarrosselObjetos carrosselObjetos;


    /*
     * Método chamado quando a cena é carregada, e realiza a inserção
     * do listener desta classe, para que assim, o botão ao ser pressionado,
     * chame os métodos OnButtonPressed e OnButtonReleased.
     * 
     * Além disso, este método cria a instância do carrossel para que ele
     * indexe todos os objetos que ele gerenciará
     */
    void Start() {
        gameObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        carrosselObjetos = new CarrosselObjetos(objetos);
    }

    /*
     * Método responsável por ouvir os toques do usuário na tela, e poder descobrir
     * se o usuário clicou sobre o botão virtual através do touch.
     * 
     * É usado também para ouvir os cliques do mouse, porém, só possui serventia em
     * debug para o Unity, sendo que se for descomentado, a captura de cliques no touch
     * dos dispositivos para de funcionar misteriosamente
     */
    void Update() {
        /*
        
        // USADO PARA CAPTAR O CLIQUE DO MOUSE QUANDO ESTÁ EM DEBUG NO UNITY  

        if (Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                mudarObjeto();
                animacaoTocar();
            }
        }

        */
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began) {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                carrosselObjetos.passarParaDireita();
                animacaoTocar();
            }
        }
    }

    /*
     * Método chamado todas as vezes que o usuário cobrir a região
     * do botão virtual sobre a carta, passando para o próximo objeto
     * do carrossel
     */
    public void OnButtonPressed(VirtualButtonBehaviour vb) {
        carrosselObjetos.passarParaDireita();
        animacaoPressionar();
    }

    /*
     * Método chamado todas as vezes que o usuário descobrir o botão
     * que havia coberto anteriormente. Dessa forma a animação do botao
     * voltando pra cima é acionada
     */
    public void OnButtonReleased(VirtualButtonBehaviour vb) {
        animacaoSoltar();
    }

    /*
     * Métodos responsáveis por comandar as animações do botão
     */
    private void animacaoTocar() {
        prefBotao.GetComponent<Animator>().Play("tocar");
    }
    private void animacaoPressionar() {
        prefBotao.GetComponent<Animator>().Play("pressionar");
    }
    private void animacaoSoltar() {
        prefBotao.GetComponent<Animator>().Play("soltar");
    }
}

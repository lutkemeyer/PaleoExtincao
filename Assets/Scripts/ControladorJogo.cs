using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
     * painel de instrução que é ativado ou desativado 
     * através do botao de instrução
     */
    public GameObject pnInstrucao;

    /*
     * Assim que a classe é instanciada, as variáveis de seleção
     * do dino e do peão é carregada, e atrelado, para que possa 
     * ser reconhecido pelo vuforia
     */
    void Start() {
        pnInstrucao.SetActive(false);
        if (personagens.Length > 0 && peoes.Length > 0) {
            int indexPersonagem = ControladorCenas.getParametro(ControladorCenas.PERSONAGEM);
            int indexPeao = ControladorCenas.getParametro(ControladorCenas.PEAO);
            Debug.Log("Recuperou: "  + indexPersonagem + " " + indexPeao);
            personagens[indexPersonagem].transform.parent = peoes[indexPeao].transform;
        } else {
            Debug.Log("Não recuperou");
        }
    }
    /*
     * Caso clique no botão de voltar, carrega a cena do menu
     * de seleção
     */
    public void OnClickVoltar() {
        ControladorCenas.carregaCena(ControladorCenas.CENA_MENU);
    }

    /*
     * Se clicar no botão de abrir/fechar o painel de instruções,
     * acessa o controlador de estados do botao, e se houver, faz
     * a mudança de estado, e acessa o painel alterando sua visibilidade
     */
    public void OnClickInstrucao() {
        GameObject btnInstrucao = GameObject.FindWithTag(Tags.CenaJogo.BtnInstrucao);
        if (btnInstrucao != null) {
            ControladorEstadosBotao controladorEstadosBotao = btnInstrucao.GetComponent<ControladorEstadosBotao>();
            if (controladorEstadosBotao != null) {
                controladorEstadosBotao.mudarEstado();
            }
        }
        if (pnInstrucao != null) {
            pnInstrucao.SetActive(!pnInstrucao.activeSelf);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public GameObject[] dinossauros;

    /*
     * instância do painel de instrucoes usado para abrir
     * e fechar o mesmo, no momento adequado
     */
    public GameObject painelInstrucoes;

    /*
     * variável que controla se o painel de instrução
     * está aberto ou não
     */
    private bool isPainelInstAberto = false;

    /*
     * Assim que a classe é instanciada, as variáveis de seleção
     * do dino e do peão é carregada, e atrelado, para que possa 
     * ser reconhecido pelo vuforia
     */
    void Start() {
        int indexDino = ControladorCenas.getParametro(ControladorCenas.DINOSSAURO);
        int indexPeao = ControladorCenas.getParametro(ControladorCenas.PEAO);
        dinossauros[indexDino].transform.parent = peoes[indexPeao].transform;
    }
    /*
     * Caso clique no botão de voltar, carrega a cena do menu
     * de seleção
     */
    public void OnClickVoltar() {
        ControladorCenas.carregaCena(ControladorCenas.CENA_MENU);
    }

    /*
     * Se clicar no botão de abrir/fechar o painel de instruções
     */
    public void OnClickInstrucoes() {
        if (isPainelInstAberto) {
            painelInstrucoes.SetActive(false);
        } else {
            painelInstrucoes.SetActive(true);
        }
        isPainelInstAberto = !isPainelInstAberto;
    }
}

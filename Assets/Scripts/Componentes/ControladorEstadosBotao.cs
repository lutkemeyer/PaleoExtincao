using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Classe responsável por administrar os sprites conforme os estados
 * dos botões
 */
public class ControladorEstadosBotao: MonoBehaviour{

    /*
     * Variável que indexa os sprites de cada um dos estados do botão
     */
    public Sprite[] sprEstados;

    /*
     * Variável que controla qual é o estado atual do botão
     */
    private int estadoAtual = 0;

    private Button btn { get { return GetComponent<Button>(); } }

    /*
     * Método chamado por classes externas, alternando os estatus definidos anteriormente
     */
    public void mudarEstado() {
        estadoAtual = (estadoAtual == (sprEstados.Length - 1)) ? 0 : estadoAtual + 1;
        btn.image.sprite = sprEstados[estadoAtual];
    }
}

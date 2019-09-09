using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorEstadosBotao : MonoBehaviour{

    public Sprite[] sprEstados;

    private int estadoAtual = 0;

    private Button btn { get { return GetComponent<Button>(); } }

    public void mudarEstado() {
        estadoAtual = (estadoAtual == (sprEstados.Length - 1)) ? 0 : estadoAtual + 1;
        btn.image.sprite = sprEstados[estadoAtual];
    }
}

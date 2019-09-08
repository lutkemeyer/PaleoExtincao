using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJogo : MonoBehaviour
{
    public GameObject[] peoes;
    public GameObject[] dinossauros;

    public GameObject painelInstrucoes;

    private bool isPainelInstAberto = false;

    void Start() {
        int indexDino = ControladorCenas.getParametro(ControladorCenas.DINOSSAURO);
        int indexPeao = ControladorCenas.getParametro(ControladorCenas.PEAO);
        dinossauros[indexDino].transform.parent = peoes[indexPeao].transform;
    }
    public void OnClickVoltar() {
        ControladorCenas.carregaCena(ControladorCenas.CENA_MENU);
    }
    public void OnClickInstrucoes() {
        if (isPainelInstAberto) {
            painelInstrucoes.SetActive(false);
        } else {
            painelInstrucoes.SetActive(true);
        }
        isPainelInstAberto = !isPainelInstAberto;
    }
}

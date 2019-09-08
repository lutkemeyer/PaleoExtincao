using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorMenu : MonoBehaviour
{
    public GameObject[] dinossauros;
    public GameObject[] peoes;
    public Text cabecalho;
    public Button btnVoltar;

    private int indexDino = 0;
    private int indexPeao = 0;

    private bool isSelecionandoDino = true;

    void Start() {
        btnVoltar.interactable = false;
    }

    public void OnClickDireita() {
        if (isSelecionandoDino) {
            if (indexDino < (dinossauros.Length - 1)) {
                dinossauros[indexDino].SetActive(false);
                indexDino++;
                dinossauros[indexDino].SetActive(true);
            } else {
                dinossauros[indexDino].SetActive(false);
                indexDino = 0;
                dinossauros[indexDino].SetActive(true);
            }
        } else {
            if (indexPeao < (peoes.Length - 1)) {
                peoes[indexPeao].SetActive(false);
                indexPeao++;
                peoes[indexPeao].SetActive(true);
            } else {
                peoes[indexPeao].SetActive(false);
                indexPeao = 0;
                peoes[indexPeao].SetActive(true);
            }
        }
    }
    public void OnClickEsquerda() {
        if (isSelecionandoDino) {
            if (indexDino > 0) {
                dinossauros[indexDino].SetActive(false);
                indexDino--;
                dinossauros[indexDino].SetActive(true);
            } else {
                dinossauros[indexDino].SetActive(false);
                indexDino = dinossauros.Length - 1;
                dinossauros[indexDino].SetActive(true);
            }
        } else {
            if (indexPeao > 0) {
                peoes[indexPeao].SetActive(false);
                indexPeao--;
                peoes[indexPeao].SetActive(true);
            } else {
                peoes[indexPeao].SetActive(false);
                indexPeao = peoes.Length - 1;
                peoes[indexPeao].SetActive(true);
            }
        }
    }
    public void OnClickSelecionar() {

        if (isSelecionandoDino) {
            btnVoltar.interactable = true;
            isSelecionandoDino = false;
            dinossauros[indexDino].SetActive(false);
            peoes[indexPeao].SetActive(true);
            cabecalho.text = "ESCOLHA SEU PEÃO";
        } else {
            ControladorDeCenas.addParametro(ControladorDeCenas.DINOSSAURO, indexDino);
            ControladorDeCenas.addParametro(ControladorDeCenas.PEAO, indexPeao);
            ControladorDeCenas.carregaCena(ControladorDeCenas.CENA_JOGO);
        }
    }
    
    public void OnClickVoltar() {
        cabecalho.text = "ESCOLHA SEU PERSONAGEM";
        btnVoltar.interactable = false;
        isSelecionandoDino = true;
        peoes[indexPeao].SetActive(false);
        dinossauros[indexDino].SetActive(true);
    }
}

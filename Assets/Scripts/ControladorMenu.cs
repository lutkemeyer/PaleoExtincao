using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorMenu : MonoBehaviour{

    /*
     * vetor de dinossauros inseridos através
     * do unity
     */
    public GameObject[] personagens;

    /*
     * vetor de peoes inseridos através do
     * unity
     */
    public GameObject[] peoes;

    /*
     * botão de voltar do menu, para que seja 
     * desativado / ativado quando está selecionando
     * um dino / peão
     */
    public Button btnVoltar;

    /* 
     * variável que controla se o usuário
     * está selecionando dinossauros ou peões
     */
    private bool isSelecionandoDino = true;

    private CarrosselObjetos carrosselDinossauros;
    private CarrosselObjetos carrosselPeoes;

    public void Start() {
        carrosselDinossauros = new CarrosselObjetos(personagens);
        carrosselPeoes = new CarrosselObjetos(peoes);
    }
    /*
     * método que troca o objeto para o próximo
     * item do vetor, seja ele um dino ou um peão
     */
    public void OnClickDireita() {
        if (isSelecionandoDino){
            carrosselDinossauros.passarParaDireita();
        } else {
            carrosselPeoes.passarParaDireita();
        }
    }
    /*
     * método que troca o objeto para item anterior
     * do vetor, seja ele um dino ou um peão
     */
    public void OnClickEsquerda() {
        if (isSelecionandoDino) {
            carrosselDinossauros.passarParaEsquerda();
        } else {
            carrosselPeoes.passarParaEsquerda();
        }
    }

    /*
     * Seleciona o peão ou o dino, guardando nas variáveis da classe
     * ou inserindo nas variáveis estáticas para posteriormente trocar de tela 
     * e as mesmas serem possíveis de ser acessadas
     */
    public void OnClickSelecionar() {
        if (isSelecionandoDino) {
            btnVoltar.gameObject.SetActive(true);
            isSelecionandoDino = false;
            carrosselDinossauros.setActive(false);
            carrosselPeoes.setActive(true);
            setTitulo("ESCOLHA SEU PEÃO");
        } else {
            ControladorCenas.addParametro(ControladorCenas.PERSONAGEM, carrosselDinossauros.getIndice());
            ControladorCenas.addParametro(ControladorCenas.PEAO, carrosselPeoes.getIndice());
            ControladorCenas.carregaCena(ControladorCenas.CENA_JOGO);
        }
    }
    
    /*
     * volta a opção de seleção de peão para dino, desativando o botão
     */
    public void OnClickVoltar() {
        setTitulo("ESCOLHA SEU PERSONAGEM");
        btnVoltar.gameObject.SetActive(false);
        isSelecionandoDino = true;
        carrosselDinossauros.setActive(true);
        carrosselPeoes.setActive(false);
    }

    /*
     * Muda o título para o texto que for passado como parâmetro
     */
    private void setTitulo(string texto) {
        GameObject txtTitulo = GameObject.FindGameObjectWithTag("TxtTitulo");
        if(txtTitulo != null) {
            txtTitulo.GetComponent<Text>().text = texto;
        }
    }

}

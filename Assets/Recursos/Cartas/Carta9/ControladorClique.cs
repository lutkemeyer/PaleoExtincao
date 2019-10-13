using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorClique : MonoBehaviour{

    public GameObject[] objetos;
    public Sprite[] imagens;
    public Canvas visualizador;
    public AnimadorImagem animadorImagem;
    public RepositorioConteudo repositorioConteudo;
    public Text txtTitulo, txtTexto;

    void Start(){
        animadorImagem = new AnimadorImagem(visualizador);
        repositorioConteudo = new RepositorioConteudo(imagens);
    }
    void Update(){
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                string nome = hit.transform.name;
                for (int i = 0; i < objetos.Length; i++) {
                    if (objetos[i].name.Equals(nome)) {
                        funcao(i);
                    }
                }
            }
        }
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began) {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                string nome = hit.transform.name;
                for (int i = 0; i<objetos.Length; i++) {
                    if (objetos[i].name.Equals(nome)) {
                        funcao(i);
                    }
                }
            }
        }
        animadorImagem.Update();
    }
    public void funcao(int index) {
        FamiliaDinossauro familia = repositorioConteudo.get(index);
        visualizador.GetComponent<Image>().sprite = familia.GetSprite();
        txtTitulo.GetComponent<Text>().text = familia.getTitulo();
        txtTexto.GetComponent<Text>().text = familia.getTexto();
        animadorImagem.abrir();
    }
    public void OnClick() {
        animadorImagem.fechar();
    }
}

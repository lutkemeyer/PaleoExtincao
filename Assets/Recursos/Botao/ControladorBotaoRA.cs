using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ControladorBotaoRA : MonoBehaviour, IVirtualButtonEventHandler{

    public GameObject[] objetos;
    public GameObject prefabBotao;

    private int index = 0;

    void Start() {
        gameObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                mudarObjeto();
                animacaoTocar();
            }
        }
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began) {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                mudarObjeto();
                animacaoTocar();
            }
        }
    }
    private void mudarObjeto() {
        objetos[index].SetActive(false);
        index = (index == (objetos.Length - 1)) ? 0 : (index + 1);
        objetos[index].SetActive(true);
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb) {
        mudarObjeto();
        animacaoPressionar();
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb) {
        animacaoSoltar();
    }

    private void animacaoTocar() {
        prefabBotao.GetComponent<Animator>().Play("tocar");
    }
    private void animacaoPressionar() {
        prefabBotao.GetComponent<Animator>().Play("pressionar");
    }
    private void animacaoSoltar() {
        prefabBotao.GetComponent<Animator>().Play("soltar");
    }
}

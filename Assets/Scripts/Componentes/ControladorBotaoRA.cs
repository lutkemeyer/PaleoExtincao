using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ControladorBotaoRA : MonoBehaviour, IVirtualButtonEventHandler{

    public GameObject[] objetos;
    public GameObject prefabBotao;

    private CarrosselObjetos carrosselObjetos;

    private int index = 0;

    void Start() {
        gameObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        carrosselObjetos = new CarrosselObjetos(objetos);
    }
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
    public void OnButtonPressed(VirtualButtonBehaviour vb) {
        carrosselObjetos.passarParaDireita();
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ControladorBotaoRA : MonoBehaviour, IVirtualButtonEventHandler{

    public GameObject[] objetos;
    public GameObject vuforiaVirtualButton;
    public GameObject botao3D;

    private int index = 0;

    void Start() {
        vuforiaVirtualButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb) {
        objetos[index].SetActive(false);
        index = (index == (objetos.Length-1)) ? 0 : (index + 1);
        objetos[index].SetActive(true);
        botao3D.GetComponent<Animator>().Play("pressionar");
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb) {
        botao3D.GetComponent<Animator>().Play("soltar");
    }
}

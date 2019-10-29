using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPassarosCenario : MonoBehaviour {

    public Transform InicioTrajeto;
    public GameObject passaro;
    public float velocidadePassaro = 13;

    private GameObject passaroInstanciado;

    void Start(){
        spawnPassaro();
    }

    void FixedUpdate(){
        if (velocidadePassaro != 0 && passaroInstanciado != null) {
            if(passaroInstanciado.GetComponent<Rigidbody>().transform.localPosition.z > 120) {
                destruirPassaro();
                girarTrajeto();
                spawnPassaro();
            }
            passaroInstanciado.GetComponent<Rigidbody>().position += (passaroInstanciado.transform.forward) * (velocidadePassaro * Time.fixedDeltaTime);
            passaroInstanciado.transform.SetParent(InicioTrajeto, false);
        }
    }

    private void destruirPassaro() {
        Destroy(passaroInstanciado);
        passaroInstanciado = null;
    }

    private void girarTrajeto() {
        int[] faixasValoresPossiveis = new int[3];
        faixasValoresPossiveis[0] = Random.Range(0, 46);
        faixasValoresPossiveis[1] = Random.Range(144, 240);
        faixasValoresPossiveis[2] = Random.Range(306, 360);
        Quaternion rotacao = Quaternion.Euler(0, faixasValoresPossiveis[Random.Range(0, 3)], 0);
        transform.rotation = rotacao;
    }

    private void spawnPassaro() {
        passaroInstanciado = Instantiate(passaro, InicioTrajeto.forward, Quaternion.identity) as GameObject;
        passaroInstanciado.AddComponent<Rigidbody>();
        passaroInstanciado.GetComponent<Rigidbody>().useGravity = false;
        passaroInstanciado.transform.localScale = Vector3.one * 2;
    }
}

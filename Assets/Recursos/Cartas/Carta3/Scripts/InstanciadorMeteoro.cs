using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorMeteoro : MonoBehaviour{

    public GameObject meteoro;
    public Transform pontoFinal;
    public int distanciaMeteoro = 10;

    private GameObject meteoroAtual;
    private bool podeInstanciar = false;

    void Start(){

    }

    private void Spawn(){
        Vector3 posicaoInicial = new Vector3(0, ((float)distanciaMeteoro)/10, 0);
        meteoroAtual = Instantiate(meteoro, posicaoInicial, Quaternion.identity) as GameObject;
        meteoroAtual.transform.SetParent(pontoFinal, false);
    }

    public void colidiu() {
        GameObject.Find("ParticulaEstilhacos").GetComponent<ParticleSystem>().Play();
    }

    void Update(){
        if (podeInstanciar) {
            if (meteoroAtual == null) {
                Spawn();
            }
        }
    }

    public void startInstance() {
        podeInstanciar = true;
    }

    public void stopInstance() {
        podeInstanciar = false;
        Destroy(meteoroAtual);
        meteoroAtual = null;
    }
}

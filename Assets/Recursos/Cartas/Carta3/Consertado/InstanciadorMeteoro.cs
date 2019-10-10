using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorMeteoro : MonoBehaviour{

    public GameObject meteoro;
    public Transform pontoFinal;
    public int distanciaMeteoro = 10;

    private GameObject meteoroAtual;

    void Start(){
        Spawn();
    }

    private void Spawn(){
        Vector3 posicaoInicial = new Vector3(0, ((float)distanciaMeteoro)/10, 0);
        meteoroAtual = Instantiate(meteoro, posicaoInicial, Quaternion.identity) as GameObject;
        meteoroAtual.transform.SetParent(pontoFinal, false); // setando o meteoro como filho de PontoFinal
        //Debug.Log(posicaoInicial);
        //Vector3 posicaoFinal = pontoFinal.transform.position;
        //Vector3 direction = posicaoFinal - meteoroInstanciado.transform.position;
        //Quaternion rotation = Quaternion.LookRotation(direction);
        //meteoroInstanciado.transform.localRotation = Quaternion.Lerp(meteoroInstanciado.transform.rotation, rotation, 1);
    }

    void Update(){
        if (meteoroAtual == null) {
            Spawn();
        }
    }
}

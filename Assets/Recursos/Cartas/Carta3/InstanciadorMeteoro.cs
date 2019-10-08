using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorMeteoro : MonoBehaviour{

    public float tempoDeSpawn = 3;
    public GameObject meteoro;
    public Transform pontoFinal;
    public int distanciaMeteoro = 10;

    private float tempoRestante;

    void Start(){
        Spawn();
        tempoRestante = tempoDeSpawn;
    }

    private void Spawn(){
        Vector3 posicaoInicial = new Vector3(0, ((float)distanciaMeteoro)/10, 0);
        GameObject meteoroInstanciado = Instantiate(meteoro, posicaoInicial, Quaternion.identity) as GameObject;
        meteoroInstanciado.transform.SetParent(pontoFinal, false); // setando o meteoro como filho de PontoFinal
        
        //Vector3 posicaoFinal = pontoFinal.transform.position;
        //Vector3 direction = posicaoFinal - meteoroInstanciado.transform.position;
        //Quaternion rotation = Quaternion.LookRotation(direction);
        //meteoroInstanciado.transform.localRotation = Quaternion.Lerp(meteoroInstanciado.transform.rotation, rotation, 1);
    }

    // Update is called once per frame
    void Update(){

        tempoRestante -= Time.deltaTime;
        if (tempoRestante < 0) {
            tempoRestante = tempoDeSpawn;
            Spawn();
        }
    }
}

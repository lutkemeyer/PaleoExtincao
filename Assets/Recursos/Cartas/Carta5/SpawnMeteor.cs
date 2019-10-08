using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMeteor : MonoBehaviour{

    public float tempoDeSpawn = 3;
    public GameObject meteoro;
    public Transform pontoInicial;
    public Transform pontoFinal;

    private float tempoRestante;

    void Start(){
        tempoRestante = tempoDeSpawn;
        Spawn();
    }

    private void Spawn() {
        Vector3 startPos = pontoInicial.position;
        GameObject meteoroInstanciado = Instantiate(meteoro, startPos, Quaternion.identity) as GameObject;
        Vector3 endPos = pontoFinal.position;
        RotateTo(meteoroInstanciado, endPos);
    }

    void Update() {
        tempoRestante -= Time.deltaTime;
        if (tempoRestante < 0) {
            tempoRestante = tempoDeSpawn;
            Spawn();
        }
    }

    void RotateTo(GameObject obj, Vector3 destination){
        Vector3 direction = destination - obj.transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        obj.transform.localRotation = Quaternion.Lerp(obj.transform.rotation, rotation, 1);
    }
}

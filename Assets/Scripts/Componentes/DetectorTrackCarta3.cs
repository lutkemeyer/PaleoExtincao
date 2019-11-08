using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Componente responsável por realizar a detecção da carta 3,
 * fazendo com que o meteoro nao seja instanciado quando a carta
 * não foi detectada
 */
public class DetectorTrackCarta3 : ControladorDeteccaoAR{

    /*
     * Objeto que gerencia a queda do meteoro
     */
    public GameObject prefColisaoMeteoro;

    /*
     * Quando a carta for detectada, permite o inicio da queda de meteoros
     */
    public override void onApareceu() {
        InstanciadorMeteoro instanciador = prefColisaoMeteoro.GetComponentInChildren<InstanciadorMeteoro>();
        if (instanciador != null) {
            instanciador.startInstance();
        }
    }

    /*
     * Quando a carta sumir da detecção, envia um sinal interrompendo a queda de meteoros
     */
    public override void onDesapareceu() {
        InstanciadorMeteoro instanciador = prefColisaoMeteoro.GetComponentInChildren<InstanciadorMeteoro>();
        if(instanciador != null) {
            instanciador.stopInstance();
        }
    }

    public override void onNaoApareceu() {
        Debug.Log("carta não apareceu");
    }
}
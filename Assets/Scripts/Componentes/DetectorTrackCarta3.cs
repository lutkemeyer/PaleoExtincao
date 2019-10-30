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
    public GameObject PrefMeteoroNaTerra;

    /*
     * Quando a carta for detectada, permite o inicio da queda de meteoros
     */
    public override void onApareceu() {
        PrefMeteoroNaTerra.GetComponent<InstanciadorMeteoro>().startInstance();
    }

    /*
     * Quando a carta sumir da detecção, envia um sinal interrompendo a queda de meteoros
     */
    public override void onDesapareceu() {
        PrefMeteoroNaTerra.GetComponent<InstanciadorMeteoro>().stopInstance();
    }

    public override void onNaoApareceu() {
    }
}
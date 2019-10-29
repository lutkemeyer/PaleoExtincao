using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorTrackCarta3 : ControladorDeteccaoAR{

    public GameObject PrefMeteoroNaTerra;

    public override void onApareceu() {
        PrefMeteoroNaTerra.GetComponent<InstanciadorMeteoro>().startInstance();
    }
    public override void onDesapareceu() {
        PrefMeteoroNaTerra.GetComponent<InstanciadorMeteoro>().stopInstance();
    }
    public override void onNaoApareceu() {
    }
}
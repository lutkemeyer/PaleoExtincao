using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorTrackCarta3 : ControladorDeteccaoAR{
    public override void onApareceu() {
        GameObject.Find("MeteoroNaTerra").GetComponent<InstanciadorMeteoro>().startInstance();
    }
    public override void onDesapareceu() {
        GameObject.Find("MeteoroNaTerra").GetComponent<InstanciadorMeteoro>().stopInstance();
    }
    public override void onNaoApareceu() {
    }
}
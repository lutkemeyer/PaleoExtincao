using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorTestes : MonoBehaviour{

    public GameObject obj;
    public Text btnX, btnY, btnZ;

    public void pressX() {
        bool val = obj.GetComponent<RotacionadorAutomatico>().EixoX;
        val = !val;
        obj.GetComponent<RotacionadorAutomatico>().EixoX = val;
        btnX.text = "X " + val;
    }
    public void pressY() {
        bool val = obj.GetComponent<RotacionadorAutomatico>().EixoY;
        val = !val;
        obj.GetComponent<RotacionadorAutomatico>().EixoY = val;
        btnY.text = "Y " + val;
    }
    public void pressZ() {
        bool val = obj.GetComponent<RotacionadorAutomatico>().EixoZ;
        val = !val;
        obj.GetComponent<RotacionadorAutomatico>().EixoZ = val;
        btnZ.text = "Z " + val;
    }
}

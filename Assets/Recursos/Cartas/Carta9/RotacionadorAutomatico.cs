using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionadorAutomatico : MonoBehaviour{

    public Transform alvo;
    public bool EixoX = false, EixoY = false, EixoZ = false;
    
    void Update(){
        Vector3 direction = alvo.position - transform.position;
        Quaternion rotacao3eixos = Quaternion.LookRotation(direction);
        Quaternion rotacaoCorrigida = transform.rotation;
        if (EixoX) {
            rotacaoCorrigida.x = rotacao3eixos.x;
        }
        if (EixoY) {
            rotacaoCorrigida.y = rotacao3eixos.y;
        }
        if (EixoZ) {
            rotacaoCorrigida.z = rotacao3eixos.z;
        }
        transform.rotation = rotacaoCorrigida;
    }
}

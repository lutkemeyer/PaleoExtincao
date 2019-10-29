using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCeu : MonoBehaviour{

    /*
     * valor referente a velocidade
     * em que o céu gira
     */
    public float velocidade = 1.2f;

    /*
     * faz a posição do céu ser atualizada
     * a cada frame
     */
    void Update() {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * velocidade);
    }
}

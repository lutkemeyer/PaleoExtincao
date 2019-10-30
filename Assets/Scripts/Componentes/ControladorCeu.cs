using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Componente responsável por fazer as nuvens girarem
 */
public class ControladorCeu : MonoBehaviour{

    /*
     * Valor referente a velocidade
     * em que o céu gira
     */
    public float velocidade = 1.2f;

    /*
     * Faz a posição do céu ser atualizada
     * a cada frame
     */
    void Update() {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * velocidade);
    }
}

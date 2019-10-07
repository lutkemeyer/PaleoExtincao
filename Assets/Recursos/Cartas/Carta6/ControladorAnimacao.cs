using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAnimacao : MonoBehaviour{
    public enum TipoReproducao{ SEQUENCIAL = 0, ALEATORIO = 1 }

    public TipoReproducao tipoReproducao;

    public Motion[] animacoes;

    void Start(){

        Animator animator = GetComponent<Animator>();
        
    }

    void Update(){
        
    }
}

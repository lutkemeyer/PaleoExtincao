using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicializadorFumaca : MonoBehaviour{

    public ParticleSystem particulas;

    void Start(){
        //particulas.GetComponent<ParticleSystem>().st
        particulas.GetComponent<ParticleSystem>().Play();
        particulas.Play();
    }
    void Update(){
        
    }
}

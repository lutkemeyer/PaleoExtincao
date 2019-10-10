using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class ScriptParticulas : MonoBehaviour{

    private ParticleSystem sp;
    private ParticleSystem.Particle[] particulas;

    void Start(){
        sp = GetComponent<ParticleSystem>();
        particulas = new ParticleSystem.Particle[sp.main.maxParticles];
    }
    void Update(){
        int numParticlesAlive = sp.GetParticles(particulas);
        Debug.Log(numParticlesAlive);

    }
}

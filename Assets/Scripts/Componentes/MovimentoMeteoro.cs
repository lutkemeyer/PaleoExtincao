using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * 
 */
public class MovimentoMeteoro : MonoBehaviour{

    public float velocidade = 5;

    private Rigidbody rb;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void Update() {
    }

    void FixedUpdate() {
        if (velocidade != 0 && rb != null) {
            rb.position += (transform.up * -1) * (velocidade * Time.deltaTime);
        }
    }
    private void OnCollisionEnter(Collision collision) {
        autoDestruir();
        GameObject.Find("PrefMeteoroColidindoTerra").GetComponent<InstanciadorMeteoro>().colidiu();
    }

    private void autoDestruir() {
        Destroy(gameObject);
    }
}
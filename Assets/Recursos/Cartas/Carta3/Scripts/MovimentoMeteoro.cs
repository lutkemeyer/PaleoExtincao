using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        GameObject.Find("MeteoroNaTerra").GetComponent<InstanciadorMeteoro>().colidiu();
        //Debug.Log(collision.collider.name);
        
        //ContactPoint contact = collision.contacts[0];

        //ParticleSystem pd = Instantiate(, posicaoInicial, Quaternion.identity) as GameObject;

        //contact.point
        //Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        //Vector3 pos = contact.point;
        
        
    }

    private void autoDestruir() {
        Destroy(gameObject);
    }
}
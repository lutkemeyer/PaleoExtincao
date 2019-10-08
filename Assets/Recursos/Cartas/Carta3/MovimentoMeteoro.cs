using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoMeteoro : MonoBehaviour{

    public float tempoDeVidaMax = 5;

    public float velocidade;
    public GameObject impactPrefab;

    private Rigidbody rb;
    private float tempoDeVidaRestante;
    void Start() {
        tempoDeVidaRestante = tempoDeVidaMax;
        rb = GetComponent<Rigidbody>();
    }

    void Update() {
        tempoDeVidaRestante -= Time.deltaTime;
        if (tempoDeVidaRestante < 0) {
            Destroy(gameObject);
        }
    }
    void FixedUpdate() {
        if (velocidade != 0 && rb != null) {
            rb.position += (transform.up * -1) * (velocidade * Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision collision) {
        velocidade = 0;

        ContactPoint contact = collision.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;
        if (impactPrefab != null) {

        }
        Destroy(gameObject);
    }
}
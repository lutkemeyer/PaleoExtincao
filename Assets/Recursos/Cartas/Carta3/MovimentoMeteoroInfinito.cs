using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoMeteoroInfinito : MonoBehaviour{

    public float velocidade;
    public GameObject impactPrefab;
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

    void OnTriggerEnter(Collider other) {
        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision collision) {
        velocidade = 0;

        ContactPoint contact = collision.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;
        if (impactPrefab != null) {

        }
        Debug.Log("colidiu");
        Destroy(gameObject);
    }
}
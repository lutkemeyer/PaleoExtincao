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
    void OnTriggerEnter(Collider other) {
        autoDestruir();
    }
    void OnCollisionEnter(Collision collision) {
        
        ContactPoint contact = collision.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;
        Debug.Log("colidiu");
        
    }

    private void autoDestruir() {
        Destroy(gameObject);
    }
}
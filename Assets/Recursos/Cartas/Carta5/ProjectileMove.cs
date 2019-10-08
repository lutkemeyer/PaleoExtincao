using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour{

    public float speed;
    public GameObject impactPrefab;

    private Rigidbody rb;

    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate(){
        if (speed != 0 && rb != null) {
            rb.position += transform.forward * (speed * Time.deltaTime);
        }
    }
}

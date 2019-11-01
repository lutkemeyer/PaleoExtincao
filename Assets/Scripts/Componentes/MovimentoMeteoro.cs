using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Componente responsável por mover o meteoro sempre para baixo
 * na sua posição local, em sua devida velocidade
 */
public class MovimentoMeteoro : MonoBehaviour{

    /*
     * Variável responsável por controlar a velocidade do meteoro,
     * possivel de alterar pelo Unity
     */
    public float velocidade = 3;

    /*
     * Variável que guarda o componente RigidBody do próprio meteoro,
     * que basicamente e interpretado como se fosse a "Massa" do meteoro
     */
    private Rigidbody rb;

    /*
     * Método que capta o componente ao instanciar o objeto
     */
    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    /*
     * Método que atualiza a posicao do meteoro independente da taxa
     * de atualizaçoes de quadros
     */
    void FixedUpdate() {
        if (velocidade != 0 && rb != null) {
            rb.position += (transform.up * -1) * (velocidade/100 * Time.fixedDeltaTime);
        }
    }

}
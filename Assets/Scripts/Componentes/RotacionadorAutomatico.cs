using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Componente responsável por alinhar o objeto atrelado ao
 * objeto alvo, pelos eixos que o usuário selecionar
 */
public class RotacionadorAutomatico : MonoBehaviour{

    /*
     * Variável alvo que será usado de referencia para o 
     * alinhamento
     */
    public Transform alvo;

    /*
     * Variáveis de controle de eixos que serão alinhados
     */
    public bool EixoX = false, EixoY = false, EixoZ = false;
    

    /*
     * Método chamado ao renderizar cada quadro, fazendo se alinhar
     * de forma suave
     */
    void Update(){
        Vector3 direction = alvo.position - transform.position;
        Quaternion rotacao3eixos = Quaternion.LookRotation(direction);
        Quaternion rotacaoCorrigida = transform.rotation;
        if (EixoX) {
            rotacaoCorrigida.x = rotacao3eixos.x;
        }
        if (EixoY) {
            rotacaoCorrigida.y = rotacao3eixos.y;
        }
        if (EixoZ) {
            rotacaoCorrigida.z = rotacao3eixos.z;
        }
        transform.rotation = rotacaoCorrigida;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Componente responsável por instanciar e gerenciar os pássaros
 * presentes voando no menu principal
 */
public class ControladorPassarosCenario : MonoBehaviour {

    /*
     * Variável que indica a posição incial onde
     * sempre será instanciado o pássaro
     */
    public Transform InicioTrajeto;

    /*
     * Variável usada unicamente para indicar que tipo
     * de objeto será instanciado, neste caso, o pássaro
     */
    public GameObject passaro;

    /*
     * Variável pública que indica a velocidade do pássaro,
     * sendo possível alterar externamente
     */
    public float velocidadePassaro = 13;

    /*
     * Variável que armazena o único pássaro ativo na cena
     */
    private GameObject passaroInstanciado;

    /*
     * Método chamado ao carregar a cena, indicando que deve ser
     * instanciado um novo pássaro
     */
    void Start(){
        spawnPassaro();
    }

    /*
     * Método chamado independentemente da taxa de atualização de quadros,
     * mudando a posição do pássaro, fazendo-o se movimentar. Quando o pássaro
     * atingir uma certa distância desde sua instância, ele é destruído para que 
     * um novo possa ser criado
     */
    void FixedUpdate(){
        if (velocidadePassaro != 0 && passaroInstanciado != null) {
            if(passaroInstanciado.GetComponent<Rigidbody>().transform.localPosition.z > 120) {
                destruirPassaro();
                girarTrajeto();
                spawnPassaro();
            }
            passaroInstanciado.GetComponent<Rigidbody>().position += (passaroInstanciado.transform.forward) * (velocidadePassaro * Time.fixedDeltaTime);
            passaroInstanciado.transform.SetParent(InicioTrajeto, false);
        }
    }

    /*
     * Método responsável por destruir o pássaro atual quando
     * ele atingir um determinado ponto
     */
    private void destruirPassaro() {
        Destroy(passaroInstanciado);
        passaroInstanciado = null;
    }

    /*
     * Sempre quando um pássaro é destruido, sua trajetória muda para uma
     * posição aleatoria, fazendo sempre criar voos diferentes
     */
    private void girarTrajeto() {
        int[] faixasValoresPossiveis = new int[3];
        faixasValoresPossiveis[0] = Random.Range(0, 46);
        faixasValoresPossiveis[1] = Random.Range(144, 240);
        faixasValoresPossiveis[2] = Random.Range(306, 360);
        Quaternion rotacao = Quaternion.Euler(0, faixasValoresPossiveis[Random.Range(0, 3)], 0);
        transform.rotation = rotacao;
    }

    /*
     * Método responsável por instanciar o pássaro
     */
    private void spawnPassaro() {
        passaroInstanciado = Instantiate(passaro, InicioTrajeto.forward, Quaternion.identity) as GameObject;
        passaroInstanciado.AddComponent<Rigidbody>();
        passaroInstanciado.GetComponent<Rigidbody>().useGravity = false;
        passaroInstanciado.transform.localScale = Vector3.one * 2;
    }
}

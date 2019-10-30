using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Componente responsável por instanciar os meteoros que caem na terra,
 * além de gerenciar o que acontece com ele
 */
public class InstanciadorMeteoro : MonoBehaviour{

    /*
     * Variável usado unicamente para saber de que tipo de objeto 
     * será instanciado
     */
    public GameObject meteoro;

    /*
     * Variável que armazena a posição final que o meteoro atingirá
     */
    public Transform pontoFinal;

    /*
     * Variável que armazena a distância da terra que será instanciado
     */
    public int distanciaMeteoro = 10;


    /*
     * Variável usada para guardar o meteoro atual
     */
    private GameObject meteoroAtual;

    /*
     * Variável responsável por controlar quando o meteoro pode ou 
     * nao ser instanciado 
     */
    private bool podeInstanciar = false;
    
    /*
     * Metodo responsável por instanciar um meteoro na sua posição
     * adequada
     */
    private void Spawn(){
        Vector3 posicaoInicial = new Vector3(0, ((float)distanciaMeteoro)/10, 0);
        meteoroAtual = Instantiate(meteoro, posicaoInicial, Quaternion.identity) as GameObject;
        meteoroAtual.transform.SetParent(pontoFinal, false);
    }

    /*
     * Método chamado externamente, informando que o meteoro colidiu 
     * com a Terra
     */
    public void colidiu() {
        GameObject.Find("ParticulaEstilhacos").GetComponent<ParticleSystem>().Play();
    }

    /*
     * Método que verifica se pode instanciar, e quando pode, chama o método que
     * instancia
     */
    void Update(){
        if (podeInstanciar) {
            if (meteoroAtual == null) {
                Spawn();
            }
        }
    }

    /*
     * Métodos chamados externamente, informando quando pode ou não instanciar
     * os meteoros
     */
    public void startInstance() {
        podeInstanciar = true;
    }

    public void stopInstance() {
        podeInstanciar = false;
        Destroy(meteoroAtual);
        meteoroAtual = null;
    }
}

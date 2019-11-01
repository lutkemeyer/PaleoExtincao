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
    public GameObject prefabMeteoro;

    /*
     * Variavel que armazena o sistema de particulas ativado quando
     * o meteoro colide com a Terra
     */
    public ParticleSystem prefabParticulaColisao;

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
     * Método que verifica se pode instanciar, e quando pode, chama o método que
     * instancia
     */
    void Update(){
        if (podeInstanciar) {
            if (meteoroAtual != null) {
                if (meteoroAtual.transform.localPosition.y <= 0) {
                    destruirMeteoro();
                    instanciarImpacto();
                    spawnMeteoro();
                }
            } else {
                spawnMeteoro();
            }
        } else {
            if (meteoroAtual != null) {
                destruirMeteoro();
            }
        }
    }

    /*
     * Metodo responsável por instanciar um meteoro na sua posição
     * adequada
     */
    private void spawnMeteoro() {
        Vector3 posicaoInicial = new Vector3(0, 0.31f, 0);
        meteoroAtual = Instantiate(prefabMeteoro, posicaoInicial, Quaternion.identity) as GameObject;
        meteoroAtual.transform.SetParent(transform, false);
    }

    /*
     * Método que destroi o meteoro atual se este existir
     */
    private void destruirMeteoro() {
        if (meteoroAtual != null) {
            Destroy(meteoroAtual);
            meteoroAtual = null;
        }
    }

    /*
     * Método que ativa os estilhacos da colisao
     */
    private void instanciarImpacto() {
        prefabParticulaColisao.GetComponent<ParticleSystem>().Play();
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
    }
}

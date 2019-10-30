using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Componente resposável por criar animações e fazer o controle
 * de abrir e fechar um determinado objeto de UI (sendo usado
 * para abrir/fechar o painel de dinossauro ou o painel de instrucoes
 */
public class AnimadorAbrirFechar : MonoBehaviour{

    /*
     * Variáveis publicas acessíveis através do Unity, permitindo
     * a personalização do tempo de animação definido em segundos, e 
     * e o objeto inicializará aberto ou fechado, não sendo necessário
     * desativar o objeto se ele não será inicializado ao abrir a cena
     */
    public float segundosAnimacao = 0.5f;
    public bool inicializarAberto = false;

    /*
     * variáveis responsáveis por fazer o controle interno se está
     * aberto ou não
     */
    private bool aberto = false, abrindo = false, fechando = false;

    /*
     * Variável de controle que armazena a porcentagem de uma animação
     * enquanto ela ocorre
     */
    private float porcAnim = 0;
    
    /*
     * Método chamado quando a cena é criada, e controla se é pra deixar
     * o objeto desativado ao abrir ou não
     */
    void Start() {
        if (!inicializarAberto) {
            gameObject.transform.localScale = Vector3.zero;
        }
    }

    /*
     * Método chamado a cada atualização de frame, e faz o controle da
     * porcentagem de animação quando está ocorrendo uma
     */
    void Update(){
        if (abrindo || fechando) {
            gameObject.GetComponent<RectTransform>().localScale = Vector3.Lerp(Vector3.zero, Vector3.one, porcAnim);
            if (abrindo) {
                porcAnim += Time.deltaTime / segundosAnimacao;
            } else if (fechando) {
                porcAnim -= Time.deltaTime / segundosAnimacao;
            }
        }
        if (porcAnim > 1) {

            // VER SE FUNCIONA
            gameObject.GetComponent<RectTransform>().localScale = Vector3.one;
            // colocar 100% de escala aqui

            abrindo = false;
            aberto = true;
        }else if(porcAnim < 0) {

            // VER SE FUNCIONA
            gameObject.GetComponent<RectTransform>().localScale = Vector3.zero;
            // colocar 0% de escala aqui

            fechando = false;
            aberto = false;
            gameObject.transform.localScale = Vector3.zero;
        }
    }

    /*
     * Método chamado por componentes externos a este, informando que é para
     * abrir o objeto
     */
    public void abrir() {
        if (!aberto) {
            abrindo = true;
        }
    }

    /*
     * Método chamado por componentes externos a este, informando que é para
     * fechar o objeto
     */
    public void fechar() {
        if (aberto) {
            fechando = true;
        }
    }

    /*
     * Método chamado por componentes externos a este (chamado pelo botão do
     * painel de instruções). Este método é utilizado quando não se sabe se o
     * objeto está aberto ou fechado, apenas inverte seu estado
     */
    public void abrirOuFechar() {
        if (aberto) {
            fechando = true;
        } else {
            abrindo = true;
        }
    }


    public bool isAberto() {
        return aberto;
    }
}

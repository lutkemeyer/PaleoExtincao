using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Classe responsável por controlar um determinado numero de objetos
 * que devem ser apresentados em ordem
 */
public class CarrosselObjetos{

    /*
     * Variável que armazena os objetos que devem ser apresentados
     */
    private GameObject[] objetos;

    /*
     * Variável que indica qual dos objetos está sendo mostrado naquele
     * instante
     */
    private int indiceAtivo = 0;

    /*
     * Variável que indica qual é quantidade de objetos que será mostrado
     */
    private int tamanho;

    /*
     * Construtor da classe, responsável por armazenar os objetos na variável
     * e indicar qual é a quantidade total de objetos
     */
    public CarrosselObjetos(GameObject[] objetos) {
        if(objetos.Length > 0) {
            this.objetos = objetos;
            tamanho = objetos.Length;
        }
    }

    /*
     * Método responsável por trocar de objeto ativo, indo para a direita
     * ou em ordem crescente dos indices
     */
    public void passarParaDireita() {
        objetos[indiceAtivo].SetActive(false);
        if (indiceAtivo == (tamanho-1)) {
            indiceAtivo = 0;
        } else {
            indiceAtivo++;
        }
        objetos[indiceAtivo].SetActive(true);
    }

    /*
     * Método responsável por trocar de objeto ativo, indo para a esquerda
     * ou em ordem descrescente dos indices
     */
    public void passarParaEsquerda() {
        objetos[indiceAtivo].SetActive(false);
        if (indiceAtivo == 0) {
            indiceAtivo = (tamanho-1);
        } else {
            indiceAtivo--;
        }
        objetos[indiceAtivo].SetActive(true);
    }

    /*
     * Método responsável por ativar ou desativar o objeto ativo no momento,
     * dependendo da variável passada
     */
    public void setActive(bool ativar) {
        objetos[indiceAtivo].SetActive(ativar);
    }

    /*
     * Método que retorna qual indice é o objeto ativo
     */
    public int getIndice() {
        return indiceAtivo;
    }
}

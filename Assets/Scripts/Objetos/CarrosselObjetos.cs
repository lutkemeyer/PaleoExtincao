using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrosselObjetos{

    private GameObject[] objetos;
    private int indiceAtivo = 0;
    private int tamanho;

    public CarrosselObjetos(GameObject[] objetos) {
        if(objetos.Length > 0) {
            this.objetos = objetos;
            tamanho = objetos.Length;
        }
    }

    public void passarParaDireita() {
        objetos[indiceAtivo].SetActive(false);
        if (indiceAtivo == (tamanho-1)) {
            indiceAtivo = 0;
        } else {
            indiceAtivo++;
        }
        objetos[indiceAtivo].SetActive(true);
    }
    public void passarParaEsquerda() {
        objetos[indiceAtivo].SetActive(false);
        if (indiceAtivo == 0) {
            indiceAtivo = (tamanho-1);
        } else {
            indiceAtivo--;
        }
        objetos[indiceAtivo].SetActive(true);
    }
    public void setActive(bool ativar) {
        objetos[indiceAtivo].SetActive(ativar);
    }
    public int getIndice() {
        return indiceAtivo;
    }
}

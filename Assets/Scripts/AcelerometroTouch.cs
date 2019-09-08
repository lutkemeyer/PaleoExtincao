using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcelerometroTouch : MonoBehaviour
{
    public enum Direcao { DIREITA, ESQUERDA, PARADO };

    private bool emMovimento = false;
    private float valorInicial = 0.0f, valorFinal = 0.0f, distancia = 0.0f;
    private Direcao direcao = Direcao.PARADO;

    private float valorParaNormalizacao;

    public bool primeiroToque = false;

    public AcelerometroTouch() {
        valorParaNormalizacao = Screen.width / 5;
    }

    public void atualiza() {
        if (Input.touchCount == 0) {
            encerraMov();
        } else {
            if (!emMovimento) {
                primeiroToque = true;
                iniciaMov();
            }
        }
        if (emMovimento) {
            valorInicial = primeiroToque ? Input.GetTouch(0).position.x : valorFinal;
            valorFinal = Input.GetTouch(0).position.x;
            distancia = calcDistancia(valorInicial, valorFinal);
            direcao = valorFinal - valorInicial > 0 ? Direcao.DIREITA : Direcao.ESQUERDA;
            primeiroToque = false;
        }
    }
    public Direcao getDir() {
        return direcao;
    }
    public float getDist() {
        return distancia;
    }
    public float getDistNorm() {
        return distancia / valorParaNormalizacao;
    }
    private void iniciaMov() {
        emMovimento = true;
        zerar();
    }
    private void encerraMov() {
        emMovimento = false;
        zerar();
    }
    private void zerar() {
        distancia = 0.0f;
        valorInicial = 0.0f;
        valorFinal = 0.0f;
        direcao = Direcao.PARADO;
    }
    private float calcDistancia(float inicio, float fim) {
        return Mathf.Abs(fim - inicio);
    }
}

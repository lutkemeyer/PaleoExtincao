using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimadorImagem{

    private Canvas canvas;
    private bool aberto = false, abrindo = false, fechando = false;
    private float segundosAnimacao = 0.5f, porcAnim = 0;

    public AnimadorImagem(Canvas canvas) {
        this.canvas = canvas;
        canvas.transform.localScale = Vector3.zero;
    }
    public void Update(){
        if (abrindo || fechando) {
            canvas.GetComponent<RectTransform>().localScale = Vector3.Lerp(Vector3.zero, Vector3.one, porcAnim);
            if (abrindo) {
                porcAnim += Time.deltaTime / segundosAnimacao;
            } else if (fechando) {
                porcAnim -= Time.deltaTime / segundosAnimacao;
            }
            Color cor = canvas.GetComponent<Image>().color;
            cor.a = porcAnim * 10;
            canvas.GetComponent<Image>().color = cor;
        }
        if (porcAnim > 1) {
            abrindo = false;
            aberto = true;
        }else if(porcAnim < 0) {
            fechando = false;
            aberto = false;
            canvas.GetComponent<Image>().color = Color.clear;
        }
    }
    public void abrir() {
        canvas.GetComponent<Image>().color = Color.white;
        if (!aberto) {
            abrindo = true;
        }
    }
    public void fechar() {
        if (aberto) {
            fechando = true;
        }
    }
}

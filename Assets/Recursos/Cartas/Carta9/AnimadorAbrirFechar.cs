using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimadorAbrirFechar : MonoBehaviour{

    private bool aberto = false, abrindo = false, fechando = false;
    public float segundosAnimacao = 0.5f;
    private float porcAnim = 0;
    public bool inicializarAberto = false;

    void Start() {
        if (!inicializarAberto) {
            desaparecer();
        }
    }
    void Update(){
        if (abrindo || fechando) {
            gameObject.GetComponent<RectTransform>().localScale = Vector3.Lerp(Vector3.zero, Vector3.one, porcAnim);
            if (abrindo) {
                porcAnim += Time.deltaTime / segundosAnimacao;
            } else if (fechando) {
                porcAnim -= Time.deltaTime / segundosAnimacao;
            }
            //Color cor = gameObject.GetComponent<Image>().color;
            //cor.a = porcAnim * 10;
            //gameObject.GetComponent<Image>().color = cor;
        }
        if (porcAnim > 1) {
            abrindo = false;
            aberto = true;
        }else if(porcAnim < 0) {
            fechando = false;
            aberto = false;
            gameObject.transform.localScale = Vector3.zero;
            //objeto.SetActive(false);
        }
    }
    public void abrir() {
        //gameObject.transform.localScale = Vector3.one;
        //objeto.SetActive(true);
        if (!aberto) {
            abrindo = true;
        }
    }
    public void fechar() {
        if (aberto) {
            fechando = true;
        }
    }
    public void abrirOuFechar() {
        if (aberto) {
            fechando = true;
        } else {
            abrindo = true;
        }
    }
    private void desaparecer() {
        gameObject.transform.localScale = Vector3.zero;
    }
    public bool isAberto() {
        return aberto;
    }
}

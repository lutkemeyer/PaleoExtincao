using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamiliaDinossauro{

    private Sprite sprite;
    private string titulo, texto;

    public FamiliaDinossauro(Sprite spr, string titulo, string texto) {
        this.sprite = spr;
        this.titulo = titulo;
        this.texto = texto;
    }
    public string getTitulo() {
        return titulo;
    }
    public string getTexto() {
        return texto;
    }
    public Sprite GetSprite() {
        return sprite;
    }
}

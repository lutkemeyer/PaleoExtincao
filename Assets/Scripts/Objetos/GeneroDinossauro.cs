using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneroDinossauro{

    private Sprite sprite;
    private string familia, nomeGenero, descricao;

    public GeneroDinossauro(Sprite spr, string familia, string nomeGenero, string descricao) {
        this.sprite = spr;
        this.familia = familia;
        this.nomeGenero = nomeGenero;
        this.descricao = descricao;
    }
    public string getFamilia() {
        return familia;
    }
    public string getNomeGenero() {
        return nomeGenero;
    }
    public string getDescricao() {
        return descricao;
    }
    public Sprite getSprite() {
        return sprite;
    }
    public string toString() {
        return "Dino: " + nomeGenero + " familia: " + familia + " descricao: ";
    }
}

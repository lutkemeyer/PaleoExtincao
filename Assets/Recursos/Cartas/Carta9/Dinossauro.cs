using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinossauro{

    private Sprite sprite;
    private string familia, nome, descricao;

    public Dinossauro(Sprite spr, string familia, string nome, string descricao) {
        this.sprite = spr;
        this.familia = familia;
        this.nome = nome;
        this.descricao = descricao;
    }
    public string getFamilia() {
        return familia;
    }
    public string getNome() {
        return nome;
    }
    public string getDescricao() {
        return descricao;
    }
    public Sprite getSprite() {
        return sprite;
    }
    public string toString() {
        return "Dino: " + nome + " familia: " + familia + " descricao: ";
    }
}

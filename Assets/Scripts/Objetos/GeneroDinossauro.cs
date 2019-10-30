using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Classe responsável por gerenciar informações a respeito de determinado
 * gênero de dinossauro, usado na apresentação da carta 9
 */
public class GeneroDinossauro{

    /*
     * Variável responsável por armazenar a imagem do dinossauro
     */
    private Sprite sprite;

    /*
     * Variáveis que armazenam as informçaões de determinado gênero de dinossauro
     */
    private string familia, nomeGenero, descricao;

    /*
     * Construtor da classe que armazenam as informações passados
     */
    public GeneroDinossauro(Sprite spr, string familia, string nomeGenero, string descricao) {
        this.sprite = spr;
        this.familia = familia;
        this.nomeGenero = nomeGenero;
        this.descricao = descricao;
    }

    /*
     * Getters das variáveis
     */
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
}

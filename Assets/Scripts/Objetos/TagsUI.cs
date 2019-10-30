using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Classe responsável por armazenar o nome das tags usadas nos
 * elementos visuais separadas por qual cena é usada
 */
public class TagsUI{

    /*
     * Tags usadas no menu
     */
    public class CenaMenu{
        public const string BtnInstrucao = "BtnSelecionar";
        public const string BtnVoltar = "BtnVoltar";
        public const string TxtTitulo = "TxtTitulo";
    }

    /*
     * Tags usadas no jogo
     */
    public class CenaJogo{
        public const string BtnInstrucao = "BtnInstrucao";
        public const string BtnVoltar = "BtnVoltar";

        public const string PnDinossauro = "PnDinossauro";
        public const string ImgDinossauro = "ImgDinossauro";
        public const string TxtGenero = "TxtGenero";
        public const string TxtFamilia = "TxtFamilia";
        public const string TxtDescricao = "TxtDescricao";

        public const string PnInstrucao = "PnInstrucao";
    }
    
}

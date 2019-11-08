using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Componente responsável por controlar a detecção dos peões,
 * mantendo a padronização criada para a detecção das cartas
 */
public class DetectorTrackPeoes : ControladorDeteccaoAR{

    /*
     * Sempre que um peão for reconhecido, ele fechará o painel de
     * instrucoes, caso ele esteja aberto
     */
    public override void onApareceu() {
        GameObject pnInstrucao = GameObject.FindGameObjectWithTag(TagsUI.CenaJogo.PnInstrucao);
        if (pnInstrucao != null) {
            pnInstrucao.GetComponent<AnimadorAbrirFechar>().fechar();
        }
    }
    public override void onDesapareceu() {}
    public override void onNaoApareceu() {}
}

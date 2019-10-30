using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

/*
 * Componente responsável por fechar o painel de instrucoes sempre que reconhecer
 * o objeto atrelado
 */
public class DetectorReconhecimento : MonoBehaviour, ITrackableEventHandler{

    private TrackableBehaviour mTrackableBehaviour;
    
    // botão que ativa / desativa o painel de instrução
    public Button btnInstrucoes; 

    /*
     * Insere uma instancia desta classe como listener
     * do rastreador de imagens do vuforia
     */
    void Start() {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour) {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    /*
     * Função chamada todas as vezes que
     * altera o estado do rastreio de um 
     * target
     **/
    public void OnTrackableStateChanged(
        TrackableBehaviour.Status previousStatus,
        TrackableBehaviour.Status newStatus) {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED) {

            GameObject pnInstrucao = GameObject.FindGameObjectWithTag(TagsUI.CenaJogo.PnInstrucao);
            if (pnInstrucao != null) {
                pnInstrucao.GetComponent<AnimadorAbrirFechar>().fechar();
            }
        }
    }
}

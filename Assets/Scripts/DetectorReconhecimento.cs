using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class DetectorReconhecimento : MonoBehaviour, ITrackableEventHandler{

    private TrackableBehaviour mTrackableBehaviour;
    
    // botão que ativa / desativa o painel de instrução
    public Button btnInstrucoes; 

    /* painel de instruções que será ativado / desativado
     * se o rastreio funcionar
     */

    public GameObject painelInstrucoes;

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
        // SE ENCONTROU O OBJETO
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED) {
            if (painelInstrucoes.active) {
                btnInstrucoes.onClick.Invoke();
            }
        }
    }
}

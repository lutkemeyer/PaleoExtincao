using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class DetectorReconhecimento : MonoBehaviour, ITrackableEventHandler{
    private TrackableBehaviour mTrackableBehaviour;
    public Button btnInstrucoes;
    public GameObject painelInstrucoes;

    void Start() {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour) {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

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

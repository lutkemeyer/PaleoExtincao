using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using static Vuforia.TrackableBehaviour;

public class ControladorDeteccaoAR : MonoBehaviour, ITrackableEventHandler, TrackHandler{

    private TrackableBehaviour mTrackableBehaviour;

    void Start() {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour) {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(Status ps, Status ns) {
        if (ns == Status.DETECTED || ns == Status.TRACKED || ns == Status.EXTENDED_TRACKED) {
            onApareceu();
        } else if ((ps == Status.DETECTED || ps == Status.TRACKED || ps == Status.EXTENDED_TRACKED) && ns == Status.NO_POSE) {
            onDesapareceu();
        } else {
            onNaoApareceu();
        }
    }

    public virtual void onApareceu() {}

    public virtual void onDesapareceu() {}

    public virtual void onNaoApareceu() {}
}

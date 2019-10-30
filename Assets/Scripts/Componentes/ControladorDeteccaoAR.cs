using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using static Vuforia.TrackableBehaviour;

/*
 * Componente responsável por detectar quando um objeto é detectado
 * pelo vuforia, sendo necessário criar uma classe que herda desta para
 * implementar os métodos onApareceu(), onDesapareceu(), onNaoApareceu()
 */
public class ControladorDeteccaoAR : MonoBehaviour, ITrackableEventHandler, TrackHandler{

    private TrackableBehaviour mTrackableBehaviour;

    /*
     * Método que adiciona o listener ao objeto para que seja chamado sempre que mudar
     * status de reconhecimento
     */
    void Start() {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour) {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    /*
     * Método que é chamado sempre que o status de reconhecimento muda
     */
    public void OnTrackableStateChanged(Status ps, Status ns) {
        if (ns == Status.DETECTED || ns == Status.TRACKED || ns == Status.EXTENDED_TRACKED) {
            onApareceu();
        } else if ((ps == Status.DETECTED || ps == Status.TRACKED || ps == Status.EXTENDED_TRACKED) && ns == Status.NO_POSE) {
            onDesapareceu();
        } else {
            onNaoApareceu();
        }
    }

    /*
     * Métodos que são implementados nas classes filhas
     */
    public virtual void onApareceu() {}

    public virtual void onDesapareceu() {}

    public virtual void onNaoApareceu() {}
}

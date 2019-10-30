using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Interface usada para padronizar o controle de rastreio de objetos
 */
public interface TrackHandler{
    void onApareceu();
    void onDesapareceu();
    void onNaoApareceu();
}

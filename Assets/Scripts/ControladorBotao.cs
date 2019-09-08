using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorBotao : MonoBehaviour{

    public AudioClip som;
    public Sprite sprHabilitado, sprDesabilitado;
    private Button botao { get { return GetComponent<Button>(); } }
    public bool verificarSeEstaAtivo;

    void Start() {
        if (som != null) {
            gameObject.AddComponent<AudioSource>();
            AudioSource source = GetComponent<AudioSource>();
            source.clip = som;
            source.playOnAwake = false;
            botao.onClick.AddListener(() => source.PlayOneShot(som));
        }
        if (!verificarSeEstaAtivo) {
            if (sprHabilitado != null && sprDesabilitado != null) {
                botao.onClick.AddListener(() => onClick());
            }
        }
    }
    void Update() {
        if (verificarSeEstaAtivo) {
            if (sprHabilitado != null && sprDesabilitado != null) {
                if (botao.IsInteractable()) {
                    botao.GetComponent<Image>().sprite = sprHabilitado;
                } else {
                    botao.GetComponent<Image>().sprite = sprDesabilitado;
                }
            }
        }
    }
    private void onClick() {
        botao.GetComponent<Image>().sprite = botao.GetComponent<Image>().sprite == sprDesabilitado ? sprHabilitado : sprDesabilitado;
    }
}

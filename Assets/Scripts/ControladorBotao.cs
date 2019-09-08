using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorBotao : MonoBehaviour{

    /*
     * Os botões devem ter som ao clicar, sendo passado através do
     * unity do atrelar esta classe a um botao
     */
    public AudioClip som;

    /*
     * caso o botao tiver dois status, seus respectivos sprites
     * devem ser passados através do unity, caso contrário, não
     * é obrigatório indexar sprites
     */
    public Sprite sprHabilitado, sprDesabilitado;

    /*
     * captura uma referência do próprio botão anexado a esta classe
     */
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

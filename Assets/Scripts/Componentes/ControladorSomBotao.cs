using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Componente responsável por controlar o som dos botoes
 */
public class ControladorSomBotao : MonoBehaviour{

    /*
     * Os botões devem ter som ao clicar, sendo passado através do
     * unity do atrelar esta classe a um botao
     */
    public AudioClip som;

    /*
     * captura uma referência do próprio botão anexado a esta classe
     */
    private Button botao { get { return GetComponent<Button>(); } }

    /*
     * Adiciona um listener ao botao que sempre que clicar, o som
     * armazenado na variável é tocado
     */
    void Start() {
        if (som != null) {
            gameObject.AddComponent<AudioSource>();
            AudioSource source = GetComponent<AudioSource>();
            source.clip = som;
            source.playOnAwake = false;
            botao.onClick.AddListener(() => source.PlayOneShot(som));
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * CLASSE RESPONSÁVEL POR REALIZAR AS TRANSIÇÕES ENTRE TELAS,
 * GUARDANDO SUAS VARIÁVEIS DE TRANSIÇÃO
 */
public class ControladorCenas : MonoBehaviour{

    public enum Cena { CENA_JOGO, CENA_MENU }
    public enum Variavel { DINOSSAURO, PEAO }
    
    public const string DINOSSAURO = "DINOSSAURO";
    public const string PEAO = "PEAO";

    public const string CENA_JOGO = "CenaJogo";
    public const string CENA_MENU = "CenaMenu";

    private static Dictionary<string, string> parametros = new Dictionary<string, string>();

    /*
     * carrega o cena passada por parametro
     */
    public static void carregaCena(string nomeCena) {
        SceneManager.LoadScene(nomeCena);
    }

    /*
     * Retorna o indice da seleção feita na tela de menu
     * e guardada no discionario desta classe.
     * Caso não encontre um valor guardado, retorna 0
     */
    public static int getParametro(string chave) {
        if (parametros.ContainsKey(chave)) {
            return int.Parse(parametros[chave]);
        } else {
            Debug.Log("DEU ERRO AO TENTAR PEGAR PARAMETRO: " + chave);
            return 0;
        }
    }

    /*
     * Insere valores no discionario (usado para guardar os indices
     * de seleção tanto dos peões quanto dos dinos).
     * Se já tiver valores salvos para o mesmo parâmetro, substitui,
     * caso contrario, apenas adiciona.
     */
    public static void addParametro(string chave, int valor) {
        if (parametros.ContainsKey(chave)) {
            parametros.Remove(chave);
        }
        parametros.Add(chave, valor.ToString());
    }
}

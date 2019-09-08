using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorCenas : MonoBehaviour
{
    public const string DINOSSAURO = "DINOSSAURO";
    public const string PEAO = "PEAO";

    public const string CENA_JOGO = "CenaJogo";
    public const string CENA_MENU = "CenaMenu";

    private static Dictionary<string, string> parametros = new Dictionary<string, string>();

    public static void carregaCena(string nomeCena) {
        SceneManager.LoadScene(nomeCena);
    }

    public static int getParametro(string chave) {
        if (parametros.ContainsKey(chave)) {
            return int.Parse(parametros[chave]);
        } else {
            Debug.Log("DEU ERRO AO TENTAR PEGAR PARAMETRO: " + chave);
            return 0;
        }
    }

    public static void addParametro(string chave, int valor) {
        if (parametros.ContainsKey(chave)) {
            parametros.Remove(chave);
        }
        parametros.Add(chave, valor.ToString());
    }
}

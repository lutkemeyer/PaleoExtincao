using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * CLASSE RESPONSÁVEL POR REALIZAR AS TRANSIÇÕES ENTRE TELAS,
 * GUARDANDO SUAS VARIÁVEIS DE TRANSIÇÃO
 */
public class ControladorCenas{

    public const string CENA_JOGO = "CenaJogo";
    public const string CENA_MENU = "CenaMenu";
    
    public const string PERSONAGEM = "PERSONAGEM";
    public const string PEAO = "PEAO";
    
    
    private static Dictionary<string, string> parametros = new Dictionary<string, string>();

    /*
     * carrega o cena passada por parametro
     */
    public static void carregaCena(string cena) {
        SceneManager.LoadScene(cena);
    }

    /*
     * Retorna o indice da seleção feita na tela de menu
     * e guardada no discionario desta classe.
     * Caso não encontre um valor guardado, retorna 0
     */
    public static int getParametro(string var) {
        if (parametros.ContainsKey(var)) {
            return int.Parse(parametros[var]);
        } else {
            Debug.Log("DEU ERRO AO TENTAR PEGAR PARAMETRO: " + var);
            return 0;
        }
    }

    /*
     * Insere valores no discionario (usado para guardar os indices
     * de seleção tanto dos peões quanto dos dinos).
     * Se já tiver valores salvos para o mesmo parâmetro, substitui,
     * caso contrario, apenas adiciona.
     */
    public static void addParametro(string var, int valor) {
        if (parametros.ContainsKey(var)) {
            parametros.Remove(var);
        }
        parametros.Add(var, valor.ToString());
    }
}

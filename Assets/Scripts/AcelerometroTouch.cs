using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcelerometroTouch{
    /*
     * Enumerador para controle dos movimentos realizados
     * com touch, caso não esteja sendo realizado um movimento,
     * permanece em "PARADO"
     */
    public enum Direcao { DIREITA, ESQUERDA, PARADO };

    /*
     * Variavel que é atualizada sempre que um
     * novo movimento se inicia / encerra
     */
    private bool emMovimento = false;

    /*
     * * valorInicial = guarda o valor do primeiro toque
     * na tela, para poder calcular a distância do arrasto
     * 
     * * valorFinal = guarda o valor da posição atual do
     * toque, sendo comparado com o último valor guardado,
     * sendo realizado o calculo da distância
     * 
     * * distancia = calculada a cada iteração com os valores
     * incial e final
     */
    private float valorInicial = 0.0f, valorFinal = 0.0f, distancia = 0.0f;

    /*
     * Direção atualizada a cada iteração
     */
    private Direcao direcao = Direcao.PARADO;

    /*
     * Valor relativo ao tamanho da tela em pixels,
     * para posterior normalização da distância do arrasto
     * para calculos mais genéricos
     */
    private float valorParaNormalizacao;

    /*
     * Variável necessária para desconsiderar a posição
     * do primeiro toque, que causa instabilidade no movimento
     * capturado
     */
    private bool primeiroToque = false;

    /*
     * Inicia com um valor padrão de proporção
     * em relação a tela, sendo razoável para 
     * a normalização dos movimentos
     */
    public AcelerometroTouch() {
        valorParaNormalizacao = Screen.width / 5;
    }

    /*
     * * Função responsável por verificar se um movimento
     * de touch está sendo feito e manter o controle sobre
     * o mesmo.
     * 
     * * É chamada sempre que se deseja capturar algum
     * movimento de touch (geralmente em funções Update())
     */
    public void atualiza() {
        if (Input.touchCount == 0) {
            encerraMov();
        } else {
            if (!emMovimento) {
                primeiroToque = true;
                iniciaMov();
            }
        }
        if (emMovimento) {
            valorInicial = primeiroToque ? Input.GetTouch(0).position.x : valorFinal;
            valorFinal = Input.GetTouch(0).position.x;
            distancia = calcDistancia(valorInicial, valorFinal);
            direcao = valorFinal - valorInicial > 0 ? Direcao.DIREITA : Direcao.ESQUERDA;
            primeiroToque = false;
        }
    }
    /*
     * Retorna a direção em que o movimento está sendo feito
     * através de um enumerador criado dentro desta classe,
     * se não estiver sendo feito nenhum movimento no momento,
     * é retornado a direção "PARADO"
     */
    public Direcao getDir() {
        return direcao;
    }

    /*
     * Retorna a distância do movimento feito a partir dos 
     * pixels da tela, retornando valores variáveis para
     * cada tipo de tela, sendo de maneira geral, valores altos
     */
    public float getDist() { 
        return distancia;
    }

    /*
     * Retorna a distência do movimento feito de forma normalizada,
     * (valor entre 0 e 1 em relação ao tamanho da tela, independente
     * de qual seja), dessa forma, facilita o calculo genérico.
     */
    public float getDistNorm() {
        return distancia / valorParaNormalizacao;
    }
    /*
     * Indica que um novo movimento de touch está sendo feito,
     * zerando as variáveis para uma nova captura
     */
    private void iniciaMov() {
        emMovimento = true;
        zerar();
    }

    /*
     * Indica que o movimento de touch atual se encerrou,
     * zerando as variáveis para uma futura captura
     */
    private void encerraMov() {
        emMovimento = false;
        zerar();
    }

    /*
     * zera as variáveis
     */
    private void zerar() {
        distancia = 0.0f;
        valorInicial = 0.0f;
        valorFinal = 0.0f;
        direcao = Direcao.PARADO;
    }

    /*
     * calcula a distancia entre dois pontos
     */
    private float calcDistancia(float inicio, float fim) {
        return Mathf.Abs(fim - inicio);
    }
}

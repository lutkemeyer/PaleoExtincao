using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Componente responsável por inserir uma variavel aleatoria
 * em uma animacao, podendo executar as animações de forma aleatoria
 */
public class RandomAnimBehaviour : StateMachineBehaviour {

    /*
     * Variavel que armazena o numero de animacoes que o objeto possui
     * para gerar um numero aleatorio entre 0 e o numero de animacoes
     */
    public int numAnimacoes;

    /*
     * Metodo chamado sempre que entra em uma StateMachine que tenha
     * este componente, sendo gerado neste método o número aleatório
     */
    override public void OnStateMachineEnter(Animator animator, int stateMachinePathHash){
        int valor = Random.Range(0, numAnimacoes);
        animator.SetInteger("valor", valor);
    }

}

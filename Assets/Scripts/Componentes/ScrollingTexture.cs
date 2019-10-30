using UnityEngine;
using System.Collections;

/*
 * Componente responsável por animar uma textura
 * para alguma direcao
 */
public class ScrollingTexture : MonoBehaviour {

    /*
     * Variável que armazena a direção e velocidade que a textura
     * será animada
     */
	public Vector2 uvAnimationRate = new Vector2( 1.0f, 0.0f );

    /*
     * Variável que armazena o nome da textura que será animada
     */
	public string textureName = "_LavaTex";
	
    /*
     * Variável que armazena a posição em que a textura está no momento
     */
	private Vector2 uvOffset = Vector2.zero;
	
    /*
     * Método que atualiza a posicao da textura a cada frame
     */
	void LateUpdate(){
		uvOffset += ( uvAnimationRate * Time.deltaTime );
		if( GetComponent<Renderer>().enabled ){
			GetComponent<Renderer>().sharedMaterial.SetTextureOffset( textureName, uvOffset );
		}
	}
}
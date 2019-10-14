using UnityEngine;
using System.Collections;

public class RotateTexture : MonoBehaviour {

    private static Vector2[] pontos = {new Vector2(0, 1), new Vector2(0,1),
        new Vector2(0.71f, 0.71f), new Vector2(-0.71f,-0.71f),
        new Vector2(1, 0), new Vector2(-1,0),
        new Vector2(0.71f, -0.71f), new Vector2(-0.71f,0.71f)};

    public string nomeTextura = "_MainTex";
    public float velocidade = 0.01f;

    private float local = 0;
    private Vector2 origem, destino;

    void Start() {
        origem = Vector2.zero;
        destino = pontos[Random.Range(0, 8)];
    }

    void LateUpdate(){
        if (local >= 1) {
            local = 0;
            origem = destino;
            do { destino = pontos[Random.Range(0, 8)]; } while (origem == destino);
        }
        local += velocidade;
        GetComponent<Renderer>().sharedMaterial.SetTextureOffset(nomeTextura, Vector2.Lerp(origem,destino,local));
    }
}
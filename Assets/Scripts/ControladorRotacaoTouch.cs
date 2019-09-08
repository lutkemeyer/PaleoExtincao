using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorRotacaoTouch : MonoBehaviour
{
    public float velocidade;
    public float suavidade;

    private float valorMovimento;
    private Quaternion QRfrom; // QR = QuaternionRotate
    private Quaternion QRto;

    private AcelerometroTouch acelerometro = new AcelerometroTouch();

    void Update() {
        acelerometro.atualiza();
        float distAcel = acelerometro.getDistNorm();
        if (acelerometro.getDir() == AcelerometroTouch.Direcao.DIREITA) {
            distAcel = distAcel * (-1);
        }
        valorMovimento += (distAcel * 10) * velocidade;
        QRfrom = transform.rotation;
        QRto = Quaternion.Euler(0, valorMovimento, 0);
        transform.rotation = Quaternion.Lerp(QRfrom, QRto, Time.deltaTime * suavidade);
    }
}

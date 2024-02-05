using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigos : MonoBehaviour
{
    public float velocidadHorizontal = 5f;
    public float velocidadDescenso = 1f;
    public float limiteXnegativo;
    public float limiteXpositivo;

    private bool moverDerecha = true;

    void Update()
    {
        float movimiento = 1;
        if (!moverDerecha)
        {
            movimiento = -1;
        }

        Vector3 nuevaPosicion = transform.position + Vector3.right * movimiento * velocidadHorizontal * Time.deltaTime;
        transform.position = nuevaPosicion;

        if (moverDerecha)
        {
            if (limiteXpositivo < transform.position.x)
            {
                moverDerecha = !moverDerecha;
                Vector3 nuevaDireccion = transform.position + Vector3.down * velocidadDescenso;
                transform.position = nuevaPosicion;
            }
        }
        else
        {
            if (limiteXnegativo > transform.position.x)
            {
                moverDerecha = !moverDerecha;
                Vector3 nuevaDireccion = transform.position + Vector3.down * velocidadDescenso;
                transform.position = nuevaPosicion;
            }
        }
    }
}

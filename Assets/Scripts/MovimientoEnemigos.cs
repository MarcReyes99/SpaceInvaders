using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigos : MonoBehaviour
{
    public float velocidadHorizontal;
    public float direccionDescenso;
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

        Vector3 nuevaPosicion = transform.position + new Vector3(1, 0, 0) * movimiento * velocidadHorizontal * Time.deltaTime;
        transform.position = nuevaPosicion;

        if (moverDerecha)
        {
            if (limiteXpositivo < transform.position.x)
            {
                moverDerecha = !moverDerecha;
                Vector3 nuevaDireccion = transform.position + new Vector3(0, -1, 0) * Time.deltaTime * direccionDescenso;
                transform.position = nuevaDireccion;
            }
        }
        else
        {
            if (limiteXnegativo > transform.position.x)
            {
                moverDerecha = !moverDerecha;
                Vector3 nuevaDireccion = transform.position + new Vector3(0, -1, 0) * Time.deltaTime * direccionDescenso;
                transform.position = nuevaDireccion;
            }
        }
    }
}

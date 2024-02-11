using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigos : MonoBehaviour
{
    public float velocidadHorizontal;
    public float direccionDescenso;

    public bool moverDerecha = true;

    void FixedUpdate()
    {
        float movimiento = 1;
        if (!moverDerecha)
        {
            movimiento = -1;
        }

        Vector3 nuevaPosicion = transform.position + new Vector3(1, 0, 0) * movimiento * velocidadHorizontal * Time.deltaTime;
        transform.position = nuevaPosicion;
    }
}

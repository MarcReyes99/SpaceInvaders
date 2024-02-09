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
    private bool haySquare = false;
    private string nombreFila = "";

    private void Start()
    {
        for (int i = 1; i <= 5; i++)
        {
            if (i == 1)
            {
                nombreFila = "PrimeraFila";
            }
            else if (i == 2)
            {
                nombreFila = "SegundaFila";
            }
            else if (i == 3)
            {
                nombreFila = "TerceraFila";
            }
            else if (i == 4)
            {
                nombreFila = "CuartaFila";
            }
            else if (i == 5)
            {
                nombreFila = "QuintaFila";
            }
        }
    }
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

        GameObject fila = transform.Find(nombreFila).gameObject;

        if (fila != null)
        {
            GameObject[] enemigos = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject enemigo in enemigos)
            {
                if (enemigo.name == "Square")
                {
                    haySquare = false;
                }
                else
                {
                    haySquare = true;
                }
                if (haySquare)
                {
                    limiteXnegativo = -4.8f;
                }
            }
        }
    }
}

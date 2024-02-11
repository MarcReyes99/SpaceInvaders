using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioDireccion : MonoBehaviour
{
    public MovimientoEnemigos cambioDireccion;
    private bool colisionActivada = true;
    public float retrasoColision = 0.5f; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pared1") || collision.gameObject.CompareTag("Pared2"))
        {
            if (colisionActivada)
            {
                colisionActivada = false;
                if (cambioDireccion != null)
                {
                    cambioDireccion.moverDerecha = !cambioDireccion.moverDerecha;
                    Vector3 nuevaDireccion = cambioDireccion.transform.position + new Vector3(0, -1, 0) * Time.deltaTime * cambioDireccion.direccionDescenso;
                    cambioDireccion.transform.position = nuevaDireccion;
                    Invoke("ActivarColision", retrasoColision);
                }
            }
        }
    }
    private void ActivarColision()
    {
        colisionActivada = true;
    }
}

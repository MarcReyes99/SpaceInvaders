using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioDireccion : MonoBehaviour
{
    public MovimientoEnemigos cambioDireccion;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Si el enemigo colisiona con una pared, cambia la direcci�n
        if (collision.gameObject.CompareTag("Pared1") || collision.gameObject.CompareTag("Pared2"))
        {
            CambiarDireccion();
        }
    }

    // M�todo para cambiar la direcci�n de los enemigos
    private void CambiarDireccion()
    {
        if (cambioDireccion != null)
        {
            cambioDireccion.CambiarDireccion();
        }
    }
}

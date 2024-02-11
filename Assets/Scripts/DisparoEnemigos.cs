using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEnemigos : MonoBehaviour
{
    public GameObject balaPrefab;

    void Start()
    {
        InvokeRepeating("DispararBalaAleatoria", 0f, 1f);
    }

    void DispararBalaAleatoria()
    {
        GameObject[] enemigos = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemigos.Length > 0)
        {
            // Elegir un enemigo aleatorio
            GameObject enemigoAleatorio = enemigos[Random.Range(0, enemigos.Length)];

            // Instanciar la bala en la posición del enemigo
            GameObject balaEnemigo = Instantiate(balaPrefab, enemigoAleatorio.transform.position, Quaternion.identity);

            
            Rigidbody2D rb = balaEnemigo.GetComponent<Rigidbody2D>();
            rb.AddForce(Vector2.down * 500f);
        }
    }
}

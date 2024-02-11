using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaEnemigo : MonoBehaviour
{
    Rigidbody2D rb;
    public float bullet_speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * bullet_speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            UI puntuacion = FindObjectOfType<UI>();
            puntuacion.life--;
            if(puntuacion.life <= 0)
            {
                Destroy(collision.gameObject);
            }
        }
        if (collision.gameObject.tag == "Building")
        {
            collision.gameObject.transform.localScale += new Vector3(-1, 0, 0);
            Destroy(gameObject);
            if (collision.gameObject.transform.localScale == Vector3.zero)
            {
                Destroy(collision.gameObject);
            }
        }
    }
}

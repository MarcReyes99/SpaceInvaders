using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    Rigidbody2D rb;
    public float bullet_speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * bullet_speed);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            MovimientoEnemigos velocidadEnemy = FindObjectOfType<MovimientoEnemigos>();
            velocidadEnemy.velocidadHorizontal += 0.1f;
        }
        if (collision.gameObject.tag == "Building")
        {
            collision.gameObject.transform.localScale += new Vector3(-2, 0, 0);
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    Rigidbody2D rb;
    public float bullet_speed;
    public bool target_enemies = true;
    public bool target_building = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * bullet_speed);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*if (target_enemies && collision.gameObject.tag == "Enemies")
        {
            collision.gameObject.GetComponent<AsteroidController>().Muerte();
            Destroy(gameObject);
        }*/
        if (target_building && collision.gameObject.tag == "Building")
        {
            collision.gameObject.transform.localScale += new Vector3(-2, 0, 0);
        }
    }
}

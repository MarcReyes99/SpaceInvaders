using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float speed;
    public GameObject bala;


    Collider2D coll;
    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontal, 0, 0) * Time.deltaTime * speed;

        if (Input.GetButtonDown("Jump") && coll.enabled)
        {
            GameObject temp = Instantiate(bala, transform.position, transform.rotation);
            Destroy(temp, 1);
        }
    }
}

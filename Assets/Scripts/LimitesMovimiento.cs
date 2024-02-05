using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitesMovimiento : MonoBehaviour
{
    public float limiteXnegativo;
    public float limiteXpositivo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (limiteXpositivo < transform.position.x)
        {
            transform.position = new Vector3(limiteXpositivo, transform.position.y, 0);
        }
        if (limiteXnegativo > transform.position.x)
        {
            transform.position = new Vector3(limiteXnegativo, transform.position.y, 0);
        }
    }
}

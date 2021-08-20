using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mano : MonoBehaviour
{
    [SerializeField] float velocidad;
    bool andaArriba;
    void Start()
    {
        andaArriba = false;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (andaArriba == false)
        {
            HaciaAbajo();
        }

        if (andaArriba == true)
        {
            HaciaArriba();
        }

        if (transform.rotation.z > 0.16f)
        {
            andaArriba = true;
        }

        if (transform.rotation.z < -0.30f)
        {
            andaArriba = false;
        }
    }

    void HaciaAbajo()
    {
        transform.Rotate(0, 0, velocidad * Time.deltaTime);
    }
    void HaciaArriba()
    {
        transform.Rotate(0, 0, -velocidad * Time.deltaTime);
    }
}

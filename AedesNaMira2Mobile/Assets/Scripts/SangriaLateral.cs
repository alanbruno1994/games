using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SangriaLateral : MonoBehaviour
{
    public float x, z;
    public bool xis;
    public GameObject Heroi;
    void Start()
    {
        Heroi = GameObject.FindGameObjectWithTag("Heroi");
    }
    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.tag == "Arma" || collision.gameObject.tag == "Heroi")
        {


            if (xis)
            {
                Heroi.transform.position = new Vector3(x, 1.5f, Heroi.transform.position.z);
            }
            else
            {
                Heroi.transform.position = new Vector3(Heroi.transform.position.x, 1.5f, z);
            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {

        if (collision.gameObject.tag == "Arma" || collision.gameObject.tag == "Heroi")
        {

            if (xis)
            {
                Heroi.transform.position = new Vector3(x, 1.5f, Heroi.transform.position.z);
            }
            else
            {
                Heroi.transform.position = new Vector3(Heroi.transform.position.x, 1.5f, z);
            }

        }
    }

}

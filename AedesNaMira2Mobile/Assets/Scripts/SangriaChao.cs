using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SangriaChao : MonoBehaviour
{
    public bool sagriaPersonalizada;
    public float y, x, z;
    // Start is called before the first frame update
    void Start()
    {

    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Heroi")
        {
            GameObject aux = collision.gameObject;
            if (sagriaPersonalizada == false)
            {
                aux.transform.position = new Vector3(aux.transform.position.x, y, aux.transform.position.z);
            }
            else
            {
                aux.transform.position = new Vector3(x, y, z);

            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Heroi")
        {
            GameObject aux = collision.gameObject;
            if (sagriaPersonalizada == false)
            {
                aux.transform.position = new Vector3(aux.transform.position.x, y, aux.transform.position.z);
            }
            else
            {
                aux.transform.position = new Vector3(x, y, z);
            }

        }
    }
}

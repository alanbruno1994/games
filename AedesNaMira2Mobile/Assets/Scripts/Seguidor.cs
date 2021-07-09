using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguidor : MonoBehaviour
{
    public GameObject referencia;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (referencia != null)
        {
            transform.position = new Vector3(referencia.transform.position.x, referencia.transform.position.y + 0.5f, referencia.transform.position.z);
        }
        else 
        {
            referencia = GameObject.FindGameObjectWithTag("Heroi");
        }
    }
}

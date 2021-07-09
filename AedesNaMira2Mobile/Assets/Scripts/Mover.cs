using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    public bool x, y, z;//direcao
    public int velocidade;
    public float destroytime;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, destroytime);
    }

    // Update is called once per frame
    void Update()
    {
        if (x)
        {
            transform.Translate(velocidade*Time.deltaTime,0,0);
        } else if (y)
        {
            transform.Translate(0, velocidade * Time.deltaTime, 0);
        }
        else if(z)
        {
            transform.Translate(0, 0, velocidade * Time.deltaTime);
        }
    }
}

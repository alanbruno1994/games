using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moverse_30s : MonoBehaviour {
    public float velocidade;
    public int eixo;

    // Use this for initialization
    void Start () {
        Destroy(gameObject, 30);
    }
	
	// Update is called once per frame
	void Update () {
        if (eixo == 1)
        {
            transform.Translate(velocidade * Time.deltaTime, 0, 0);
        }
        else if (eixo == 2)
        {
            transform.Translate(0, velocidade * Time.deltaTime, 0);
        }
        else if (eixo == 3)
        {
            transform.Translate(0, 0, velocidade * Time.deltaTime);
        }
    }
}

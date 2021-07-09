using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carros3Fase : MonoBehaviour {
    public GameObject c1, c2,c3,c4;
    public float time;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time = time + Time.deltaTime;
        if (time > 8)
        {
            int sort = Random.Range(0, 12);
            if (sort < 2)
            {
                Instantiate(c1, c1.transform.position, c1.transform.rotation);
            }
            else if (sort < 4)
            {
                Instantiate(c2, c2.transform.position, c1.transform.rotation);
            }
            else if (sort < 6)
            {
                Instantiate(c2, c2.transform.position, c2.transform.rotation);
            }
            else if (sort < 8)
            {
                Instantiate(c4, c4.transform.position, c4.transform.rotation);
            }           
            time = 0;
        }
    }
}

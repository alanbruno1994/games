using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaAgua : MonoBehaviour
{
    public AudioSource Som;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 3);
        Som.volume = PlayerPrefs.GetFloat("Efeitos");
    }

    // Update is called once per frame
    void Update()
    {
		transform.Translate( 0,0, 2 * Time.deltaTime);
		//transform.Translate( 2 * Time.deltaTime,0, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VortexEfeito : MonoBehaviour {
    public GameObject ativa;
    public float time = 0;
    public AudioSource Som;
    // Use this for initialization
    void Start () {
        Som.volume =0.3f * PlayerPrefs.GetFloat("Efeitos");
        ativa.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (time > 2)
        {
            ativa.SetActive(true);
            this.GetComponent<VortexEfeito>().enabled = false;
            
        }
        else {
            time += Time.deltaTime;
        }
	}
}

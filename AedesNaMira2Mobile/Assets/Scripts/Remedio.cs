using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remedio : MonoBehaviour
{
	public float valor;
	public GameObject recolherRemedio;
	// Use this for initialization
	void Start ()
	{
		
	}

	void OnTriggerEnter (Collider e)
	{
		string tag = e.gameObject.tag;
		if (tag == "Heroi") {
			try {
				e.gameObject.GetComponent<Heroi> ().life += valor;
				if (e.gameObject.GetComponent<Heroi> ().life > 100) {
					e.gameObject.GetComponent<Heroi> ().life = 100;                   
				}
                e.gameObject.GetComponent<Heroi>().huds.vidaRefresh();
                Instantiate (recolherRemedio, this.transform.position, recolherRemedio.transform.rotation);
			} catch (System.Exception) {
			
			}
			Destroy (this.gameObject);
		}

	}
}

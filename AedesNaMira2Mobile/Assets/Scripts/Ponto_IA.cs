using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ponto_IA : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public void OnTriggerEnter(Collider e){
		string tag = e.gameObject.tag;
		if (tag == "Mosquito_Normal" || tag == "Mosquito_Chikungunya" || tag == "Mosquito_Zika" || tag == "Mosquito_Dengue") {
			e.gameObject.GetComponent<Mosquito> ().destinoHeroi ();
		}

	}
}

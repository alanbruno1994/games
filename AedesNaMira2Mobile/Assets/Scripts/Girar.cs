using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girar : MonoBehaviour {
	public float velocidade;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, velocidade * Time.deltaTime, 0);
	}
}

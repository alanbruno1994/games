using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tag : MonoBehaviour {
	public string tag;
    
	// Use this for initialization
	void Awake() {       
            this.gameObject.tag = tag;       
	}
	

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciarPontoLarva : MonoBehaviour {
	//public GameObject Larva1, Larva2, Larva3, Larva4, Larva5, Larva6, Larva7, Larva8;
	public int quantidadeLarva;
	public int larvaViva;
	public int idFoco;
	public GameObject Gerenciar;
    public GameObject efeito;
    // Use this for initialization
    void Start () {
		larvaViva =	quantidadeLarva;
		Gerenciar= GameObject.FindWithTag("Gerenciar");

	}
	
	// Update is called once per frame
	void Update () {
		if (larvaViva <= 0) {
			if(idFoco==1)
			{
				Gerenciar.GetComponent<GerirFocos> ().MatarFoco1 ();
			}else if(idFoco==2)
			{
				Gerenciar.GetComponent<GerirFocos> ().MatarFoco2 ();
			}else if(idFoco==3)
			{
				Gerenciar.GetComponent<GerirFocos> ().MatarFoco3 ();
			}else if(idFoco==4)
			{
				Gerenciar.GetComponent<GerirFocos> ().MatarFoco4 ();
			}else if(idFoco==5)
			{
				Gerenciar.GetComponent<GerirFocos> ().MatarFoco5 ();
			}else if(idFoco==6)
			{
				Gerenciar.GetComponent<GerirFocos> ().MatarFoco6 ();
			}
			Destroy (this.gameObject);
            Instantiate(efeito);
		}
	}

	public void Matar(){
		larvaViva -= 1;

	}
}

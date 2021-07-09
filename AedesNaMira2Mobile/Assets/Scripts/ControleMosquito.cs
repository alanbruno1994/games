using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleMosquito : MonoBehaviour
{
	public int total = 0;
	public GameObject Mosquito_1, Mosquito0, Mosquito1, Mosquito2, Mosquito3;
	public GameObject Mosq1, Mosq2, Mosq3, Mosq4, Mosq5;
	public GameObject Reference1, Reference2, Reference3, Reference4, Reference5, Reference6;
	public int fase;
	public float time=0;
    public GameObject Gerenciar;
    // Use this for initialization
    void Awake ()
	{
        
		Mosq1 = Instantiate (Mosquito_1, Mosquito_1.transform.position,Mosquito_1.transform.rotation);            
        Mosq1.GetComponent<Transform>().position = new Vector3(Reference1.transform.position.x, Mosq1.transform.position.y, Reference1.transform.position.z);
        Mosq2 = Instantiate (Mosquito0, Mosquito0.transform.position, Mosquito0.transform.rotation);
        Mosq2.GetComponent<Transform>().position = new Vector3(Reference1.transform.position.x, Mosq2.transform.position.y, Reference1.transform.position.z);
        Mosq3 = Instantiate (Mosquito1, Mosquito1.transform.position,Mosquito1.transform.rotation);
        Mosq3.GetComponent<Transform>().position = new Vector3(Reference2.transform.position.x, Mosq3.transform.position.y, Reference2.transform.position.z);
        Mosq4 = Instantiate (Mosquito2, Mosquito2.transform.position,Mosquito2.transform.rotation);
        Mosq4.GetComponent<Transform>().position = new Vector3(Reference2.transform.position.x, Mosq4.transform.position.y, Reference2.transform.position.z);
        Mosq5 = Instantiate (Mosquito3, Mosquito3.transform.position,Mosquito3.transform.rotation);
        Mosq5.GetComponent<Transform>().position = new Vector3(Reference3.transform.position.x, Mosq5.transform.position.y, Reference3.transform.position.z);
        
        total = 5;
	}

	void Start ()
	{
        Gerenciar = GameObject.FindGameObjectWithTag("Gerenciar");
    }
	
	// Update is called once per frame
	void Update ()
	{
		if (total <= 5) {
			if (time > timeDefinido ()) {
				if (Mosq1 == null) {
					createMosquito (1);
				} else if (Mosq2 == null) {
					createMosquito (2);
				} else if (Mosq3 == null) {
					createMosquito (3);
				} else if (Mosq4 == null) {
					createMosquito (4);
				} else if (Mosq5 == null) {
					createMosquito (5);
				}
				time = 0;
			}
			time += Time.deltaTime;
		}
	}


    public float timeDefinido()
    {
        int dificuldade = Gerenciar.GetComponent<ControleDificuldade>().NivelDificulade;
        int retorno = 7 - dificuldade;
        if (retorno < 0)
        {
            retorno = 0;
        }
        return retorno;
    }



	public void createMosquito (int code)
	{
		GameObject result = focoLancamento ();
		switch (code) {
		case 1:
			Mosq1 = Instantiate (Mosquito_1, Mosquito_1.transform.position,Mosquito_1.transform.rotation);
            Mosq1.GetComponent<Transform>().position = new Vector3(result.transform.position.x, Mosq1.transform.position.y, result.transform.position.z);
            break;
		case 2:
			Mosq2 = Instantiate (Mosquito0, Mosquito0.transform.position,Mosquito0.transform.rotation);
                Mosq2.GetComponent<Transform>().position = new Vector3(result.transform.position.x, Mosq2.transform.position.y, result.transform.position.z);
                break;
		case 3:
			Mosq3 = Instantiate (Mosquito1, Mosquito1.transform.position,Mosquito1.transform.rotation);
                Mosq3.GetComponent<Transform>().position = new Vector3(result.transform.position.x, Mosq3.transform.position.y, result.transform.position.z);
                break;
		case 4:
			Mosq4 = Instantiate (Mosquito2, Mosquito2.transform.position,Mosquito2.transform.rotation);
                Mosq4.GetComponent<Transform>().position = new Vector3(result.transform.position.x, Mosq4.transform.position.y, result.transform.position.z);
                break;
		case 5:
			Mosq5 = Instantiate (Mosquito3, Mosquito3.transform.position,Mosquito3.transform.rotation);
                Mosq5.GetComponent<Transform>().position = new Vector3(result.transform.position.x, Mosq5.transform.position.y, result.transform.position.z);
                break;
		}
	
	}


	public GameObject focoLancamento ()
	{
		if (fase == 1) {
			if (this.gameObject.GetComponent<GerirFocos> ().foco1Vivo && this.gameObject.GetComponent<GerirFocos> ().foco2Vivo && this.gameObject.GetComponent<GerirFocos> ().foco3Vivo) {
				int escolha = Random.Range (0, 2);
				switch (escolha) {
				case 0:
					return Reference1;
				case 1:
					return Reference2;
				case 2:
					return Reference3;
				}
			} else if (this.gameObject.GetComponent<GerirFocos> ().foco1Vivo && this.gameObject.GetComponent<GerirFocos> ().foco2Vivo) {
				int escolha = Random.Range (0, 1);
				switch (escolha) {
				case 0:
					return Reference1;
				case 1:
					return Reference2;				
				}
			} else if (this.gameObject.GetComponent<GerirFocos> ().foco1Vivo) {				
				return Reference1;
			} else if (this.gameObject.GetComponent<GerirFocos> ().foco2Vivo) {				
				return Reference2;
			} else if (this.gameObject.GetComponent<GerirFocos> ().foco3Vivo) {				
				return Reference3;
			} else if (this.gameObject.GetComponent<GerirFocos> ().foco4Vivo) {				
				return Reference4;
			}
		} else if (fase == 2) {
			if (this.gameObject.GetComponent<GerirFocos> ().foco1Vivo && this.gameObject.GetComponent<GerirFocos> ().foco2Vivo && this.gameObject.GetComponent<GerirFocos> ().foco3Vivo && this.gameObject.GetComponent<GerirFocos> ().foco4Vivo) {
				int escolha = Random.Range (0, 3);
				switch (escolha) {
				case 0:
					return Reference1;
				case 1:
					return Reference2;
				case 2:
					return Reference3;
				case 3:
					return Reference4;
				}
			} else if (this.gameObject.GetComponent<GerirFocos> ().foco1Vivo && this.gameObject.GetComponent<GerirFocos> ().foco2Vivo) {
				int escolha = Random.Range (0, 1);
				switch (escolha) {
				case 0:
					return Reference1;
				case 1:
					return Reference2;				
				}
			} else if (this.gameObject.GetComponent<GerirFocos> ().foco3Vivo && this.gameObject.GetComponent<GerirFocos> ().foco4Vivo) {
				int escolha = Random.Range (0, 1);
				switch (escolha) {
				case 0:
					return Reference3;
				case 1:
					return Reference4;				
				}
			} else if (this.gameObject.GetComponent<GerirFocos> ().foco1Vivo) {				
				return Reference1;
			} else if (this.gameObject.GetComponent<GerirFocos> ().foco2Vivo) {				
				return Reference2;
			} else if (this.gameObject.GetComponent<GerirFocos> ().foco3Vivo) {				
				return Reference3;
			} else if (this.gameObject.GetComponent<GerirFocos> ().foco4Vivo) {				
				return Reference4;
			} else if (this.gameObject.GetComponent<GerirFocos> ().foco5Vivo) {				
				return Reference5;
			}
		} else if (fase == 3) {
			if (this.gameObject.GetComponent<GerirFocos> ().foco1Vivo && this.gameObject.GetComponent<GerirFocos> ().foco2Vivo && this.gameObject.GetComponent<GerirFocos> ().foco3Vivo && this.gameObject.GetComponent<GerirFocos> ().foco4Vivo && this.gameObject.GetComponent<GerirFocos> ().foco5Vivo) {
				int escolha = Random.Range (0, 4);
				switch (escolha) {
				case 0:
					return Reference1;
				case 1:
					return Reference2;
				case 2:
					return Reference3;
				case 3:
					return Reference4;
				case 4:
					return Reference5;
				}
			} else if (this.gameObject.GetComponent<GerirFocos> ().foco1Vivo && this.gameObject.GetComponent<GerirFocos> ().foco2Vivo) {
				int escolha = Random.Range (0, 1);
				switch (escolha) {
				case 0:
					return Reference1;
				case 1:
					return Reference2;				
				}
			} else if (this.gameObject.GetComponent<GerirFocos> ().foco3Vivo && this.gameObject.GetComponent<GerirFocos> ().foco4Vivo) {
				int escolha = Random.Range (0, 1);
				switch (escolha) {
				case 0:
					return Reference3;
				case 1:
					return Reference4;				
				}
			} else if (this.gameObject.GetComponent<GerirFocos> ().foco4Vivo && this.gameObject.GetComponent<GerirFocos> ().foco5Vivo) {
				int escolha = Random.Range (0, 1);
				switch (escolha) {
				case 0:
					return Reference4;
				case 1:
					return Reference5;				
				}
			} else if (this.gameObject.GetComponent<GerirFocos> ().foco1Vivo) {				
				return Reference1;
			} else if (this.gameObject.GetComponent<GerirFocos> ().foco2Vivo) {				
				return Reference2;
			} else if (this.gameObject.GetComponent<GerirFocos> ().foco3Vivo) {				
				return Reference3;
			} else if (this.gameObject.GetComponent<GerirFocos> ().foco4Vivo) {				
				return Reference4;
			} else if (this.gameObject.GetComponent<GerirFocos> ().foco5Vivo) {				
				return Reference5;
			} else if (this.gameObject.GetComponent<GerirFocos> ().foco6Vivo) {				
				return Reference6;
			}
		}
		return null;
	
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeLarva : MonoBehaviour
{

    public float life;
    public float desconto;
    public GameObject efeito;
    public GameObject corpo;
	public GameObject LarvaGerencia;

    // Start is called before the first frame update
    void Start()
    {

    }


    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "BalaAzul")
        {
            descontoFazerAzul();
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "BalaVermelha")
        {
            descontoFazerVermelho();
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "BalaDourada")
        {
            descontoFazerDourada();
            Destroy(col.gameObject);
        }


    }

    public void descontoFazerAzul()
    {
        life = life - 25;//25 de descinto
        if (life <= 0)
        {
            //print("acertou");
             Instantiate(efeito, this.transform.position, efeito.transform.rotation);
           Destroy(corpo);
			LarvaGerencia.gameObject.GetComponent<GerenciarPontoLarva> ().Matar ();
        }
    }


    public void descontoFazerVermelho()
    {
        life = life - 50;//25 de descinto
        if (life <= 0)
        {
            //print("acertou");
            Instantiate(efeito, this.transform.position, efeito.transform.rotation);
            Destroy(corpo);
            LarvaGerencia.gameObject.GetComponent<GerenciarPontoLarva>().Matar();
        }
    }

    public void descontoFazerDourada()
    {
        life = life - 100;//25 de descinto
        if (life <= 0)
        {
            //print("acertou");
            Instantiate(efeito, this.transform.position, efeito.transform.rotation);
            Destroy(corpo);
            LarvaGerencia.gameObject.GetComponent<GerenciarPontoLarva>().Matar();
        }
    }


    void OnCollisionStay(Collision col)
    {
       
		if (col.gameObject.tag == "BalaAzul")
        {
			descontoFazerAzul();
            Destroy(col.gameObject);
        }
        
    }

}

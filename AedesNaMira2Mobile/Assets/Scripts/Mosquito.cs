using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mosquito : MonoBehaviour
{
    public GameObject Heroi;
    public NavMeshAgent agent;
    public GameObject corpo;
    public int id;
    private float time = 0;
    public int altura;
    public GameObject destino;
    public GameObject Ponto1, Ponto2, Ponto3, Ponto4;
    public float life = 100;
    public GameObject Remedio5, Remedio20;
    public GameObject Morte;
    public GameObject Gerenciar;
    // Use this for initialization
    void Start()
    {
        try
        {
            Heroi = GameObject.FindGameObjectWithTag("Heroi");
            Ponto1 = GameObject.FindGameObjectWithTag("Ponto1");
            Ponto2 = GameObject.FindGameObjectWithTag("Ponto2");
            Ponto3 = GameObject.FindGameObjectWithTag("Ponto3");
            Ponto4 = GameObject.FindGameObjectWithTag("Ponto4");
            Gerenciar = GameObject.FindGameObjectWithTag("Gerenciar");
            destino = Heroi;
            agent = GetComponent<NavMeshAgent>();
            id = Random.Range(0, 10);
            if (id < 4)
            {
                this.gameObject.tag = "Mosquito_Normal";
            }
            else if (id < 6)
            {
                this.gameObject.tag = "Mosquito_Chikungunya";
            }
            else if (id < 8)
            {
                this.gameObject.tag = "Mosquito_Zika";
            }
            else
            {
                this.gameObject.tag = "Mosquito_Dengue";
            }
            destinoHeroi();
        }
        catch (System.Exception) { }
        //    corpo.gameObject.GetComponent<MeshRenderer>().material = Normal;

    }

    // Update is called once per frame
    void Update()
    {

        try
        {
            agent.destination = destino.transform.position;
        }
        catch (System.Exception)
        {

        }
        int dificuldade = Gerenciar.GetComponent<ControleDificuldade>().NivelDificulade;
        if (life <= 0)
        {

            int sorte = 15 + dificuldade;
            if (sorte >= int.MaxValue - 1)
            {
                sorte = int.MaxValue;
            }
            int solta = Random.Range(1, sorte);
            if (solta <= 3)
            {
                Instantiate(Remedio20, this.gameObject.transform.position, Remedio20.transform.rotation);
            }
            else if (solta <= 7)
            {
                Instantiate(Remedio5, this.gameObject.transform.position, Remedio5.transform.rotation);
            }


            if (gameObject.tag == "Mosquito_Normal")
            {

                GameObject.FindGameObjectWithTag("Gerenciar").GetComponent<DadosFase>().IncrementarSaldo(2.5f);
                Gerenciar.GetComponent<DadosFase>().AddMosquitoNormalMorto();

            }
            else if (gameObject.tag == "Mosquito_Chikungunya")
            {
                GameObject.FindGameObjectWithTag("Gerenciar").GetComponent<DadosFase>().IncrementarSaldo(5);
                Gerenciar.GetComponent<DadosFase>().AddMosquitoChMorto();
            }
            else if (gameObject.tag == "Mosquito_Zika")
            {
                GameObject.FindGameObjectWithTag("Gerenciar").GetComponent<DadosFase>().IncrementarSaldo(10);
                Gerenciar.GetComponent<DadosFase>().AddMosquitoZikaMorto();
            }
            else if (gameObject.tag == "Mosquito_Dengue")
            {
                GameObject.FindGameObjectWithTag("Gerenciar").GetComponent<DadosFase>().IncrementarSaldo(15);
                Gerenciar.GetComponent<DadosFase>().AddMosquitoDengueMorto();
            }
            Gerenciar.GetComponent<DadosFase>().Mosquitototal = Gerenciar.GetComponent<DadosFase>().Mosquitototal + 1;

            Instantiate(Morte, this.gameObject.transform.position, Morte.transform.rotation);

            Destroy(this.gameObject);

        }

    }



    public void destinoHeroi()
    {
        destino = Heroi;
        agent.destination = destino.transform.position;
    }

    public void destinoPonto()
    {

        if (altura == 0)
        {
            if (Vector3.Distance(transform.position, Ponto1.transform.position) > Vector3.Distance(transform.position, Ponto2.transform.position))
            {
                destino = Ponto1;
            }
            else
            {
                destino = Ponto2;
            }
        }
        else if (altura == -1)
        {
            if (Vector3.Distance(transform.position, Ponto1.transform.position) > Vector3.Distance(transform.position, Ponto3.transform.position))
            {
                destino = Ponto1;
            }
            else
            {
                destino = Ponto3;
            }
        }
        else if (altura == 1)
        {
            if (Vector3.Distance(transform.position, Ponto2.transform.position) > Vector3.Distance(transform.position, Ponto3.transform.position))
            {
                destino = Ponto2;
            }
            else
            {
                destino = Ponto3;
            }
        }
        else if (altura == 2)
        {
            if (Vector3.Distance(transform.position, Ponto1.transform.position) > Vector3.Distance(transform.position, Ponto3.transform.position) && Vector3.Distance(transform.position, Ponto1.transform.position) > Vector3.Distance(transform.position, Ponto2.transform.position))
            {
                destino = Ponto1;
            }
            else if (Vector3.Distance(transform.position, Ponto2.transform.position) > Vector3.Distance(transform.position, Ponto1.transform.position) && Vector3.Distance(transform.position, Ponto2.transform.position) > Vector3.Distance(transform.position, Ponto3.transform.position))
            {
                destino = Ponto2;
            }
            else
            {
                destino = Ponto3;
            }
        }
        else if (altura == 3)
        {
            if (Vector3.Distance(transform.position, Ponto3.transform.position) > Vector3.Distance(transform.position, Ponto4.transform.position))
            {
                destino = Ponto3;
            }
            else
            {
                destino = Ponto4;
            }
        }
        agent.destination = destino.transform.position;
    }




}

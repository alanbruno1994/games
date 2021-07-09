using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ponto : MonoBehaviour
{
    public NavMeshAgent AuxPosicaoNavMesh;
    public Transform ponto1,ponto2,ponto3;
    public Transform ponto;
    // Use this for initialization
    void Start()
    {
        ponto = ponto1;

    }

    // Update is called once per frame
    void Update()
    {
        AuxPosicaoNavMesh.destination = ponto.position;

    }

    
   /**

    void OnCollisionEnter(Collision col)
    {
        print("1");

        if (col.gameObject.tag == "Ponto1")
        {
            ponto = ponto2;
        }
        else if (col.gameObject.tag == "Ponto2")
        {
            ponto = ponto3;
        }
        else if (col.gameObject.tag == "Ponto3")
        {
            ponto = ponto1;
        }
    }

    void OnCollisionStay(Collision col)
    {
        print("2");
        if (col.gameObject.tag == "Ponto1")
        {
            ponto = ponto2;
        }
        else if (col.gameObject.tag == "Ponto2")
        {
            ponto = ponto3;
        }
        else if (col.gameObject.tag == "Ponto3")
        {
            ponto = ponto1;
        }
    }
    */

    void OnTriggerEnter(Collider col)
    {
        

        if (col.gameObject.tag == "Ponto1")
        {
            ponto = ponto2;
        }
        else if (col.gameObject.tag == "Ponto2")
        {
            ponto = ponto3;
        }
        else if (col.gameObject.tag == "Ponto3")
        {
            ponto = ponto1;
        }
    }

    void OnTriggerStay(Collider col)
    {
       
        if (col.gameObject.tag == "Ponto1")
        {
            ponto = ponto2;
        }
        else if (col.gameObject.tag == "Ponto2")
        {
            ponto = ponto3;
        }
        else if (col.gameObject.tag == "Ponto3")
        {
            ponto = ponto1;
        }
    }

}
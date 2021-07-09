using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Refere-se animacoa de disparar uma arma;
 */
public class GerirAnimacoesArma : MonoBehaviour
{
    public Animator Sisk8000, HamiltonM9, MH44;
    public Animator MDSH98, MDK90, MDFALL16, MDT47, MDRT90;
    public Animator MESH98, MEK90, MEFALL16, MET47, MERT90;
    public DadosFase dados;
    public GameObject rSisk8000, rHamiltonM9, rMH44;//Referencial
    public GameObject rSH98, rK90, rFALL16, rT47,rRT90;//Referencial
    public GameObject eSisk8000, eHamiltonM9, eMH44;//Efeito
    public GameObject eSH98, eK90, eFALL16, eT47, eRT90;//Efeito
    public GameObject bSisk8000, bHamiltonM9, bMH44;//Bala
    public GameObject bSH98, bK90, bFALL16, bT47, bRT90;//Bala
    public bool disparo;
    void Start()
    {
        dados = GameObject.FindGameObjectWithTag("Gerenciar").GetComponent<DadosFase>();
        disparo = true;
    }



    public void fazerDisparo()
    {
        /*
        disparo = false;
        switch (dados.armaUsada) 
        {
            case 0:
                Sisk8000.SetBool("atirar",true);
                dados.qtdBalas0--;
                Instantiate(eSisk8000, rSisk8000.transform);
                Instantiate(bSisk8000, rSisk8000.transform.position, rSisk8000.transform.rotation);
                break;
            case 1:
                HamiltonM9.SetBool("atirar", true);
                dados.qtdBalas1--;
                Instantiate(eHamiltonM9, rHamiltonM9.transform);               
                Instantiate(bHamiltonM9, rHamiltonM9.transform.position, rHamiltonM9.transform.rotation);
                break;
            case 2:
                MH44.SetBool("atirar", true);
                dados.qtdBalas2--;
                Instantiate(eMH44, rMH44.transform);               
                Instantiate(bMH44, rMH44.transform.position, rMH44.transform.rotation);
                break;
            case 3:
                MDK90.SetBool("atirar", true);
                MEK90.SetBool("atirar", true);
                dados.qtdBalas3--;
                Instantiate(eK90, rK90.transform);                
                Instantiate(bK90, rK90.transform.position, rK90.transform.rotation);
                break;
            case 4:
                MDRT90.SetBool("atirar", true);
                MERT90.SetBool("atirar", true);
                dados.qtdBalas4--;
                Instantiate(eRT90, rRT90.transform);
                Instantiate(bRT90, rRT90.transform.position, rRT90.transform.rotation);
                break;
            case 5:
                MDSH98.SetBool("atirar", true);
                MESH98.SetBool("atirar", true);
                dados.qtdBalas5--;
                Instantiate(eSH98, rSH98.transform);
                Instantiate(bSH98, rSH98.transform.position, rSH98.transform.rotation);
                break;
            case 6:
                MDT47.SetBool("atirar", true);
                MET47.SetBool("atirar", true);
                dados.qtdBalas6--;
                Instantiate(eT47, rT47.transform);
                Instantiate(bT47, rT47.transform.position, rT47.transform.rotation);
                break;
            case 7:
                MDFALL16.SetBool("atirar", true);
                MEFALL16.SetBool("atirar", true);
                dados.qtdBalas7--;
                Instantiate(eFALL16, rFALL16.transform);
                Instantiate(bFALL16, rFALL16.transform.position, rFALL16.transform.rotation);
                break;
        }*/
    }



    public bool veriricarSeterminou() 
    {
        /*
        Debug.Log("forma  "+this.Sisk8000.GetCurrentAnimatorStateInfo(0).IsTag("atirar"));
        if (dados.armaUsada==0)//SISK8000
        {
            if (this.Sisk8000.GetCurrentAnimatorStateInfo(0).IsTag("atirar"))
            {
                disparo = true;
                Sisk8000.SetBool("atirar", false);
            }
        }else if (dados.armaUsada == 1)//HamiltonM9
        {
            if (this.HamiltonM9.GetCurrentAnimatorStateInfo(0).IsTag("atirar"))
            {
                disparo = true;
                HamiltonM9.SetBool("atirar", false);
            }
        }else if (dados.armaUsada == 2)//MH44
        {
            if (this.MH44.GetCurrentAnimatorStateInfo(0).IsTag("atirar"))
            {
                disparo = true;
                MH44.SetBool("atirar", false);
            }
        }else if (dados.armaUsada == 3)//K90
        {
            if (this.MDK90.GetCurrentAnimatorStateInfo(0).IsTag("atirar"))
            {
                disparo = true;
                MDK90.SetBool("atirar", false);
                MEK90.SetBool("atirar", false);
            }
        }else if (dados.armaUsada == 4)//RT90
        {
            if (this.MDRT90.GetCurrentAnimatorStateInfo(0).IsTag("atirar"))
            {
                disparo = true;
                MDRT90.SetBool("atirar", false);
                MERT90.SetBool("atirar", false);
            }
        }else if (dados.armaUsada == 5)//MDSH98
        {
            if (this.MDSH98.GetCurrentAnimatorStateInfo(0).IsTag("atirar"))
            {
                disparo = true;
                MDSH98.SetBool("atirar", false);
                MESH98.SetBool("atirar", false);
            }
        }else if (dados.armaUsada == 6)//MDT47
        {
            if (this.MDT47.GetCurrentAnimatorStateInfo(0).IsTag("atirar"))
            {
                disparo = true;
                MDT47.SetBool("atirar", false);
                MET47.SetBool("atirar", false);
            }
        }else if (dados.armaUsada == 7)//FALL16
        {
            if (this.MDFALL16.GetCurrentAnimatorStateInfo(0).IsTag("atirar"))
            {
                disparo = true;
                MDFALL16.SetBool("atirar", false);
                MEFALL16.SetBool("atirar", false);
            }
        }*/
        return disparo;
    }
    
}

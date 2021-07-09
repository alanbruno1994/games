using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class DadosFase : MonoBehaviour
{
    public float Saldo = 0, pontos = 0;
    public int MosquitoNormalMorto = 0, MosquitoZikaMorto = 0, MosquitoDengueMorto = 0, MosquitoChMorto = 0, Mosquitototal = 0, FocoDestruido = 0;
    public GameObject HUD;
    public int fase;
    void Start()
    {
        HUD = GameObject.FindGameObjectWithTag("HUD");

    }


    public void IncrementarSaldo(float Saldo)
    {
        this.Saldo += Saldo;
        pontos += Saldo;
        if (HUD != null)
        {
            if (HUD.GetComponent<HUD>() != null)
            {
                HUD.GetComponent<HUD>().Dinheiro.text = "" + Math.Round(this.Saldo, 2);
                HUD.GetComponent<HUD>().Ponto.text = "" + Math.Round(this.pontos, 2);
            }
        }
    }


    public void DecrementarSaldo(float Saldo)
    {
        this.Saldo -= Saldo;
        if (protecao())
        {
            HUD.GetComponent<HUD>().Dinheiro.text = "" + Math.Round(this.Saldo, 2);
        }
    }

    private bool protecao()
    {
        if (HUD != null)
        {
            if (HUD.GetComponent<HUD>() != null)
            {
                return true;
            }
        }
        return false;
    }

    public void AddMosquitoNormalMorto()
    {
        MosquitoNormalMorto++;
        if (protecao())
        {
            HUD.GetComponent<HUD>().MosquitoMorto.text = "" + (MosquitoNormalMorto + MosquitoZikaMorto + MosquitoDengueMorto + MosquitoChMorto);
        }

    }

    public void AddMosquitoZikaMorto()
    {
        MosquitoZikaMorto++;
        if (protecao())
        {
            HUD.GetComponent<HUD>().MosquitoMorto.text = "" + (MosquitoNormalMorto + MosquitoZikaMorto + MosquitoDengueMorto + MosquitoChMorto);
        }
    }

    public void AddMosquitoChMorto()
    {
        MosquitoChMorto++;
        if (protecao())
        {
            HUD.GetComponent<HUD>().MosquitoMorto.text = "" + (MosquitoNormalMorto + MosquitoZikaMorto + MosquitoDengueMorto + MosquitoChMorto);
        }
    }

    public void AddMosquitoDengueMorto()
    {
        MosquitoDengueMorto++;
        if (protecao())
        {
            HUD.GetComponent<HUD>().MosquitoMorto.text = "" + (MosquitoNormalMorto + MosquitoZikaMorto + MosquitoDengueMorto + MosquitoChMorto);
        }
    }

    public void AddFocoAbatido()
    {
        FocoDestruido++;
    }
}

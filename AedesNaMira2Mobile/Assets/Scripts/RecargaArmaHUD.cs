using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecargaArmaHUD : MonoBehaviour
{
    public Image recargaArma;
    public Sprite ck1, ck2, ck3, ck4, ck5, ck6, ck7, ck8, ck9, ck10, ck11,nada;
    public bool terminou;
    public DadosFase dados;
    void Start()
    {
        dados = GameObject.FindGameObjectWithTag("Gerenciar").GetComponent<DadosFase>();
        terminou = true;
    }


    public void tempo2s(int contador) 
    {
        if (contador < 10)
        {
            recargaArma.sprite = ck1;
        }
        else if (contador < 20)
        {
            recargaArma.sprite = ck2;
        }
        else if (contador < 30)
        {
            recargaArma.sprite = ck3;
        }
        else if (contador < 40)
        {
            recargaArma.sprite = ck4;
        }
        else if (contador < 50)
        {
            recargaArma.sprite = ck5;
        }
        else if (contador < 60)
        {
            recargaArma.sprite = ck6;
        }
        else if (contador < 70)
        {
            recargaArma.sprite = ck7;
        }
        else if (contador < 80)
        {
            recargaArma.sprite = ck8;
        }
        else if (contador < 90)
        {
            recargaArma.sprite = ck9;
        }
        else if (contador < 100)
        {
            recargaArma.sprite = ck10;
        }
        else 
        {
            recargaArma.sprite = ck11;
            terminou=true;
            recomporBalas();
        }
        
    }

    public void tempo1s(int contador)
    {
        if (contador < 5)
        {
            recargaArma.sprite = ck1;
        }
        else if (contador < 10)
        {
            recargaArma.sprite = ck2;
        }
        else if (contador < 15)
        {
            recargaArma.sprite = ck3;
        }
        else if (contador < 20)
        {
            recargaArma.sprite = ck4;
        }
        else if (contador < 25)
        {
            recargaArma.sprite = ck5;
        }
        else if (contador < 30)
        {
            recargaArma.sprite = ck6;
        }
        else if (contador < 35)
        {
            recargaArma.sprite = ck7;
        }
        else if (contador < 40)
        {
            recargaArma.sprite = ck8;
        }
        else if (contador < 45)
        {
            recargaArma.sprite = ck9;
        }
        else if (contador < 50)
        {
            recargaArma.sprite = ck10;
        }
        else
        {
            recargaArma.sprite = ck11;
            terminou = true;
            recomporBalas();
        }
        
    }

    public void tempo3s(int contador)
    {
        if (contador < 15)
        {
            recargaArma.sprite = ck1;
        }
        else if (contador < 30)
        {
            recargaArma.sprite = ck2;
        }
        else if (contador < 45)
        {
            recargaArma.sprite = ck3;
        }
        else if (contador < 60)
        {
            recargaArma.sprite = ck4;
        }
        else if (contador < 75)
        {
            recargaArma.sprite = ck5;
        }
        else if (contador < 90)
        {
            recargaArma.sprite = ck6;
        }
        else if (contador < 105)
        {
            recargaArma.sprite = ck7;
        }
        else if (contador < 120)
        {
            recargaArma.sprite = ck8;
        }
        else if (contador < 135)
        {
            recargaArma.sprite = ck9;
        }
        else if (contador < 150)
        {
            recargaArma.sprite = ck10;
        }
        else
        {
            recargaArma.sprite = ck11;
            terminou = true;
            recomporBalas();
        }        
    }

    public void tempo4s(int contador)
    {
        if (contador < 20)
        {
            recargaArma.sprite = ck1;
        }
        else if (contador < 40)
        {
            recargaArma.sprite = ck2;
        }
        else if (contador < 60)
        {
            recargaArma.sprite = ck3;
        }
        else if (contador < 80)
        {
            recargaArma.sprite = ck4;
        }
        else if (contador < 100)
        {
            recargaArma.sprite = ck5;
        }
        else if (contador < 120)
        {
            recargaArma.sprite = ck6;
        }
        else if (contador < 140)
        {
            recargaArma.sprite = ck7;
        }
        else if (contador < 160)
        {
            recargaArma.sprite = ck8;
        }
        else if (contador < 180)
        {
            recargaArma.sprite = ck9;
        }
        else if (contador < 200)
        {
            recargaArma.sprite = ck10;
        }
        else
        {
            recargaArma.sprite = ck11;
            terminou = true;
            recomporBalas();
        }
       
    }

    public void recomporBalas() 
    {/*
        switch (dados.armaUsada) 
        {
            case 0://sisk8000
                dados.qtdBalas0 = 8;
                break;
            case 1://Hamilton M9
                dados.qtdBalas1 = 15;
                break;
            case 2://MH44
                dados.qtdBalas2 = 6;
                break;
            case 3://K90
                dados.qtdBalas3 = 30;
                break;
            case 4://RT90
                dados.qtdBalas4 = 2;
                break;
            case 5://SH98
                dados.qtdBalas5 = 7;
                break;
            case 6://T47
                dados.qtdBalas6 = 30;
                break;
            case 7://FALL16
                dados.qtdBalas6 = 30;
                break;
        }*/
    }
    
}

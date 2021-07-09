using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle_trocaHUD : MonoBehaviour
{
    public GameObject Vida,Arma,Grana,MosquitoMorto,Protocoes, Relogio,AguaParada;
    public int id;
    // Start is called before the first frame update
    void Start()
    {
        id = 0;
    }

    public void avancar() 
    {
        id++;
        if (id>7) 
        {
            id = 0;
        }
        escolha();
    }

    public void voltar()
    {
        id--;
        if (id < 0)
        {
            id = 7;
        }
        escolha();
    }


    public void escolha() 
    {
        switch (id)
        {
            case 0:
                Vida.SetActive(false);
                Arma.SetActive(false);
                Grana.SetActive(false);
                MosquitoMorto.SetActive(false);
                Protocoes.SetActive(false);
                Relogio.SetActive(false);
                AguaParada.SetActive(false);
                break;
            case 1:
                Vida.SetActive(true);
                Arma.SetActive(false);
                Grana.SetActive(false);
                MosquitoMorto.SetActive(false);
                Protocoes.SetActive(false);
                Relogio.SetActive(false);
                AguaParada.SetActive(false);
                break;
            case 2:
                Vida.SetActive(false);
                Arma.SetActive(true);
                Grana.SetActive(false);
                MosquitoMorto.SetActive(false);
                Protocoes.SetActive(false);
                Relogio.SetActive(false);
                AguaParada.SetActive(false);
                break;
            case 3:
                Vida.SetActive(false);
                Arma.SetActive(false);
                Grana.SetActive(true);
                MosquitoMorto.SetActive(false);
                Protocoes.SetActive(false);
                Relogio.SetActive(false);
                AguaParada.SetActive(false);
                break;
            case 4:
                Vida.SetActive(false);
                Arma.SetActive(false);
                Grana.SetActive(false);
                MosquitoMorto.SetActive(true);
                Protocoes.SetActive(false);
                Relogio.SetActive(false);
                AguaParada.SetActive(false);
                break;
            case 5:
                Vida.SetActive(false);
                Arma.SetActive(false);
                Grana.SetActive(false);
                MosquitoMorto.SetActive(false);
                Protocoes.SetActive(true);
                Relogio.SetActive(false);
                AguaParada.SetActive(false);
                break;
            case 6:
                Vida.SetActive(false);
                Arma.SetActive(false);
                Grana.SetActive(false);
                MosquitoMorto.SetActive(false);
                Protocoes.SetActive(false);
                Relogio.SetActive(true);
                AguaParada.SetActive(false);
                break;
            case 7:
                Vida.SetActive(false);
                Arma.SetActive(false);
                Grana.SetActive(false);
                MosquitoMorto.SetActive(false);
                Protocoes.SetActive(false);
                Relogio.SetActive(false);
                AguaParada.SetActive(true);
                break;

        } 
    }


}

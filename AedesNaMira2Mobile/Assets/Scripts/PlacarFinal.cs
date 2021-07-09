using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlacarFinal : MonoBehaviour
{
    public Text nome, ponto, mosquitoNormal, MosquitoDengue, MosquitoChikungunya, MosquitoZika, Focos,JogarNavamente;
    public Text Define,MenuPrincipalT;
    public GameObject Gerenciar;
    public GameObject FaseAnterior, FaseProximo;
    public int fase;
    void Start()
    {
        configurarRecorde();
        Gerenciar = GameObject.FindGameObjectWithTag("Gerenciar");
        switch (Gerenciar.GetComponent<DadosFase>().fase)
        {
            case 1:
                fase = 1;
                FaseAnterior.SetActive(false);
                if (PlayerPrefs.GetInt("Fase2") != 1)
                {
                    FaseProximo.SetActive(false);
                }                
                break;
            case 2:
                fase = 2;
                if (PlayerPrefs.GetInt("Fase3") != 1)
                {
                    FaseProximo.SetActive(false);
                }                
                break;
            case 3:
                fase = 3;
                FaseProximo.SetActive(false);
                break;

        }
    }
    public void configurarRecorde()
    {
        Define.text = "Jogador";
        Define.alignment = TextAnchor.UpperLeft;
        nome.text = PlayerPrefs.GetString("Nome");
        ponto.text = "" + PlayerPrefs.GetFloat("Ponto");
        mosquitoNormal.text = "" + PlayerPrefs.GetInt("MosquitoNormal");
        MosquitoDengue.text = "" + PlayerPrefs.GetInt("MosquitoDengue");
        MosquitoChikungunya.text = "" + PlayerPrefs.GetInt("MosquitoChikungunya");
        MosquitoZika.text = "" + PlayerPrefs.GetInt("MosquitoZika");
        Focos.text = "" + PlayerPrefs.GetInt("Focos");
        
        
    }

    public void configurarMeuPlacar()
    {
        Define.text = "Meu Placar";
        Define.alignment = TextAnchor.UpperCenter;
        nome.text = "";
        ponto.text = "" + Gerenciar.GetComponent<DadosFase>().pontos;
        mosquitoNormal.text = "" + Gerenciar.GetComponent<DadosFase>().MosquitoNormalMorto;
        MosquitoDengue.text = "" + Gerenciar.GetComponent<DadosFase>().MosquitoDengueMorto;
        MosquitoChikungunya.text = "" + Gerenciar.GetComponent<DadosFase>().MosquitoChMorto;
        MosquitoZika.text = "" + Gerenciar.GetComponent<DadosFase>().MosquitoZikaMorto;
        Focos.text = "" + Gerenciar.GetComponent<DadosFase>().FocoDestruido;
    }

    public void MenuPrincipal()
    {
        MenuPrincipalT.text = "Aguarde...";
        Application.LoadLevel("Menu");
    }

    public void proximaFase()
    {
        if (fase == 1)
        {
            
            SceneManager.LoadScene("Fase_2");

        }
        else if (fase == 2)
        {
            
            SceneManager.LoadScene("Fase_3");
        }
    }

    public void faseAnteiror()
    {
        if (fase == 2)
        {
           
            SceneManager.LoadScene("Fase_1");
        } else if (fase == 3)
        {
            
            SceneManager.LoadScene("Fase_2");
        }
    }


    public void repetirFase()
    {
        JogarNavamente.text = "Aguarde...";
        switch (fase)
        {
            case 1:               
                SceneManager.LoadScene("Fase_1");
                break;
            case 2:               
                SceneManager.LoadScene("Fase_2");
                break;
            case 3:               
                SceneManager.LoadScene("Fase_3");
                break;
        }
    }
}

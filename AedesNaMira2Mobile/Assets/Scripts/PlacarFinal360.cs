using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlacarFinal360 : MonoBehaviour
{
    public Text nome, ponto, mosquitoNormal, MosquitoDengue, MosquitoChikungunya, MosquitoZika, Focos, JogarNavamente;
    public Text Define, MenuPrincipalT;
    public GameObject Gerenciar;
    public GameObject FaseAnterior, FaseProximo,RepertirFase,MeuPlacar,Recorde,Menu_Principal;
    public GameObject Aguarde;
    public int fase;
    public Input360 input;
    void Start()
    {
        configurarRecorde();
        Gerenciar = GameObject.FindGameObjectWithTag("Gerenciar");
        if (PlayerPrefs.HasKey("Fase2")==false) 
        {
            PlayerPrefs.SetInt("Fase2", 0);
            PlayerPrefs.SetInt("Fase3", 0);
        }
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
        SceneManager.LoadScene("Menu_RV", LoadSceneMode.Single);
    }

    public void AtivaAguarde() 
    {
        FaseAnterior.SetActive(false);
        FaseProximo.SetActive(false);
        RepertirFase.SetActive(false);
        MeuPlacar.SetActive(false);
        Recorde.SetActive(false);
        Menu_Principal.SetActive(false);
        Aguarde.SetActive(true);
    }


    public bool proximaFase()
    {
        if (fase == 1)
        {
            SceneManager.LoadScene("Fase_2");
            return true;
        }
        else if (fase == 2)
        {

            SceneManager.LoadScene("Fase_3");
            return true;
        }
        return false;
    }

    public bool faseAnteiror()
    {
        if (fase == 2)
        {

            SceneManager.LoadScene("Fase_1");
            return true;
        }
        else if (fase == 3)
        {

            SceneManager.LoadScene("Fase_2");
            return true;
        }
        return false;
    }

    void Update()
    {
        if (input.A.isBotao())//Jogar Novamente
        {
            repetirFase();
            AtivaAguarde();
        }
        else if (input.X.isBotao())//Fase Anterior
        {
            if (faseAnteiror()) 
            {
                AtivaAguarde();


            }
        }
        else if (input.B.isBotao())//Proxima fase
        {
            if (proximaFase()) 
            {
                AtivaAguarde();


            }

        }
        else if (input.Y.isBotao())//Recorde
        {
            configurarRecorde();
        }
        else if (input.Rb.isBotao())//Meu Placar
        {
            configurarMeuPlacar();
        }
        else if (input.start.isBotao())//Menu Principal
        {
            AtivaAguarde();
            MenuPrincipal();
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuPlay : MonoBehaviour
{
    public Text condicaoLimitacao,NomeFase;
    public Image Fase;
    public Sprite fase1, fase2, fase3;
    public int idFase = 1;
    public Input360 input;
    public MenuControle360 menuControle360;
    public GameObject tampao;
    // Start is called before the first frame update
    void Start()
    {
        Reset();
        if (PlayerPrefs.HasKey("Fase2")==false) 
        {
            PlayerPrefs.SetInt("Fase2",0);//0 nao liberado e 1 liberado
            PlayerPrefs.SetInt("Fase3", 0);//0 nao liberado e 1 liberado
        } 
    }

    // Update is called once per frame
    void Update()
    {
        if (input.A.isBotao())//Play
        {

            if (idFase == 1)
            {
                SceneManager.LoadScene("Fase_1", LoadSceneMode.Single);
            } else if (idFase==2 && PlayerPrefs.GetInt("Fase2")>0)
            {
                SceneManager.LoadScene("Fase_2", LoadSceneMode.Single);
            }
            else if (idFase == 3 && PlayerPrefs.GetInt("Fase3")>0)
            {
                SceneManager.LoadScene("Fase_3", LoadSceneMode.Single);
            }

        }
        else if (input.B.isBotao())//Back
        {
            Reset();
            menuControle360.ativaMenuCentral();
        }
        else if (input.JoystickEsquerdoDireita.positivoBotao())//Avancar Options
        {
            AvancarID();
        }
        else if (input.JoystickEsquerdoDireita.negativoBotao())//Voltar Options
        {
            RetornarID();
        }
    }





    public void Reset()
    {
        idFase = 1;
        Fase.sprite = fase1;
        NomeFase.text = "Fase 1: A casa";
        mudarItem();
    }

    public void AvancarID()
    {
        idFase++;
        if (idFase > 3)
        {
            idFase = 1;
        }
        mudarItem();
    }

    public void RetornarID()
    {
        idFase--;
        if (idFase < 1)
        {
            idFase = 3;
        }
        mudarItem();
    }


    public void mudarItem() 
    {
        switch (idFase) 
        {
            case 1:
                NomeFase.text = "Fase 1: A casa";
                Fase.sprite = fase1;
                tampao.SetActive(false);
                break;
            case 2:
                NomeFase.text = "Fase 2: O bairro";
                Fase.sprite = fase2;
                if (PlayerPrefs.GetInt("Fase2") > 0)
                {
                    tampao.SetActive(false);
                }
                else 
                {
                    tampao.SetActive(true);
                    condicaoLimitacao.text = "Atinja 200 pontos.";
                }
                break;
            case 3:
                NomeFase.text = "Fase 3: O parque";
                Fase.sprite = fase3;
                if (PlayerPrefs.GetInt("Fase3") > 0)
                {
                    tampao.SetActive(false);
                }
                else
                {
                    tampao.SetActive(true);
                    condicaoLimitacao.text = "Atinja 400 pontos.";
                }
                break;        
        }    
    
    }



}
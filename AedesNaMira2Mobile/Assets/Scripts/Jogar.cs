using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Jogar : MonoBehaviour
{

    public Text Fase,Meta,TextoJogar;
    public int id = 1;
    public Image FaseImage,Cadeado;
    public Sprite imageFase1, imageFase2, imageFase3;
    public Button ButaoJogar;

    void Start()
    {
       
        id = 1;
        FaseImage.sprite = imageFase1;
        Cadeado.enabled = false;
        Meta.text = "";
    }

    // Start is called before the first frame update

    public void Ir()
    {
        if (id == 1)
        {
            id = 2;
            Fase.text = "Fase 2: O bairro";
            FaseImage.sprite = imageFase2;
            if (PlayerPrefs.HasKey("Fase2"))
            {
                if (PlayerPrefs.GetInt("Fase2") == 1)
                {
                    Cadeado.enabled = false;
                    Meta.text = "";
                }
                else
                {
                    Cadeado.enabled = true;
                    Meta.text = "Atinja 200 pontos.";
                }
            }
            else
            {
                Cadeado.enabled = true;
                Meta.text = "Atinja 200 pontos.";
            }
        }
        else if (id == 2)
        {
            id = 3;
            Fase.text = "Fase 3: O parque";
            FaseImage.sprite = imageFase3;
            if (PlayerPrefs.HasKey("Fase3"))
            {
                if (PlayerPrefs.GetInt("Fase3") == 1)
                {
                    Cadeado.enabled = false;
                    Meta.text = "";
                }
                else
                {
                    Cadeado.enabled = true;
                    Meta.text = "Atinja 400 pontos.";
                }
            }
            else
            {
                Cadeado.enabled = true;
                Meta.text = "Atinja 400 pontos.";
            }
        }
        else if (id == 3)
        {
            id = 1;
            Fase.text = "Fase 1: A casa";
            FaseImage.sprite = imageFase1;
            Cadeado.enabled = false;
            Meta.text = "";
        }

    }

    public void Voltar()
    {
        if (id == 1)
        {
            id = 3;
            Fase.text = "Fase 3: O parque";
            FaseImage.sprite = imageFase3;
            if (PlayerPrefs.HasKey("Fase3"))
            {
                if (PlayerPrefs.GetInt("Fase3") == 1)
                {
                    Cadeado.enabled = false;
                    Meta.text = "";
                }
                else
                {
                    Cadeado.enabled = true;
                    Meta.text = "Atinja 400 pontos.";
                }
            }
            else
            {
                Cadeado.enabled = true;
                Meta.text = "Atinja 400 pontos.";
            }
        }
        else if (id == 2)
        {
            id = 1;
            Fase.text = "Fase 1: A casa";
            FaseImage.sprite = imageFase1;
            Cadeado.enabled = false;
            Meta.text = "";
        }
        else if (id == 3)
        {      

            id = 2;
            Fase.text = "Fase 2: O bairro";
            FaseImage.sprite = imageFase2;
            if (PlayerPrefs.HasKey("Fase2"))
            {
                if (PlayerPrefs.GetInt("Fase2") == 1)
                {
                    Cadeado.enabled = false;
                    Meta.text = "";
                }
                else
                {
                    Cadeado.enabled = true;
                    Meta.text = "Atinja 200 pontos.";
                }
            }
            else
            {
                Cadeado.enabled = true;
                Meta.text = "Atinja 200 pontos.";
            }
        }

    }


    public void JogarGame()
    {
        switch (id)
        {
            case 1:
                ButaoJogar.GetComponent<Image>().enabled = false;
                TextoJogar.text = "Aguarde...";               
                SceneManager.LoadScene("Fase_1");
                break;
            case 2:
                if (PlayerPrefs.HasKey("Fase2"))
                {
                    if (PlayerPrefs.GetInt("Fase2") == 1)
                    {
                        ButaoJogar.GetComponent<Image>().enabled = false;
                        TextoJogar.text = "Aguarde...";                        
                        SceneManager.LoadScene("Fase_2");
                    }
                }                
                break;
            case 3:
                if (PlayerPrefs.HasKey("Fase3"))
                {
                    if (PlayerPrefs.GetInt("Fase3") == 1)
                    {
                        ButaoJogar.GetComponent<Image>().enabled = false;
                        TextoJogar.text = "Aguarde...";                       
                        SceneManager.LoadScene("Fase_3");
                    }
                }
                break;


        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR;

public class MapearController : MonoBehaviour
{
    public GameObject Controle1, Controle2;
    public GameObject telaBotaoA, telaBotaoX, telaBotaoY,telaBotaoB, telaBotaoStart, telaBotaoSelect, telaBotaoJoystickDireito, telaBotaoJoystickEsquerdo, telaDirecionalCima;
    public GameObject telaDirecionalDireita, telaRT, telaLT, telaRB, telaLB, telaJoystickDireitoCima, telaJoystickDireitoDireita, telaJoystickEsquerdoCima, telaJoystickEsquerdoDireita;
    public bool A, B, X, Y, BotaoJoystickDireito, BotaoJoystickEsquerdo, JoystickDireitoCima;
    public bool JoystickDireitoDireita, JoystickEsquerdoCima, JoystickEsquerdoDireita, DirecionalCima, DirecionalDireita;
    public bool start, Select, RB, RT, LB, LT;
    public bool save;
    public string valueButao = "", valueTrigger = "";
    public int inverte = 1;
    public GameObject configuracaoSalva;
    public ObjectAtiva objectAtiva;
    public Text Trigger, TriggerValue, Botao, BotaoValue, Info1, Info1Value, Info2, Info2Value, Info3, Info3Value, Sentido, SentidoValue;
    public GameObject ControleAutomatico;
    public Text controle;
    // Start is called before the first frame update
    void Start()
    {       
        objectAtiva = new ObjectAtiva(19, telaBotaoA, telaBotaoX, telaBotaoY, telaBotaoB, telaBotaoStart, telaBotaoSelect, telaBotaoJoystickDireito, telaBotaoJoystickEsquerdo, telaDirecionalCima, telaDirecionalDireita, telaRT, telaLT, telaRB, telaLB, telaJoystickDireitoCima, telaJoystickDireitoDireita, telaJoystickEsquerdoCima, telaJoystickEsquerdoDireita, configuracaoSalva);
        if (controlerConected() == false)
        {
            Nao();
        }
        else 
        {
            string[] joy = Input.GetJoystickNames();
            for (int i=0;i<joy.Length;i++) 
            {
                if ("Xbox Wireless Controller"==joy[i]) 
                {
                    Trigger.enabled = TriggerValue.enabled = Botao.enabled = BotaoValue.enabled = Info1.enabled = Info1Value.enabled = Info2.enabled = Info2Value.enabled = Info3.enabled = Info3Value.enabled = Sentido.enabled = SentidoValue.enabled = false;
                    ControleAutomatico.SetActive(true);
                    save = true;
                    controle.text = "Xbox One Controller";
                    break;
                }

                if (i==joy.Length-1) 
                {
                    Nao();
                }
            }
        }
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (save==false) 
        {
            if (A == false)
            {
                objectAtiva.ativa(telaBotaoA);
                pegarBotao();
            }
            else if (B == false)
            {
                objectAtiva.ativa(telaBotaoB);
                pegarBotao();
            }
            else if (X == false)
            {
                objectAtiva.ativa(telaBotaoX);
                pegarBotao();
            }
            else if (Y == false)
            {
                objectAtiva.ativa(telaBotaoY);
                pegarBotao();
            }
            else if (start == false)
            {
                objectAtiva.ativa(telaBotaoStart);
                pegarBotao();
            }
            else if (Select == false)
            {
                objectAtiva.ativa(telaBotaoSelect);
                pegarBotao();
            }
            else if (BotaoJoystickDireito == false)
            {
                objectAtiva.ativa(telaBotaoJoystickDireito);
                pegarBotao();
            }
            else if (BotaoJoystickEsquerdo == false)
            {
                objectAtiva.ativa(telaBotaoJoystickEsquerdo);
                pegarBotao();
            }
            else if (JoystickDireitoCima == false)
            {
                objectAtiva.ativa(telaJoystickDireitoCima);
                pegarTrigger();
            }
            else if (JoystickDireitoDireita == false)
            {
                objectAtiva.ativa(telaJoystickDireitoDireita);
                pegarTrigger();
            }
            else if (JoystickEsquerdoCima == false)
            {
                objectAtiva.ativa(telaJoystickEsquerdoCima);
                pegarTrigger();
            }
            else if (JoystickEsquerdoDireita == false)
            {
                objectAtiva.ativa(telaJoystickEsquerdoDireita);
                pegarTrigger();
            }
            else if (DirecionalCima == false)
            {
                objectAtiva.ativa(telaDirecionalCima);
                pegarTrigger();
            }
            else if (DirecionalDireita == false)
            {
                objectAtiva.ativa(telaDirecionalDireita);
                pegarTrigger();
            }
            else if (RT == false)
            {
                Controle1.SetActive(false);
                Controle2.SetActive(true);
                objectAtiva.ativa(telaRT);
                pegarTrigger();
                pegarBotao();
            }
            else if (LT == false)
            {
                objectAtiva.ativa(telaLT);
                pegarTrigger();
                pegarBotao();
            }
            else if (RB == false)
            {
                objectAtiva.ativa(telaRB);
                pegarBotao();
            }
            else if (LB == false)
            {
                objectAtiva.ativa(telaLB);
                pegarBotao();
            }
            else 
            {
                if (RamSystem.tecnologia == 2)
                {
                    SceneManager.LoadScene("Menu_RV", LoadSceneMode.Single);
                }
                else
                {
                    SceneManager.LoadScene("Menu_C", LoadSceneMode.Single);
                }
            }
          /*
            TriggerValue.text = valueTrigger;
            BotaoValue.text = valueButao;
            string[] info = Input.GetJoystickNames();
            string[] infos = new string[3];
            int c = 0;
            for (int i=0;i<info.Length;i++) 
            {
                if (info[i].Length>0) 
                {
                    if (c<3) 
                    {
                        infos[c] = info[i];
                        c++;
                    }                
                }
            }
            Info1Value.text = infos[0];
            Info2Value.text = infos[1];
            Info3Value.text = infos[2];
            SentidoValue.text = "" + inverte;
            */
        }
    }

    
    public bool controlerConected() 
    {
        string[] joy = Input.GetJoystickNames();
        for (int i=0;i<joy.Length;i++) 
        {
            if (joy[i].Length>0) 
            {
                return true;
            }
        }
        return false;    
    }

    

    public void A_Ok()
    {
        if (valueButao.Length > 1)
        {
            PlayerPrefs.SetString("Xbox360A", valueButao);
        }
        A = true;
        valueButao = valueTrigger = "";
    }

    public void B_Ok()
    {
        if (valueButao.Length > 1)
        {
            PlayerPrefs.SetString("Xbox360B", valueButao);
        }
        B = true;
        valueButao = valueTrigger = "";
    }

    public void X_Ok()
    {
        if (valueButao.Length > 1)
        {
            PlayerPrefs.SetString("Xbox360X", valueButao);
        }
        X = true;
        valueButao = valueTrigger = "";
    }

    public void Y_Ok()
    {
        if (valueButao.Length > 1)
        {
            PlayerPrefs.SetString("Xbox360Y", valueButao);
        }
        Y = true;
        valueButao = valueTrigger = "";
    }

    public void BotaoJoystickDireito_Ok()
    {
        if (valueButao.Length > 1)
        {
            PlayerPrefs.SetString("Xbox360BJDireito", valueButao);
        }
        BotaoJoystickDireito = true;
        valueButao = valueTrigger = "";
    }

    public void BotaoJoystickEsquerdo_OK()
    {
        if (valueButao.Length > 1)
        {
            PlayerPrefs.SetString("Xbox360BJEsquerdo", valueButao);
        }
        BotaoJoystickEsquerdo = true;
        valueButao = valueTrigger = "";
    }


    public void start_OK()
    {
        if (valueButao.Length > 1)
        {
            PlayerPrefs.SetString("Xbox360Start", valueButao);
        }
        start = true;
        valueButao = valueTrigger = "";
    }

    public void Select_OK()
    {
        if (valueButao.Length > 1)
        {
            PlayerPrefs.SetString("Xbox360Select", valueButao);
        }
        Select = true;
        valueButao = valueTrigger = "";
    }

    public void RB_OK()
    {
        if (valueButao.Length > 1)
        {
            PlayerPrefs.SetString("Xbox360RB", valueButao);
        }
        RB = true;
        valueButao = valueTrigger = "";
    }

    public void LB_OK()
    {
        if (valueButao.Length > 1)
        {
            PlayerPrefs.SetString("Xbox360LB", valueButao);
        }
        LB = true;
        valueButao = valueTrigger = "";
    }

    public void JoystickDireitoCima_OK()
    {
        if (valueTrigger.Length > 1)
        {
            PlayerPrefs.SetString("Xbox360JDireitoCima", valueTrigger);
            PlayerPrefs.SetInt("Xbox360JDireitoCimaInverte", inverte);
        }
        JoystickDireitoCima = true;
        valueButao = valueTrigger = "";
    }

    public void JoystickDireitoDireita_OK()
    {
        if (valueTrigger.Length > 1)
        {
            PlayerPrefs.SetString("Xbox360JDireitoDireita", valueTrigger);
            PlayerPrefs.SetInt("Xbox360JDireitoCimaDireitaInverte", inverte);
        }
        JoystickDireitoDireita = true;
        valueButao = valueTrigger = "";
    }


    public void JoystickEsquerdoCima_OK()
    {
        if (valueTrigger.Length > 1)
        {
            PlayerPrefs.SetString("Xbox360JEsquerdoCima", valueTrigger);
            PlayerPrefs.SetInt("Xbox360JEsquerdoCimaInverte", inverte);
        }
        JoystickEsquerdoCima = true;
        valueButao = valueTrigger = "";
    }

    public void JoystickEsquerdoDireita_OK()
    {
        if (valueTrigger.Length > 1)
        {
            PlayerPrefs.SetString("Xbox360JEsquerdoDireita", valueTrigger);
            PlayerPrefs.SetInt("Xbox360JEsquerdoDireitaInverte", inverte);
        }
        JoystickEsquerdoDireita = true;
        valueButao = valueTrigger = "";
    }

    public void DirecionalCima_OK()
    {
        if (valueTrigger.Length > 1)
        {
            PlayerPrefs.SetString("Xbox360DirecionalCima", valueTrigger);
            PlayerPrefs.SetInt("Xbox360DirecionalCimaInverte", inverte);
        }
        DirecionalCima = true;
        valueButao = valueTrigger = "";
    }

    public void DirecionalDireita_OK()
    {
        if (valueTrigger.Length > 1)
        {
            PlayerPrefs.SetString("Xbox360DirecionalDireita", valueTrigger);
            PlayerPrefs.SetInt("Xbox360DirecionalDireitaInverte", inverte);
        }
        DirecionalDireita = true;
        valueButao = valueTrigger = "";
    }



    public void RT_OK()
    {
        if (valueTrigger.Length > 1)
        {
            PlayerPrefs.SetString("Xbox360RT_Trigger", valueTrigger);
            PlayerPrefs.SetInt("Xbox360RT_TriggerInverte", inverte);
            PlayerPrefs.SetString("Xbox360RT", "");
        }
        else if (valueButao.Length > 1)
        {
            PlayerPrefs.SetString("Xbox360RT", valueButao);
            PlayerPrefs.SetString("Xbox360RT_Trigger", "");
            PlayerPrefs.SetInt("Xbox360RT_TriggerInverte", 0);
        }
        RT = true;
        valueButao = valueTrigger = "";
    }

    public void LT_OK()
    {
        if (valueTrigger.Length > 1)
        {
            PlayerPrefs.SetString("Xbox360LT_Trigger", valueTrigger);
            PlayerPrefs.SetInt("Xbox360LT_TriggerInverte", inverte);
            PlayerPrefs.SetString("Xbox360LT", "");
        }
        else if (valueButao.Length > 1)
        {
            PlayerPrefs.SetString("Xbox360LT", valueButao);
            PlayerPrefs.SetString("Xbox360LT_Trigger", "");
            PlayerPrefs.SetInt("Xbox360LT_TriggerInverte", 0);
        }
        LT = true;
        valueButao = valueTrigger = "";
    }


    public bool pegarBotao() 
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton0)) 
        {
            valueButao = "JoystickButton0";
            return true;
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton1))
        {
            valueButao = "JoystickButton1";
            return true;
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton2))
        {
            valueButao = "JoystickButton2";
            return true;
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton3))
        {
            valueButao = "JoystickButton3";
            return true;
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton4))
        {
            valueButao = "JoystickButton4";
            return true;
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton5))
        {
            valueButao = "JoystickButton5";
            return true;
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton6))
        {
            valueButao = "JoystickButton6";
            return true;
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton7))
        {
            valueButao = "JoystickButton7";
            return true;
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton8))
        {
            valueButao = "JoystickButton8";
            return true;
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton9))
        {
            valueButao = "JoystickButton9";
            return true;
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton10))
        {
            valueButao = "JoystickButton10";
            return true;
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton11))
        {
            valueButao = "JoystickButton11";
            return true;
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton12))
        {
            valueButao = "JoystickButton12";
            return true;
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton13))
        {
            valueButao = "JoystickButton13";
            return true;
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton14))
        {
            valueButao = "JoystickButton14";
            return true;
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton15))
        {
            valueButao = "JoystickButton15";
            return true;
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton16))
        {
            valueButao = "JoystickButton16";
            return true;
        }
        
        if (Input.GetKeyDown(KeyCode.JoystickButton17))
        {
            valueButao = "JoystickButton17";
            return true;
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton18))
        {
            valueButao = "JoystickButton18";
            return true;
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton19))
        {
            valueButao = "JoystickButton19";
            return true;
        }

        return false;

    }


    public bool pegarTrigger() 
    {
        if (Input.GetAxis("joy1") > 0)
        {
            valueTrigger = "joy1";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("joy1") < 0) 
        {
            valueTrigger = "joy1";
            inverte = -1;
            return true;       
        }

        if (Input.GetAxis("joy2") > 0)
        {
            valueTrigger = "joy2";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("joy2") < 0)
        {
            valueTrigger = "joy2";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("joy3") > 0)
        {
            valueTrigger = "joy3";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("joy3") < 0)
        {
            valueTrigger = "joy3";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("joy4") > 0)
        {
            valueTrigger = "joy4";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("joy4") < 0)
        {
            valueTrigger = "joy4";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("joy5") > 0)
        {
            valueTrigger = "joy5";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("joy5") < 0)
        {
            valueTrigger = "joy5";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("joy6") > 0)
        {
            valueTrigger = "joy6";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("joy6") < 0)
        {
            valueTrigger = "joy6";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("joy7") > 0)
        {
            valueTrigger = "joy7";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("joy7") < 0)
        {
            valueTrigger = "joy7";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("joy8") > 0)
        {
            valueTrigger = "joy8";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("joy8") < 0)
        {
            valueTrigger = "joy8";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("joy9") > 0)
        {
            valueTrigger = "joy9";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("joy9") < 0)
        {
            valueTrigger = "joy9";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("joy10") > 0)
        {
            valueTrigger = "joy10";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("joy10") < 0)
        {
            valueTrigger = "joy10";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("joy11") > 0)
        {
            valueTrigger = "joy11";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("joy11") < 0)
        {
            valueTrigger = "joy11";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("joy12") > 0)
        {
            valueTrigger = "joy12";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("joy12") < 0)
        {
            valueTrigger = "joy12";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("joy13") > 0)
        {
            valueTrigger = "joy13";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("joy13") < 0)
        {
            valueTrigger = "joy13";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("joy14") > 0)
        {
            valueTrigger = "joy14";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("joy14") < 0)
        {
            valueTrigger = "joy14";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("joy15") > 0)
        {
            valueTrigger = "joy15";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("joy15") < 0)
        {
            valueTrigger = "joy15";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("joy16") > 0)
        {
            valueTrigger = "joy16";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("joy16") < 0)
        {
            valueTrigger = "joy16";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("joy17") > 0)
        {
            valueTrigger = "joy17";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("joy17") < 0)
        {
            valueTrigger = "joy17";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("joy18") > 0)
        {
            valueTrigger = "joy18";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("joy18") < 0)
        {
            valueTrigger = "joy18";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("joy19") > 0)
        {
            valueTrigger = "joy19";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("joy19") < 0)
        {
            valueTrigger = "joy19";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("joy20") > 0)
        {
            valueTrigger = "joy20";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("joy20") < 0)
        {
            valueTrigger = "joy20";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("joy21") > 0)
        {
            valueTrigger = "joy21";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("joy21") < 0)
        {
            valueTrigger = "joy21";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("joy22") > 0)
        {
            valueTrigger = "joy22";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("joy22") < 0)
        {
            valueTrigger = "joy22";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("joy23") > 0)
        {
            valueTrigger = "joy23";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("joy23") < 0)
        {
            valueTrigger = "joy23";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("joy24") > 0)
        {
            valueTrigger = "joy24";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("joy24") < 0)
        {
            valueTrigger = "joy24";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("joy25") > 0)
        {
            valueTrigger = "joy25";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("joy25") < 0)
        {
            valueTrigger = "joy25";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("joy26") > 0)
        {
            valueTrigger = "joy26";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("joy26") < 0)
        {
            valueTrigger = "joy26";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("joy27") > 0)
        {
            valueTrigger = "joy27";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("joy27") < 0)
        {
            valueTrigger = "joy27";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("joy28") > 0)
        {
            valueTrigger = "joy28";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("joy28") < 0)
        {
            valueTrigger = "joy28";
            inverte = -1;
            return true;
        }

        return false;
    }

    public void configuracaoNova() 
    {
        Trigger.enabled = TriggerValue.enabled = Botao.enabled = BotaoValue.enabled = Info1.enabled = Info1Value.enabled = Info2.enabled = Info2Value.enabled = Info3.enabled = Info3Value.enabled = Sentido.enabled = SentidoValue.enabled = false;
        objectAtiva.ativa(telaBotaoA);
        Controle1.SetActive(true);
        Controle2.SetActive(false);
        save = false;    
    }

    public void configuracaoAnterior() 
    {
        if (RamSystem.tecnologia == 2)
        {
            SceneManager.LoadScene("Menu_RV", LoadSceneMode.Single);
        }
        else
        {
            SceneManager.LoadScene("Menu_C", LoadSceneMode.Single);
        }
    }

    public void Nao() 
    {
        ControleAutomatico.SetActive(false);
        if (PlayerPrefs.HasKey("Xbox360A") == false)
        {
            objectAtiva.ativa(telaBotaoA);
            Controle1.SetActive(true);
            Controle2.SetActive(false);
            save = false;
            Trigger.enabled = TriggerValue.enabled = Botao.enabled = BotaoValue.enabled = Info1.enabled = Info1Value.enabled = Info2.enabled = Info2Value.enabled = Info3.enabled = Info3Value.enabled = Sentido.enabled = SentidoValue.enabled = false;
        }
        else
        {
            objectAtiva.ativa(configuracaoSalva);
            Controle1.SetActive(false);
            Controle2.SetActive(false);
            save = true;
            Trigger.enabled = TriggerValue.enabled = Botao.enabled = BotaoValue.enabled = Info1.enabled = Info1Value.enabled = Info2.enabled = Info2Value.enabled = Info3.enabled = Info3Value.enabled = Sentido.enabled = SentidoValue.enabled = false;

        }
    }

    public void Sim() 
    {
        PlayerPrefs.SetString("Xbox360A","JoystickButton0");
        PlayerPrefs.SetString("Xbox360B", "JoystickButton1");
        PlayerPrefs.SetString("Xbox360X", "JoystickButton2");
        PlayerPrefs.SetString("Xbox360Y", "JoystickButton3");
        PlayerPrefs.SetString("Xbox360BJDireito", "JoystickButton9");
        PlayerPrefs.SetString("Xbox360BJEsquerdo", "JoystickButton8");
        PlayerPrefs.SetString("Xbox360Start", "JoystickButton10");
        PlayerPrefs.SetString("Xbox360Select", "");
        PlayerPrefs.SetString("Xbox360RB", "JoystickButton5");
        PlayerPrefs.SetString("Xbox360LB", "JoystickButton4");
        PlayerPrefs.SetString("Xbox360JDireitoCima", "joy4");
        PlayerPrefs.SetInt("Xbox360JDireitoCimaInverte", -1);
        PlayerPrefs.SetString("Xbox360JDireitoDireita", "joy3");
        PlayerPrefs.SetInt("Xbox360JDireitoCimaDireitaInverte", 1);
        PlayerPrefs.SetString("Xbox360JEsquerdoCima", "joy2");
        PlayerPrefs.SetInt("Xbox360JEsquerdoCimaInverte", -1);
        PlayerPrefs.SetString("Xbox360JEsquerdoDireita", "joy1");
        PlayerPrefs.SetInt("Xbox360JEsquerdoDireitaInverte",1);
        PlayerPrefs.SetString("Xbox360DirecionalCima", "joy6");
        PlayerPrefs.SetInt("Xbox360DirecionalCimaInverte", -1);
        PlayerPrefs.SetString("Xbox360DirecionalDireita", "joy5");
        PlayerPrefs.SetInt("Xbox360DirecionalDireitaInverte", 1);
        PlayerPrefs.SetString("Xbox360RT_Trigger", "joy12");
        PlayerPrefs.SetInt("Xbox360RT_TriggerInverte", 1);
        PlayerPrefs.SetString("Xbox360RT", "");
        PlayerPrefs.SetString("Xbox360LT_Trigger", "joy13");
        PlayerPrefs.SetInt("Xbox360LT_TriggerInverte", 1);
        PlayerPrefs.SetString("Xbox360LT", "");
        if (RamSystem.tecnologia == 2)
        {
            SceneManager.LoadScene("Menu_RV", LoadSceneMode.Single);
        }
        else 
        {
            SceneManager.LoadScene("Menu_C", LoadSceneMode.Single);
        }
    }
}

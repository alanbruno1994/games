using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Controle360 : MonoBehaviour
{
    public bool A, B, X, Y, BotaoJoystickDireito, BotaoJoystickEsquerdo, JoystickDireitoCima;
    public bool JoystickDireitoDireita, JoystickEsquerdoCima, JoystickEsquerdoDireita, DirecionalCima, DirecionalDireita;
    public bool start, Select, RB, RT, LB, LT;
    public string joystickdireitocima, joystickdireitodireita, joystickesquerdocima, joystickesquerdodireita, rt, lt, direcionalcima, direcionaldireita;
    public string valueButao, valueTrigger;
    public IntegerKey integer = new IntegerKey();
    public GameObject telaA, telaB, telaX, telaY, telaStart, telaSelect, telaJoystickDireitoCima, telaJoystickDireitoDireita, telaJoystickEsquerdoCima, telaJoystickEsquerdoDireita;
    public GameObject telaDirecionalCima, telaDirecionalDireita, telaRT, telaLT, telaRB, telaLB, telaButaoJoystickDireito, telaButaoJoystickEsquerdo;
    public GameObject Controle1, Controle2;
    public string Abotao, Bbotao, Xbotao, Ybotao, BotaoJoystickDireitobotao, BotaoJoystickEsquerdobotao, trigerJoystickDireitoDireita, trigerJoystickDireitoCima, triggerjoystickesquerdocima, triggerjoystickesquerdodireita;
    public string triggerDirecionalCima, triggerDirecionalDireita, startbotao, selectbotao, rbbotao, rtbotao, lbbotao, ltbotao, rttrigger, lttrigger;
    public string sceneload;
    public TelaInicial telaInicial;
    public int inverte = 1;
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

      
        if (A == false)//pegar Butao A
        {
            Controle1.SetActive(true);
            telaA.SetActive(true);
            pegarButao();
            Abotao = valueButao;
            if (valueButao.Length>1) { 
                 PlayerPrefs.SetString("Xbox360A", valueButao);
            }
        }
        else if (B == false)//pegar Butao B
        {

            telaB.SetActive(true);
            telaA.SetActive(false);
            pegarButao();
            Bbotao = valueButao;
            PlayerPrefs.SetString("Xbox360_B", valueButao);
        }
        else if (X == false)//pegar Butao X
        {
            telaX.SetActive(true);
            telaB.SetActive(false);
            pegarButao();
            Xbotao = valueButao;
            PlayerPrefs.SetString("Xbox360_X", valueButao);
        }
        else if (Y == false)//pegar Butao Y
        {
            telaY.SetActive(true);
            telaX.SetActive(false);
            pegarButao();
            Ybotao = valueButao;
            PlayerPrefs.SetString("Xbox360_Y", valueButao);
        }
        else if (start == false)//pegar Butao Start
        {
            telaStart.SetActive(true);
            telaY.SetActive(false);
            pegarButao();
            startbotao = valueButao;
            PlayerPrefs.SetString("Xbox360_Start", valueButao);
        }
        else if (Select == false)//pegar Butao Select
        {
            telaSelect.SetActive(true);
            telaStart.SetActive(false);
            pegarButao();
            selectbotao = valueButao;
            PlayerPrefs.SetString("Xbox360_Select", valueButao);
        }
        else if (JoystickDireitoCima == false)//pegar JoystickDireitoCima
        {

            telaJoystickDireitoCima.SetActive(true);
            telaSelect.SetActive(false);
            pegarTriggerJoystick();
            trigerJoystickDireitoCima = valueTrigger;
            PlayerPrefs.SetString("Xbox360_JoystickDireitoCima", valueTrigger);
            PlayerPrefs.SetInt("joystickDireitoCima", inverte);//1 normal -1 invertido
        }
        else if (JoystickDireitoDireita == false)//pegar JoystickDireitoDireita
        {
            telaJoystickDireitoDireita.SetActive(true);
            telaJoystickDireitoCima.SetActive(false);
            pegarTriggerJoystick();
            trigerJoystickDireitoDireita = valueTrigger;
            PlayerPrefs.SetString("Xbox360_JoystickDireitoDireita", valueTrigger);
            PlayerPrefs.SetInt("joystickDireitoDireita", inverte);//1 normal -1 invertido
        }
        else if (JoystickEsquerdoCima == false)//pegar JoystickEsquerdoCima
        {
            telaJoystickEsquerdoCima.SetActive(true);
            telaJoystickDireitoDireita.SetActive(false);
            pegarTriggerJoystick();
            triggerjoystickesquerdocima = valueTrigger;
            PlayerPrefs.SetString("Xbox360_JoystickEsquerdoCima", valueTrigger);
            PlayerPrefs.SetInt("joystickEsquerdoCima", inverte);//1 normal -1 invertido
        }
        else if (JoystickEsquerdoDireita == false)//pegar JoystickEsquerdoDireita
        {
            telaJoystickEsquerdoDireita.SetActive(true);
            telaJoystickEsquerdoCima.SetActive(false);
            pegarTriggerJoystick();
            triggerjoystickesquerdodireita = valueTrigger;
            PlayerPrefs.SetString("Xbox360_JoystickEsquerdoDireita", valueTrigger);
            PlayerPrefs.SetInt("joystickEsquerdoDireita", inverte);//1 normal -1 invertido
        }
        else if (DirecionalCima == false)//pegar DirecionalCima
        {
            telaDirecionalCima.SetActive(true);
            telaJoystickEsquerdoDireita.SetActive(false);
            pegarTriggerJoystick();
            triggerDirecionalCima = valueTrigger;
            PlayerPrefs.SetString("Xbox360_DirecionalCima", valueTrigger);
            PlayerPrefs.SetInt("direcionalCima", inverte);//1 normal -1 invertido 
        }
        else if (DirecionalDireita == false)//pegar DirecionalDireita
        {
            telaDirecionalDireita.SetActive(true);
            telaDirecionalCima.SetActive(false);
            pegarTriggerJoystick();
            triggerDirecionalDireita = valueTrigger;
            PlayerPrefs.SetString("Xbox360_DirecionalDireita", valueTrigger);
            PlayerPrefs.SetInt("direcionalDireita", inverte);//1 normal -1 invertido
        }
        else if (RT == false)//pegar RT
        {
            Controle1.SetActive(false);
            Controle2.SetActive(true);
            telaRT.SetActive(true);
            telaDirecionalDireita.SetActive(false);
            pegarTriggerJoystick();
            PlayerPrefs.SetString("Xbox360_RT_Triger", valueTrigger);
            rttrigger = valueTrigger;
            pegarButao();
            rtbotao = valueButao;
            PlayerPrefs.SetString("Xbox360_RT", valueButao);
        }
        else if (LT == false)//pegar LT
        {
            telaLT.SetActive(true);
            telaRT.SetActive(false);
            pegarTriggerJoystick();
            lttrigger = valueTrigger;
            PlayerPrefs.SetString("Xbox360_LT_Triger", valueTrigger);
            pegarButao();
            ltbotao = valueButao;
            PlayerPrefs.SetString("Xbox360_LT", valueButao);
        }
        else if (RB == false)//pegar Butao RB
        {
            telaRB.SetActive(true);
            telaLT.SetActive(false);
            pegarButao();
            rbbotao = valueButao;
            PlayerPrefs.SetString("Xbox360_RB", valueButao);
        }
        else if (LB == false)//pegar Butao LB
        {
            telaLB.SetActive(true);
            telaRB.SetActive(false);
            pegarButao();
            lbbotao = valueButao;
            PlayerPrefs.SetString("Xbox360_LB", valueButao);
        }
        else if (BotaoJoystickDireito == false)//pegar Butao Joystick Direito
        {
            Controle1.SetActive(true);
            Controle2.SetActive(false);
            telaButaoJoystickDireito.SetActive(true);
            telaLB.SetActive(false);
            pegarButao();
            PlayerPrefs.SetString("Xbox360_BJoystickDireito", valueButao);
            BotaoJoystickDireitobotao = valueButao;
        }
        else if (BotaoJoystickEsquerdo == false)//pegar Butao Joystick Esquerdo
        {
            telaButaoJoystickEsquerdo.SetActive(true);
            telaButaoJoystickDireito.SetActive(false);
            pegarButao();
            PlayerPrefs.SetString("Xbox360_BJoystickEsquerdo", valueButao);
            BotaoJoystickEsquerdobotao = valueButao;
            telaInicial.AtivaAguarde();
            loadScene();
        }
    }


    public bool pegarButao()
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



    public bool pegarTriggerJoystick()
    {

        if (Input.GetAxis("Joystick1") > 0)
        {
            valueTrigger = "Joystick1";
            inverte = 1;
            return true;
        }else if (Input.GetAxis("Joystick1") < 0)
        {
            valueTrigger = "Joystick1";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("Joystick2") > 0)
        {
            valueTrigger = "Joystick2";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("Joystick2") < 0)
        {
            valueTrigger = "Joystick2";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("Joystick3") > 0)
        {
            valueTrigger = "Joystick3";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("Joystick3") < 0)
        {
            valueTrigger = "Joystick1";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("Joystick4") > 0)
        {
            valueTrigger = "Joystick4";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("Joystick4") < 0)
        {
            valueTrigger = "Joystick4";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("Joystick5") > 0)
        {
            valueTrigger = "Joystick5";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("Joystick5") < 0)
        {
            valueTrigger = "Joystick5";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("Joystick6") > 0)
        {
            valueTrigger = "Joystick6";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("Joystick6") < 0)
        {
            valueTrigger = "Joystick6";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("Joystick7") > 0)
        {
            valueTrigger = "Joystick7";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("Joystick7") < 0)
        {
            valueTrigger = "Joystick7";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("Joystick8") > 0)
        {
            valueTrigger = "Joystick8";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("Joystick8") < 0)
        {
            valueTrigger = "Joystick8";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("Joystick9") > 0)
        {
            valueTrigger = "Joystick9";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("Joystick9") < 0)
        {
            valueTrigger = "Joystick9";
            inverte = -1;
            return true;
        }


        if (Input.GetAxis("Joystick10") > 0)
        {
            valueTrigger = "Joystick10";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("Joystick10") < 0)
        {
            valueTrigger = "Joystick10";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("Joystick11") > 0)
        {
            valueTrigger = "Joystick11";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("Joystick11") < 0)
        {
            valueTrigger = "Joystick11";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("Joystick12") > 0)
        {
            valueTrigger = "Joystick12";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("Joystick12") < 0)
        {
            valueTrigger = "Joystick12";
            inverte = -1;
            return true;
        }


        if (Input.GetAxis("Joystick13") > 0)
        {
            valueTrigger = "Joystick13";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("Joystick13") < 0)
        {
            valueTrigger = "Joystick13";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("Joystick14") > 0)
        {
            valueTrigger = "Joystick14";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("Joystick14") < 0)
        {
            valueTrigger = "Joystick14";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("Joystick15") > 0)
        {
            valueTrigger = "Joystick15";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("Joystick15") < 0)
        {
            valueTrigger = "Joystick15";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("Joystick16") > 0)
        {
            valueTrigger = "Joystick16";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("Joystick16") < 0)
        {
            valueTrigger = "Joystick16";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("Joystick17") > 0)
        {
            valueTrigger = "Joystick17";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("Joystick17") < 0)
        {
            valueTrigger = "Joystick17";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("Joystick18") > 0)
        {
            valueTrigger = "Joystick18";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("Joystick18") < 0)
        {
            valueTrigger = "Joystick18";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("Joystick19") > 0)
        {
            valueTrigger = "Joystick19";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("Joystick19") < 0)
        {
            valueTrigger = "Joystick19";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("Joystick20") > 0)
        {
            valueTrigger = "Joystick20";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("Joystick20") < 0)
        {
            valueTrigger = "Joystick20";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("Joystick21") > 0)
        {
            valueTrigger = "Joystick21";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("Joystick21") < 0)
        {
            valueTrigger = "Joystick21";
            inverte = -1;
            return true;
        }

        if (Input.GetAxis("Joystick22") > 0)
        {
            valueTrigger = "Joystick22";
            inverte = 1;
            return true;
        }
        else if (Input.GetAxis("Joystick22") < 0)
        {
            valueTrigger = "Joystick22";
            inverte = -1;
            return true;
        }        
        return false;

    }



    public void A_Ok()
    {
        A = true;
        valueButao = valueTrigger = "";

    }

    public void B_Ok()
    {
        B = true;
        valueButao = valueTrigger = "";
    }

    public void X_Ok()
    {
        X = true;
        valueButao = valueTrigger = "";
    }

    public void Y_Ok()
    {
        Y = true;
        valueButao = valueTrigger = "";
    }

    public void BotaoJoystickDireito_Ok()
    {
        BotaoJoystickDireito = true;
        valueButao = valueTrigger = "";
    }

    public void BotaoJoystickEsquerdo_OK()
    {
        BotaoJoystickEsquerdo = true;
        valueButao = valueTrigger = "";
    }

    public void JoystickDireitoCima_OK()
    {
        JoystickDireitoCima = true;
        valueButao = valueTrigger = "";
    }

    public void JoystickDireitoDireita_OK()
    {
        JoystickDireitoDireita = true;
        valueButao = valueTrigger = "";
    }


    public void JoystickEsquerdoCima_OK()
    {
        JoystickEsquerdoCima = true;
        valueButao = valueTrigger = "";
    }

    public void JoystickEsquerdoDireita_OK()
    {
        JoystickEsquerdoDireita = true;
        valueButao = valueTrigger = "";
    }

    public void start_OK()
    {
        start = true;
        valueButao = valueTrigger = "";
    }

    public void Select_OK()
    {
        Select = true;
        valueButao = valueTrigger = "";
    }

    public void RB_OK()
    {
        RB = true;
        valueButao = valueTrigger = "";
    }


    public void RT_OK()
    {
        RT = true;
        valueButao = valueTrigger = "";
    }

    public void LB_OK()
    {
        LB = true;
        valueButao = valueTrigger = "";
    }

    public void LT_OK()
    {
        LT = true;
        valueButao = valueTrigger = "";
    }

    public void DirecionalCima_OK()
    {
        DirecionalCima = true;
        valueButao = valueTrigger = "";
    }

    public void DirecionalDireita_OK()
    {
        DirecionalDireita = true;
        valueButao = valueTrigger = "";
    }


    public void loadScene()
    {
        SceneManager.LoadScene(sceneload, LoadSceneMode.Single);
    }


  


}

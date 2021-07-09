using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class Input360 : MonoBehaviour
{
    public Botao A, B, X, Y, Select, start, Lb, Rb, Rt, Lt, BjoystickDireito, BjoystickEsquerdo;
    public Trigger JoystickEsquerdoCima, JoystickEsquerdoDireita, JoystickDireitoCima, JoystickDireitoDireita, rtTrigger, ltTrigger;
    public Trigger direcionalCima, direcionalDireita;
    public int contador;
    // Start is called before the first frame update
    void Start()
    {
        contador = 0;
        capturaControles();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (contador>=20) 
        {
            JoystickEsquerdoCima.chequeTime(contador);
            JoystickEsquerdoDireita.chequeTime(contador);
            JoystickDireitoCima.chequeTime(contador);
            JoystickDireitoDireita.chequeTime(contador);
            direcionalCima.chequeTime(contador);
            direcionalDireita.chequeTime(contador);
            if (rtTrigger!=null) 
            {
                rtTrigger.chequeTime(contador);
            }
            if (ltTrigger!=null) 
            {
                ltTrigger.chequeTime(contador);
            }
            contador = 0;
        }
        contador++;
    }

    public void capturaControles() 
    {
        A = new Botao(PlayerPrefs.GetString("Xbox360A"));
        B = new Botao(PlayerPrefs.GetString("Xbox360B"));
        X = new Botao(PlayerPrefs.GetString("Xbox360X"));
        Y = new Botao(PlayerPrefs.GetString("Xbox360Y"));
        start = new Botao(PlayerPrefs.GetString("Xbox360Start"));
        Select = new Botao(PlayerPrefs.GetString("Xbox360Select"));
        BjoystickDireito = new Botao(PlayerPrefs.GetString("Xbox360BJDireito"));
        BjoystickEsquerdo = new Botao(PlayerPrefs.GetString("Xbox360BJEsquerdo"));
        Lb = new Botao(PlayerPrefs.GetString("Xbox360LB"));
        Rb = new Botao(PlayerPrefs.GetString("Xbox360RB"));       
        JoystickEsquerdoCima = new Trigger(PlayerPrefs.GetString("Xbox360JEsquerdoCima"), PlayerPrefs.GetInt("Xbox360JEsquerdoCimaInverte"));
        JoystickEsquerdoDireita = new Trigger(PlayerPrefs.GetString("Xbox360JEsquerdoDireita"), PlayerPrefs.GetInt("Xbox360JEsquerdoDireitaInverte"));
        JoystickDireitoCima = new Trigger(PlayerPrefs.GetString("Xbox360JDireitoCima"), PlayerPrefs.GetInt("Xbox360JDireitoCimaInverte"));
        JoystickDireitoDireita = new Trigger(PlayerPrefs.GetString("Xbox360JDireitoDireita"), PlayerPrefs.GetInt("Xbox360JDireitoCimaDireitaInverte"));
        direcionalCima = new Trigger(PlayerPrefs.GetString("Xbox360DirecionalCima"), PlayerPrefs.GetInt("Xbox360DirecionalCimaInverte"));
        direcionalDireita = new Trigger(PlayerPrefs.GetString("Xbox360DirecionalDireita"), PlayerPrefs.GetInt("Xbox360DirecionalDireitaInverte"));

        if (PlayerPrefs.GetString("Xbox360RT_Trigger").Length > 0)
        {
            rtTrigger = new Trigger(PlayerPrefs.GetString("Xbox360RT_Trigger"), PlayerPrefs.GetInt("Xbox360RT_TriggerInverte"), 1);

        }
        else
        {
            Rt = new Botao(PlayerPrefs.GetString("Xbox360RT"));
        }

        if (PlayerPrefs.GetString("Xbox360LT_Trigger").Length > 0)
        {
            ltTrigger = new Trigger(PlayerPrefs.GetString("Xbox360LT_Trigger"), PlayerPrefs.GetInt("Xbox360LT_TriggerInverte"), 2);

        }
        else
        {
            Lt = new Botao(PlayerPrefs.GetString("Xbox360LT"));
        }
    }

    public bool RT() 
    {
        if (Rt != null)
        {
            return Rt.isBotao();
        } else if (rtTrigger.RT()) 
        {
            return true;
        }

        return false;
    
    }

    public bool LT()
    {
        if (Lt != null)
        {
            return Lt.isBotao();
        }
        else if (ltTrigger.LT())
        {
            return true;
        }

        return false;

    }
}

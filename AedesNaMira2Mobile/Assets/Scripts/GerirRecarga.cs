using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerirRecarga : MonoBehaviour
{
    public DadosFase dados;
    public RecargaArmaHUD recargaArmaHUD;

    // Start is called before the first frame update
    void Start()
    {
        dados= GameObject.FindGameObjectWithTag("Gerenciar").GetComponent<DadosFase>();
    }


    public void recarga(int contador)
    {/*
        
        if (dados.armaUsada == 0 || dados.armaUsada == 2)
        {
            recargaArmaHUD.tempo3s(contador);
        }
        else if (dados.armaUsada==5)
        {
            recargaArmaHUD.tempo4s(contador);
        }
        else if (dados.armaUsada==1 || dados.armaUsada == 4 || dados.armaUsada == 6 || dados.armaUsada == 7)
        {
            recargaArmaHUD.tempo2s(contador);
        }
        else if (dados.armaUsada ==3)
        {
            recargaArmaHUD.tempo1s(contador);
        } */
    }




public bool possoRecarregar()
{/*
    if (dados.armaUsada == 0 && dados.municao0 > 0)
    {
            dados.municao0--;
            recargaArmaHUD.terminou = false;
            return true;
    }
    else if (dados.armaUsada == 1 && dados.municao1 > 0)
    {
            dados.municao1--;
            recargaArmaHUD.terminou = false;
            return true;
    }
    else if (dados.armaUsada == 2 && dados.municao2 > 0)
    {
            dados.municao2--;
            recargaArmaHUD.terminou = false;
            return true;
    }
    else if (dados.armaUsada == 3 && dados.municao3 > 0)
    {
            dados.municao3--;
            recargaArmaHUD.terminou = false;
            return true;
    }
    else if (dados.armaUsada == 4 && dados.municao4 > 0)
    {
            dados.municao4--;
            recargaArmaHUD.terminou = false;
            return true;
    }
    else if (dados.armaUsada == 5 && dados.municao5 > 0)
    {
            dados.municao5--;
            recargaArmaHUD.terminou = false;
            return true;
    }
    else if (dados.armaUsada == 6 && dados.municao6 > 0)
    {
            dados.municao6--;
            recargaArmaHUD.terminou = false;
            return true;
    }
    else if (dados.armaUsada == 7 && dados.municao7 > 0)
    {
            dados.municao7--;
            recargaArmaHUD.terminou = false;
            return true;
    }*/
    return false;
}






}

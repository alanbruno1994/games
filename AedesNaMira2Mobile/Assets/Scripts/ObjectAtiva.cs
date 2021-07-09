using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAtiva 
{
    public GameObject[] itens;

    public ObjectAtiva(int tamanho,GameObject telaBotaoA,GameObject telaBotaoX,GameObject telaBotaoY,GameObject telaBotaoB,GameObject telaBotaoStart,GameObject telaBotaoSelect,GameObject telaBotaoJostickDireito,GameObject telaBotaoJostickEsquerdo,GameObject telaDirecionalCima,GameObject telaDirecionalDireita,GameObject telaRT,GameObject telaLT,GameObject telaRB,GameObject telaLB,GameObject telaJoystickDireitoCima,GameObject telaJoystickDireitoDireita,GameObject telaJoystickEsquerdoCima,GameObject telaJoystickEsquerdoDireita,GameObject configuracaoSalva) 
    {
        itens = new GameObject[tamanho];
        itens[0] = telaBotaoA;
        itens[1] = telaBotaoX;
        itens[2] = telaBotaoY;
        itens[3] = telaBotaoB;
        itens[4] = telaBotaoStart;
        itens[5] = telaBotaoSelect;
        itens[6] = telaBotaoJostickDireito;
        itens[7] = telaBotaoJostickEsquerdo;
        itens[8] = telaDirecionalCima;
        itens[9] = telaDirecionalDireita;
        itens[10] = telaRT;
        itens[11] = telaLT;
        itens[12] = telaRB;
        itens[13] = telaLB;
        itens[14] = telaJoystickDireitoCima;
        itens[15] = telaJoystickDireitoDireita;
        itens[16] = telaJoystickEsquerdoCima;
        itens[17] = telaJoystickEsquerdoDireita;
        itens[18] = configuracaoSalva;    
    }

    public void ativa(GameObject item)
    {
        for (int i=0;i<itens.Length;i++) 
        {
            if (itens[i].Equals(item))
            {
                itens[i].SetActive(true);
            }
            else 
            {
                itens[i].SetActive(false);
            }
        
        }
    }
}

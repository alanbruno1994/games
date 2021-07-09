using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmaHUD : MonoBehaviour
{
    public Image ItemBateriaAgua, BateriaouAgua, Item;
    public Sprite q100, q99, q98, q97, q96, q95, q94, q93, q92, q91, q90, q89, q88, q87, q86, q85, q84, q83, q82, q81, q80, q79, q78, q77, q76, q75, q74, q73, q72, q71;
    public Sprite q70, q69, q68, q67, q66, q65, q64, q63, q62, q61, q60, q59, q58, q57, q56, q55, q54, q53, q52, q51, q50, q49, q48, q47, q46, q45, q44, q43, q42, q41;
    public Sprite q40, q39, q38, q37, q36, q35, q34, q33, q32, q31, q30, q29, q28, q27, q26, q25, q24, q23, q22, q21, q20, q19, q18, q17, q16, q15, q14, q13, q12, q11;
    public Sprite q10, q9, q8, q7, q6, q5, q4, q3, q2, q1, q0;
    public Sprite SpriteBateria, SpriteAguaSanitaria, SpritePilhaInfinita;
    public Text QuantidadeArma;
    public Sprite raqueteAzul, raqueteCinza, raqueteVermelha, raqueteDourada, aguaAzul, aguaVermelha, aguaDourada;

    public void armaRefresh() 
    {
        float life = 0;
        switch (RamSystem.ArmaUsada)
        {
            case 4:
                ItemBateriaAgua.sprite = SpriteAguaSanitaria;
                life = RamSystem.Quantidade1AguaSanitariaAzul;
                break;
            case 5:
                ItemBateriaAgua.sprite = SpriteAguaSanitaria;
                life = RamSystem.Quantidade1AguaSanitariaVermelha;
                break;
            case 6:
                ItemBateriaAgua.sprite = SpriteAguaSanitaria;
                life = RamSystem.Quantidade1AguaSanitariaDourada;
                break;
            case 0:
                ItemBateriaAgua.sprite = SpritePilhaInfinita;
                break;
            default:
                ItemBateriaAgua.sprite = SpriteBateria;
                if (RamSystem.QuantidadePilhas >= 1)
                {
                    life = RamSystem.Quantidade1Pilha;
                    Refresh(life);
                }
               break;
        }

        atualizar();
    }

    private void atualizar() 
    {
        switch (RamSystem.ArmaUsada)
        {
            case 0:
                Item.sprite = raqueteCinza;
                QuantidadeArma.text = "" + 1;              
                BateriaouAgua.sprite = SpritePilhaInfinita;                
                break;
            case 1:
                Item.sprite = raqueteAzul;
                QuantidadeArma.text = "" + 1;                
                break;
            case 2:
                Item.sprite = raqueteVermelha;
                QuantidadeArma.text = "" + 1;
               
                break;
            case 3:
                Item.sprite = raqueteDourada;
                QuantidadeArma.text = "" + 1;                
                break;
            case 4:
                Item.sprite = aguaAzul;
                QuantidadeArma.text = "" + RamSystem.AguaSanitariaAzul;                
                break;
            case 5:
                Item.sprite = aguaVermelha;
                QuantidadeArma.text = "" + RamSystem.AguaSanitariaVermelha;
                break;
            case 6:
                Item.sprite = aguaDourada;
                QuantidadeArma.text = "" + RamSystem.AguaSanitariaDourada;                
                break;
        }

    }



    private void Refresh(float life)
    {
        try
        {      
            
            Debug.Log(RamSystem.ArmaUsada + "  AGUA REFRESH " + life);
            if (life >= 100)
                BateriaouAgua.sprite = q100;
            else if (life >= 99)
                BateriaouAgua.sprite = q99;
            else if (life >= 98)
                BateriaouAgua.sprite = q98;
            else if (life >= 97)
                BateriaouAgua.sprite = q97;
            else if (life >= 96)
                BateriaouAgua.sprite = q96;
            else if (life >= 95)
                BateriaouAgua.sprite = q95;
            else if (life >= 94)
                BateriaouAgua.sprite = q94;
            else if (life >= 93)
                BateriaouAgua.sprite = q93;
            else if (life >= 92)
                BateriaouAgua.sprite = q92;
            else if (life >= 91)
                BateriaouAgua.sprite = q91;
            else if (life >= 90)
                BateriaouAgua.sprite = q90;
            else if (life >= 89)
                BateriaouAgua.sprite = q89;
            else if (life >= 87)
                BateriaouAgua.sprite = q87;
            else if (life >= 86)
                BateriaouAgua.sprite = q86;
            else if (life >= 85)
                BateriaouAgua.sprite = q85;
            else if (life >= 84)
                BateriaouAgua.sprite = q84;
            else if (life >= 83)
                BateriaouAgua.sprite = q83;
            else if (life >= 82)
                BateriaouAgua.sprite = q82;
            else if (life >= 81)
                BateriaouAgua.sprite = q81;
            else if (life >= 80)
                BateriaouAgua.sprite = q80;
            else if (life >= 79)
                BateriaouAgua.sprite = q79;
            else if (life >= 78)
                BateriaouAgua.sprite = q78;
            else if (life >= 77)
                BateriaouAgua.sprite = q77;
            else if (life >= 76)
                BateriaouAgua.sprite = q76;
            else if (life >= 75)
                BateriaouAgua.sprite = q75;
            else if (life >= 74)
                BateriaouAgua.sprite = q74;
            else if (life >= 73)
                BateriaouAgua.sprite = q73;
            else if (life >= 72)
                BateriaouAgua.sprite = q72;
            else if (life >= 71)
                BateriaouAgua.sprite = q71;
            else if (life >= 70)
                BateriaouAgua.sprite = q70;
            else if (life >= 69)
                BateriaouAgua.sprite = q69;
            else if (life >= 68)
                BateriaouAgua.sprite = q68;
            else if (life >= 67)
                BateriaouAgua.sprite = q67;
            else if (life >= 66)
                BateriaouAgua.sprite = q66;
            else if (life >= 65)
                BateriaouAgua.sprite = q65;
            else if (life >= 64)
                BateriaouAgua.sprite = q64;
            else if (life >= 63)
                BateriaouAgua.sprite = q63;
            else if (life >= 62)
                BateriaouAgua.sprite = q62;
            else if (life >= 61)
                BateriaouAgua.sprite = q61;
            else if (life >= 60)
                BateriaouAgua.sprite = q60;
            else if (life >= 59)
                BateriaouAgua.sprite = q59;
            else if (life >= 58)
                BateriaouAgua.sprite = q58;
            else if (life >= 57)
                BateriaouAgua.sprite = q57;
            else if (life >= 56)
                BateriaouAgua.sprite = q56;
            else if (life >= 55)
                BateriaouAgua.sprite = q55;
            else if (life >= 54)
                BateriaouAgua.sprite = q54;
            else if (life >= 53)
                BateriaouAgua.sprite = q53;
            else if (life >= 52)
                BateriaouAgua.sprite = q52;
            else if (life >= 51)
                BateriaouAgua.sprite = q51;
            else if (life >= 50)
                BateriaouAgua.sprite = q50;
            else if (life >= 49)
                BateriaouAgua.sprite = q49;
            else if (life >= 48)
                BateriaouAgua.sprite = q48;
            else if (life >= 47)
                BateriaouAgua.sprite = q47;
            else if (life >= 46)
                BateriaouAgua.sprite = q46;
            else if (life >= 45)
                BateriaouAgua.sprite = q45;
            else if (life >= 44)
                BateriaouAgua.sprite = q44;
            else if (life >= 43)
                BateriaouAgua.sprite = q43;
            else if (life >= 42)
                BateriaouAgua.sprite = q42;
            else if (life >= 41)
                BateriaouAgua.sprite = q41;
            else if (life >= 40)
                BateriaouAgua.sprite = q40;
            else if (life >= 39)
                BateriaouAgua.sprite = q39;
            else if (life >= 38)
                BateriaouAgua.sprite = q38;
            else if (life >= 37)
                BateriaouAgua.sprite = q37;
            else if (life >= 36)
                BateriaouAgua.sprite = q36;
            else if (life >= 35)
                BateriaouAgua.sprite = q35;
            else if (life >= 34)
                BateriaouAgua.sprite = q34;
            else if (life >= 33)
                BateriaouAgua.sprite = q33;
            else if (life >= 32)
                BateriaouAgua.sprite = q32;
            else if (life >= 31)
                BateriaouAgua.sprite = q31;
            else if (life >= 30)
                BateriaouAgua.sprite = q30;
            else if (life >= 29)
                BateriaouAgua.sprite = q29;
            else if (life >= 28)
                BateriaouAgua.sprite = q28;
            else if (life >= 27)
                BateriaouAgua.sprite = q27;
            else if (life >= 26)
                BateriaouAgua.sprite = q26;
            else if (life >= 25)
                BateriaouAgua.sprite = q25;
            else if (life >= 24)
                BateriaouAgua.sprite = q24;
            else if (life >= 23)
                BateriaouAgua.sprite = q23;
            else if (life >= 22)
                BateriaouAgua.sprite = q22;
            else if (life >= 21)
                BateriaouAgua.sprite = q21;
            else if (life >= 20)
                BateriaouAgua.sprite = q20;
            else if (life >= 19)
                BateriaouAgua.sprite = q19;
            else if (life >= 18)
                BateriaouAgua.sprite = q18;
            else if (life >= 17)
                BateriaouAgua.sprite = q17;
            else if (life >= 16)
                BateriaouAgua.sprite = q16;
            else if (life >= 15)
                BateriaouAgua.sprite = q15;
            else if (life >= 14)
                BateriaouAgua.sprite = q14;
            else if (life >= 13)
                BateriaouAgua.sprite = q13;
            else if (life >= 12)
                BateriaouAgua.sprite = q12;
            else if (life >= 11)
                BateriaouAgua.sprite = q11;
            else if (life >= 10)
                BateriaouAgua.sprite = q10;
            else if (life >= 9)
                BateriaouAgua.sprite = q9;
            else if (life >= 8)
                BateriaouAgua.sprite = q8;
            else if (life >= 7)
                BateriaouAgua.sprite = q7;
            else if (life >= 6)
                BateriaouAgua.sprite = q5;
            else if (life >= 5)
                BateriaouAgua.sprite = q5;
            else if (life >= 4)
                BateriaouAgua.sprite = q4;
            else if (life >= 3)
                BateriaouAgua.sprite = q3;
            else if (life >= 2)
                BateriaouAgua.sprite = q2;
            else if (life >= 1)
                BateriaouAgua.sprite = q1;
            else if (life <= 0)
                BateriaouAgua.sprite = q0;
        }
        catch (System.Exception)
        {

        }
    }


}

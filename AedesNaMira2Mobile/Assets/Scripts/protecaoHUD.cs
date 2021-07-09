using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class protecaoHUD : MonoBehaviour
{
    public GameObject Protecao, EscuroAzul, EscuroVermelho, EscuroDourado, Protecao_Item;
    public Image Escudo;
    public Sprite i100, i99, i98, i97, i96, i95, i94, i93, i92, i91, i90, i89, i88, i87, i86, i85, i84, i83, i82, i81, i80, i79, i78, i77, i76, i75, i74, i73, i72, i71;
    public Sprite i70, i69, i68, i67, i66, i65, i64, i63, i62, i61, i60, i59, i58, i57, i56, i55, i54, i53, i52, i51, i50, i49, i48, i47, i46, i45, i44, i43, i42, i41;
    public Sprite i40, i39, i38, i37, i36, i35, i34, i33, i32, i31, i30, i29, i28, i27, i26, i25, i24, i23, i22, i21, i20, i19, i18, i17, i16, i15, i14, i13, i12, i11;
    public Sprite i10, i9, i8, i7, i6, i5, i4, i3, i2, i1, i0;
    public bool desabilitarRepelente;

    void Start()
    {
        desabilitarRepelente = false;
        Protecao_Item.SetActive(false);
        Protecao.SetActive(false);
    }


    public bool protecaoAtualizar(int protecao, int timeProtecaoLimite, int timeProtecao)
    {
        if (protecao > 0)
        {
            if (timeProtecaoLimite == 2)
            {
                if (timeProtecao > 0)
                {
                    protecao = 100;
                    Protecao_Item.SetActive(true);
                    Protecao.SetActive(true);
                }
                else
                if (timeProtecao > 10)
                {
                    protecao = 90;
                }
                else if (timeProtecao > 20)
                {
                    protecao = 80;
                }
                else if (timeProtecao > 30)
                {
                    protecao = 70;
                }
                else if (timeProtecao > 40)
                {
                    protecao = 60;
                }
                else if (timeProtecao > 50)
                {
                    protecao = 50;
                }
                else if (timeProtecao > 60)
                {
                    protecao = 40;
                }
                else if (timeProtecao > 70)
                {
                    protecao = 30;
                }
                else if (timeProtecao > 80)
                {
                    protecao = 20;
                }
                else if (timeProtecao > 90)
                {
                    protecao = 10;
                }
                else if (timeProtecao >= 100)
                {
                    protecao = 0;
                    Protecao_Item.SetActive(false);
                    desabilitarRepelente = false;
                    EscuroAzul.SetActive(false);
                    return true;
                }
                statusVidaPreservada(protecao);
            }
            else if (timeProtecaoLimite == 3)
            {
                if (timeProtecao > 0)
                {
                    protecao = 100;
                    Protecao_Item.SetActive(true);
                }
                else
               if (timeProtecao > 15)
                {
                    protecao = 90;
                }
                else if (timeProtecao > 30)
                {
                    protecao = 80;
                }
                else if (timeProtecao > 45)
                {
                    protecao = 70;
                }
                else if (timeProtecao > 60)
                {
                    protecao = 60;
                }
                else if (timeProtecao > 75)
                {
                    protecao = 50;
                }
                else if (timeProtecao > 90)
                {
                    protecao = 40;
                }
                else if (timeProtecao > 105)
                {
                    protecao = 30;
                }
                else if (timeProtecao > 120)
                {
                    protecao = 20;
                }
                else if (timeProtecao > 135)
                {
                    protecao = 10;
                }
                else if (timeProtecao >= 150)
                {
                    protecao = 0;
                    EscuroVermelho.SetActive(false);
                    Protecao_Item.SetActive(false);
                    desabilitarRepelente = false;
                    return true;
                }
                statusVidaPreservada(protecao);
            }
            else if (timeProtecaoLimite == 5)
            {
                if (timeProtecao > 0)
                {
                    protecao = 100;
                    Protecao_Item.SetActive(true);
                }
                else
                  if (timeProtecao > 50)
                {
                    protecao = 90;
                }
                else if (timeProtecao > 100)
                {
                    protecao = 80;
                }
                else if (timeProtecao > 150)
                {
                    protecao = 70;
                }
                else if (timeProtecao > 200)
                {
                    protecao = 60;
                }
                else if (timeProtecao > 250)
                {
                    protecao = 50;
                }
                else if (timeProtecao > 300)
                {
                    protecao = 40;
                }
                else if (timeProtecao > 350)
                {
                    protecao = 30;
                }
                else if (timeProtecao > 400)
                {
                    protecao = 20;
                }
                else if (timeProtecao > 450)
                {
                    protecao = 10;
                }
                else if (timeProtecao >= 500)
                {
                    protecao = 0;
                    Protecao_Item.SetActive(false);
                    desabilitarRepelente = false;
                    EscuroDourado.SetActive(false);
                    return true;
                }
                statusVidaPreservada(protecao);

            }
        }
        return false;
    }






    private void statusVidaPreservada(int vidaPreservada)
    {
        try
        {
            if (vidaPreservada > 0)
            {
                Protecao.SetActive(true);
            }
            switch (vidaPreservada)
            {
                case 100:
                    Escudo.sprite = i100;
                    break;
                case 99:
                    Escudo.sprite = i99;
                    break;
                case 98:
                    Escudo.sprite = i98;
                    break;
                case 97:
                    Escudo.sprite = i97;
                    break;
                case 96:
                    Escudo.sprite = i96;
                    break;
                case 95:
                    Escudo.sprite = i95;
                    break;
                case 94:
                    Escudo.sprite = i94;
                    break;
                case 93:
                    Escudo.sprite = i93;
                    break;
                case 92:
                    Escudo.sprite = i92;
                    break;
                case 91:
                    Escudo.sprite = i91;
                    break;
                case 90:
                    Escudo.sprite = i90;
                    break;
                case 89:
                    Escudo.sprite = i89;
                    break;
                case 88:
                    Escudo.sprite = i88;
                    break;
                case 87:
                    Escudo.sprite = i87;
                    break;
                case 86:
                    Escudo.sprite = i86;
                    break;
                case 85:
                    Escudo.sprite = i85;
                    break;
                case 84:
                    Escudo.sprite = i84;
                    break;
                case 83:
                    Escudo.sprite = i83;
                    break;
                case 82:
                    Escudo.sprite = i82;
                    break;
                case 81:
                    Escudo.sprite = i81;
                    break;
                case 80:
                    Escudo.sprite = i80;
                    break;
                case 79:
                    Escudo.sprite = i79;
                    break;
                case 78:
                    Escudo.sprite = i78;
                    break;
                case 77:
                    Escudo.sprite = i77;
                    break;
                case 76:
                    Escudo.sprite = i76;
                    break;
                case 75:
                    Escudo.sprite = i75;
                    break;
                case 74:
                    Escudo.sprite = i74;
                    break;
                case 73:
                    Escudo.sprite = i73;
                    break;
                case 72:
                    Escudo.sprite = i72;
                    break;
                case 71:
                    Escudo.sprite = i71;
                    break;
                case 70:
                    Escudo.sprite = i70;
                    break;
                case 69:
                    Escudo.sprite = i69;
                    break;
                case 68:
                    Escudo.sprite = i68;
                    break;
                case 67:
                    Escudo.sprite = i67;
                    break;
                case 66:
                    Escudo.sprite = i66;
                    break;
                case 65:
                    Escudo.sprite = i65;
                    break;
                case 64:
                    Escudo.sprite = i64;
                    break;
                case 63:
                    Escudo.sprite = i63;
                    break;
                case 62:
                    Escudo.sprite = i62;
                    break;
                case 61:
                    Escudo.sprite = i61;
                    break;
                case 60:
                    Escudo.sprite = i60;
                    break;
                case 59:
                    Escudo.sprite = i59;
                    break;
                case 58:
                    Escudo.sprite = i58;
                    break;
                case 57:
                    Escudo.sprite = i57;
                    break;
                case 56:
                    Escudo.sprite = i56;
                    break;
                case 55:
                    Escudo.sprite = i55;
                    break;
                case 54:
                    Escudo.sprite = i54;
                    break;
                case 53:
                    Escudo.sprite = i53;
                    break;
                case 52:
                    Escudo.sprite = i52;
                    break;
                case 51:
                    Escudo.sprite = i51;
                    break;
                case 50:
                    Escudo.sprite = i50;
                    break;
                case 49:
                    Escudo.sprite = i49;
                    break;
                case 48:
                    Escudo.sprite = i48;
                    break;
                case 47:
                    Escudo.sprite = i47;
                    break;
                case 46:
                    Escudo.sprite = i46;
                    break;
                case 45:
                    Escudo.sprite = i45;
                    break;
                case 44:
                    Escudo.sprite = i44;
                    break;
                case 43:
                    Escudo.sprite = i43;
                    break;
                case 42:
                    Escudo.sprite = i42;
                    break;
                case 41:
                    Escudo.sprite = i41;
                    break;
                case 40:
                    Escudo.sprite = i40;
                    break;
                case 39:
                    Escudo.sprite = i39;
                    break;
                case 38:
                    Escudo.sprite = i38;
                    break;
                case 37:
                    Escudo.sprite = i37;
                    break;
                case 36:
                    Escudo.sprite = i36;
                    break;
                case 35:
                    Escudo.sprite = i35;
                    break;
                case 34:
                    Escudo.sprite = i34;
                    break;
                case 33:
                    Escudo.sprite = i33;
                    break;
                case 32:
                    Escudo.sprite = i32;
                    break;
                case 31:
                    Escudo.sprite = i31;
                    break;
                case 30:
                    Escudo.sprite = i30;
                    break;
                case 29:
                    Escudo.sprite = i29;
                    break;
                case 28:
                    Escudo.sprite = i28;
                    break;
                case 27:
                    Escudo.sprite = i27;
                    break;
                case 26:
                    Escudo.sprite = i26;
                    break;
                case 25:
                    Escudo.sprite = i25;
                    break;
                case 24:
                    Escudo.sprite = i24;
                    break;
                case 23:
                    Escudo.sprite = i23;
                    break;
                case 22:
                    Escudo.sprite = i22;
                    break;
                case 21:
                    Escudo.sprite = i21;
                    break;
                case 20:
                    Escudo.sprite = i20;
                    break;
                case 19:
                    Escudo.sprite = i19;
                    break;
                case 18:
                    Escudo.sprite = i18;
                    break;
                case 17:
                    Escudo.sprite = i17;
                    break;
                case 16:
                    Escudo.sprite = i16;
                    break;
                case 15:
                    Escudo.sprite = i15;
                    break;
                case 14:
                    Escudo.sprite = i14;
                    break;
                case 13:
                    Escudo.sprite = i13;
                    break;
                case 12:
                    Escudo.sprite = i12;
                    break;
                case 11:
                    Escudo.sprite = i11;
                    break;
                case 10:
                    Escudo.sprite = i10;
                    break;
                case 9:
                    Escudo.sprite = i9;
                    break;
                case 8:
                    Escudo.sprite = i8;
                    break;
                case 7:
                    Escudo.sprite = i7;
                    break;
                case 6:
                    Escudo.sprite = i6;
                    break;
                case 5:
                    Escudo.sprite = i5;
                    break;
                case 4:
                    Escudo.sprite = i4;
                    break;
                case 3:
                    Escudo.sprite = i3;
                    break;
                case 2:
                    Escudo.sprite = i2;
                    break;
                case 1:
                    Escudo.sprite = i1;
                    break;
                case 0:
                    Escudo.sprite = i0;
                    Protecao.SetActive(false);
                    break;
            }
        }
        catch (System.Exception)
        {


        }
    }

}

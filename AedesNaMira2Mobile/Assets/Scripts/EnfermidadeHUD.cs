using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnfermidadeHUD : MonoBehaviour
{
    public Image Enfermidade, EnfermidadeCarregar;
    public Heroi heroi;
    public HeroiControle heroiControle;
    public Sprite e100, e99, e98, e97, e96, e95, e94, e93, e92, e91, e90, e89, e88, e87, e86, e85, e84, e83, e82, e81, e80, e79, e78, e77, e76, e75, e74, e73, e72, e71;
    public Sprite e70, e69, e68, e67, e66, e65, e64, e63, e62, e61, e60, e59, e58, e57, e56, e55, e54, e53, e52, e51, e50, e49, e48, e47, e46, e45, e44, e43, e42, e41;
    public Sprite e40, e39, e38, e37, e36, e35, e34, e33, e32, e31, e30, e29, e28, e27, e26, e25, e24, e23, e22, e21, e20, e19, e18, e17, e16, e15, e14, e13, e12, e11;
    public Sprite e10, e9, e8, e7, e6, e5, e4, e3, e2, e1, e0;
    public float valor = 0;
    public void refreshDoenca()
    {
        if (heroi==null && heroiControle==null) 
        {
            if (GameObject.FindGameObjectWithTag("Heroi").GetComponent<Heroi>()!=null) 
            {
                heroi = GameObject.FindGameObjectWithTag("Heroi").GetComponent<Heroi>();
            }
            else if (GameObject.FindGameObjectWithTag("Heroi").GetComponent<HeroiControle>() != null)
            {
                heroiControle = GameObject.FindGameObjectWithTag("Heroi").GetComponent<HeroiControle>();
            }
        }
        int porcetagemDoente = 0;
        if (heroi != null)
        {
            porcetagemDoente = heroi.porcetagemDoente;
        }
        else if (heroiControle != null)
        {
            porcetagemDoente = heroiControle.porcetagemDoente;
        }
        porcetagemDoente = porcetagemDoente - 1;
        if (heroi != null)
        {
            heroi.porcetagemDoente = porcetagemDoente;
        }
        else if (heroiControle != null)
        {
            heroiControle.porcetagemDoente = porcetagemDoente;
        }

        if (porcetagemDoente > 0)
        {

            Enfermidade.enabled = true;
            EnfermidadeCarregar.enabled = true;
        }
        else
        {
            fim();
        }

        switch (porcetagemDoente)
        {
            case 100:
                EnfermidadeCarregar.sprite = e100;
                break;
            case 99:
                EnfermidadeCarregar.sprite = e99;
                break;
            case 98:
                EnfermidadeCarregar.sprite = e98;
                break;
            case 97:
                EnfermidadeCarregar.sprite = e97;
                break;
            case 96:
                EnfermidadeCarregar.sprite = e96;
                break;
            case 95:
                EnfermidadeCarregar.sprite = e95;
                break;
            case 94:
                EnfermidadeCarregar.sprite = e94;
                break;
            case 93:
                EnfermidadeCarregar.sprite = e93;
                break;
            case 92:
                EnfermidadeCarregar.sprite = e92;
                break;
            case 91:
                EnfermidadeCarregar.sprite = e91;
                break;
            case 90:
                EnfermidadeCarregar.sprite = e90;
                break;
            case 89:
                EnfermidadeCarregar.sprite = e89;
                break;
            case 88:
                EnfermidadeCarregar.sprite = e88;
                break;
            case 87:
                EnfermidadeCarregar.sprite = e87;
                break;
            case 86:
                EnfermidadeCarregar.sprite = e86;
                break;
            case 85:
                EnfermidadeCarregar.sprite = e85;
                break;
            case 84:
                EnfermidadeCarregar.sprite = e84;
                break;
            case 83:
                EnfermidadeCarregar.sprite = e83;
                break;
            case 82:
                EnfermidadeCarregar.sprite = e82;
                break;
            case 81:
                EnfermidadeCarregar.sprite = e81;
                break;
            case 80:
                EnfermidadeCarregar.sprite = e80;
                break;
            case 79:
                EnfermidadeCarregar.sprite = e79;
                break;
            case 78:
                EnfermidadeCarregar.sprite = e78;
                break;
            case 77:
                EnfermidadeCarregar.sprite = e77;
                break;
            case 76:
                EnfermidadeCarregar.sprite = e76;
                break;
            case 75:
                EnfermidadeCarregar.sprite = e75;
                break;
            case 74:
                EnfermidadeCarregar.sprite = e74;
                break;
            case 73:
                EnfermidadeCarregar.sprite = e73;
                break;
            case 72:
                EnfermidadeCarregar.sprite = e72;
                break;
            case 71:
                EnfermidadeCarregar.sprite = e71;
                break;
            case 70:
                EnfermidadeCarregar.sprite = e70;
                break;
            case 69:
                EnfermidadeCarregar.sprite = e69;
                break;
            case 68:
                EnfermidadeCarregar.sprite = e68;
                break;
            case 67:
                EnfermidadeCarregar.sprite = e67;
                break;
            case 66:
                EnfermidadeCarregar.sprite = e66;
                break;
            case 65:
                EnfermidadeCarregar.sprite = e65;
                break;
            case 64:
                EnfermidadeCarregar.sprite = e64;
                break;
            case 63:
                EnfermidadeCarregar.sprite = e63;
                break;
            case 62:
                EnfermidadeCarregar.sprite = e62;
                break;
            case 61:
                EnfermidadeCarregar.sprite = e61;
                break;
            case 60:
                EnfermidadeCarregar.sprite = e60;
                break;
            case 59:
                EnfermidadeCarregar.sprite = e59;
                break;
            case 58:
                EnfermidadeCarregar.sprite = e58;
                break;
            case 57:
                EnfermidadeCarregar.sprite = e57;
                break;
            case 56:
                EnfermidadeCarregar.sprite = e56;
                break;
            case 55:
                EnfermidadeCarregar.sprite = e55;
                break;
            case 54:
                EnfermidadeCarregar.sprite = e54;
                break;
            case 53:
                EnfermidadeCarregar.sprite = e53;
                break;
            case 52:
                EnfermidadeCarregar.sprite = e52;
                break;
            case 51:
                EnfermidadeCarregar.sprite = e51;
                break;
            case 50:
                EnfermidadeCarregar.sprite = e50;
                break;
            case 49:
                EnfermidadeCarregar.sprite = e49;
                break;
            case 48:
                EnfermidadeCarregar.sprite = e48;
                break;
            case 47:
                EnfermidadeCarregar.sprite = e47;
                break;
            case 46:
                EnfermidadeCarregar.sprite = e46;
                break;
            case 45:
                EnfermidadeCarregar.sprite = e45;
                break;
            case 44:
                EnfermidadeCarregar.sprite = e44;
                break;
            case 43:
                EnfermidadeCarregar.sprite = e43;
                break;
            case 42:
                EnfermidadeCarregar.sprite = e42;
                break;
            case 41:
                EnfermidadeCarregar.sprite = e41;
                break;
            case 40:
                EnfermidadeCarregar.sprite = e40;
                break;
            case 39:
                EnfermidadeCarregar.sprite = e39;
                break;
            case 38:
                EnfermidadeCarregar.sprite = e38;
                break;
            case 37:
                EnfermidadeCarregar.sprite = e37;
                break;
            case 36:
                EnfermidadeCarregar.sprite = e36;
                break;
            case 35:
                EnfermidadeCarregar.sprite = e35;
                break;
            case 34:
                EnfermidadeCarregar.sprite = e34;
                break;
            case 33:
                EnfermidadeCarregar.sprite = e33;
                break;
            case 32:
                EnfermidadeCarregar.sprite = e32;
                break;
            case 31:
                EnfermidadeCarregar.sprite = e31;
                break;
            case 30:
                EnfermidadeCarregar.sprite = e30;
                break;
            case 29:
                EnfermidadeCarregar.sprite = e29;
                break;
            case 28:
                EnfermidadeCarregar.sprite = e28;
                break;
            case 27:
                EnfermidadeCarregar.sprite = e27;
                break;
            case 26:
                EnfermidadeCarregar.sprite = e26;
                break;
            case 25:
                EnfermidadeCarregar.sprite = e25;
                break;
            case 24:
                EnfermidadeCarregar.sprite = e24;
                break;
            case 23:
                EnfermidadeCarregar.sprite = e23;
                break;
            case 22:
                EnfermidadeCarregar.sprite = e22;
                break;
            case 21:
                EnfermidadeCarregar.sprite = e21;
                break;
            case 20:
                EnfermidadeCarregar.sprite = e20;
                break;
            case 19:
                EnfermidadeCarregar.sprite = e19;
                break;
            case 18:
                EnfermidadeCarregar.sprite = e18;
                break;
            case 17:
                EnfermidadeCarregar.sprite = e17;
                break;
            case 16:
                EnfermidadeCarregar.sprite = e16;
                break;
            case 15:
                EnfermidadeCarregar.sprite = e15;
                break;
            case 14:
                EnfermidadeCarregar.sprite = e14;
                break;
            case 13:
                EnfermidadeCarregar.sprite = e13;
                break;
            case 12:
                EnfermidadeCarregar.sprite = e12;
                break;
            case 11:
                EnfermidadeCarregar.sprite = e11;
                break;
            case 10:
                EnfermidadeCarregar.sprite = e10;
                break;
            case 9:
                EnfermidadeCarregar.sprite = e9;
                break;
            case 8:
                EnfermidadeCarregar.sprite = e8;
                break;
            case 7:
                EnfermidadeCarregar.sprite = e7;
                break;
            case 6:
                EnfermidadeCarregar.sprite = e6;
                break;
            case 5:
                EnfermidadeCarregar.sprite = e5;
                break;
            case 4:
                EnfermidadeCarregar.sprite = e4;
                break;
            case 3:
                EnfermidadeCarregar.sprite = e3;
                break;
            case 2:
                EnfermidadeCarregar.sprite = e2;
                break;
            case 1:
                EnfermidadeCarregar.sprite = e1;
                break;
            case 0:
                EnfermidadeCarregar.sprite = e0;
                fim();
                break;
        }


    }

    public void fim()
    {
        if (heroi != null)
        {
            heroi.doente = false;
        }
        else
        {
            heroiControle.doente = false;
        }
        valor = 0;
        Enfermidade.enabled = false;
        EnfermidadeCarregar.enabled = false;
    }
}

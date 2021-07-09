using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectRaquete : MonoBehaviour
{
    public GameObject efect, HUD, Gerenciar,ControleDireito;
    public int id;

    // Use this for initialization
    void Start()
    {
        HUD = GameObject.FindGameObjectWithTag("HUD");
        Gerenciar = GameObject.FindGameObjectWithTag("Gerenciar");
        ControleDireito= GameObject.FindGameObjectWithTag("controledireito");
        Physics.IgnoreLayerCollision(7, 8);
    }

    void OnCollisionStay(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Mosquito_Dengue" || collisionInfo.gameObject.tag == "Mosquito_Normal" || collisionInfo.gameObject.tag == "Mosquito_Chikungunya" || collisionInfo.gameObject.tag == "Mosquito_Zika")
        {
            switch (id)
            {
                case 0://Raquete Cinza
                    RaqueteNivelCinza(collisionInfo);
                    break;
                case 1://Raquete Azul
                    RaqueteNivelAzul(collisionInfo);
                    RamSystem.Quantidade1Pilha -= 2;
                    HUD.GetComponent<HUD>().BateriaRefresh();                    
                    break;
                case 2://Raquete Vermelha                    
                        RaqueteNivelVermelho(collisionInfo);
                        RamSystem.Quantidade1Pilha -= 2;
                        HUD.GetComponent<HUD>().BateriaRefresh();                    
                    break;
                case 3://Raquete Dourada                   
                        RaqueteNivelDourada(collisionInfo);
                        RamSystem.Quantidade1Pilha -= 2;
                        HUD.GetComponent<HUD>().BateriaRefresh();                      
                    break;
            }
            efect.SetActive(true);
            collisionInfo.gameObject.GetComponent<Mosquito>().destinoPonto();

        }

        if (collisionInfo.gameObject.tag == "Heroi")
        {
            Physics.IgnoreCollision(collisionInfo.collider, GetComponent<Collider>());
        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Mosquito_Dengue" || collisionInfo.gameObject.tag == "Mosquito_Normal" || collisionInfo.gameObject.tag == "Mosquito_Chikungunya" || collisionInfo.gameObject.tag == "Mosquito_Zika")
        {
            switch (id)
            {
                case 0://Raquete Cinza
                    RaqueteNivelCinza(collisionInfo);
                    break;
                case 1://Raquete Azul
                    RamSystem.Quantidade1Pilha -= 1;
                    HUD.GetComponent<HUD>().BateriaRefresh();
                    RaqueteNivelAzul(collisionInfo);
                    break;
                case 2://Raquete Vermelha
                    RamSystem.Quantidade1Pilha -= 1;
                    HUD.GetComponent<HUD>().BateriaRefresh();
                    RaqueteNivelVermelho(collisionInfo);
                    break;
                case 3://Raquete Dourada
                    RamSystem.Quantidade1Pilha -= 1;
                    HUD.GetComponent<HUD>().BateriaRefresh();
                    RaqueteNivelDourada(collisionInfo);
                    break;
            }
            efect.SetActive(true);
            collisionInfo.gameObject.GetComponent<Mosquito>().destinoPonto();
        }

        if (collisionInfo.gameObject.tag == "Heroi")
        {
            Physics.IgnoreCollision(collisionInfo.collider, GetComponent<Collider>());
        }
    }

    void OnCollisionExit(Collision collisionInfo)
    {
        efect.SetActive(false);
    }

    public void RaqueteNivelCinza(Collision collisionInfo)
    {
        switch (Gerenciar.GetComponent<ControleDificuldade>().NivelDificulade)
        {
            case 1:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 15;
                break;
            case 2:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 14;
                break;
            case 3:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 13;
                break;
            case 4:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 12;
                break;
            case 5:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 11;
                break;
            case 6:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 10;
                break;
            case 7:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 9;
                break;
            case 8:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 8;
                break;
            case 9:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 7;
                break;
            case 10:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 6;
                break;
            case 11:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 5;
                break;
            case 12:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 4;
                break;
            case 13:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 3;
                break;
            case 14:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 2;
                break;
            case 15:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 1;
                break;
            case 16:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 0.9f;
                break;
            case 17:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 0.8f;
                break;
            case 18:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 0.7f;
                break;
            case 19:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 0.6f;
                break;
            case 20:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 0.5f;
                break;
            case 21:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 0.4f;
                break;
            case 22:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 0.3f;
                break;
            case 23:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 0.2f;
                break;
            case 24:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 0.1f;
                break;
            case 25:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 0.09f;
                break;
            case 26:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 0.08f;
                break;
            case 27:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 0.07f;
                break;
            case 28:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 0.06f;
                break;
            case 29:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 0.05f;
                break;
            case 30:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 0.04f;
                break;

        }
    }

    public void RaqueteNivelAzul(Collision collisionInfo)
    {
        switch (Gerenciar.GetComponent<ControleDificuldade>().NivelDificulade)
        {
            case 1:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 25;
                break;
            case 2:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 24;
                break;
            case 3:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 23;
                break;
            case 4:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 22;
                break;
            case 5:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 21;
                break;
            case 6:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 20;
                break;
            case 7:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 19;
                break;
            case 8:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 18;
                break;
            case 9:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 17;
                break;
            case 10:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 16;
                break;
            case 11:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 15;
                break;
            case 12:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 14;
                break;
            case 13:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 13;
                break;
            case 14:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 12;
                break;
            case 15:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 11;
                break;
            case 16:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 10;
                break;
            case 17:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 9;
                break;
            case 18:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 8;
                break;
            case 19:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 7;
                break;
            case 20:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 6;
                break;
            case 21:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 5;
                break;
            case 22:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 4;
                break;
            case 23:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 3;
                break;
            case 24:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 2;
                break;
            case 25:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 1;
                break;
            case 26:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 0.9f;
                break;
            case 27:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 0.8f;
                break;
            case 28:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 0.7f;
                break;
            case 29:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 0.6f;
                break;
            case 30:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 0.5f;
                break;

        }
    }

    public void RaqueteNivelVermelho(Collision collisionInfo)
    {
        switch (Gerenciar.GetComponent<ControleDificuldade>().NivelDificulade)
        {
            case 1:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 50;
                break;
            case 2:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 49;
                break;
            case 3:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 48;
                break;
            case 4:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 47;
                break;
            case 5:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 46;
                break;
            case 6:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 45;
                break;
            case 7:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 44;
                break;
            case 8:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 43;
                break;
            case 9:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 42;
                break;
            case 10:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 41;
                break;
            case 11:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 40;
                break;
            case 12:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 39;
                break;
            case 13:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 38;
                break;
            case 14:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 37;
                break;
            case 15:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 36;
                break;
            case 16:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 35;
                break;
            case 17:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 34;
                break;
            case 18:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 33;
                break;
            case 19:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 31;
                break;
            case 20:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 30;
                break;
            case 21:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 29;
                break;
            case 22:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 28;
                break;
            case 23:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 27;
                break;
            case 24:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 26;
                break;
            case 25:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 25;
                break;
            case 26:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 24;
                break;
            case 27:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 23;
                break;
            case 28:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 21;
                break;
            case 29:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 20;
                break;
            case 30:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 19;
                break;

        }
    }


    public void RaqueteNivelDourada(Collision collisionInfo)
    {
        switch (Gerenciar.GetComponent<ControleDificuldade>().NivelDificulade)
        {
            case 1:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 100;
                break;
            case 2:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 99;
                break;
            case 3:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 98;
                break;
            case 4:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 97;
                break;
            case 5:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 96;
                break;
            case 6:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 95;
                break;
            case 7:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 94;
                break;
            case 8:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 93;
                break;
            case 9:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 92;
                break;
            case 10:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 91;
                break;
            case 11:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 90;
                break;
            case 12:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 89;
                break;
            case 13:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 88;
                break;
            case 14:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 87;
                break;
            case 15:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 86;
                break;
            case 16:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 85;
                break;
            case 17:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 84;
                break;
            case 18:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 83;
                break;
            case 19:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 81;
                break;
            case 20:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 80;
                break;
            case 21:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 79;
                break;
            case 22:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 78;
                break;
            case 23:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 77;
                break;
            case 24:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 76;
                break;
            case 25:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 75;
                break;
            case 26:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 74;
                break;
            case 27:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 73;
                break;
            case 28:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 72;
                break;
            case 29:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 71;
                break;
            case 30:
                collisionInfo.gameObject.GetComponent<Mosquito>().life -= 70;
                break;
        }
    }

}

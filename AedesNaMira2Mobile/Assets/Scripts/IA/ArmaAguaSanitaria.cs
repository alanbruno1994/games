using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaAguaSanitaria : MonoBehaviour
{

    public GameObject bala;
    

    public void Disparar()
    {
       
        Instantiate(bala, transform.position, transform.rotation);
        switch (RamSystem.ArmaUsada)
        {
            case 4:
                RamSystem.Quantidade1AguaSanitariaAzul = RamSystem.Quantidade1AguaSanitariaAzul - 1;
                if (RamSystem.Quantidade1AguaSanitariaAzul <= 0)
                {
                    RamSystem.AguaSanitariaAzul = RamSystem.AguaSanitariaAzul - 1;
                    GameObject.FindGameObjectWithTag("HUD").GetComponent<HUD>().QuantidadeArma.text = "" + RamSystem.AguaSanitariaAzul;
                    RamSystem.Quantidade1AguaSanitariaAzul = 100;
                    if (RamSystem.AguaSanitariaAzul <= 0)
                    {
                        RamSystem.AguaSanitariaAzul = 0;
                        GameObject.FindGameObjectWithTag("controledireito").GetComponent<JoystickDireito>().TrocarArma();
                    }
                }
                else {                    
                    GameObject HUD = GameObject.FindGameObjectWithTag("HUD");
                    if (HUD != null)
                    {
                        if (HUD.GetComponent<HUD>() != null)
                        {
                            HUD.GetComponent<HUD>().AguaRefresh();
                        }
                    }
                   
                }
                break;
            case 5:
                RamSystem.Quantidade1AguaSanitariaVermelha = RamSystem.Quantidade1AguaSanitariaVermelha - 1;
                if (RamSystem.Quantidade1AguaSanitariaVermelha <= 0)
                {
                    RamSystem.AguaSanitariaVermelha = RamSystem.AguaSanitariaVermelha - 1;
                    GameObject.FindGameObjectWithTag("HUD").GetComponent<HUD>().QuantidadeArma.text = "" + RamSystem.AguaSanitariaVermelha;
                    RamSystem.Quantidade1AguaSanitariaVermelha = 100;
                    if (RamSystem.AguaSanitariaVermelha <= 0)
                    {
                        RamSystem.AguaSanitariaVermelha = 0;
                        GameObject.FindGameObjectWithTag("controledireito").GetComponent<JoystickDireito>().TrocarArma();
                    }
                }
                else
                {
                    GameObject HUD = GameObject.FindGameObjectWithTag("HUD");
                    if (HUD!=null) 
                    {
                        if (HUD.GetComponent<HUD>()!=null) 
                        {
                            HUD.GetComponent<HUD>().AguaRefresh();
                        }
                    }
                    
                }
                break;
            case 6:
                RamSystem.Quantidade1AguaSanitariaDourada = RamSystem.Quantidade1AguaSanitariaDourada - 1;
                if (RamSystem.Quantidade1AguaSanitariaDourada <= 0)
                {
                    RamSystem.AguaSanitariaDourada = RamSystem.AguaSanitariaDourada - 1;
                    GameObject.FindGameObjectWithTag("HUD").GetComponent<HUD>().QuantidadeArma.text = "" + RamSystem.AguaSanitariaDourada;
                    RamSystem.Quantidade1AguaSanitariaDourada = 100;
                    if (RamSystem.AguaSanitariaDourada <= 0)
                    {
                        RamSystem.AguaSanitariaDourada = 0;
                        GameObject.FindGameObjectWithTag("controledireito").GetComponent<JoystickDireito>().TrocarArma();
                    }
                }
                else
                {
                    GameObject HUD = GameObject.FindGameObjectWithTag("HUD");
                    if (HUD != null)
                    {
                        if (HUD.GetComponent<HUD>() != null)
                        {
                            HUD.GetComponent<HUD>().AguaRefresh();
                        }
                    }                   
                }
                break;
        }
         
    }


   
}

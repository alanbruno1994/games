using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoystickDireito : MonoBehaviour
{
	//Codigos=-1--Raquete Cinza,0--Raquete Azul,1--Raquete Vermelho,2--Raquete Dourado
	//Codigos=3--AguaSanitariaAzul,4--AguaSanitariaVermelha,5--AguaSanitariaDourado
	//Codigos=6--RepelenteAzul,7--RepelenteVermelha,8--RepelenteDourado
	// Use this for initialization
	//public GameObject RaqueteCinza, RaqueteAzul, RaqueteVermelha, RaqueteDourada, AguaSAzul, AguaSVermelha, AguaSDourada, RepelenteAzul, RepelenteVermelho, RepelenteDourado;
	public GameObject AguaSanitariaAzul, AguaSanitariaVermelho, AguaSanitariaDourada,Raquete_Cinza,Raquete_Azul,Raquete_Vermelha,Raquete_Dourada;
	public GameObject heroi,HUD;   
    public Sprite raqueteAzul, raqueteCinza, raqueteVermelha, raqueteDourada, aguaAzul, aguaVermelha, aguaDourada;
    public GameObject ArmatureAgua, ArmatureRaquete;
    public GameObject MaoAgua, MaoRaquete;
    //Deixo no 9 para começa em -1;
    void Start ()
	{

        ArmatureAgua.SetActive(false);
        MaoAgua.SetActive(false);
        MaoRaquete.SetActive(true);
        ArmatureRaquete.SetActive(true);
        AguaSanitariaAzul.SetActive (false);
		AguaSanitariaVermelho.SetActive (false);
		AguaSanitariaDourada.SetActive (false);
		Raquete_Cinza.SetActive (true);
		Raquete_Azul.SetActive (false);
		Raquete_Vermelha.SetActive (false);
		Raquete_Dourada.SetActive (false);        
        heroi =GameObject.FindGameObjectWithTag ("Heroi");
        HUD= GameObject.FindGameObjectWithTag("HUD");

    }

    // Update is called once per frame
    /*
    * ID=1 Raquete Azul
    * ID=2 Raquete Vermelha
    * ID=3 Raquete Dourada
    * ID=4 Agua Sanitaria Azul
    * ID=5 Agua Sanitaria Vermelha
    * ID=6 Agua Sanitaria Dourada 
    * ID=7 Repelente Azul
    * ID=8 Repelente Vermelha
    * ID=9 Repelente Dourada 
    * ID=10 Pilha
    */
    public void TrocarArma()
    {
        int opcao = RamSystem.ArmaUsada;
        switch (opcao)
        {
            case 0://Raquete Cinza
                if (RamSystem.RaqueteAzul)
                {
                    RamSystem.ArmaUsada = 1;
                }
                else if (RamSystem.RaqueteVermelha && RamSystem.QuantidadePilhas>=1)
                {
                    RamSystem.ArmaUsada = 2;
                }
                else if (RamSystem.RaqueteDourada && RamSystem.QuantidadePilhas >= 1)
                {
                    RamSystem.ArmaUsada = 3;
                }
                else if (RamSystem.AguaSanitariaAzul > 0)
                {
                    RamSystem.ArmaUsada = 4;
                }
                else if (RamSystem.AguaSanitariaVermelha > 0)
                {
                    RamSystem.ArmaUsada = 5;
                }
                else if (RamSystem.AguaSanitariaDourada > 0)
                {
                    RamSystem.ArmaUsada = 6;
                }
                else
                {
                    RamSystem.ArmaUsada = 0;
                }
                break;
            case 1://Raquete Azul             
                if (RamSystem.RaqueteVermelha)
                {
                    RamSystem.ArmaUsada = 2;
                }
                else if (RamSystem.RaqueteDourada)
                {
                    RamSystem.ArmaUsada = 3;
                }
                else if (RamSystem.AguaSanitariaAzul > 0)
                {
                    RamSystem.ArmaUsada = 4;
                }
                else if (RamSystem.AguaSanitariaVermelha > 0)
                {
                    RamSystem.ArmaUsada = 5;
                }
                else if (RamSystem.AguaSanitariaDourada > 0)
                {
                    RamSystem.ArmaUsada = 6;
                }
                else
                {
                    RamSystem.ArmaUsada = 0;
                }
                break;
            case 2://Raquete Vermelha
                if (RamSystem.RaqueteDourada)
                {
                    RamSystem.ArmaUsada = 3;
                }
                else if (RamSystem.AguaSanitariaAzul > 0)
                {
                    RamSystem.ArmaUsada = 4;
                }
                else if (RamSystem.AguaSanitariaVermelha > 0)
                {
                    RamSystem.ArmaUsada = 5;
                }
                else if (RamSystem.AguaSanitariaDourada > 0)
                {
                    RamSystem.ArmaUsada = 6;
                }
                else
                {
                    RamSystem.ArmaUsada = 0;
                }
                break;
            case 3://Raquete Dourada
                if (RamSystem.AguaSanitariaAzul > 0)
                {
                    RamSystem.ArmaUsada = 4;
                }
                else if (RamSystem.AguaSanitariaVermelha > 0)
                {
                    RamSystem.ArmaUsada = 5;
                }
                else if (RamSystem.AguaSanitariaDourada > 0)
                {
                    RamSystem.ArmaUsada = 6;
                }
                else
                {
                    RamSystem.ArmaUsada = 0;
                }
                break;
            case 4://Agua Sanitaria Azul
                if (RamSystem.AguaSanitariaVermelha > 0)
                {
                    RamSystem.ArmaUsada = 5;
                }
                else if (RamSystem.AguaSanitariaDourada > 0)
                {
                    RamSystem.ArmaUsada = 6;
                }
                else
                {
                    RamSystem.ArmaUsada = 0;
                }
                break;
            case 5://Agua Sanitaria Vermelha
                if (RamSystem.AguaSanitariaDourada > 0)
                {
                    RamSystem.ArmaUsada = 6;
                }
                else
                {
                    RamSystem.ArmaUsada = 0;
                }
                break;
            case 6://Agua Sanitaria Dourada 
                RamSystem.ArmaUsada = 0;
                break;

        }
        ArmaUsada();

    }


    public void ArmaUsada()
    {
        switch (RamSystem.ArmaUsada)
        {
            case 0:
                Raquete_Cinza.SetActive(true);
                Raquete_Azul.SetActive(false);
                Raquete_Vermelha.SetActive(false);
                Raquete_Dourada.SetActive(false);
                AguaSanitariaAzul.SetActive(false);
                AguaSanitariaVermelho.SetActive(false);
                AguaSanitariaDourada.SetActive(false);
                HUD.GetComponent<HUD>().Item.sprite = raqueteCinza;
                HUD.GetComponent<HUD>().QuantidadeArma.text = "" + 1;
                HUD.GetComponent<HUD>().TrocarBateria(0);
                ArmatureAgua.SetActive(false);
                MaoAgua.SetActive(false);
                MaoRaquete.SetActive(true);
                ArmatureRaquete.SetActive(true);
                HUD.GetComponent<HUD>().Disparo.SetActive(false);
                HUD.GetComponent<HUD>().BateriaouAgua.sprite = HUD.GetComponent<HUD>().SpritePilhaInfinita;
                break;
            case 1:                
                Raquete_Cinza.SetActive(false);
                Raquete_Azul.SetActive(true);
                Raquete_Vermelha.SetActive(false);
                Raquete_Dourada.SetActive(false);
                AguaSanitariaAzul.SetActive(false);
                AguaSanitariaVermelho.SetActive(false);
                AguaSanitariaDourada.SetActive(false);
                HUD.GetComponent<HUD>().Item.sprite = raqueteAzul;
                HUD.GetComponent<HUD>().QuantidadeArma.text = "" + 1;
                HUD.GetComponent<HUD>().TrocarBateria(1);
                ArmatureAgua.SetActive(false);
                MaoAgua.SetActive(false);
                MaoRaquete.SetActive(true);
                ArmatureRaquete.SetActive(true);
                HUD.GetComponent<HUD>().Disparo.SetActive(false);
                HUD.GetComponent<HUD>().BateriaRefresh();                
                break;
            case 2:                
                    Raquete_Cinza.SetActive(false);
                    Raquete_Azul.SetActive(false);
                    Raquete_Vermelha.SetActive(true);
                    Raquete_Dourada.SetActive(false);
                    AguaSanitariaAzul.SetActive(false);
                    AguaSanitariaVermelho.SetActive(false);
                    AguaSanitariaDourada.SetActive(false);
                    HUD.GetComponent<HUD>().Item.sprite = raqueteVermelha;
                    HUD.GetComponent<HUD>().QuantidadeArma.text = "" + 1;
                    HUD.GetComponent<HUD>().TrocarBateria(2);
                    ArmatureAgua.SetActive(false);
                    MaoAgua.SetActive(false);
                    MaoRaquete.SetActive(true);
                    ArmatureRaquete.SetActive(true);
                    HUD.GetComponent<HUD>().Disparo.SetActive(false);
                    HUD.GetComponent<HUD>().BateriaRefresh();                
                break;
            case 3:                
                    Raquete_Cinza.SetActive(false);
                    Raquete_Azul.SetActive(false);
                    Raquete_Vermelha.SetActive(false);
                    Raquete_Dourada.SetActive(true);
                    AguaSanitariaAzul.SetActive(false);
                    AguaSanitariaVermelho.SetActive(false);
                    AguaSanitariaDourada.SetActive(false);
                    HUD.GetComponent<HUD>().Item.sprite = raqueteDourada;
                    HUD.GetComponent<HUD>().QuantidadeArma.text = "" + 1;
                    HUD.GetComponent<HUD>().TrocarBateria(3);
                    ArmatureAgua.SetActive(false);
                    MaoAgua.SetActive(false);
                    MaoRaquete.SetActive(true);
                    ArmatureRaquete.SetActive(true);
                    HUD.GetComponent<HUD>().Disparo.SetActive(false);
                    HUD.GetComponent<HUD>().BateriaRefresh();                
                break;
            case 4:
                Raquete_Cinza.SetActive(false);
                Raquete_Azul.SetActive(false);
                Raquete_Vermelha.SetActive(false);
                Raquete_Dourada.SetActive(false);
                AguaSanitariaAzul.SetActive(true);
                AguaSanitariaVermelho.SetActive(false);
                AguaSanitariaDourada.SetActive(false);
                HUD.GetComponent<HUD>().Item.sprite = aguaAzul;
                HUD.GetComponent<HUD>().QuantidadeArma.text = "" + RamSystem.AguaSanitariaAzul;
                HUD.GetComponent<HUD>().TrocarAgua();
                ArmatureAgua.SetActive(true);
                MaoAgua.SetActive(true);
                MaoRaquete.SetActive(false);
                ArmatureRaquete.SetActive(false);
                HUD.GetComponent<HUD>().Disparo.SetActive(true);
                HUD.GetComponent<HUD>().AguaRefresh();
                break;
            case 5:
                Raquete_Cinza.SetActive(false);
                Raquete_Azul.SetActive(false);
                Raquete_Vermelha.SetActive(false);
                Raquete_Dourada.SetActive(false);
                AguaSanitariaAzul.SetActive(false);
                AguaSanitariaVermelho.SetActive(true);
                AguaSanitariaDourada.SetActive(false);
                HUD.GetComponent<HUD>().Item.sprite = aguaVermelha;
                HUD.GetComponent<HUD>().QuantidadeArma.text = "" + RamSystem.AguaSanitariaVermelha;
                HUD.GetComponent<HUD>().TrocarAgua();
                ArmatureAgua.SetActive(true);
                MaoAgua.SetActive(true);
                MaoRaquete.SetActive(false);
                ArmatureRaquete.SetActive(false);
                HUD.GetComponent<HUD>().Disparo.SetActive(true);
                HUD.GetComponent<HUD>().AguaRefresh();
                break;
            case 6:
                Raquete_Cinza.SetActive(false);
                Raquete_Azul.SetActive(false);
                Raquete_Vermelha.SetActive(false);
                Raquete_Dourada.SetActive(false);
                AguaSanitariaAzul.SetActive(false);
                AguaSanitariaVermelho.SetActive(false);
                AguaSanitariaDourada.SetActive(true);
                HUD.GetComponent<HUD>().Item.sprite = aguaDourada;
                HUD.GetComponent<HUD>().QuantidadeArma.text = "" + RamSystem.AguaSanitariaDourada;
                HUD.GetComponent<HUD>().TrocarAgua();
                ArmatureAgua.SetActive(true);
                MaoAgua.SetActive(true);
                MaoRaquete.SetActive(false);
                ArmatureRaquete.SetActive(false);
                HUD.GetComponent<HUD>().Disparo.SetActive(true);
                HUD.GetComponent<HUD>().AguaRefresh();
                break;
        }


    }
}

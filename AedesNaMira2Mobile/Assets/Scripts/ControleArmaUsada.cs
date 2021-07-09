using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControleArmaUsada : MonoBehaviour
{
    //public RecargaArmaHUD recargaArmaHUD;
    //Codigos=-1--Raquete Cinza,0--Raquete Azul,1--Raquete Vermelho,2--Raquete Dourado
    //Codigos=3--AguaSanitariaAzul,4--AguaSanitariaVermelha,5--AguaSanitariaDourado
    //Codigos=6--RepelenteAzul,7--RepelenteVermelha,8--RepelenteDourado
    // Use this for initialization
    //public GameObject RaqueteCinza, RaqueteAzul, RaqueteVermelha, RaqueteDourada, AguaSAzul, AguaSVermelha, AguaSDourada, RepelenteAzul, RepelenteVermelho, RepelenteDourado;
    public GameObject AguaSanitariaAzul, AguaSanitariaVermelho, AguaSanitariaDourada, Raquete_Cinza, Raquete_Azul, Raquete_Vermelha, Raquete_Dourada;    
    public GameObject ArmatureAgua, ArmatureRaquete, MaoAgua, MaoRaquete, Disparo;   
    public DesativoItens desativa = new DesativoItens();
    public ArmaAguaSanitaria AAzul,AVermelha,ADourada;

  
    //Deixo no 9 para começa em -1;
    void Start()
    {
        desativa.mudar11(ArmatureAgua,false, MaoAgua,false, MaoRaquete,true, ArmatureRaquete,true, AguaSanitariaAzul,false, AguaSanitariaVermelho,false, AguaSanitariaDourada,false, Raquete_Cinza,true, Raquete_Azul,false, Raquete_Vermelha,false, Raquete_Dourada,false);
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
                else if (RamSystem.RaqueteVermelha && RamSystem.QuantidadePilhas >= 1)
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

    public void dispararAgua() 
    {
        switch (RamSystem.ArmaUsada)
        {            
            case 4:
                AAzul.Disparar();
                break;
            case 5:
                AVermelha.Disparar();
                break;
            case 6:
                ADourada.Disparar();
                break;
        }
    }

    public void ArmaUsada()
    {
        switch (RamSystem.ArmaUsada)
        {
            case 0:                                                        
                desativaDisparo(false);              
                desativa.mudar11(ArmatureAgua, false, MaoAgua, false, MaoRaquete, true, ArmatureRaquete, true, AguaSanitariaAzul, false, AguaSanitariaVermelho, false, AguaSanitariaDourada, false, Raquete_Cinza, true, Raquete_Azul, false, Raquete_Vermelha, false, Raquete_Dourada, false);
                break;
            case 1:                            
                desativaDisparo(false);
                desativa.mudar11(ArmatureAgua, false, MaoAgua, false, MaoRaquete, true, ArmatureRaquete, true, AguaSanitariaAzul, false, AguaSanitariaVermelho, false, AguaSanitariaDourada, false, Raquete_Cinza, false, Raquete_Azul, true, Raquete_Vermelha, false, Raquete_Dourada, false);
                break;
            case 2:                        
                desativaDisparo(false);
                desativa.mudar11(ArmatureAgua, false, MaoAgua, false, MaoRaquete, true, ArmatureRaquete, true, AguaSanitariaAzul, false, AguaSanitariaVermelho, false, AguaSanitariaDourada, false, Raquete_Cinza, false, Raquete_Azul, false, Raquete_Vermelha, true, Raquete_Dourada, false);
                break;
            case 3:
                desativaDisparo(false);
                desativa.mudar11(ArmatureAgua, false, MaoAgua, false, MaoRaquete, true, ArmatureRaquete, true, AguaSanitariaAzul, false, AguaSanitariaVermelho, false, AguaSanitariaDourada, false, Raquete_Cinza, false, Raquete_Azul, false, Raquete_Vermelha, false, Raquete_Dourada, true);
                break;
            case 4:                      
                desativa.mudar11(ArmatureAgua, true, MaoAgua, true, MaoRaquete, false, ArmatureRaquete, false, AguaSanitariaAzul, true, AguaSanitariaVermelho, false, AguaSanitariaDourada, false, Raquete_Cinza, false, Raquete_Azul, false, Raquete_Vermelha, false, Raquete_Dourada, false);
                desativaDisparo(true);
                break;
            case 5:                                 
                desativaDisparo(true);
                desativa.mudar11(ArmatureAgua, true, MaoAgua, true, MaoRaquete, false, ArmatureRaquete, false, AguaSanitariaAzul, false, AguaSanitariaVermelho, true, AguaSanitariaDourada, false, Raquete_Cinza, false, Raquete_Azul, false, Raquete_Vermelha, false, Raquete_Dourada, false);
                break;
            case 6:
                desativaDisparo(true);
                desativa.mudar11(ArmatureAgua, true, MaoAgua, true, MaoRaquete, false, ArmatureRaquete, false, AguaSanitariaAzul, false, AguaSanitariaVermelho, false, AguaSanitariaDourada, true, Raquete_Cinza, false, Raquete_Azul, false, Raquete_Vermelha, false, Raquete_Dourada, false);
                break;
        }


    }

    

    public void desativaDisparo(bool v)
    {
        if (Disparo != null)
        {
            Disparo.SetActive(v);
        }

    }
}

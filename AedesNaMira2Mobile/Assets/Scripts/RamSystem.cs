using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamSystem : MonoBehaviour
{
    
    public static bool RaqueteAzul, RaqueteVermelha, RaqueteDourada;
    public static int AguaSanitariaAzul, AguaSanitariaVermelha, AguaSanitariaDourada,RepelenteAzul,RepelenteVermelho,RepelenteDourada;
    public static float QuantidadeAguaSanitariaAzul=100, QuantidadeAguaSanitariaVermelha=100, QuantidadeAguaSanitariaDourada=100, QuantidadeRepelenteAzul, QuantidadeRepelenteVermelho, QuantidadeRepelenteDourada;
    public static int QuantidadePilhas;
    public static int Quantidade1Pilha=100;
    public static int Quantidade1AguaSanitariaAzul = 100;
    public static int Quantidade1AguaSanitariaVermelha = 100;
    public static int Quantidade1AguaSanitariaDourada = 100;
    public static int ArmaUsada = 0;
    public static bool pausa = false;
    public static int Fase = 1;
    public static int tecnologia = 2;//1=tela,2=rv+controle,3=controle
    public static bool RV = true;

    public static void resetRam()
    {
        AguaSanitariaAzul = AguaSanitariaVermelha = AguaSanitariaDourada = RepelenteAzul = RepelenteVermelho = RepelenteDourada = 0;
        QuantidadeAguaSanitariaAzul = 100; QuantidadeAguaSanitariaVermelha = 100; QuantidadeAguaSanitariaDourada = 100; QuantidadeRepelenteAzul = QuantidadeRepelenteVermelho = QuantidadeRepelenteDourada = 0;
        QuantidadePilhas = 0;
        Quantidade1Pilha = 100;
        Quantidade1AguaSanitariaAzul = 100;
        Quantidade1AguaSanitariaVermelha = 100;
        Quantidade1AguaSanitariaDourada = 100;
        ArmaUsada = 0;
        RaqueteAzul = RaqueteVermelha = RaqueteDourada = false;
    }
}



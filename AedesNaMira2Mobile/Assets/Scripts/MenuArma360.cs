using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuArma360 : MonoBehaviour
{
    public int IDItem = 1;
    public Image Arma, Cadeado;
    public Sprite RaqueteAzul, RaqueteVermelha, RaqueteDourada, AguaSanitariaAzul, AguaSanitariaVermelha, AguaSanitariaDourada, RepelenteAzul, RepelenteVermelho, RepelenteDourada, Pilha;
    public Text Preco, Info, Nome, Bloqueio, Grana;   
    public Input360 input;
    public DadosFase dadosFase;
    public ControleDificuldade nivelDificuldade;
    public MenuControle360 menuControle360; 
    // Start is called before the first frame update
    void Start()
    {
        dadosFase= GameObject.FindGameObjectWithTag("Gerenciar").GetComponent<DadosFase>();
        nivelDificuldade= GameObject.FindGameObjectWithTag("Gerenciar").GetComponent<ControleDificuldade>();
        Reset();
    }




    // Update is called once per frame
    void Update()
    {
        if (input.A.isBotao())//Buy
        {
            comprar();
        }
        else if (input.B.isBotao())//Back
        {
            Reset();
            menuControle360.ativaMenuCentral();
        }        
        else if (input.JoystickEsquerdoDireita.positivoBotao())//Avancar 
        {
            AvancarID();
        }
        else if (input.JoystickEsquerdoDireita.negativoBotao())//Voltar 
        {
            RetornarID();
        }
    }


    public void AvancarID()
    {
        IDItem++;
        if (IDItem > 10)
        {
            IDItem = 1;
        }
        selectArma();
    }

    public void RetornarID()
    {
        IDItem--;
        if (IDItem < 1)
        {
            IDItem = 10;
        }
        selectArma();
    }

    public void Reset()
    {       
        selectArma();
        Grana.text =""+dadosFase.Saldo;
    }

    public void selectArma() 
    {
        int dificuldade = nivelDificuldade.NivelDificulade;
        switch (IDItem)
        {
            case 1:                
                Arma.sprite = RaqueteAzul;
                Preco.text = "$" + 30 * dificuldade;
                Info.text = "Dano:+20";
                Nome.text = "Raquete Azul";
                Bloqueio.text = "";
                Cadeado.enabled = false;
                if (RamSystem.RaqueteAzul)
                {
                    Cadeado.enabled = true;
                    Bloqueio.text = "Limite de 1 atingido.";
                }
                break;
            case 2:               
                Arma.sprite = RaqueteVermelha;
                Preco.text = "$" + 60 * dificuldade;
                Info.text = "Dano:+50";
                Nome.text = "Raquete Vermelha";
                Cadeado.enabled = false;
                Bloqueio.text = "";
                Cadeado.enabled = false;
                if (RamSystem.RaqueteVermelha)
                {
                    Cadeado.enabled = true;
                    Bloqueio.text = "Limite de 1 atingido.";
                }
                break;
            case 3:                
                Arma.sprite = RaqueteDourada;
                Preco.text = "$" + 100 * dificuldade;
                Info.text = "Dano:+100";
                Nome.text = "Raquete Dourada";
                Bloqueio.text = "";
                Cadeado.enabled = false;
                if (RamSystem.RaqueteDourada)
                {
                    Cadeado.enabled = true;
                    Bloqueio.text = "Limite de 1 atingido.";
                }
                break;
            case 4:              
                Arma.sprite = AguaSanitariaAzul;
                Preco.text = "$" + 30 * dificuldade;
                Info.text = "Dano:+20";
                Nome.text = "Água Sanitária Azul";
                Bloqueio.text = "";
                Cadeado.enabled = false;
                if (RamSystem.AguaSanitariaAzul >= 99)
                {
                    Cadeado.enabled = true;
                    Bloqueio.text = "Limite de 99 atingido.";
                }
                break;
            case 5:               
                Arma.sprite = AguaSanitariaVermelha;
                Preco.text = "$" + 60 * dificuldade;
                Info.text = "Dano:+50";
                Nome.text = "Água Sanitária Vermelha";
                Bloqueio.text = "";
                Cadeado.enabled = false;
                if (RamSystem.AguaSanitariaVermelha >= 99)
                {
                    Cadeado.enabled = true;
                    Bloqueio.text = "Limite de 99 atingido.";
                }
                break;
            case 6:               
                Arma.sprite = AguaSanitariaDourada;
                Preco.text = "$" + 100 * dificuldade;
                Info.text = "Dano:+100";
                Nome.text = "Água Sanitária Dourada";
                Bloqueio.text = "";
                Cadeado.enabled = false;
                if (RamSystem.AguaSanitariaDourada >= 99)
                {
                    Cadeado.enabled = true;
                    Bloqueio.text = "Limite de 99 atingido.";
                }
                break;
            case 7:                
                Arma.sprite = RepelenteAzul;
                Preco.text = "$" + 20 * dificuldade;
                Info.text = "Proteção:2s";
                Nome.text = "Repelente Azul";
                Bloqueio.text = "";
                Cadeado.enabled = false;
                if (RamSystem.RepelenteAzul >= 99)
                {
                    Cadeado.enabled = true;
                    Bloqueio.text = "Limite de 99 atingido.";
                }
                break;
            case 8:                
                Arma.sprite = RepelenteVermelho;
                Preco.text = "$" + 40 * dificuldade;
                Info.text = "Proteção:3s";
                Nome.text = "Repelente Vermelho";
                Bloqueio.text = "";
                Cadeado.enabled = false;
                if (RamSystem.RepelenteVermelho >= 99)
                {
                    Cadeado.enabled = true;
                    Bloqueio.text = "Limite de 99 atingido.";
                }
                break;
            case 9:               
                Arma.sprite = RepelenteDourada;
                Preco.text = "$" + 60 * dificuldade;
                Info.text = "Proteção:5s";
                Nome.text = "Repelente Dourado";
                Bloqueio.text = "";
                Cadeado.enabled = false;
                if (RamSystem.RepelenteDourada >= 99)
                {
                    Cadeado.enabled = true;
                    Bloqueio.text = "Limite de 99 atingido.";
                }
                break;
            case 10:               
                Arma.sprite = Pilha;
                Preco.text = "$" + 20 * dificuldade;
                Nome.text = "Pilha";
                Bloqueio.text = "";
                Cadeado.enabled = false;
                if (RamSystem.QuantidadePilhas >= 99)
                {
                    Cadeado.enabled = true;
                    Bloqueio.text = "Limite de 99 atingido.";
                }
                break;           
        }
    }

    public void comprar()
    {
        int dificuldade = nivelDificuldade.NivelDificulade;
        switch (IDItem)
        {
            case 1:
                if (RamSystem.RaqueteAzul == false && dadosFase.Saldo >= 30 * dificuldade)
                {
                    RamSystem.RaqueteAzul = true;
                    dadosFase.Saldo = dadosFase.Saldo - 30 * dificuldade;
                    Cadeado.enabled = true;
                    Bloqueio.text = "Limite de 1 atingido.";
                }
                break;
            case 2:
                if (RamSystem.RaqueteVermelha == false && dadosFase.Saldo >= 60 * dificuldade)
                {
                    RamSystem.RaqueteVermelha = true;
                    dadosFase.Saldo = dadosFase.Saldo - 60 * dificuldade;
                    Cadeado.enabled = true;
                    Bloqueio.text = "Limite de 1 atingido.";
                }
                break;
            case 3:
                if (RamSystem.RaqueteDourada == false && dadosFase.Saldo >= 100 * dificuldade)
                {
                    RamSystem.RaqueteDourada = true;
                    dadosFase.Saldo = dadosFase.Saldo - 100 * dificuldade;
                    Cadeado.enabled = true;
                    Bloqueio.text = "Limite de 1 atingido.";
                }
                break;
            case 4:
                if (RamSystem.AguaSanitariaAzul < 99 && dadosFase.Saldo >= 30 * dificuldade)
                {
                    RamSystem.AguaSanitariaAzul = RamSystem.AguaSanitariaAzul + 1;
                    dadosFase.Saldo = dadosFase.Saldo - 30 * dificuldade;
                    if (RamSystem.AguaSanitariaAzul >= 99)
                    {
                        Cadeado.enabled = true;
                        Bloqueio.text = "Limite de 99 atingido.";
                    }
                }
                break;
            case 5:
                if (RamSystem.AguaSanitariaVermelha < 99 && dadosFase.Saldo >= 60 * dificuldade)
                {
                    RamSystem.AguaSanitariaVermelha = RamSystem.AguaSanitariaVermelha + 1;
                    dadosFase.Saldo = dadosFase.Saldo - 60 * dificuldade;
                    if (RamSystem.AguaSanitariaVermelha >= 99)
                    {
                        Cadeado.enabled = true;
                        Bloqueio.text = "Limite de 99 atingido.";
                    }
                }
                break;
            case 6:
                if (RamSystem.AguaSanitariaDourada < 99 && dadosFase.Saldo >= 100 * dificuldade)
                {
                    RamSystem.AguaSanitariaDourada = RamSystem.AguaSanitariaDourada + 1;
                    dadosFase.Saldo = dadosFase.Saldo - 100 * dificuldade;
                    if (RamSystem.AguaSanitariaDourada >= 99)
                    {
                        Cadeado.enabled = true;
                        Bloqueio.text = "Limite de 99 atingido.";
                    }
                }
                break;
            case 7:
                if (RamSystem.RepelenteAzul < 99 && dadosFase.Saldo >= 20 * dificuldade)
                {
                    RamSystem.RepelenteAzul = RamSystem.RepelenteAzul + 1;
                    dadosFase.Saldo = dadosFase.Saldo - 20 * dificuldade;
                    if (RamSystem.RepelenteAzul >= 99)
                    {
                        Cadeado.enabled = true;
                        Bloqueio.text = "Limite de 99 atingido.";
                    }
                }
                break;
            case 8:
                if (RamSystem.RepelenteVermelho < 99 && dadosFase.Saldo >= 40 * dificuldade)
                {
                    RamSystem.RepelenteVermelho = RamSystem.RepelenteVermelho + 1;
                    dadosFase.Saldo = dadosFase.Saldo - 40 * dificuldade;
                    if (RamSystem.RepelenteVermelho >= 99)
                    {
                        Cadeado.enabled = true;
                        Bloqueio.text = "Limite de 99 atingido.";
                    }
                }
                break;
            case 9:
                if (RamSystem.RepelenteDourada < 99 && dadosFase.Saldo >= 60 * dificuldade)
                {
                    RamSystem.RepelenteDourada = RamSystem.RepelenteDourada + 1;
                    dadosFase.Saldo = dadosFase.Saldo - 60 * dificuldade;
                    if (RamSystem.RepelenteDourada >= 99)
                    {
                        Cadeado.enabled = true;
                        Bloqueio.text = "Limite de 99 atingido.";
                    }
                }
                break;
            case 10:
                if (RamSystem.QuantidadePilhas < 99 && dadosFase.Saldo >= 20 * dificuldade)
                {
                    RamSystem.QuantidadePilhas = RamSystem.QuantidadePilhas + 1;
                    dadosFase.Saldo = dadosFase.Saldo - 20 * dificuldade;

                    if (RamSystem.QuantidadePilhas >= 99)
                    {
                        Cadeado.enabled = true;
                        Bloqueio.text = "Limite de 99 atingido.";
                    }
                }
                break;


        }

        Grana.text = "" + dadosFase.Saldo;
    }

}

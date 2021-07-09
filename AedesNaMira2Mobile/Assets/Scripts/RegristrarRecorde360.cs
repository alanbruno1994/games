using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class RegristrarRecorde360 : MonoBehaviour
{
    public int idColuna, idLinha;
    public Image[] images;
    public Sprite nada, selecionado;
    public Input360 input;
    public int numero;
    public string letraPega;
    public Text NomeFormado;
    public FimGame fim;
    // Start is called before the first frame update
    void Start()
    {
        idColuna = idLinha = -1;
        numero = -1;
        letraPega = "";
    }


    public void Reset()
    {
        for (int i = 0; i < images.Length; i++)
        {
            images[i].sprite = nada;
        }
    }





    // Update is called once per frame
    void Update()
    {
        if (input.JoystickEsquerdoCima.negativoBotao())//Avancar ID
        {
            avancarLinha();
        }
        else if (input.JoystickEsquerdoCima.positivoBotao())//Retorna ID
        {
            voltarLinha();
        }
        else if (input.JoystickEsquerdoDireita.positivoBotao())//Avancar Options
        {
            avancarColuna();
        }
        else if (input.JoystickEsquerdoDireita.negativoBotao())//Voltar Options
        {
            voltarColuna();
        }
        else if (input.A.isBotao())
        {
            if (NomeFormado.text.Length <= 6)
            {
                NomeFormado.text = NomeFormado.text + letraPega;
            }
        }
        else if (input.X.isBotao())//CLEAR
        {
            string valor = NomeFormado.text;
            if (valor.Length == 1)
            {
                valor = "";
            }
            else if (valor.Length > 1)
            {
                valor = valor.Substring(0, valor.Length - 1);
            }
            NomeFormado.text = valor;
        }
        else if (input.start.isBotao())//Registrar
        {
            fim.RegistrarRecorde();
        }
    }


    public void avancarLinha()
    {
        idLinha++;
        if (idLinha > 5)
        {
            idLinha = 0;
        }
        gerarNumero();
    }

    public void voltarLinha()
    {
        idLinha--;
        if (idLinha < 0)
        {
            idLinha = 5;
        }
        gerarNumero();
    }


    public void avancarColuna()
    {
        idColuna++;
        if (idColuna > 5)
        {
            idColuna = 0;
        }
        gerarNumero();
    }

    public void voltarColuna()
    {
        idColuna--;
        if (idColuna < 0)
        {
            idColuna = 5;
        }
        gerarNumero();
    }

    public void gerarNumero()
    {
        if (idLinha == 0)
        {
            numero = idColuna;
        }
        else if (idLinha == 1)
        {
            numero = 6 + idColuna;
        }
        else if (idLinha == 2)
        {
            numero = 12 + idColuna;
        }
        else if (idLinha == 3)
        {
            numero = 18 + idColuna;
        }
        else if (idLinha == 4)
        {
            numero = 24 + idColuna;
        }
        else if (idLinha == 5)
        {
            numero = 30 + idColuna;
        }
        letraSelect();
    }


    public void letraSelect()
    {
        Reset();
        switch (numero)
        {
            case 0:
                letraPega = "Q";
                images[numero].sprite = selecionado;
                break;
            case 1:
                letraPega = "W";
                images[numero].sprite = selecionado;
                break;
            case 2:
                letraPega = "E";
                images[numero].sprite = selecionado;
                break;
            case 3:
                letraPega = "R";
                images[numero].sprite = selecionado;
                break;
            case 4:
                letraPega = "T";
                images[numero].sprite = selecionado;
                break;
            case 5:
                letraPega = "Y";
                images[numero].sprite = selecionado;
                break;
            case 6:
                letraPega = "A";
                images[numero].sprite = selecionado;
                break;
            case 7:
                letraPega = "S";
                images[numero].sprite = selecionado;
                break;
            case 8:
                letraPega = "D";
                images[numero].sprite = selecionado;
                break;
            case 9:
                letraPega = "F";
                images[numero].sprite = selecionado;
                break;
            case 10:
                letraPega = "G";
                images[numero].sprite = selecionado;
                break;
            case 11:
                letraPega = "H";
                images[numero].sprite = selecionado;
                break;
            case 12:
                letraPega = "Z";
                images[numero].sprite = selecionado;
                break;
            case 13:
                letraPega = "X";
                images[numero].sprite = selecionado;
                break;
            case 14:
                letraPega = "C";
                images[numero].sprite = selecionado;
                break;
            case 15:
                letraPega = "V";
                images[numero].sprite = selecionado;
                break;
            case 16:
                letraPega = "B";
                images[numero].sprite = selecionado;
                break;
            case 17:
                letraPega = "N";
                images[numero].sprite = selecionado;
                break;
            case 18:
                letraPega = "U";
                images[numero].sprite = selecionado;
                break;
            case 19:
                letraPega = "I";
                images[numero].sprite = selecionado;
                break;
            case 20:
                letraPega = "O";
                images[numero].sprite = selecionado;
                break;
            case 21:
                letraPega = "P";
                images[numero].sprite = selecionado;
                break;
            case 22:
                letraPega = "J";
                images[numero].sprite = selecionado;
                break;
            case 23:
                letraPega = "K";
                images[numero].sprite = selecionado;
                break;
            case 24:
                letraPega = "L";
                images[numero].sprite = selecionado;
                break;
            case 25:
                letraPega = "M";
                images[numero].sprite = selecionado;
                break;
            case 26:
                letraPega = "1";
                images[numero].sprite = selecionado;
                break;
            case 27:
                letraPega = "2";
                images[numero].sprite = selecionado;
                break;
            case 28:
                letraPega = "3";
                images[numero].sprite = selecionado;
                break;
            case 29:
                letraPega = "4";
                images[numero].sprite = selecionado;
                break;
            case 30:
                letraPega = "5";
                images[numero].sprite = selecionado;
                break;
            case 31:
                letraPega = "6";
                images[numero].sprite = selecionado;
                break;
            case 32:
                letraPega = "7";
                images[numero].sprite = selecionado;
                break;
            case 33:
                letraPega = "8";
                images[numero].sprite = selecionado;
                break;
            case 34:
                letraPega = "9";
                images[numero].sprite = selecionado;
                break;
            case 35:
                letraPega = "0";
                images[numero].sprite = selecionado;
                break;


        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPrincipalPausa : MonoBehaviour
{
    public int id = 0;
    public Image Return,CompraArma, Record, Options, Exit;
    public Sprite nada, selecionado;
    public Input360 input;
    public MenuControle360 menuControle360;
    public GameObject Pausa;

    void Start()
    {
        Reset();
    }

    public void Reset()
    {
        Return.sprite = nada;
        CompraArma.sprite = nada;     
        Record.sprite = nada;
        Options.sprite = nada;
        Exit.sprite = nada;
    }

    // Update is called once per frame
    void Update()
    {
        if (input.A.isBotao())//Select
        {
            switch (id)
            {
                case 1://Return
                    RamSystem.pausa = false;
                    Destroy(Pausa);                   
                    break;
                case 2://Arma
                    menuControle360.ativaCompraArma();
                    break;            
                case 3://Record
                    menuControle360.ativaRecord();
                    break;
                case 4://Options
                    menuControle360.ativaOptions();
                    break;
                case 5://Sair
                    SceneManager.LoadScene("Menu_RV");
                    break;
            }
        }
        else if (input.JoystickEsquerdoCima.negativoBotao())//Avancar ID
        {
            AvancarID();
        }
        else if (input.JoystickEsquerdoCima.positivoBotao())//Retorna ID
        {
            RetornarID();
        }

    }


    public void AvancarID()
    {
        id++;
        if (id > 5)
        {
            id = 1;
        }
        mudarItem();
    }

    public void RetornarID()
    {
        id--;
        if (id < 1)
        {
            id = 5;
        }
        mudarItem();
    }

    private void mudarItem()
    {
        switch (id)
        {
            case 1://Return
                Return.sprite = selecionado;
                CompraArma.sprite = nada;              
                Record.sprite = nada;
                Options.sprite = nada;
                Exit.sprite = nada;
                break;
            case 2://Arma
                Return.sprite = nada;
                CompraArma.sprite = selecionado;               
                Record.sprite = nada;
                Options.sprite = nada;
                Exit.sprite = nada;
                break;         
            case 3://Record
                Return.sprite = nada;
                CompraArma.sprite = nada;           
                Record.sprite = selecionado;
                Options.sprite = nada;
                Exit.sprite = nada;
                break;
            case 4://Options
                Return.sprite = nada;
                CompraArma.sprite = nada;               
                Record.sprite = nada;
                Options.sprite = selecionado;
                Exit.sprite = nada;
                break;
            case 5://Exit
                Return.sprite = nada;
                CompraArma.sprite = nada;               
                Record.sprite = nada;
                Options.sprite = nada;
                Exit.sprite = selecionado;
                break;


        }
    }
}

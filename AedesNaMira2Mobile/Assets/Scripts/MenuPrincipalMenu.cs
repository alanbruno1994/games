using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class MenuPrincipalMenu : MonoBehaviour
{
    public int id=0;
    public Image Play, Record, Options, Exit;
    public Sprite nada, selecionado;
    public Input360 input;
    public MenuControle360 menuControle360;
    
    void Start()
    {
        Reset();
    }

    public void Reset()
    {
        Play.sprite = nada;
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
                case 1:
                    menuControle360.ativaPlay();
                    break;
                case 2:
                    menuControle360.ativaRecord();
                    break;
                case 3:
                    menuControle360.ativaOptions();
                    break;
                case 4:
                    Application.Quit();
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
        if (id > 4)
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
            id = 4;
        }
        mudarItem();
    }

    private void mudarItem()
    {
        switch (id)
        {
            case 1://Play
                Play.sprite = selecionado;
                Record.sprite = nada;
                Options.sprite = nada;
                Exit.sprite = nada;
                break;
            case 2://Record
                Play.sprite = nada;
                Record.sprite = selecionado;
                Options.sprite = nada;
                Exit.sprite = nada;
                break;
            case 3://Options
                Play.sprite = nada;
                Record.sprite = nada;
                Options.sprite = selecionado;
                Exit.sprite = nada;
                break;
            case 4://Exit
                Play.sprite = nada;
                Record.sprite = nada;
                Options.sprite = nada;
                Exit.sprite = selecionado;
                break;
            

        }
    }
}

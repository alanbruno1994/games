using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botao 
{
    private KeyCode botao;

    public Botao(string text) 
    {
        botao = pegarButao(text);
    }

    public bool isBotao() 
    {
        if (Input.GetKeyDown(botao)) 
        {
            return true;
        }
        return false;
    }

    public KeyCode pegarButao(string valueButton) 
    {
        if (valueButton== "JoystickButton0") 
        {
            return KeyCode.JoystickButton0;
        }
        if (valueButton == "JoystickButton1")
        {
            return KeyCode.JoystickButton1;
        }
        if (valueButton == "JoystickButton2")
        {
            return KeyCode.JoystickButton2;
        }
        if (valueButton == "JoystickButton3")
        {
            return KeyCode.JoystickButton3;
        }
        if (valueButton == "JoystickButton4")
        {
            return KeyCode.JoystickButton4;
        }
        if (valueButton == "JoystickButton5")
        {
            return KeyCode.JoystickButton5;
        }
        if (valueButton == "JoystickButton6")
        {
            return KeyCode.JoystickButton6;
        }
        if (valueButton == "JoystickButton7")
        {
            return KeyCode.JoystickButton7;
        }
        if (valueButton == "JoystickButton8")
        {
            return KeyCode.JoystickButton8;
        }
        if (valueButton == "JoystickButton9")
        {
            return KeyCode.JoystickButton9;
        }
        if (valueButton == "JoystickButton10")
        {
            return KeyCode.JoystickButton10;
        }
        if (valueButton == "JoystickButton11")
        {
            return KeyCode.JoystickButton11;
        }
        if (valueButton == "JoystickButton12")
        {
            return KeyCode.JoystickButton12;
        }
        if (valueButton == "JoystickButton13")
        {
            return KeyCode.JoystickButton13;
        }
        if (valueButton == "JoystickButton14")
        {
            return KeyCode.JoystickButton14;
        }
        if (valueButton == "JoystickButton15")
        {
            return KeyCode.JoystickButton15;
        }
        if (valueButton == "JoystickButton16")
        {
            return KeyCode.JoystickButton16;
        }
        if (valueButton == "JoystickButton17")
        {
            return KeyCode.JoystickButton17;
        }
        if (valueButton == "JoystickButton18")
        {
            return KeyCode.JoystickButton18;
        }
        if (valueButton == "JoystickButton19")
        {
            return KeyCode.JoystickButton19;
        }
        return KeyCode.None;
    }
}

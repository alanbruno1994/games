using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butao
{
    private KeyCode butao;

    public Butao(string text)
    {
        butao = pegarButao(text);
    }



    public bool isButao()
    {
        if (Input.GetKeyDown(butao))
        {
            return true;
        }
        return false;
    }


    public KeyCode pegarButao(string valueButao)
    {
        if (valueButao == "JoystickButton0")
        {
            return KeyCode.JoystickButton0;
        }
        if (valueButao == "JoystickButton1")
        {
            return KeyCode.JoystickButton1;
        }
        if (valueButao == "JoystickButton2")
        {
            return KeyCode.JoystickButton2;
        }
        if (valueButao == "JoystickButton3")
        {
            return KeyCode.JoystickButton3;
        }
        if (valueButao == "JoystickButton4")
        {
            return KeyCode.JoystickButton4;
        }
        if (valueButao == "JoystickButton5")
        {
            return KeyCode.JoystickButton5;
        }
        if (valueButao == "JoystickButton6")
        {
            return KeyCode.JoystickButton6;
        }
        if (valueButao == "JoystickButton7")
        {
            return KeyCode.JoystickButton7;
        }
        if (valueButao == "JoystickButton8")
        {
            return KeyCode.JoystickButton8;
        }
        if (valueButao == "JoystickButton9")
        {
            return KeyCode.JoystickButton9;
        }
        if (valueButao == "JoystickButton10")
        {
            return KeyCode.JoystickButton10;
        }
        if (valueButao == "JoystickButton11")
        {
            return KeyCode.JoystickButton11;
        }
        if (valueButao == "JoystickButton12")
        {
            return KeyCode.JoystickButton12;
        }
        if (valueButao == "JoystickButton13")
        {
            return KeyCode.JoystickButton13;
        }
        if (valueButao == "JoystickButton14")
        {
            return KeyCode.JoystickButton14;
        }
        if (valueButao == "JoystickButton15")
        {
            return KeyCode.JoystickButton15;
        }
        if (valueButao == "JoystickButton16")
        {
            return KeyCode.JoystickButton16;
        }
        if (valueButao == "JoystickButton17")
        {
            return KeyCode.JoystickButton17;
        }
        if (valueButao == "JoystickButton18")
        {
            return KeyCode.JoystickButton18;
        }
        if (valueButao == "JoystickButton19")
        {
            return KeyCode.JoystickButton19;
        }
        return KeyCode.None;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger
{
    public string trigger;
    public bool time;
    public int inverte;
    public int id;

    public Trigger(string texto, int direcao)
    {
        trigger = texto;
        inverte = direcao;
        time = false;
    }

    public Trigger(string texto, int direcao, int id)
    {
        trigger = texto;
        inverte = direcao;
        time = false;
        this.id = id;
    }

    public bool positivoBotao() 
    {
        if (Input.GetAxis(trigger)*inverte>=0.5f && time==false) 
        {
            time = true;
            return true;
        }
        return false;    
    }

    public bool negativoBotao()
    {
        if (Input.GetAxis(trigger) * inverte <= -0.5f && time == false)
        {
            time = true;
            return true;
        }
        return false;
    }

    public bool chequeTime(int contador) 
    {
        if (time && contador>=20) 
        {
            time = false;
        }
        return time;
    }

    public float return_Value() 
    {
        return Input.GetAxis(trigger) * inverte;
    }

    public bool RT() 
    {
        if (id==1)
        {
            if (inverte == -1)
            {
                if (Input.GetAxis(trigger) * -1 >= 0.5f && time == false)
                {
                    time = true;
                    return true;
                }
            }
            else 
            {
                if (Input.GetAxis(trigger)>=0.5f && time==false)
                {
                    time = true;
                    return true;
                } 
            
            }
        
        }
        return false;
    }

    public bool LT()
    {
        if (id == 2)
        {
            if (inverte == -1)
            {
                if (Input.GetAxis(trigger) * -1 >= 0.5f && time == false)
                {
                    time = true;
                    return true;
                }
            }
            else
            {
                if (Input.GetAxis(trigger) >= 0.5f && time == false)
                {
                    time = true;
                    return true;
                }

            }

        }
        return false;
    }
}
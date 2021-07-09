using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntegerKey 
{
    private KeyCode value = new KeyCode();

    public void setValue(KeyCode va) 
    {
        value = va;    
    }


    public KeyCode getValue() 
    {
        return value;    
    }
}

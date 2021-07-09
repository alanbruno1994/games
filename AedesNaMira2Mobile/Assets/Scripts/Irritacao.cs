using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Irritacao : MonoBehaviour
{
    public int i = 0;
    // Start is called before the first frame update   
    public Color color;
    public RawImage raw;
    void Start()
    {
        i = 0;
    }

    void FixedUpdate()
    {
        i++;
        if (i<5) 
        {
            color.a = 0.1f;
        }else if (i < 10)
        {
            color.a = 0.2f;          
        }
        else if (i < 15)
        {
            color.a = 0.3f;
        }
        else if (i < 20)
        {
            color.a = 0.4f;
        }
        else if (i < 25)
        {
            color.a = 0.5f;
        }
        else if (i < 30)
        {
            color.a = 0.6f;
        }
        else if (i < 35)
        {
            color.a = 0.7f;
        }
        else if (i < 40)
        {
            color.a = 0.8f;
        }
        else if (i < 45)
        {
            color.a = 0.9f;
        }
        else if (i < 50)
        {
            color.a = 1;
        }
        else if (i < 55)
        {
            color.a = 0;
            i = 0;
        }
        raw.color = color;
    }
}

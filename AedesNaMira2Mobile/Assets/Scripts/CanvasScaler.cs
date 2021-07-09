using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScaler : MonoBehaviour
{
    public Canvas canvas;
    public bool inicio;
    // Start is called before the first frame update
    void Start()
    {
        if (inicio==false) {
            if (Screen.width == 2340 && Screen.height == 1080 || Screen.width == 2160 && Screen.height == 1080 || Screen.width == 1920 && Screen.height == 1080)
            {
                canvas.scaleFactor = 1.5f;
            }
            else if (Screen.width == 1280 && Screen.height == 720)
            {
                canvas.scaleFactor = 1;
            }
            else if (Screen.width == 2960 && Screen.height == 1440)
            {
                canvas.scaleFactor = 2;
            }
            else if (Screen.width == 800 && Screen.height == 480)
            {
                canvas.scaleFactor = 0.5f;
            }
            else if (Screen.width == 320 && Screen.height == 240)
            {
                canvas.scaleFactor = 0.25f;
            }
        }
        else 
        {
            if (Screen.width == 2340 && Screen.height == 1080 || Screen.width == 2160 && Screen.height == 1080 || Screen.width == 1920 && Screen.height == 1080)
            {
                canvas.scaleFactor = 1;
            }
            else if (Screen.width == 1280 && Screen.height == 720)
            {
                canvas.scaleFactor = 0.532f;
            }
            else if (Screen.width == 2960 && Screen.height == 1440)
            {
                canvas.scaleFactor = 1.27f;
            }
            else if (Screen.width == 800 && Screen.height == 480)
            {
                canvas.scaleFactor = 0.34f;
            }
            else if (Screen.width == 320 && Screen.height == 240)
            {
                canvas.scaleFactor = 0.124f;
            }

        }

    }

    // Update is called once per frame
   
}

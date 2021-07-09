using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamAjuste : MonoBehaviour
{
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        if (Screen.width == 800 && Screen.height == 600)
        {
            camera.focalLength = 24;
        }
        else if (Screen.width == 2560 && Screen.height == 1440)
        {
            camera.focalLength = 17;
        }
        else if (Screen.width == 3840 && Screen.height == 2160)
        {
            camera.focalLength = 17;
        }
        else if (Screen.width == 320 && Screen.height == 240)
        {
            camera.focalLength = 22.5f;
        }
        else if (Screen.width == 1920 && Screen.height == 1080)
        {
            camera.focalLength = 18;
        }
        else if (Screen.width == 1280 && Screen.height == 720)
        {
            camera.focalLength = 18;
        }
        else if (Screen.width == 1136 && Screen.height == 640)
        {
            camera.focalLength = 18;
        }
        else if (Screen.width == 1134 && Screen.height == 750)
        {
            camera.focalLength = 19.8f;
        }
        else if (Screen.width == 640 && Screen.height == 360)
        {
            camera.focalLength = 17;
        }
        else if (Screen.width == 640 && Screen.height == 480)
        {
            camera.focalLength = 22.4f;
        }
        else if (Screen.width == 960 && Screen.height == 540)
        {
            camera.focalLength = 17;
        }
        else if (Screen.width == 800 && Screen.height == 480)
        {
            camera.focalLength = 17.9f;
        }
        else if (Screen.width == 2960 && Screen.height == 1440)
        {
            camera.focalLength = 17.6f;
        }//tela_2160_1080
        else if (Screen.width == 2160 && Screen.height == 1080)
        {
            camera.focalLength = 15.2f;
        }
    }

}

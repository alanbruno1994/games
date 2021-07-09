using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTela : MonoBehaviour
{
    public GameObject tela_800_600, tela_2560_1440, tela_3840_2160, tela_320_240, tela_1920_1080, tela_1280_720, tela_1136_640, tela_1134_750, tela_640_360, tela_640_480, tela_960_540,tela_2960_1440,tela_800_480,tela_2160_1080;

    // Start is called before the first frame update
    void Awake()
    {
        if (Screen.width == 800 && Screen.height == 600)
        {
            Instantiate(tela_800_600, tela_800_600.transform.position, tela_800_600.transform.rotation);
        }
        else if (Screen.width == 2560 && Screen.height == 1440)
        {
            Instantiate(tela_2560_1440, tela_2560_1440.transform.position, tela_2560_1440.transform.rotation);

        }
        else if (Screen.width == 3840 && Screen.height == 2160)
        {
            Instantiate(tela_3840_2160, tela_3840_2160.transform.position, tela_3840_2160.transform.rotation);
        }
        else if (Screen.width == 320 && Screen.height == 240)
        {
            Instantiate(tela_320_240, tela_320_240.transform.position, tela_320_240.transform.rotation);
        }
        else if (Screen.width == 1920 && Screen.height == 1080)
        {
            Instantiate(tela_1920_1080, tela_1920_1080.transform.position, tela_1920_1080.transform.rotation);
        }
        else if (Screen.width == 1280 && Screen.height == 720)
        {
            Instantiate(tela_1280_720, tela_1280_720.transform.position, tela_1280_720.transform.rotation);
        }
        else if (Screen.width == 1136 && Screen.height == 640)
        {
            Instantiate(tela_1136_640, tela_1136_640.transform.position, tela_1136_640.transform.rotation);
        }
        else if (Screen.width == 1134 && Screen.height == 750)
        {
            Instantiate(tela_1134_750, tela_1134_750.transform.position, tela_1134_750.transform.rotation);
        }
        else if (Screen.width == 640 && Screen.height == 360)
        {
            Instantiate(tela_640_360, tela_640_360.transform.position, tela_640_360.transform.rotation);
        }
        else if (Screen.width == 640 && Screen.height == 480)
        {
            Instantiate(tela_640_480, tela_640_480.transform.position, tela_640_480.transform.rotation);
        }
        else if (Screen.width == 960 && Screen.height == 540)
        {
            Instantiate(tela_960_540, tela_960_540.transform.position, tela_960_540.transform.rotation);
        }
        else if (Screen.width == 800 && Screen.height == 480)
        {
            Instantiate(tela_800_480, tela_800_480.transform.position, tela_800_480.transform.rotation);
        }
        else if (Screen.width == 2960 && Screen.height == 1440)
        {
            Instantiate(tela_2960_1440, tela_2960_1440.transform.position, tela_2960_1440.transform.rotation);
        }//tela_2160_1080
        else if (Screen.width == 2160 && Screen.height == 1080)
        {
            Instantiate(tela_2160_1080, tela_2160_1080.transform.position, tela_2160_1080.transform.rotation);
        }
        else
        {
            Instantiate(tela_800_600, tela_800_600.transform.position, tela_800_600.transform.rotation);
        }

    }
}
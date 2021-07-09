using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.XR;
using UnityEngine.XR;

public class TecnlogoyEscolha : MonoBehaviour
{
    public GameObject HeroiRV,GameCamera, HeroiMobile,HeroiControle;
    // Start is called before the first frame update
    void Awake()
    {

        switch (RamSystem.tecnologia) 
        {
            case 1:
                XRSettings.enabled = false;
                Instantiate(HeroiMobile);
                break;
            case 2:
                XRSettings.enabled = true;
                Instantiate(HeroiRV);
                Instantiate(GameCamera);
                break;
            case 3:
                XRSettings.enabled = false;
                Instantiate(HeroiControle);
                break;
        
        }      
    }

    // Update is called once per frame
    
}

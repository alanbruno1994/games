using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class MenuControle360 : MonoBehaviour
{  
    public GameObject Options,Record,CompraArma,Play,MenuCental;    
    public int id=0;
    public bool pausa;

    // Start is called before the first frame update
    void Start()
    {
        XRSettings.enabled = true;
        ativaMenuCentral();
        if (pausa) 
        {
            RamSystem.pausa = true;
        }
    }


    public void ativaMenuCentral() 
    {
        MenuCental.SetActive(true);
        Options.SetActive(false);
        Record.SetActive(false);
        if (pausa)
        {
            CompraArma.SetActive(false);
          
        }
        else
        {
            Play.SetActive(false);
        }
    }

    public void ativaOptions()
    {
        MenuCental.SetActive(false);
        Options.SetActive(true);
        Record.SetActive(false);
        if (pausa)
        {
            CompraArma.SetActive(false);
            
        }
        else
        {
            Play.SetActive(false);
        }
    }


    public void ativaRecord()
    {
        MenuCental.SetActive(false);
        Options.SetActive(false);
        Record.SetActive(true);
        Record.GetComponent<Recorde360>().CaptureValores();
        if (pausa)
        {
            CompraArma.SetActive(false);
           
        }
        else
        {
            Play.SetActive(false);
        }
    }


    public void ativaPlay()
    {
        MenuCental.SetActive(false);
        Options.SetActive(false);
        Record.SetActive(false);
        if (pausa)
        {
            CompraArma.SetActive(false);
            
        }
        else
        {
            Play.SetActive(true);
        }
    }


    public void ativaCompraArma()
    {
        MenuCental.SetActive(false);
        Options.SetActive(false);
        Record.SetActive(false);
        if (pausa)
        {
            CompraArma.SetActive(true);
          
        }
        else
        {
            Play.SetActive(false);
        }
    }

    


}

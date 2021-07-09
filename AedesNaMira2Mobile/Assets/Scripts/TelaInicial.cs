using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR;

public class TelaInicial : MonoBehaviour
{
    public GameObject Tudo, SelectTecnology, ConfiguraManual;
    public GameObject Aguarde;
  //  public bool RV;
    
    // Start is called before the first frame update
    void Awake()
    {
        XRSettings.enabled = false;
        Aguarde.SetActive(false);
        Tudo.SetActive(true);
        SelectTecnology.SetActive(true);
        ConfiguraManual.SetActive(false);
    }


    public void escolhaTela()
    {
        AtivaAguarde();
        RamSystem.tecnologia = 1;
        SceneManager.LoadScene("Menu",LoadSceneMode.Single);
    }

   
    public void AtivaAguarde() 
    {
        Tudo.SetActive(false);
        Aguarde.SetActive(true);
    }

    


    public void escolhaControleRV()
    {
        RamSystem.tecnologia = 2;
        SelectTecnology.SetActive(false);
        ConfiguraManual.SetActive(true);
    }

    public void escolhaControle()
    {
        RamSystem.tecnologia = 3;
        SelectTecnology.SetActive(false);
        ConfiguraManual.SetActive(true);
    }


    


    }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Placar : MonoBehaviour
{
    public Text nome,ponto, mosquitoNormal, MosquitoDengue, MosquitoChikungunya, MosquitoZika, Focos;

    void Start()
    {
        configurarPlacar();
    }


    public void configurarPlacar()
    {
        nome.text= PlayerPrefs.GetString("Nome");
        ponto.text=""+ PlayerPrefs.GetFloat("Ponto");
        mosquitoNormal.text = "" + PlayerPrefs.GetInt("MosquitoNormal");
        MosquitoDengue.text = "" + PlayerPrefs.GetInt("MosquitoDengue");
        MosquitoChikungunya.text = "" + PlayerPrefs.GetInt("MosquitoChikungunya");
        MosquitoZika.text = "" + PlayerPrefs.GetInt("MosquitoZika");
        Focos.text = "" + PlayerPrefs.GetInt("Focos");
    }

 

    
}

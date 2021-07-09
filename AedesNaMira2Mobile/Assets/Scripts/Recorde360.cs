using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recorde360 : MonoBehaviour
{
    public Text nome, ponto, mosquitoNormal, MosquitoDengue, MosquitoChikungunya, MosquitoZika, Focos;
    public MenuControle360 menu;
    public Input360 input;
    // Start is called before the first frame update
    void Start()
    {
        CaptureValores();


    }

    public void CaptureValores() 
    {
        if (PlayerPrefs.HasKey("Nome") == false)
        {
            nome.text = PlayerPrefs.GetString("Nome");
            ponto.text = "" + PlayerPrefs.GetFloat("Ponto");
            mosquitoNormal.text = "" + PlayerPrefs.GetInt("MosquitoNormal");
            MosquitoDengue.text = "" + PlayerPrefs.GetInt("MosquitoDengue");
            MosquitoChikungunya.text = "" + PlayerPrefs.GetInt("MosquitoChikungunya");
            MosquitoZika.text = "" + PlayerPrefs.GetInt("MosquitoZika");
            Focos.text = "" + PlayerPrefs.GetInt("Focos");
        }

        nome.text = "";
        ponto.text = "";
        mosquitoNormal.text = "";
        MosquitoDengue.text = "";
        MosquitoChikungunya.text = "";
        MosquitoZika.text = "";
        Focos.text = "";
    }

    void Update()
    {
        if (input.B.isBotao())//Retorna
        {
            menu.ativaMenuCentral();
        }
    }
    
}

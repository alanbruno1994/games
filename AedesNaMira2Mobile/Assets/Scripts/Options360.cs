using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Options360 : MonoBehaviour
{
    public Input360 input;
    public int id = 0;
    public Image Antialiasing, Anisotropic, Sombras, FPS, Music, Effects;
    public Sprite Nada, Selecionado;
    public MenuControle360 menuControle360;
    public int idAnisotropic, idAntialising, idShadows, idFPS;
    public float idMusica, idEfeitos;
    public Text TextAnisotropic, TextAntialising, TextShadows,TextFPS;
    public Slider sMusic, sEffects;
    // Start is called before the first frame update
    void Start()
    {
        Reset();
    }


    public void Reset()
    {
        Antialiasing.sprite = Nada;
        Anisotropic.sprite = Nada;
        Sombras.sprite = Nada;      
        FPS.sprite = Nada;
        Music.sprite = Nada;
        Effects.sprite = Nada;
        id = 0;
        if (PlayerPrefs.HasKey("Sombras"))
        {
            idAnisotropic = PlayerPrefs.GetInt("Anisotropic");//0 Extremo,1 Alto,2 Medio,3 Baixo
            idAntialising = PlayerPrefs.GetInt("antiAliasing");//0 Extremo,1 Alto,2 Medio,3 Baixo
            idShadows = PlayerPrefs.GetInt("Sombras");//0 Extremo,1 Alto,2 Medio,3 Baixo           
            idFPS = PlayerPrefs.GetInt("Estabilidade");//0 60,1 30, 2 sem esta
            idMusica = PlayerPrefs.GetFloat("Musica");
            idEfeitos = PlayerPrefs.GetFloat("Efeitos");
        }
        else
        {
            PlayerPrefs.SetInt("Anisotropic", 1);//0 Ativado 1 Desatividado
            PlayerPrefs.SetInt("antiAliasing", 2);//0 Desativado,1 Alto,2 Medio,3 Baixo
            PlayerPrefs.SetInt("Sombras", 0);//0 Desativado,1 Extremo,2 Alto,3 Medio,4 Baixo
            PlayerPrefs.SetInt("Estabilidade", 1);//0 60,1 30, 2 sem esta         
            PlayerPrefs.SetFloat("Musica", 1);
            PlayerPrefs.SetFloat("Efeitos", 0.5f);
        }

        switch (idAnisotropic)
        {
            case 0:
                TextAnisotropic.text = "Ativado";
                break;
            case 1:
                TextAnisotropic.text = "Desativado";
                break;            
        }

        switch (idAntialising)
        {
            case 0:
                TextAntialising.text = "Desativado";
                break;
            case 1:
                TextAntialising.text = "Alto";
                break;
            case 2:
                TextAntialising.text = "Medio";
                break;
            case 3:
                TextAntialising.text = "Baixo";
                break;
        }

        switch (idShadows)
        {           
            case 0:
                TextShadows.text = "Nenhuma";
                break;
            case 1:
                TextShadows.text = "Extrema";
                break;
            case 2:
                TextShadows.text = "Alta";
                break;
            case 3:
                TextShadows.text = "Media";
                break;
            case 4:
                TextShadows.text = "Baixa";
                break;
        }


        switch (idFPS)
        {
            case 0:
                TextFPS.text = "60 FPS";
                break;
            case 1:
                TextFPS.text = "30 FPS";
                break;
            case 2:
                TextFPS.text = "None";
                break;
        }
        sMusic.value = idMusica;
        sEffects.value = idEfeitos;
    }


    // Update is called once per frame
    void Update()
    {
        if (input.A.isBotao())//Applay
        {
            PlayerPrefs.SetInt("Anisotropic", idAnisotropic);//0 Ativado 1 Desatividado
            PlayerPrefs.SetInt("antiAliasing", idAntialising);//0 Desativado,1 Alto,2 Medio,3 Baixo
            PlayerPrefs.SetInt("Sombras", idShadows);//0 Desativado,1 Extremo,2 Alto,3 Medio,4 Baixo
            PlayerPrefs.SetInt("Estabilidade", idFPS);//0 60,1 30, 2 sem esta         
            PlayerPrefs.SetFloat("Musica", idMusica);
            PlayerPrefs.SetFloat("Efeitos", idEfeitos);
        }
        else if (input.B.isBotao())//Back
        {
            Reset();
            menuControle360.ativaMenuCentral();
        }
        else if (input.JoystickEsquerdoCima.negativoBotao())//Avancar ID
        {
            AvancarID();
        }
        else if (input.JoystickEsquerdoCima.positivoBotao())//Retorna ID
        {
            RetornarID();
        }
        else if (input.JoystickEsquerdoDireita.positivoBotao())//Avancar Options
        {
            selectOptionAvancar(); 
        }
        else if (input.JoystickEsquerdoDireita.negativoBotao())//Voltar Options
        {
            selectOptionRetrocedor();
        }
    }


    public void selectOptionAvancar()
    {
        switch (id)
        {
            case 1://Somras
                idShadows++;
                if (idShadows > 4)
                    idShadows = 4;               
                break;
            case 2://Antialiasing
                idAntialising++;
                if (idAntialising > 3)
                    idAntialising = 3;
                break;
            case 3://Anisotropic
                idAnisotropic++;
                if (idAnisotropic > 1)
                    idAnisotropic = 1;
                break;
            case 4://FPS
                idFPS++;
                if (idFPS > 2)
                    idFPS = 2;
                break;
            case 5://Musica
                idMusica += 0.1f;
                if (idMusica > 1)
                    idMusica = 1;
                break;               
            case 6://Efeitos
                idEfeitos += 0.1f;
                if (idEfeitos > 1)
                    idEfeitos = 1;
                break;            
        }
        selectOption();
    }

    public void selectOptionRetrocedor()
    {
        switch (id)
        {
            case 1://Sombras
                idShadows--;
                if (idShadows < 0)
                    idShadows = 0;
                break;
            case 2://Antialiasing
                idAntialising--;
                if (idAntialising < 0)
                    idAntialising = 0;
                break;
            case 3://Anisotropic
                idAnisotropic--;
                if (idAnisotropic < 0)
                    idAnisotropic = 0;
                break;
            case 4://Fps
                idFPS--;
                if (idFPS < 0)
                    idFPS = 0;
                break;
            case 5://Musica
                idMusica--;
                if (idMusica < 0)
                    idMusica = 0;
                break;
            case 6://Efeitos
                idEfeitos -= 0.1f;
                if (idEfeitos < 0)
                    idEfeitos = 0;
                break;        
        }
        selectOption();
    }



    public void selectOption()
    {
        switch (id)
        {
            case 1://Sombras
                switch (idShadows)
                {
                    case 0:
                        TextShadows.text = "Nenhuma";
                        break;
                    case 1:
                        TextShadows.text = "Extrema";
                        break;
                    case 2:
                        TextShadows.text = "Alta";
                        break;
                    case 3:
                        TextShadows.text = "Media";
                        break;
                    case 4:
                        TextShadows.text = "Baixa";
                        break;
                }
                break;
            case 2://Antialiasing
                switch (idAntialising)
                {
                    case 0:
                        TextAntialising.text = "Desativado";
                        break;
                    case 1:
                        TextAntialising.text = "Alto";
                        break;
                    case 2:
                        TextAntialising.text = "Medio";
                        break;
                    case 3:
                        TextAntialising.text = "Baixo";
                        break;
                }
                break;
            case 3://Anisotropic
                switch (idAnisotropic)
                {
                    case 0:
                        TextAnisotropic.text = "Ativado";
                        break;
                    case 1:
                        TextAnisotropic.text = "Desativado";
                        break;
                }
                break;            
            case 4://FPS
                switch (idFPS)
                {
                    case 0:
                        TextFPS.text = "60 FPS";
                        break;
                    case 1:
                        TextFPS.text = "30 FPS";
                        break;
                    case 2:
                        TextFPS.text = "None";
                        break;
                }
                break;
            case 5://Musica
                sMusic.value = idMusica;
                break;
            case 6://Textura
                sEffects.value = idEfeitos;
                break;

        }

    }


    public void AvancarID()
    {
        id++;
        if (id > 6)
        {
            id = 1;
        }
        mudarItem();
    }

    public void RetornarID()
    {
        id--;
        if (id < 1)
        {
            id = 6;
        }
        mudarItem();
    }


    private void mudarItem()
    {
        switch (id)
        {
            case 1://Sombras               
                Antialiasing.sprite = Nada;
                Sombras.sprite = Selecionado;
                Anisotropic.sprite = Nada;
                FPS.sprite = Nada;
                Music.sprite = Nada;
                Effects.sprite = Nada;
                break;
            case 2://Antialising
                Antialiasing.sprite = Selecionado;
                Anisotropic.sprite = Nada;
                Sombras.sprite = Nada;               
                FPS.sprite = Nada;
                Music.sprite = Nada;
                Effects.sprite = Nada;
                break;
            case 3://Anisotropic
                Antialiasing.sprite = Nada;
                Anisotropic.sprite = Selecionado;
                Sombras.sprite = Nada;               
                FPS.sprite = Nada;
                Music.sprite = Nada;
                Effects.sprite = Nada;
                break;
            case 4://FPS
                Antialiasing.sprite = Nada;
                Anisotropic.sprite = Nada;
                Sombras.sprite = Nada;                
                FPS.sprite = Selecionado;
                Music.sprite = Nada;
                Effects.sprite = Nada;
                break;
            case 5://Musica
                Antialiasing.sprite = Nada;
                Anisotropic.sprite = Nada;
                Sombras.sprite = Nada;                
                FPS.sprite = Nada;
                Music.sprite = Selecionado;
                Effects.sprite = Nada;
                break;
            case 6://Efeitos
                Antialiasing.sprite = Nada;
                Anisotropic.sprite = Nada;
                Sombras.sprite = Nada;                
                FPS.sprite = Nada;
                Music.sprite = Nada;
                Effects.sprite = Selecionado;
                break;  

        }
    }


}

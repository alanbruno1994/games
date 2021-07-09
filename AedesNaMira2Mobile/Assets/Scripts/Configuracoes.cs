using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Experimental.GlobalIllumination;

public class Configuracoes : MonoBehaviour
{
    public Dropdown Sombras, Joystick, antiAliasing, Anistropic, Estabilidade;
    public Slider Musica, Efeitos;
   



    public void pegarConfiguracoes()
    {
       // Texturas.value = PlayerPrefs.GetInt("Texturas");
        ///Vegetacao.value = PlayerPrefs.GetInt("Vegetacao");
        Sombras.value = PlayerPrefs.GetInt("Sombras");
        Joystick.value = PlayerPrefs.GetInt("Joystick");
        Musica.value = PlayerPrefs.GetFloat("Musica");
        Efeitos.value = PlayerPrefs.GetFloat("Efeitos");
        antiAliasing.value = PlayerPrefs.GetInt("antiAliasing");
        Anistropic.value = PlayerPrefs.GetInt("Anisotropic");
        Estabilidade.value = PlayerPrefs.GetInt("Estabilidade");
    }

    public void aplicarConfiguracoes()
    {
        
        //PlayerPrefs.SetInt("Texturas", Texturas.value);
     //   PlayerPrefs.SetInt("Vegetacao", Vegetacao.value);
        PlayerPrefs.SetInt("Sombras", Sombras.value);
        PlayerPrefs.SetInt("Joystick", Joystick.value);
        PlayerPrefs.SetFloat("Musica", Musica.value);
        PlayerPrefs.SetFloat("Efeitos", Efeitos.value);
        GameObject Gerenciar= GameObject.FindGameObjectWithTag("Gerenciar");
        PlayerPrefs.SetInt("antiAliasing", antiAliasing.value);
        PlayerPrefs.SetInt("Anisotropic", Anistropic.value);
        PlayerPrefs.SetInt("Estabilidade", Estabilidade.value);


        try
        {
            Gerenciar.GetComponent<ControleQualidade>().ajustar();
            
            /*Gerenciar.GetComponent<ControleQualidade>().Musica.volume = PlayerPrefs.GetFloat("Musica");
            GameObject[] list = GameObject.FindGameObjectsWithTag("CIndividual");
            for (int i = 0; i < list.Length; i++)
            {
                try
                {
                    list[i].GetComponent<ControleQualidadeIndividual>().MudarTextura();
                }
                catch (System.Exception e)
                { }
            }*/
        }
        catch (System.Exception) { }
    }

}

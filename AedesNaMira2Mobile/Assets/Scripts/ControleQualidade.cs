using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleQualidade : MonoBehaviour
{
    public AudioSource Musica,Vencer,Triste;
    void Awake(){
        ajustar();
    }


    public void ajustar()
    {

        Musica.volume = PlayerPrefs.GetFloat("Musica");
        if (Vencer != null && Triste != null)
        {
            Vencer.volume = PlayerPrefs.GetFloat("Musica");
            Triste.volume = PlayerPrefs.GetFloat("Musica");
        }
        switch (PlayerPrefs.GetInt("Sombras"))
        {
            case 0:
                QualitySettings.shadows = ShadowQuality.Disable;
                QualitySettings.pixelLightCount = 0;
                break;
            case 1:
                QualitySettings.shadows = ShadowQuality.All;
                QualitySettings.shadowResolution = ShadowResolution.VeryHigh;
                QualitySettings.pixelLightCount = 4;
                break;
            case 2:
                QualitySettings.shadows = ShadowQuality.All;
                QualitySettings.shadowResolution = ShadowResolution.High;
                QualitySettings.pixelLightCount = 3;
                break;
            case 3:
                QualitySettings.shadows = ShadowQuality.All;
                QualitySettings.shadowResolution = ShadowResolution.Medium;
                QualitySettings.pixelLightCount = 2;
                break;
            case 4:
                QualitySettings.shadows = ShadowQuality.All;
                QualitySettings.shadowResolution = ShadowResolution.Low;
                QualitySettings.pixelLightCount = 1;
                break;
        }

        switch (PlayerPrefs.GetInt("antiAliasing"))
        {
            case 0://Nenhuma
                QualitySettings.antiAliasing = 0;
                break;
            case 1://Baixo
                QualitySettings.antiAliasing = 2;
                break;
            case 2://Médio
                QualitySettings.antiAliasing = 4;
                break;
            case 3://Alto
                QualitySettings.antiAliasing = 8;
                break;
        }

        switch (PlayerPrefs.GetInt("Anisotropic"))
        {
            case 0://Ativado
                QualitySettings.anisotropicFiltering = AnisotropicFiltering.Enable;
                break;
            case 1://Desativado
                QualitySettings.anisotropicFiltering = AnisotropicFiltering.Disable;
                break;

        }

        switch (PlayerPrefs.GetInt("Estabilidade"))
        {
            case 0:
                QualitySettings.vSyncCount = 1;//60 quadros
                break;
            case 1:
                QualitySettings.vSyncCount = 2;//30 quadros
                break;
            case 2:
                QualitySettings.vSyncCount = 0;//Sem estabilidade
                break;
        }

    }




}

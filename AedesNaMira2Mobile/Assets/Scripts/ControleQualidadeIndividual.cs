using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleQualidadeIndividual : MonoBehaviour
{
    public Material HighTexture, MediumTexture, Lowtexture;
    public AudioSource audio;
    public bool musica;
    public float alturaMaxima;
    // Start is called before the first frame update
    void Start()
    {
        MudarTextura();
    }

    public void MudarTextura()
    {
        try
        {
            switch (PlayerPrefs.GetInt("Texturas"))
            {
                case 0:
                    this.GetComponent<Renderer>().material = HighTexture;
                    break;
                case 1:
                    this.GetComponent<Renderer>().material = MediumTexture;
                    break;
                case 2:
                    this.GetComponent<Renderer>().material = Lowtexture;
                    break;
            }
        }
        catch (System.Exception)
        {

        }
        if (musica)
        {
            if (audio != null)
            {
                audio.volume = alturaMaxima * PlayerPrefs.GetFloat("Musica");
            }
        }
        else
        {
            if (audio != null)
            {
                audio.volume = alturaMaxima * PlayerPrefs.GetFloat("Efeitos");
            }
        }
    }



}

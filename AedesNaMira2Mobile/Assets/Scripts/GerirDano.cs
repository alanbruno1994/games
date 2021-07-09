using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerirDano : MonoBehaviour
{
    public Heroi heroi;
    public HeroiControle heroiControle;
    public ControleDificuldade dificuldade;
    public int chicumgunhaPicadas, zikaPicadas, denguePicadas;
    public EnfermidadeHUD enfermidadeHUD;
    void Start()
    {
        GameObject aux = GameObject.FindGameObjectWithTag("Gerenciar");
        dificuldade = aux.GetComponent<ControleDificuldade>();

    }

    public void realizarDano(Collision e, int protecao)
    {
        string tag = e.gameObject.tag;
        if (protecao == 0)
        {

            if (tag == "Mosquito_Normal" || tag == "Mosquito_Chikungunya" || tag == "Mosquito_Zika" || tag == "Mosquito_Dengue")
            {
                e.gameObject.GetComponent<Mosquito>().destinoPonto();

                switch (tag)
                {
                    case "Mosquito_Normal":
                        atualizarLife(0.25f);
                        break;
                    case "Mosquito_Chikungunya":
                        atualizarLife(0.5f);
                        chicumgunhaPicadas++;
                        if (chicumgunhaPicadas == 5)
                        {
                            Mosquito_Chikungunya();
                        }
                        break;
                    case "Mosquito_Zika":
                        atualizarLife(0.75f);
                        zikaPicadas++;
                        if (zikaPicadas == 5)
                        {
                            Zika();
                        }
                        break;
                    case "Mosquito_Dengue":
                        atualizarLife(1);
                        denguePicadas++;
                        if (denguePicadas == 5)
                        {
                            Dengue();
                        }
                        break;

                }

            }
        }
    }

    private void atualizarLife(float value)
    {
        if (heroi != null)
        {
            heroi.life = heroi.life - value * dificuldade.NivelDificulade;
        }
        else
        {
            heroiControle.life = heroiControle.life - value * dificuldade.NivelDificulade;
        }
    }


    public void Dengue()
    {

        chicumgunhaPicadas = 0;
        zikaPicadas = 0;
        denguePicadas = 0;
        //huds.embacamento.enabled = true;

        info(3);
    }

    public void Mosquito_Chikungunya()
    {

        chicumgunhaPicadas = 0;
        zikaPicadas = 0;
        denguePicadas = 0;
        //huds.embacamento.enabled = true;     
        info(1);
    }


    public void Zika()
    {
        chicumgunhaPicadas = 0;
        zikaPicadas = 0;
        denguePicadas = 0;
        //huds.Visao.enabled = true;     
        info(2);
    }


    private void info(int v)
    {

        if (heroi != null)
        {
            if (heroi.doente == false)
            {
                heroi.doente = true;
                heroi.porcetagemDoente = 100;
                heroi.tipoDoenca = v;
            }
        }
        else
        {
            if (heroiControle.doente == false)
            {
                heroiControle.doente = true;
                heroiControle.porcetagemDoente = 100;
                heroiControle.tipoDoenca = v;
            }
        }


    }



}

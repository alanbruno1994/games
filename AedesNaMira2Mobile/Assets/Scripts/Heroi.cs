using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heroi : MonoBehaviour
{
    public float life = 100, valor = 40;
    public bool desabilitarRepelente = false, VR, fimJogo;
    public GameObject Protecao_Item;
    public int porcetagemDoente = 0;
    public int protecao;
    public int denguePicadas = 0, chicumgunhaPicadas = 0, zikaPicanha = 0;
    public bool doente = false;
    public float time = 0, timeVida = 0, timeProtecao, timeProtecaoLimite, tempoataca = 0;
    public bool estaChao = false;
    public int tipoDoenca = 0;
    public Image visao;
    // public GameObject filho;
    public AudioSource Dor;
    public GameObject Chao;
    public Camera camera;
    public GameObject tela_1280_720;
    public GameObject ConquistaF2;
    public GameObject ConquistaF3;
    public HUD huds;
    public ControleDificuldade dificuldade;
    public DadosFase dadosFase;
    public GameObject Mao, Compra;
    public bool ataque = false, ativaCompra;
    public CompraItem compraItem;

    // Start is called before the first frame update
    void Start()
    {

        ativaCompra = fimJogo = false;
        huds.Visao.enabled = false;
        Chao = GameObject.FindGameObjectWithTag("chao");
        huds.vidaRefresh();
        Dor.volume = 0;
        Protecao_Item.SetActive(false);
        Time.timeScale = 1;
        huds.embacamento.enabled = false;
        Physics.IgnoreLayerCollision(8, 9);
        dadosFase = GameObject.FindGameObjectWithTag("Gerenciar").GetComponent<DadosFase>();
        dificuldade = GameObject.FindGameObjectWithTag("Gerenciar").GetComponent<ControleDificuldade>();


    }


    public void fixarProtecao2segundos()
    {
        desabilitarRepelente = true;
        Protecao_Item.SetActive(true);
        protecao = 100;
        timeProtecao = 0;
        timeProtecaoLimite = 2;

    }

    public void fixarProtecao3segundos()
    {
        desabilitarRepelente = true;
        Protecao_Item.SetActive(true);
        protecao = 100;
        timeProtecao = 0;
        timeProtecaoLimite = 3;

    }

    public void fixarProtecao5segundos()
    {

        desabilitarRepelente = true;
        Protecao_Item.SetActive(true);
        protecao = 100;
        timeProtecao = 0;
        timeProtecaoLimite = 5;

    }

    // Update is called once per frame
    void Update()
    {
        Physics.IgnoreLayerCollision(8, 9);
        if (ativaCompra)
        {
            Compra.SetActive(true);
            compraItem.selectArma();
        }
        else
        {
            Compra.SetActive(false);
        }
        /*
        if (timeDesconto>30)
        {
            timeDesconto = 0;
            desconto++;
        }
        timeDesconto += Time.deltaTime;
        */
        if ((life <= 0) && fimJogo == false)
        {
            fimJogo = true;
            Instantiate(tela_1280_720, tela_1280_720.transform.position, tela_1280_720.transform.rotation);
        }
        else if (life > 0)
        {
            if (life < 10)
            {
                try
                {
                    Vibration.Vibrate();
                }
                catch (System.Exception)
                {


                }
            }

            if (doente)
            {
                time = time + Time.deltaTime;

                if (time > 3 * (dificuldade.NivelDificulade * 0.5f))
                {

                    time = 0;
                    descontarDoenca();
                    huds.refreshDoenca();

                }
                if (porcetagemDoente <= 0)
                {

                    doente = false;
                    huds.embacamento.enabled = false;
                    //filho.GetComponent<ShaderEffect_BleedingColors>().enabled = false;
                    Dor.volume = 0;
                    //camera.clearFlags = CameraClearFlags.Skybox;
                    //camera.cullingMask = -1;
                    ///  filho.GetComponent<DesligarCamera>().enabled = false;
                    huds.refreshDoenca();
                    huds.Visao.enabled = false;
                    /*
                    if (VR == false)
                    {
                        visao.color = new Color32(0, 0, 0, 0);
                    }*/

                    //time = 0;
                }
            }

            if (protecao > 0)
            {
                timeProtecao += Time.deltaTime;
                if (timeProtecaoLimite == 2)
                {
                    if (timeProtecao <= 0.2f)
                    {
                        protecao = 90;
                    }
                    else if (timeProtecao <= 0.4f)
                    {
                        protecao = 80;
                    }
                    else if (timeProtecao <= 0.6f)
                    {
                        protecao = 70;
                    }
                    else if (timeProtecao <= 0.8f)
                    {
                        protecao = 60;
                    }
                    else if (timeProtecao <= 1)
                    {
                        protecao = 50;
                    }
                    else if (timeProtecao <= 1.2f)
                    {
                        protecao = 40;
                    }
                    else if (timeProtecao <= 1.4f)
                    {
                        protecao = 30;
                    }
                    else if (timeProtecao <= 1.6f)
                    {
                        protecao = 20;
                    }
                    else if (timeProtecao <= 1.8f)
                    {
                        protecao = 10;
                    }
                    else if (timeProtecao >= 2)
                    {
                        protecao = 0;
                        Protecao_Item.SetActive(false);
                        desabilitarRepelente = false;
                        huds.EscuroAzul.SetActive(false);
                    }
                    huds.statusVidaPreservada();
                }
                else if (timeProtecaoLimite == 3)
                {
                    if (timeProtecao <= 0.3f)
                    {
                        protecao = 90;
                    }
                    else if (timeProtecao <= 0.6f)
                    {
                        protecao = 80;
                    }
                    else if (timeProtecao <= 0.9f)
                    {
                        protecao = 70;
                    }
                    else if (timeProtecao <= 1.2f)
                    {
                        protecao = 60;
                    }
                    else if (timeProtecao <= 1.5f)
                    {
                        protecao = 50;
                    }
                    else if (timeProtecao <= 1.8f)
                    {
                        protecao = 40;
                    }
                    else if (timeProtecao <= 2.1f)
                    {
                        protecao = 30;
                    }
                    else if (timeProtecao <= 2.4f)
                    {
                        protecao = 20;
                    }
                    else if (timeProtecao <= 2.7f)
                    {
                        protecao = 10;
                    }
                    else if (timeProtecao >= 3)
                    {
                        protecao = 0;
                        huds.EscuroVermelho.SetActive(false);
                        desabilitarRepelente = false;
                        Protecao_Item.SetActive(false);
                    }
                    huds.statusVidaPreservada();
                }
                else if (timeProtecaoLimite == 5)
                {
                    if (timeProtecao <= 0.5f)
                    {
                        protecao = 90;
                    }
                    else if (timeProtecao <= 1)
                    {
                        protecao = 80;
                    }
                    else if (timeProtecao <= 1.5f)
                    {
                        protecao = 70;
                    }
                    else if (timeProtecao <= 2)
                    {
                        protecao = 60;
                    }
                    else if (timeProtecao <= 2.5f)
                    {
                        protecao = 50;
                    }
                    else if (timeProtecao <= 3)
                    {
                        protecao = 40;
                    }
                    else if (timeProtecao <= 3.5f)
                    {
                        protecao = 30;
                    }
                    else if (timeProtecao <= 4)
                    {
                        protecao = 20;
                    }
                    else if (timeProtecao <= 4.5f)
                    {
                        protecao = 10;
                    }
                    else if (timeProtecao >= 5)
                    {
                        protecao = 0;
                        Protecao_Item.SetActive(false);
                        desabilitarRepelente = false;
                        huds.EscuroDourado.SetActive(false);
                    }
                    huds.statusVidaPreservada();

                }
            }
        }

        if (PlayerPrefs.GetInt("Fase2") != 1 && dadosFase.pontos >= 200)
        {
            PlayerPrefs.SetInt("Fase2", 1);
            Instantiate(ConquistaF2, ConquistaF2.transform.position, ConquistaF2.transform.rotation);


        }

        if (PlayerPrefs.GetInt("Fase3") != 1 && dadosFase.pontos >= 400)
        {
            PlayerPrefs.SetInt("Fase3", 1);
            Instantiate(ConquistaF3, ConquistaF3.transform.position, ConquistaF3.transform.rotation);

        }
       // Debug.Log("arma usada "+ RamSystem.ArmaUsada);
        if (ataque && RamSystem.ArmaUsada != 4 && RamSystem.ArmaUsada != 5 && RamSystem.ArmaUsada != 6)
        {
            valor = valor - (Time.deltaTime * 180);
            Mao.transform.localRotation = Quaternion.Euler(0, valor, 0);
            if (valor < -40)
            {
                ataque = false;
                valor = 40;
                Mao.transform.localRotation = Quaternion.Euler(0, 0, 0);
            }
        }
        else if (RamSystem.ArmaUsada == 4 || RamSystem.ArmaUsada == 5 || RamSystem.ArmaUsada == 6)
        {
            Mao.transform.localRotation = Quaternion.Euler(0, 0, 0);

        } else if (ataque==false) 
        {
            Mao.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        Debug.Log(Mao.transform.localRotation.eulerAngles);
        
    }

    public void saltarHeroi()
    {

        if (estaChao)
        {
            transform.Translate(0, 100 * Time.deltaTime, 0);
        }

    }


    public void descontarDoenca()
    {

        switch (tipoDoenca)
        {
            case 1:
                auxDescontarDoenca(0.1f);
                break;
            case 2:
                auxDescontarDoenca(0.15f);
                break;
            case 3:
                auxDescontarDoenca(0.2f);
                huds.embacamento.enabled = true;
                break;
        }

    }

    private void auxDescontarDoenca(float fator)
    {
        int Dificuldade = dificuldade.NivelDificulade;
        life = life - fator * Dificuldade;
        int aux = 41 - Dificuldade;
        if (aux <= 0)
        {
            aux = 1;
        }
        porcetagemDoente -= aux;
        if (porcetagemDoente <= 0)
        {
            huds.Enfermidade.enabled = false;
            huds.EnfermidadeCarregar.enabled = false;


        }

    }

    void OnCollisionEnter(Collision e)
    {
        try
        {

            string tag = e.gameObject.tag;
            if (tag == "Mosquito_Normal" || tag == "Mosquito_Chikungunya" || tag == "Mosquito_Zika" || tag == "Mosquito_Dengue")
            {
                ataque = true;
            }
            if (protecao == 0)
            {

                if (tag == "Mosquito_Normal" || tag == "Mosquito_Chikungunya" || tag == "Mosquito_Zika" || tag == "Mosquito_Dengue")
                {
                    e.gameObject.GetComponent<Mosquito>().destinoPonto();

                    switch (tag)
                    {
                        case "Mosquito_Normal":
                            life = life - 0.25f * dificuldade.NivelDificulade;
                            break;
                        case "Mosquito_Chikungunya":
                            chicumgunhaPicadas++;
                            if (chicumgunhaPicadas == 5)
                            {
                                doente = true;
                                porcetagemDoente = 100;
                                tipoDoenca = 1;
                                chicumgunhaPicadas = 0;
                                zikaPicanha = 0;
                                denguePicadas = 0;
                                huds.refreshDoenca();
                            }
                            life = life - 0.5f * dificuldade.NivelDificulade;
                            break;
                        case "Mosquito_Zika":
                            life = life - 0.75f * dificuldade.NivelDificulade;
                            zikaPicanha++;
                            if (zikaPicanha == 5)
                            {
                                doente = true;
                                porcetagemDoente = 100;
                                tipoDoenca = 2;
                                chicumgunhaPicadas = 0;
                                zikaPicanha = 0;
                                denguePicadas = 0;
                                huds.Visao.enabled = true;
                                huds.refreshDoenca();
                            }
                            break;
                        case "Mosquito_Dengue":
                            life = life - 1 * dificuldade.NivelDificulade;
                            denguePicadas++;
                            if (denguePicadas == 5)
                            {
                                doente = true;
                                porcetagemDoente = 100;
                                tipoDoenca = 3;
                                chicumgunhaPicadas = 0;
                                zikaPicanha = 0;
                                denguePicadas = 0;
                                huds.embacamento.enabled = true;
                                huds.refreshDoenca();
                            }
                            break;

                    }



                    huds.vidaRefresh();

                }
            }

            if (tag == "chao")
            {
                estaChao = true;
            }
        }
        catch (System.Exception) { }
        //*/
    }




    void OnCollisionExit(Collision e)
    {

        string tag = e.gameObject.tag;
        if (tag == "Mosquito_Normal" || tag == "Mosquito_Chikungunya" || tag == "Mosquito_Zika" || tag == "Mosquito_Dengue")
        {
            ataque = false;

        }


        if (tag == "chao")
        {
            estaChao = false;
        }





    }
    /*

     private void mosquitoNormal()
     {
         float desconto = 0.5f + dificuldade.NivelDificulade / 2;
         life = life - desconto;   

     }


     private void mosquitoCh()
     {

         int valor = 0;       
         float desconto = 1 + dificuldade.NivelDificulade / 2;
         int aux = 0;
         if (50 - dificuldade.NivelDificulade <= 0)
         {
             aux = 0;
         }
         else
         {
             aux -= dificuldade.NivelDificulade;
         }
         valor = Random.Range(0, aux);
         life = life - desconto;       

             if (doente == false)
             {
                 chicumgunhaPicadas++;
                 if (chicumgunhaPicadas >= 3)
                 {
                     if (valor <= 10)
                     {

                         doente = true;
                         porcetagemDoente = 100;
                         tipoDoenca = 1;
                         huds.refreshDoenca();
                     Dor.volume = 1;
                         //nomeDoenca.text = "Chikungunya";
                     }
                     time = 0;
                     chicumgunhaPicadas = 0;
                 }
             }

     }

     private void mosquitoZika()
     {
         int valor = 0;
         float desconto = 1.5f + dificuldade.NivelDificulade / 2;
         int aux = 0;
         if (50 - dificuldade.NivelDificulade <= 0)
         {
             aux = 0;
         }
         else
         {
             aux -= dificuldade.NivelDificulade;
         }
         valor = Random.Range(0, aux);
         life = life - desconto;       

             if (doente == false)
             {
                 zikaPicanha++;
                 if (zikaPicanha >= 3)
                 {
                     if (valor <= 10)
                     {

                         doente = true;                        
                         porcetagemDoente = 100;
                         tipoDoenca = 2;
                         huds.refreshDoenca();
                     //nomeDoenca.text = "Zika";
                     filho.GetComponent<DesligarCamera>().enabled = true;
                     }
                     time = 0;
                     zikaPicanha = 0;
                 }
             }


     }


     private void mosquitoDengue()
     {

         int valor = 0;
         float desconto = 2 + dificuldade.NivelDificulade / 2;
         int aux = 0;
         if (50 - dificuldade.NivelDificulade <= 0)
         {
             aux = 0;
         }
         else
         {
             aux -= dificuldade.NivelDificulade;
         }
         valor = Random.Range(0, aux);
         life = life - desconto;

         if (doente == false)
             {
                 denguePicadas++;
                 if (denguePicadas >= 3)
                 {
                     if (valor <= 10)
                     {

                         doente = true;
                         porcetagemDoente = 100;
                           huds.refreshDoenca();                     
                          //   nomeDoenca.text = "Dengue";
                             tipoDoenca = 3;


                     }
                     time = 0;
                     denguePicadas = 0;
                 }
             }

     }
     */

}

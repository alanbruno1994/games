using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GerirFocos : MonoBehaviour
{
    public GameObject novoFoco_800_600, novoFoco_2560_1440, novoFoco_3840_2160, novoFoco_320_240, novoFoco_1920_1080, novoFoco_1280_720, novoFoco_1136_640, novoFoco_1134_750, novoFoco_640_360, novoFoco_640_480, novoFoco_960_540;
    public GameObject telaFocodestruido_800_600, telaFocodestruido_2560_1440, telaFocodestruido_3840_2160, telaFocodestruido_320_240, telaFocodestruido_1920_1080, telaFocodestruido_1280_720, telaFocodestruido_1136_640, telaFocodestruido_1134_750, telaFocodestruido_640_360, telaFocodestruido_640_480, telaFocodestruido_960_540;
    public int quantidadefoco, focosativos;
    public GameObject foco1, foco2, foco3, foco4, foco5, foco6;
    public bool foco1Vivo = true, foco2Vivo = true, foco3Vivo = true, foco4Vivo = true, foco5Vivo = true, foco6Vivo = true, setRelogio = false;
    public int idFase;
    public float contadorTime = 0;
    public GameObject foco1Destroi, foco2Destroi, foco3Destroi, foco4Destroi, foco5Destroi, foco6Destroi;
    private GameObject AuxFocoTela;
    public GameObject CarregarFase;
    public GameObject Placar_Fase;
    public GameObject NovoFoco1, NovoFoco2, NovoFoco3, NovoFoco4;
    public bool PC;//Define se jogo com os teclados
    public GameObject HUD;

    public float valorContador;
    // Use this for initialization
    void Start()
    {
        focosativos = quantidadefoco;
        HUD = GameObject.FindGameObjectWithTag("HUD");
        if (idFase == 1)
        {
            foco4Vivo = false;
            foco5Vivo = false;
            foco6Vivo = false;
        }
        else if (idFase == 2)
        {
            foco5Vivo = false;
            foco6Vivo = false;
        }
        else if (idFase == 3)
        {
            foco6Vivo = false;
        }

    }



    // Update is called once per frame
    void Update()
    {
        try
        {
            if (quantidadefoco == focosativos)
            {
                if (protecao())
                {
                    HUD.GetComponent<HUD>().RelogioImage.enabled = false;
                    HUD.GetComponent<HUD>().Relogio.enabled = false;
                }
                else
                {
                    HUD.GetComponent<HUDUpatate>().RelogioImage.enabled = false;
                    HUD.GetComponent<HUDUpatate>().Relogio.enabled = false;
                }
                setRelogio = false;
            }
            else
            {
                float mux = 1;
                if (quantidadefoco == 3)
                {
                    switch (focosativos)
                    {
                        case 1:
                            mux = 3;
                            break;
                        case 2:
                            mux = 2;
                            break;
                        case 3:
                            mux = 1;
                            break;
                    }

                }
                else if (quantidadefoco == 4)
                {
                    switch (focosativos)
                    {
                        case 1:
                            mux = 4;
                            break;
                        case 2:
                            mux = 3;
                            break;
                        case 3:
                            mux = 2;
                            break;
                        case 4:
                            mux = 1;
                            break;
                    }

                }
                else if (quantidadefoco == 5)
                {
                    switch (focosativos)
                    {
                        case 1:
                            mux = 5;
                            break;
                        case 2:
                            mux = 4;
                            break;
                        case 3:
                            mux = 3;
                            break;
                        case 4:
                            mux = 2;
                            break;
                        case 5:
                            mux = 1;
                            break;
                    }

                }
                float auxv = 0.015f * mux;
                GameObject.FindGameObjectWithTag("Gerenciar").GetComponent<DadosFase>().IncrementarSaldo(auxv);
                if (protecao())
                {
                    HUD.GetComponent<HUD>().RelogioImage.enabled = true;
                    HUD.GetComponent<HUD>().Relogio.enabled = true;
                }
                else
                {
                    HUD.GetComponent<HUDUpatate>().RelogioImage.enabled = true;
                    HUD.GetComponent<HUDUpatate>().Relogio.enabled = true;
                }
                if (setRelogio == false)
                {
                    if (valorContador >= 1)
                    {
                        valorContador = valorContador - this.GetComponent<ControleDificuldade>().NivelDificulade;
                        if (valorContador < 0)
                        {
                            valorContador = 0;
                        }
                    }
                    contadorTime = valorContador;
                    print(contadorTime);
                    setRelogio = true;
                }
                contadorTime = contadorTime - Time.deltaTime;
                int aux = (int)contadorTime;
                if (protecao())
                {
                    HUD.GetComponent<HUD>().Relogio.text = "" + aux;
                }
                else
                {
                    HUD.GetComponent<HUDUpatate>().Relogio.text = "" + aux;
                }
                if (idFase == 1)
                {
                    fase1();
                }
                else if (idFase == 2)
                {
                    fase2();
                }
                else if (idFase == 3)
                {
                    fase3();
                }

            }
            if (protecao())
            {
                HUD.GetComponent<HUD>().AguaParada.text = "" + focosativos;
            }
            else
            {
                HUD.GetComponent<HUDUpatate>().AguaParada.text = "" + focosativos;
            }

        }
        catch (System.Exception)
        {


        }
    }

    private void novoFoco()
    {
        if (Screen.width == 800 && Screen.height == 600)
        {
            AuxFocoTela = Instantiate(novoFoco_800_600, novoFoco_800_600.transform.position, novoFoco_800_600.transform.rotation);
        }
        else if (Screen.width == 2560 && Screen.height == 1440)
        {
            AuxFocoTela = Instantiate(novoFoco_2560_1440, novoFoco_2560_1440.transform.position, novoFoco_2560_1440.transform.rotation);

        }
        else if (Screen.width == 3840 && Screen.height == 2160)
        {
            AuxFocoTela = Instantiate(novoFoco_3840_2160, novoFoco_3840_2160.transform.position, novoFoco_3840_2160.transform.rotation);
        }
        else if (Screen.width == 320 && Screen.height == 240)
        {
            AuxFocoTela = Instantiate(novoFoco_320_240, novoFoco_320_240.transform.position, novoFoco_320_240.transform.rotation);
        }
        else if (Screen.width == 1920 && Screen.height == 1080)
        {
            AuxFocoTela = Instantiate(novoFoco_1920_1080, novoFoco_1920_1080.transform.position, novoFoco_1920_1080.transform.rotation);
        }
        else if (Screen.width == 1280 && Screen.height == 720)
        {
            AuxFocoTela = Instantiate(novoFoco_1280_720, novoFoco_1280_720.transform.position, novoFoco_1280_720.transform.rotation);
        }
        else if (Screen.width == 1136 && Screen.height == 640)
        {
            AuxFocoTela = Instantiate(novoFoco_1136_640, novoFoco_1136_640.transform.position, novoFoco_1136_640.transform.rotation);
        }
        else if (Screen.width == 1134 && Screen.height == 750)
        {
            AuxFocoTela = Instantiate(novoFoco_1134_750, novoFoco_1134_750.transform.position, novoFoco_1134_750.transform.rotation);
        }
        else if (Screen.width == 640 && Screen.height == 360)
        {
            AuxFocoTela = Instantiate(novoFoco_640_360, novoFoco_640_360.transform.position, novoFoco_640_360.transform.rotation);
        }
        else if (Screen.width == 640 && Screen.height == 480)
        {
            AuxFocoTela = Instantiate(novoFoco_640_480, novoFoco_640_480.transform.position, novoFoco_640_480.transform.rotation);
        }
        else if (Screen.width == 960 && Screen.height == 540)
        {
            AuxFocoTela = Instantiate(novoFoco_960_540, novoFoco_960_540.transform.position, novoFoco_960_540.transform.rotation);
        }



    }

    private void fase3()
    {
        int aux = (int)contadorTime;
        if (aux == 0)
        {
            Random random = new Random();
            float numeroSorte = Random.Range(0, 10);
            if (AuxFocoTela == null)
            {
                novoFoco();
            }
            else
            {
                try
                {
                    Destroy(AuxFocoTela);
                }
                catch (System.Exception e)
                {

                }
                novoFoco();
            }
            if (foco1Vivo == false && foco4Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco1, foco1.transform.position, foco1.transform.rotation);
                    //Instantiate (foco1Volta, foco1Volta.transform.position, foco1Volta.transform.rotation);
                    foco1Vivo = true;
                }
                else
                {
                    Instantiate(foco4, foco4.transform.position, foco4.transform.rotation);
                    //	Instantiate (foco4Volta, foco4Volta.transform.position, foco4Volta.transform.rotation);
                    foco4Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;
            }
            else if (foco1Vivo == false && foco2Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco1, foco1.transform.position, foco1.transform.rotation);
                    //Instantiate (foco1Volta, foco1Volta.transform.position, foco1Volta.transform.rotation);
                    foco1Vivo = true;
                }
                else
                {
                    Instantiate(foco2, foco2.transform.position, foco2.transform.rotation);
                    //Instantiate (foco2Volta, foco2Volta.transform.position, foco2Volta.transform.rotation);
                    foco2Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;

            }
            else if (foco1Vivo == false && foco3Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco1, foco1.transform.position, foco1.transform.rotation);
                    //Instantiate (foco1Volta, foco1Volta.transform.position, foco1Volta.transform.rotation);
                    foco1Vivo = true;
                }
                else
                {
                    Instantiate(foco3, foco3.transform.position, foco3.transform.rotation);
                    //Instantiate (foco3Volta, foco3Volta.transform.position, foco3Volta.transform.rotation);
                    foco3Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;

            }
            else if (foco1Vivo == false && foco5Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco1, foco1.transform.position, foco1.transform.rotation);
                    //	Instantiate (foco1Volta, foco1Volta.transform.position, foco1Volta.transform.rotation);
                    foco1Vivo = true;
                }
                else
                {
                    Instantiate(foco5, foco5.transform.position, foco5.transform.rotation);
                    //	Instantiate (foco5Volta, foco5Volta.transform.position, foco5Volta.transform.rotation);
                    foco5Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;

            }
            else if (foco1Vivo == false && foco6Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco1, foco1.transform.position, foco1.transform.rotation);
                    //Instantiate (foco1Volta, foco1Volta.transform.position, foco1Volta.transform.rotation);
                    foco1Vivo = true;
                }
                else
                {
                    Instantiate(foco6, foco6.transform.position, foco6.transform.rotation);
                    //	Instantiate (foco6Volta, foco6Volta.transform.position, foco6Volta.transform.rotation);
                    foco6Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;

            }
            else if (foco2Vivo == false && foco3Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco2, foco2.transform.position, foco2.transform.rotation);
                    //	Instantiate (foco2Volta, foco2Volta.transform.position, foco2Volta.transform.rotation);
                    foco2Vivo = true;
                }
                else
                {
                    Instantiate(foco3, foco3.transform.position, foco3.transform.rotation);
                    //	Instantiate (foco3Volta, foco3Volta.transform.position, foco3Volta.transform.rotation);
                    foco3Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;
            }
            else if (foco2Vivo == false && foco4Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco2, foco2.transform.position, foco2.transform.rotation);
                    //	Instantiate (foco2Volta, foco2Volta.transform.position, foco2Volta.transform.rotation);
                    foco2Vivo = true;
                }
                else
                {
                    Instantiate(foco4, foco4.transform.position, foco4.transform.rotation);
                    //	Instantiate (foco4Volta, foco4Volta.transform.position, foco4Volta.transform.rotation);
                    foco4Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;
            }
            else if (foco2Vivo == false && foco5Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco2, foco2.transform.position, foco2.transform.rotation);
                    //	Instantiate (foco2Volta, foco2Volta.transform.position, foco2Volta.transform.rotation);
                    foco2Vivo = true;
                }
                else
                {
                    Instantiate(foco5, foco5.transform.position, foco5.transform.rotation);
                    //	Instantiate (foco5Volta, foco5Volta.transform.position, foco5Volta.transform.rotation);
                    foco5Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;

            }
            else if (foco2Vivo == false && foco6Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco2, foco2.transform.position, foco2.transform.rotation);
                    //	Instantiate (foco2Volta, foco2Volta.transform.position, foco2Volta.transform.rotation);
                    foco2Vivo = true;
                }
                else
                {
                    Instantiate(foco6, foco6.transform.position, foco6.transform.rotation);
                    //	Instantiate (foco6Volta, foco6Volta.transform.position, foco6Volta.transform.rotation);
                    foco6Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;
            }
            else if (foco3Vivo == false && foco4Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco3, foco3.transform.position, foco3.transform.rotation);
                    //Instantiate (foco3Volta, foco3Volta.transform.position, foco3Volta.transform.rotation);
                    foco3Vivo = true;
                }
                else
                {
                    Instantiate(foco4, foco4.transform.position, foco4.transform.rotation);
                    //Instantiate (foco4Volta, foco4Volta.transform.position, foco4Volta.transform.rotation);
                    foco4Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;
            }
            else if (foco3Vivo == false && foco5Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco3, foco3.transform.position, foco3.transform.rotation);
                    //Instantiate (foco3Volta, foco3Volta.transform.position, foco3Volta.transform.rotation);
                    foco3Vivo = true;
                }
                else
                {
                    Instantiate(foco5, foco5.transform.position, foco5.transform.rotation);
                    //Instantiate (foco5Volta, foco5Volta.transform.position, foco5Volta.transform.rotation);
                    foco5Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;
            }
            else if (foco3Vivo == false && foco6Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco3, foco3.transform.position, foco3.transform.rotation);
                    //Instantiate (foco3Volta, foco3Volta.transform.position, foco3Volta.transform.rotation);
                    foco3Vivo = true;
                }
                else
                {
                    Instantiate(foco6, foco6.transform.position, foco6.transform.rotation);
                    //Instantiate (foco6Volta, foco6Volta.transform.position, foco6Volta.transform.rotation);
                    foco6Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;
            }
            else if (foco4Vivo == false && foco5Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco4, foco4.transform.position, foco4.transform.rotation);
                    //Instantiate (foco4Volta, foco4Volta.transform.position, foco4Volta.transform.rotation);
                    foco4Vivo = true;
                }
                else
                {
                    Instantiate(foco5, foco5.transform.position, foco5.transform.rotation);
                    //Instantiate (foco5Volta, foco5Volta.transform.position, foco5Volta.transform.rotation);
                    foco5Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;
            }
            else if (foco4Vivo == false && foco6Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco4, foco4.transform.position, foco4.transform.rotation);
                    //Instantiate (foco4Volta, foco4Volta.transform.position, foco4Volta.transform.rotation);
                    foco4Vivo = true;
                }
                else
                {
                    Instantiate(foco6, foco6.transform.position, foco6.transform.rotation);
                    //Instantiate (foco6Volta, foco6Volta.transform.position, foco6Volta.transform.rotation);
                    foco6Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;
            }
            else if (foco5Vivo == false && foco6Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco5, foco5.transform.position, foco5.transform.rotation);
                    //Instantiate (foco5Volta, foco5Volta.transform.position, foco5Volta.transform.rotation);
                    foco5Vivo = true;
                }
                else
                {
                    Instantiate(foco6, foco6.transform.position, foco6.transform.rotation);
                    //Instantiate (foco6Volta, foco6Volta.transform.position, foco6Volta.transform.rotation);
                    foco6Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;
            }

        }

    }

    private void fase2()
    {
        int aux = (int)contadorTime;
        if (aux == 0)
        {
            Random random = new Random();
            float numeroSorte = Random.Range(0, 10);
            if (AuxFocoTela == null)
            {
                novoFoco();
            }
            else
            {
                try
                {
                    Destroy(AuxFocoTela);
                }
                catch (System.Exception e)
                {

                }
                novoFoco();
            }
            if (foco1Vivo == false && foco4Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco1, foco1.transform.position, foco1.transform.rotation);
                    //	Instantiate (foco1Volta, foco1Volta.transform.position, foco1Volta.transform.rotation);
                    foco1Vivo = true;
                }
                else
                {
                    Instantiate(foco4, foco4.transform.position, foco4.transform.rotation);
                    //	Instantiate (foco4Volta, foco4Volta.transform.position, foco4Volta.transform.rotation);
                    foco4Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;
            }
            else if (foco1Vivo == false && foco2Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco1, foco1.transform.position, foco1.transform.rotation);
                    //	Instantiate (foco1Volta, foco1Volta.transform.position, foco1Volta.transform.rotation);
                    foco1Vivo = true;
                }
                else
                {
                    Instantiate(foco2, foco2.transform.position, foco2.transform.rotation);
                    //	Instantiate (foco2Volta, foco2Volta.transform.position, foco2Volta.transform.rotation);
                    foco2Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;

            }
            else if (foco1Vivo == false && foco3Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco1, foco1.transform.position, foco1.transform.rotation);
                    //	Instantiate (foco1Volta, foco1Volta.transform.position, foco1Volta.transform.rotation);
                    foco1Vivo = true;
                }
                else
                {
                    Instantiate(foco3, foco3.transform.position, foco3.transform.rotation);
                    //	Instantiate (foco3Volta, foco3Volta.transform.position, foco3Volta.transform.rotation);
                    foco3Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;

            }
            else if (foco1Vivo == false && foco5Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco1, foco1.transform.position, foco1.transform.rotation);
                    //	Instantiate (foco1Volta, foco1Volta.transform.position, foco1Volta.transform.rotation);
                    foco1Vivo = true;
                }
                else
                {
                    Instantiate(foco5, foco5.transform.position, foco5.transform.rotation);
                    //	Instantiate (foco5Volta, foco5Volta.transform.position, foco5Volta.transform.rotation);
                    foco5Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;

            }
            else if (foco2Vivo == false && foco3Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco2, foco2.transform.position, foco2.transform.rotation);
                    //	Instantiate (foco2Volta, foco2Volta.transform.position, foco2Volta.transform.rotation);
                    foco2Vivo = true;
                }
                else
                {
                    Instantiate(foco3, foco3.transform.position, foco3.transform.rotation);
                    //	Instantiate (foco3Volta, foco3Volta.transform.position, foco3Volta.transform.rotation);
                    foco3Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;
            }
            else if (foco2Vivo == false && foco4Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco2, foco2.transform.position, foco2.transform.rotation);
                    //	Instantiate (foco2Volta, foco2Volta.transform.position, foco2Volta.transform.rotation);
                    foco2Vivo = true;
                }
                else
                {
                    Instantiate(foco4, foco4.transform.position, foco4.transform.rotation);
                    //	Instantiate (foco4Volta, foco4Volta.transform.position, foco4Volta.transform.rotation);
                    foco4Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;
            }
            else if (foco2Vivo == false && foco5Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco2, foco2.transform.position, foco2.transform.rotation);
                    //	Instantiate (foco2Volta, foco2Volta.transform.position, foco2Volta.transform.rotation);
                    foco2Vivo = true;
                }
                else
                {
                    Instantiate(foco5, foco5.transform.position, foco5.transform.rotation);
                    //	Instantiate (foco5Volta, foco5Volta.transform.position, foco5Volta.transform.rotation);
                    foco5Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;
            }
            else if (foco3Vivo == false && foco4Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco3, foco3.transform.position, foco3.transform.rotation);
                    //	Instantiate (foco3Volta, foco3Volta.transform.position, foco3Volta.transform.rotation);
                    foco3Vivo = true;
                }
                else
                {
                    Instantiate(foco4, foco4.transform.position, foco4.transform.rotation);
                    //	Instantiate (foco4Volta, foco4Volta.transform.position, foco4Volta.transform.rotation);
                    foco4Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;
            }
            else if (foco3Vivo == false && foco5Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco3, foco3.transform.position, foco3.transform.rotation);
                    ///	Instantiate (foco3Volta, foco3Volta.transform.position, foco3Volta.transform.rotation);
                    foco3Vivo = true;
                }
                else
                {
                    Instantiate(foco5, foco5.transform.position, foco5.transform.rotation);
                    //	Instantiate (foco5Volta, foco5Volta.transform.position, foco5Volta.transform.rotation);
                    foco5Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;
            }
            else if (foco4Vivo == false && foco5Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco4, foco4.transform.position, foco4.transform.rotation);
                    ///	Instantiate (foco4Volta, foco4Volta.transform.position, foco4Volta.transform.rotation);
                    foco4Vivo = true;
                }
                else
                {
                    Instantiate(foco5, foco5.transform.position, foco5.transform.rotation);
                    //	Instantiate (foco5Volta, foco5Volta.transform.position, foco5Volta.transform.rotation);
                    foco5Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;
            }

        }

    }


    private void fase1()
    {
        int aux = (int)contadorTime;
        if (aux == 0)
        {
            Random random = new Random();
            float numeroSorte = Random.Range(0, 10);
            if (AuxFocoTela == null)
            {
                novoFoco();
            }
            else
            {
                try
                {
                    Destroy(AuxFocoTela);
                }
                catch (System.Exception e)
                {

                }
                novoFoco();
            }
            if (foco1Vivo == false && foco4Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco1, foco1.transform.position, foco1.transform.rotation);
                    if (PC == false)
                    {
                        Instantiate(NovoFoco1, NovoFoco1.transform.position, NovoFoco1.transform.rotation);
                    }
                    //Instantiate (foco1Volta, foco1Volta.transform.position, foco1Volta.transform.rotation);
                    foco1Vivo = true;
                }
                else
                {
                    Instantiate(foco4, foco4.transform.position, foco4.transform.rotation);
                    if (PC == false)
                    {
                        Instantiate(NovoFoco4, NovoFoco4.transform.position, NovoFoco4.transform.rotation);
                    }
                    //	Instantiate (foco4Volta, foco4Volta.transform.position, foco4Volta.transform.rotation);
                    foco4Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;
            }
            else if (foco1Vivo == false && foco2Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco1, foco1.transform.position, foco1.transform.rotation);
                    if (PC == false)
                    {
                        Instantiate(NovoFoco1, NovoFoco1.transform.position, NovoFoco1.transform.rotation);
                    }
                    // Instantiate (foco1Volta, foco1Volta.transform.position, foco1Volta.transform.rotation);
                    foco1Vivo = true;
                }
                else
                {
                    Instantiate(foco2, foco2.transform.position, foco2.transform.rotation);
                    if (PC == false)
                    {
                        Instantiate(NovoFoco2, NovoFoco2.transform.position, NovoFoco2.transform.rotation);
                    }
                    //Instantiate (foco2Volta, foco2Volta.transform.position, foco2Volta.transform.rotation);
                    foco2Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;

            }
            else if (foco1Vivo == false && foco3Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco1, foco1.transform.position, foco1.transform.rotation);
                    if (PC == false)
                    {
                        Instantiate(NovoFoco1, NovoFoco1.transform.position, NovoFoco1.transform.rotation);
                    }
                    //Instantiate (foco1Volta, foco1Volta.transform.position, foco1Volta.transform.rotation);
                    foco1Vivo = true;
                }
                else
                {
                    Instantiate(foco3, foco3.transform.position, foco3.transform.rotation);
                    if (PC == false)
                    {
                        Instantiate(NovoFoco3, NovoFoco3.transform.position, NovoFoco3.transform.rotation);
                    }
                    //Instantiate (foco3Volta, foco3Volta.transform.position, foco3Volta.transform.rotation);
                    foco3Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;

            }
            else if (foco2Vivo == false && foco3Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco2, foco2.transform.position, foco2.transform.rotation);
                    //Instantiate (foco2Volta, foco2Volta.transform.position, foco2Volta.transform.rotation);
                    foco2Vivo = true;
                }
                else
                {
                    Instantiate(foco3, foco3.transform.position, foco3.transform.rotation);
                    //	Instantiate (foco3Volta, foco3Volta.transform.position, foco3Volta.transform.rotation);
                    foco3Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;
            }
            else if (foco2Vivo == false && foco4Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco2, foco2.transform.position, foco2.transform.rotation);
                    if (PC == false)
                    {
                        Instantiate(NovoFoco2, NovoFoco2.transform.position, NovoFoco2.transform.rotation);
                    }
                    //	Instantiate (foco2Volta, foco2Volta.transform.position, foco2Volta.transform.rotation);
                    foco2Vivo = true;
                }
                else
                {
                    Instantiate(foco4, foco4.transform.position, foco4.transform.rotation);
                    if (PC == false)
                    {
                        Instantiate(NovoFoco4, NovoFoco4.transform.position, NovoFoco4.transform.rotation);
                    }
                    //Instantiate (foco4Volta, foco4Volta.transform.position, foco4Volta.transform.rotation);
                    foco4Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;
            }
            else if (foco3Vivo == false && foco4Vivo == false)
            {
                if (numeroSorte <= 5)
                {
                    Instantiate(foco3, foco3.transform.position, foco3.transform.rotation);
                    if (PC == false)
                    {
                        Instantiate(NovoFoco3, NovoFoco3.transform.position, NovoFoco3.transform.rotation);
                    }
                    //Instantiate (foco3Volta, foco3Volta.transform.position, foco3Volta.transform.rotation);
                    foco3Vivo = true;
                }
                else
                {
                    Instantiate(foco4, foco4.transform.position, foco4.transform.rotation);
                    if (PC == false)
                    {
                        Instantiate(NovoFoco4, NovoFoco4.transform.position, NovoFoco4.transform.rotation);
                    }
                    //Instantiate (foco4Volta, foco4Volta.transform.position, foco4Volta.transform.rotation);
                    foco4Vivo = true;
                }
                focosativos++;
                contadorTime = valorContador;
            }

        }

    }

    public void MatarFoco1()
    {
        foco1Vivo = false;
        focosativos -= 1;
        Instantiate(foco1Destroi, foco1Destroi.transform.position, foco1Destroi.transform.rotation);
        chamarDestroi();
        this.GetComponent<DadosFase>().AddFocoAbatido();
        this.GetComponent<DadosFase>().IncrementarSaldo(50);

    }

    public void MatarFoco2()
    {
        foco2Vivo = false;
        focosativos -= 1;
        Instantiate(foco2Destroi, foco2Destroi.transform.position, foco2Destroi.transform.rotation);
        chamarDestroi();

        this.GetComponent<DadosFase>().AddFocoAbatido();
        this.GetComponent<DadosFase>().IncrementarSaldo(50);
    }

    public void MatarFoco3()
    {
        foco3Vivo = false;
        focosativos -= 1;
        Instantiate(foco3Destroi, foco3Destroi.transform.position, foco3Destroi.transform.rotation);
        chamarDestroi();

        this.GetComponent<DadosFase>().AddFocoAbatido();
        this.GetComponent<DadosFase>().IncrementarSaldo(50);
    }

    public void MatarFoco4()
    {
        foco4Vivo = false;
        focosativos -= 1;
        Instantiate(foco4Destroi, foco4Destroi.transform.position, foco4Destroi.transform.rotation);
        chamarDestroi();

        this.GetComponent<DadosFase>().AddFocoAbatido();
        this.GetComponent<DadosFase>().IncrementarSaldo(50);
    }

    public void MatarFoco5()
    {
        foco5Vivo = false;
        focosativos -= 1;
        Instantiate(foco5Destroi, foco5Destroi.transform.position, foco5Destroi.transform.rotation);
        chamarDestroi();

        this.GetComponent<DadosFase>().AddFocoAbatido();
        this.GetComponent<DadosFase>().IncrementarSaldo(50);
    }

    public void MatarFoco6()
    {
        foco6Vivo = false;
        focosativos -= 1;
        Instantiate(foco6Destroi, foco6Destroi.transform.position, foco6Destroi.transform.rotation);
        chamarDestroi();

        this.GetComponent<DadosFase>().AddFocoAbatido();
        this.GetComponent<DadosFase>().IncrementarSaldo(50);
    }

    private void chamarDestroi()
    {
        if (Screen.width == 800 && Screen.height == 600)
        {
            AuxFocoTela = Instantiate(telaFocodestruido_800_600, telaFocodestruido_800_600.transform.position, telaFocodestruido_800_600.transform.rotation);
        }
        else if (Screen.width == 2560 && Screen.height == 1440)
        {
            AuxFocoTela = Instantiate(telaFocodestruido_2560_1440, telaFocodestruido_2560_1440.transform.position, telaFocodestruido_2560_1440.transform.rotation);

        }
        else if (Screen.width == 3840 && Screen.height == 2160)
        {
            AuxFocoTela = Instantiate(telaFocodestruido_3840_2160, telaFocodestruido_3840_2160.transform.position, telaFocodestruido_3840_2160.transform.rotation);
        }
        else if (Screen.width == 320 && Screen.height == 240)
        {
            AuxFocoTela = Instantiate(telaFocodestruido_320_240, telaFocodestruido_320_240.transform.position, telaFocodestruido_320_240.transform.rotation);
        }
        else if (Screen.width == 1920 && Screen.height == 1080)
        {
            AuxFocoTela = Instantiate(telaFocodestruido_1920_1080, telaFocodestruido_1920_1080.transform.position, telaFocodestruido_1920_1080.transform.rotation);
        }
        else if (Screen.width == 1280 && Screen.height == 720)
        {
            AuxFocoTela = Instantiate(telaFocodestruido_1280_720, telaFocodestruido_1280_720.transform.position, telaFocodestruido_1280_720.transform.rotation);
        }
        else if (Screen.width == 1136 && Screen.height == 640)
        {
            AuxFocoTela = Instantiate(telaFocodestruido_1136_640, telaFocodestruido_1136_640.transform.position, telaFocodestruido_1136_640.transform.rotation);
        }
        else if (Screen.width == 1134 && Screen.height == 750)
        {
            AuxFocoTela = Instantiate(telaFocodestruido_1134_750, telaFocodestruido_1134_750.transform.position, telaFocodestruido_1134_750.transform.rotation);
        }
        else if (Screen.width == 640 && Screen.height == 360)
        {
            AuxFocoTela = Instantiate(telaFocodestruido_640_360, telaFocodestruido_640_360.transform.position, telaFocodestruido_640_360.transform.rotation);
        }
        else if (Screen.width == 640 && Screen.height == 480)
        {
            AuxFocoTela = Instantiate(telaFocodestruido_640_480, telaFocodestruido_640_480.transform.position, telaFocodestruido_640_480.transform.rotation);
        }
        else if (Screen.width == 960 && Screen.height == 540)
        {
            AuxFocoTela = Instantiate(telaFocodestruido_960_540, telaFocodestruido_960_540.transform.position, telaFocodestruido_960_540.transform.rotation);
        }


    }

    public bool protecao()
    {
        if (HUD != null)
        {
            if (HUD.GetComponent<HUD>() != null)
            {
                return true;

            }
            return false;
        }
        else
        {
            HUD = GameObject.FindGameObjectWithTag("HUD");
        }
        return false;
    }
}

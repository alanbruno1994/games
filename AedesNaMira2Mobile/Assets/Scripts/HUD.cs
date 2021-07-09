using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{

    public GameObject Pausa;
    public float time;
    public Image Vida, Enfermidade, Escudo, BateriaouAgua, ItemBateriaAgua, RelogioImage, Item, EnfermidadeCarregar;
    public Sprite v100, v99, v98, v97, v96, v95, v94, v93, v92, v91, v90, v89, v88, v87, v86, v85, v84, v83, v82, v81;
    public Sprite v80, v79, v78, v77, v76, v75, v74, v73, v72, v71, v70, v69, v68, v67, v66, v65, v64, v63, v62, v61;
    public Sprite v60, v59, v58, v57, v56, v55, v54, v53, v52, v51, v50, v49, v48, v47, v46, v45, v44, v43, v42, v41;
    public Sprite v40, v39, v38, v37, v36, v35, v34, v33, v32, v31, v30, v29, v28, v27, v26, v25, v24, v23, v22, v21;
    public Sprite v20, v19, v18, v17, v16, v15, v14, v13, v12, v11, v10, v9, v8, v7, v6, v5, v4, v3, v2, v1, v0;
    public GameObject Heroi;
    public Sprite e100, e99, e98, e97, e96, e95, e94, e93, e92, e91, e90, e89, e88, e87, e86, e85, e84, e83, e82, e81, e80, e79, e78, e77, e76, e75, e74, e73, e72, e71;
    public Sprite e70, e69, e68, e67, e66, e65, e64, e63, e62, e61, e60, e59, e58, e57, e56, e55, e54, e53, e52, e51, e50, e49, e48, e47, e46, e45, e44, e43, e42, e41;
    public Sprite e40, e39, e38, e37, e36, e35, e34, e33, e32, e31, e30, e29, e28, e27, e26, e25, e24, e23, e22, e21, e20, e19, e18, e17, e16, e15, e14, e13, e12, e11;
    public Sprite e10, e9, e8, e7, e6, e5, e4, e3, e2, e1, e0;
    public Sprite i100, i99, i98, i97, i96, i95, i94, i93, i92, i91, i90, i89, i88, i87, i86, i85, i84, i83, i82, i81, i80, i79, i78, i77, i76, i75, i74, i73, i72, i71;
    public Sprite i70, i69, i68, i67, i66, i65, i64, i63, i62, i61, i60, i59, i58, i57, i56, i55, i54, i53, i52, i51, i50, i49, i48, i47, i46, i45, i44, i43, i42, i41;
    public Sprite i40, i39, i38, i37, i36, i35, i34, i33, i32, i31, i30, i29, i28, i27, i26, i25, i24, i23, i22, i21, i20, i19, i18, i17, i16, i15, i14, i13, i12, i11;
    public Sprite i10, i9, i8, i7, i6, i5, i4, i3, i2, i1, i0;
    public Sprite q100, q99, q98, q97, q96, q95, q94, q93, q92, q91, q90, q89, q88, q87, q86, q85, q84, q83, q82, q81, q80, q79, q78, q77, q76, q75, q74, q73, q72, q71;
    public Sprite q70, q69, q68, q67, q66, q65, q64, q63, q62, q61, q60, q59, q58, q57, q56, q55, q54, q53, q52, q51, q50, q49, q48, q47, q46, q45, q44, q43, q42, q41;
    public Sprite q40, q39, q38, q37, q36, q35, q34, q33, q32, q31, q30, q29, q28, q27, q26, q25, q24, q23, q22, q21, q20, q19, q18, q17, q16, q15, q14, q13, q12, q11;
    public Sprite q10, q9, q8, q7, q6, q5, q4, q3, q2, q1, q0;
    public GameObject Protecao, Disparo, ControleGirar;
    public Sprite SpriteBateria, SpriteAguaSanitaria, SpritePilhaInfinita;
    public GameObject canvasHUD, EscuroAzul, EscuroVermelho, EscuroDourado, Joystik_Direito;
    public Text Relogio, AguaParada, MosquitoMorto, QuantidadePilha, Ponto, Dinheiro;
    public Text RepelenteAzul, RepelenteVermelho, RepelenteDourado, QuantidadeArma;
    public Image embacamento, Visao, areaAguaS, pontoareaAguaS;
    public bool girar = true;
    void Awake()
    {


    }

    // Start is called before the first frame update
    void Start()
    {
        RamSystem.resetRam();
        try
        {
            Heroi = GameObject.FindGameObjectWithTag("Heroi");
            Joystik_Direito = GameObject.FindGameObjectWithTag("controledireito");
            Relogio.text = "";
            AguaParada.text = "";
            MosquitoMorto.text = "0";
            QuantidadePilha.text = "0";
            Ponto.text = "0";

            Dinheiro.text = "" + GameObject.FindGameObjectWithTag("Gerenciar").GetComponent<DadosFase>().Saldo;

            RepelenteAzul.text = "0";
            RepelenteVermelho.text = "0";
            RepelenteDourado.text = "0";
            QuantidadeArma.text = "" + 1;
            EscuroAzul.SetActive(false);
            EscuroVermelho.SetActive(false);
            EscuroDourado.SetActive(false);
            ItemBateriaAgua.sprite = SpriteBateria;
            BateriaouAgua.sprite = q100;
            Enfermidade.enabled = false;
            EnfermidadeCarregar.enabled = false;
            Protecao.SetActive(false);
            Disparo.SetActive(false);
            BateriaouAgua.sprite = SpritePilhaInfinita;
            Time.timeScale = 1;
        }
        catch (System.Exception)
        {


        }

    }

    public void ativarCompra()
    {
        if (Heroi.GetComponent<Heroi>().ativaCompra)
        {
            Heroi.GetComponent<Heroi>().ativaCompra = false;
        }
        else
        {
            Heroi.GetComponent<Heroi>().ativaCompra = true;
        }
    }




    public void TrocarArma()
    {//
        Joystik_Direito.GetComponent<JoystickDireito>().TrocarArma();
        if (RamSystem.ArmaUsada == 4 || RamSystem.ArmaUsada == 5 || RamSystem.ArmaUsada == 6)
        {
            ControleGirar.SetActive(false);
            areaAguaS.enabled = true;
            pontoareaAguaS.enabled = true;
            Heroi.GetComponent<Heroi>().Mao.transform.localRotation = Quaternion.Euler(0, 0, 0);
            Heroi.GetComponent<Heroi>().ataque = false;

        }
        else
        {
            ControleGirar.SetActive(true);
            areaAguaS.enabled = false;
            pontoareaAguaS.enabled = false;
            Heroi.transform.rotation = Quaternion.Euler(0, Heroi.transform.rotation.eulerAngles.y, Heroi.transform.rotation.eulerAngles.z);
        }

    }


    public void TrocarBateria(int id)
    {//
        ItemBateriaAgua.sprite = SpriteBateria;
        if (id == 0)
        {
            BateriaouAgua.sprite = q100;
        }

    }


    public void TrocarAgua()
    {//
        ItemBateriaAgua.sprite = SpriteAguaSanitaria;
    }


    public void UsarRepelenteAzul()
    {
        try
        {
            if (RamSystem.RepelenteAzul >= 1 && Heroi.GetComponent<Heroi>().desabilitarRepelente == false)
            {
                Protecao.SetActive(true);
                EscuroAzul.SetActive(true);
                Heroi.GetComponent<Heroi>().fixarProtecao2segundos();
                RamSystem.RepelenteAzul -= 1;
                RepelenteAzul.text = "" + RamSystem.RepelenteAzul;
            }
        }
        catch (System.Exception)
        {


        }

    }

    public void UsarRepelenteVermelho()
    {
        try
        {
            if (RamSystem.RepelenteVermelho >= 1 && Heroi.GetComponent<Heroi>().desabilitarRepelente == false)
            {
                Protecao.SetActive(true);
                EscuroVermelho.SetActive(true);
                Heroi.GetComponent<Heroi>().fixarProtecao3segundos();
                RamSystem.RepelenteVermelho -= 1;
                RepelenteVermelho.text = "" + RamSystem.RepelenteVermelho;
            }
        }
        catch (System.Exception) { }
    }


    public void UsarRepelenteDourado()
    {
        try
        {
            if (RamSystem.RepelenteDourada >= 1 && Heroi.GetComponent<Heroi>().desabilitarRepelente == false)
            {
                Protecao.SetActive(true);
                EscuroDourado.SetActive(true);
                Heroi.GetComponent<Heroi>().fixarProtecao5segundos();
                RamSystem.RepelenteDourada -= 1;
                RepelenteDourado.text = "" + RamSystem.RepelenteDourada;
            }
        }
        catch (System.Exception)
        {

        }
    }



    public void direita()
    {
        if (girar)
        {
            Heroi.transform.Rotate(0, 120 * Time.deltaTime, 0);
        }

    }

    public void esquerda()
    {
        if (girar)
        {
            Heroi.transform.Rotate(0, -120 * Time.deltaTime, 0);
        }

    }


    public void Stop()
    {
        girar = false;
    }

    public void Run()
    {
        girar = true;
    }

    public void fazerDisparo()
    {
        try
        {
            Debug.Log("fazer disparo " + RamSystem.ArmaUsada);
            if (RamSystem.ArmaUsada == 4)
            {
                GameObject.FindGameObjectWithTag("AguaSAzul").GetComponent<ArmaAguaSanitaria>().Disparar();
            }
            else if (RamSystem.ArmaUsada == 5)
            {
                GameObject.FindGameObjectWithTag("AguaSVermelha").GetComponent<ArmaAguaSanitaria>().Disparar();
            }
            else if (RamSystem.ArmaUsada == 6)
            {
                GameObject.FindGameObjectWithTag("AguaSDourada").GetComponent<ArmaAguaSanitaria>().Disparar();
            }
        }
        catch (System.Exception)
        {


        }

    }

    public void fazerSalto()
    {
        Heroi.GetComponent<Heroi>().saltarHeroi();

    }

    public void AguaRefresh()
    {
        try
        {
            ItemBateriaAgua.sprite = SpriteAguaSanitaria;
            float life = 0;
            switch (RamSystem.ArmaUsada)
            {
                case 4:
                    life = RamSystem.Quantidade1AguaSanitariaAzul;
                    break;
                case 5:
                    life = RamSystem.Quantidade1AguaSanitariaVermelha;
                    break;
                case 6:
                    life = RamSystem.Quantidade1AguaSanitariaDourada;
                    break;
            }
            Debug.Log(RamSystem.ArmaUsada + "  AGUA REFRESH " + life);
            if (life >= 100)
                BateriaouAgua.sprite = q100;
            else if (life >= 99)
                BateriaouAgua.sprite = q99;
            else if (life >= 98)
                BateriaouAgua.sprite = q98;
            else if (life >= 97)
                BateriaouAgua.sprite = q97;
            else if (life >= 96)
                BateriaouAgua.sprite = q96;
            else if (life >= 95)
                BateriaouAgua.sprite = q95;
            else if (life >= 94)
                BateriaouAgua.sprite = q94;
            else if (life >= 93)
                BateriaouAgua.sprite = q93;
            else if (life >= 92)
                BateriaouAgua.sprite = q92;
            else if (life >= 91)
                BateriaouAgua.sprite = q91;
            else if (life >= 90)
                BateriaouAgua.sprite = q90;
            else if (life >= 89)
                BateriaouAgua.sprite = q89;
            else if (life >= 87)
                BateriaouAgua.sprite = q87;
            else if (life >= 86)
                BateriaouAgua.sprite = q86;
            else if (life >= 85)
                BateriaouAgua.sprite = q85;
            else if (life >= 84)
                BateriaouAgua.sprite = q84;
            else if (life >= 83)
                BateriaouAgua.sprite = q83;
            else if (life >= 82)
                BateriaouAgua.sprite = q82;
            else if (life >= 81)
                BateriaouAgua.sprite = q81;
            else if (life >= 80)
                BateriaouAgua.sprite = q80;
            else if (life >= 79)
                BateriaouAgua.sprite = q79;
            else if (life >= 78)
                BateriaouAgua.sprite = q78;
            else if (life >= 77)
                BateriaouAgua.sprite = q77;
            else if (life >= 76)
                BateriaouAgua.sprite = q76;
            else if (life >= 75)
                BateriaouAgua.sprite = q75;
            else if (life >= 74)
                BateriaouAgua.sprite = q74;
            else if (life >= 73)
                BateriaouAgua.sprite = q73;
            else if (life >= 72)
                BateriaouAgua.sprite = q72;
            else if (life >= 71)
                BateriaouAgua.sprite = q71;
            else if (life >= 70)
                BateriaouAgua.sprite = q70;
            else if (life >= 69)
                BateriaouAgua.sprite = q69;
            else if (life >= 68)
                BateriaouAgua.sprite = q68;
            else if (life >= 67)
                BateriaouAgua.sprite = q67;
            else if (life >= 66)
                BateriaouAgua.sprite = q66;
            else if (life >= 65)
                BateriaouAgua.sprite = q65;
            else if (life >= 64)
                BateriaouAgua.sprite = q64;
            else if (life >= 63)
                BateriaouAgua.sprite = q63;
            else if (life >= 62)
                BateriaouAgua.sprite = q62;
            else if (life >= 61)
                BateriaouAgua.sprite = q61;
            else if (life >= 60)
                BateriaouAgua.sprite = q60;
            else if (life >= 59)
                BateriaouAgua.sprite = q59;
            else if (life >= 58)
                BateriaouAgua.sprite = q58;
            else if (life >= 57)
                BateriaouAgua.sprite = q57;
            else if (life >= 56)
                BateriaouAgua.sprite = q56;
            else if (life >= 55)
                BateriaouAgua.sprite = q55;
            else if (life >= 54)
                BateriaouAgua.sprite = q54;
            else if (life >= 53)
                BateriaouAgua.sprite = q53;
            else if (life >= 52)
                BateriaouAgua.sprite = q52;
            else if (life >= 51)
                BateriaouAgua.sprite = q51;
            else if (life >= 50)
                BateriaouAgua.sprite = q50;
            else if (life >= 49)
                BateriaouAgua.sprite = q49;
            else if (life >= 48)
                BateriaouAgua.sprite = q48;
            else if (life >= 47)
                BateriaouAgua.sprite = q47;
            else if (life >= 46)
                BateriaouAgua.sprite = q46;
            else if (life >= 45)
                BateriaouAgua.sprite = q45;
            else if (life >= 44)
                BateriaouAgua.sprite = q44;
            else if (life >= 43)
                BateriaouAgua.sprite = q43;
            else if (life >= 42)
                BateriaouAgua.sprite = q42;
            else if (life >= 41)
                BateriaouAgua.sprite = q41;
            else if (life >= 40)
                BateriaouAgua.sprite = q40;
            else if (life >= 39)
                BateriaouAgua.sprite = q39;
            else if (life >= 38)
                BateriaouAgua.sprite = q38;
            else if (life >= 37)
                BateriaouAgua.sprite = q37;
            else if (life >= 36)
                BateriaouAgua.sprite = q36;
            else if (life >= 35)
                BateriaouAgua.sprite = q35;
            else if (life >= 34)
                BateriaouAgua.sprite = q34;
            else if (life >= 33)
                BateriaouAgua.sprite = q33;
            else if (life >= 32)
                BateriaouAgua.sprite = q32;
            else if (life >= 31)
                BateriaouAgua.sprite = q31;
            else if (life >= 30)
                BateriaouAgua.sprite = q30;
            else if (life >= 29)
                BateriaouAgua.sprite = q29;
            else if (life >= 28)
                BateriaouAgua.sprite = q28;
            else if (life >= 27)
                BateriaouAgua.sprite = q27;
            else if (life >= 26)
                BateriaouAgua.sprite = q26;
            else if (life >= 25)
                BateriaouAgua.sprite = q25;
            else if (life >= 24)
                BateriaouAgua.sprite = q24;
            else if (life >= 23)
                BateriaouAgua.sprite = q23;
            else if (life >= 22)
                BateriaouAgua.sprite = q22;
            else if (life >= 21)
                BateriaouAgua.sprite = q21;
            else if (life >= 20)
                BateriaouAgua.sprite = q20;
            else if (life >= 19)
                BateriaouAgua.sprite = q19;
            else if (life >= 18)
                BateriaouAgua.sprite = q18;
            else if (life >= 17)
                BateriaouAgua.sprite = q17;
            else if (life >= 16)
                BateriaouAgua.sprite = q16;
            else if (life >= 15)
                BateriaouAgua.sprite = q15;
            else if (life >= 14)
                BateriaouAgua.sprite = q14;
            else if (life >= 13)
                BateriaouAgua.sprite = q13;
            else if (life >= 12)
                BateriaouAgua.sprite = q12;
            else if (life >= 11)
                BateriaouAgua.sprite = q11;
            else if (life >= 10)
                BateriaouAgua.sprite = q10;
            else if (life >= 9)
                BateriaouAgua.sprite = q9;
            else if (life >= 8)
                BateriaouAgua.sprite = q8;
            else if (life >= 7)
                BateriaouAgua.sprite = q7;
            else if (life >= 6)
                BateriaouAgua.sprite = q5;
            else if (life >= 5)
                BateriaouAgua.sprite = q5;
            else if (life >= 4)
                BateriaouAgua.sprite = q4;
            else if (life >= 3)
                BateriaouAgua.sprite = q3;
            else if (life >= 2)
                BateriaouAgua.sprite = q2;
            else if (life >= 1)
                BateriaouAgua.sprite = q1;
            else if (life <= 0)
                BateriaouAgua.sprite = q0;
        }
        catch (System.Exception)
        {

        }
    }

    public void BateriaRefresh()
    {
        if (RamSystem.QuantidadePilhas >= 1)
        {
            ItemBateriaAgua.sprite = SpriteBateria;
            float life = RamSystem.Quantidade1Pilha;
            if (life >= 100)
                BateriaouAgua.sprite = q100;
            else if (life >= 99)
                BateriaouAgua.sprite = q99;
            else if (life >= 98)
                BateriaouAgua.sprite = q98;
            else if (life >= 97)
                BateriaouAgua.sprite = q97;
            else if (life >= 96)
                BateriaouAgua.sprite = q96;
            else if (life >= 95)
                BateriaouAgua.sprite = q95;
            else if (life >= 94)
                BateriaouAgua.sprite = q94;
            else if (life >= 93)
                BateriaouAgua.sprite = q93;
            else if (life >= 92)
                BateriaouAgua.sprite = q92;
            else if (life >= 91)
                BateriaouAgua.sprite = q91;
            else if (life >= 90)
                BateriaouAgua.sprite = q90;
            else if (life >= 89)
                BateriaouAgua.sprite = q89;
            else if (life >= 87)
                BateriaouAgua.sprite = q87;
            else if (life >= 86)
                BateriaouAgua.sprite = q86;
            else if (life >= 85)
                BateriaouAgua.sprite = q85;
            else if (life >= 84)
                BateriaouAgua.sprite = q84;
            else if (life >= 83)
                BateriaouAgua.sprite = q83;
            else if (life >= 82)
                BateriaouAgua.sprite = q82;
            else if (life >= 81)
                BateriaouAgua.sprite = q81;
            else if (life >= 80)
                BateriaouAgua.sprite = q80;
            else if (life >= 79)
                BateriaouAgua.sprite = q79;
            else if (life >= 78)
                BateriaouAgua.sprite = q78;
            else if (life >= 77)
                BateriaouAgua.sprite = q77;
            else if (life >= 76)
                BateriaouAgua.sprite = q76;
            else if (life >= 75)
                BateriaouAgua.sprite = q75;
            else if (life >= 74)
                BateriaouAgua.sprite = q74;
            else if (life >= 73)
                BateriaouAgua.sprite = q73;
            else if (life >= 72)
                BateriaouAgua.sprite = q72;
            else if (life >= 71)
                BateriaouAgua.sprite = q71;
            else if (life >= 70)
                BateriaouAgua.sprite = q70;
            else if (life >= 69)
                BateriaouAgua.sprite = q69;
            else if (life >= 68)
                BateriaouAgua.sprite = q68;
            else if (life >= 67)
                BateriaouAgua.sprite = q67;
            else if (life >= 66)
                BateriaouAgua.sprite = q66;
            else if (life >= 65)
                BateriaouAgua.sprite = q65;
            else if (life >= 64)
                BateriaouAgua.sprite = q64;
            else if (life >= 63)
                BateriaouAgua.sprite = q63;
            else if (life >= 62)
                BateriaouAgua.sprite = q62;
            else if (life >= 61)
                BateriaouAgua.sprite = q61;
            else if (life >= 60)
                BateriaouAgua.sprite = q60;
            else if (life >= 59)
                BateriaouAgua.sprite = q59;
            else if (life >= 58)
                BateriaouAgua.sprite = q58;
            else if (life >= 57)
                BateriaouAgua.sprite = q57;
            else if (life >= 56)
                BateriaouAgua.sprite = q56;
            else if (life >= 55)
                BateriaouAgua.sprite = q55;
            else if (life >= 54)
                BateriaouAgua.sprite = q54;
            else if (life >= 53)
                BateriaouAgua.sprite = q53;
            else if (life >= 52)
                BateriaouAgua.sprite = q52;
            else if (life >= 51)
                BateriaouAgua.sprite = q51;
            else if (life >= 50)
                BateriaouAgua.sprite = q50;
            else if (life >= 49)
                BateriaouAgua.sprite = q49;
            else if (life >= 48)
                BateriaouAgua.sprite = q48;
            else if (life >= 47)
                BateriaouAgua.sprite = q47;
            else if (life >= 46)
                BateriaouAgua.sprite = q46;
            else if (life >= 45)
                BateriaouAgua.sprite = q45;
            else if (life >= 44)
                BateriaouAgua.sprite = q44;
            else if (life >= 43)
                BateriaouAgua.sprite = q43;
            else if (life >= 42)
                BateriaouAgua.sprite = q42;
            else if (life >= 41)
                BateriaouAgua.sprite = q41;
            else if (life >= 40)
                BateriaouAgua.sprite = q40;
            else if (life >= 39)
                BateriaouAgua.sprite = q39;
            else if (life >= 38)
                BateriaouAgua.sprite = q38;
            else if (life >= 37)
                BateriaouAgua.sprite = q37;
            else if (life >= 36)
                BateriaouAgua.sprite = q36;
            else if (life >= 35)
                BateriaouAgua.sprite = q35;
            else if (life >= 34)
                BateriaouAgua.sprite = q34;
            else if (life >= 33)
                BateriaouAgua.sprite = q33;
            else if (life >= 32)
                BateriaouAgua.sprite = q32;
            else if (life >= 31)
                BateriaouAgua.sprite = q31;
            else if (life >= 30)
                BateriaouAgua.sprite = q30;
            else if (life >= 29)
                BateriaouAgua.sprite = q29;
            else if (life >= 28)
                BateriaouAgua.sprite = q28;
            else if (life >= 27)
                BateriaouAgua.sprite = q27;
            else if (life >= 26)
                BateriaouAgua.sprite = q26;
            else if (life >= 25)
                BateriaouAgua.sprite = q25;
            else if (life >= 24)
                BateriaouAgua.sprite = q24;
            else if (life >= 23)
                BateriaouAgua.sprite = q23;
            else if (life >= 22)
                BateriaouAgua.sprite = q22;
            else if (life >= 21)
                BateriaouAgua.sprite = q21;
            else if (life >= 20)
                BateriaouAgua.sprite = q20;
            else if (life >= 19)
                BateriaouAgua.sprite = q19;
            else if (life >= 18)
                BateriaouAgua.sprite = q18;
            else if (life >= 17)
                BateriaouAgua.sprite = q17;
            else if (life >= 16)
                BateriaouAgua.sprite = q16;
            else if (life >= 15)
                BateriaouAgua.sprite = q15;
            else if (life >= 14)
                BateriaouAgua.sprite = q14;
            else if (life >= 13)
                BateriaouAgua.sprite = q13;
            else if (life >= 12)
                BateriaouAgua.sprite = q12;
            else if (life >= 11)
                BateriaouAgua.sprite = q11;
            else if (life >= 10)
                BateriaouAgua.sprite = q10;
            else if (life >= 9)
                BateriaouAgua.sprite = q9;
            else if (life >= 8)
                BateriaouAgua.sprite = q8;
            else if (life >= 7)
                BateriaouAgua.sprite = q7;
            else if (life >= 6)
                BateriaouAgua.sprite = q5;
            else if (life >= 5)
                BateriaouAgua.sprite = q5;
            else if (life >= 4)
                BateriaouAgua.sprite = q4;
            else if (life >= 3)
                BateriaouAgua.sprite = q3;
            else if (life >= 2)
                BateriaouAgua.sprite = q2;
            else if (life >= 1)
                BateriaouAgua.sprite = q1;
            else if (life <= 0)
            {
                BateriaouAgua.sprite = q0;
                if (RamSystem.QuantidadePilhas - 1 >= 0)
                {
                    RamSystem.QuantidadePilhas -= 1;
                    RamSystem.Quantidade1Pilha = 100;
                    BateriaouAgua.sprite = q100;
                    if (RamSystem.QuantidadePilhas == 0)
                    {
                        RamSystem.ArmaUsada = 0;
                        Joystik_Direito.GetComponent<JoystickDireito>().ArmaUsada();
                        BateriaouAgua.sprite = SpritePilhaInfinita;
                    }
                }
                QuantidadePilha.text = "" + RamSystem.QuantidadePilhas;
            }
        }
        else
        {
            BateriaouAgua.sprite = SpritePilhaInfinita;
        }

    }




    public void vidaRefresh()
    {
        float life = 100;
        try
        {
            life = Heroi.GetComponent<Heroi>().life;

            if (life >= 100)
                Vida.sprite = v100;
            else if (life >= 99)
                Vida.sprite = v99;
            else if (life >= 98)
                Vida.sprite = v98;
            else if (life >= 97)
                Vida.sprite = v97;
            else if (life >= 96)
                Vida.sprite = v96;
            else if (life >= 95)
                Vida.sprite = v95;
            else if (life >= 94)
                Vida.sprite = v94;
            else if (life >= 93)
                Vida.sprite = v93;
            else if (life >= 92)
                Vida.sprite = v92;
            else if (life >= 91)
                Vida.sprite = v91;
            else if (life >= 90)
                Vida.sprite = v90;
            else if (life >= 89)
                Vida.sprite = v89;
            else if (life >= 87)
                Vida.sprite = v87;
            else if (life >= 86)
                Vida.sprite = v86;
            else if (life >= 85)
                Vida.sprite = v85;
            else if (life >= 84)
                Vida.sprite = v84;
            else if (life >= 83)
                Vida.sprite = v83;
            else if (life >= 82)
                Vida.sprite = v82;
            else if (life >= 81)
                Vida.sprite = v81;
            else if (life >= 80)
                Vida.sprite = v80;
            else if (life >= 79)
                Vida.sprite = v79;
            else if (life >= 78)
                Vida.sprite = v78;
            else if (life >= 77)
                Vida.sprite = v77;
            else if (life >= 76)
                Vida.sprite = v76;
            else if (life >= 75)
                Vida.sprite = v75;
            else if (life >= 74)
                Vida.sprite = v74;
            else if (life >= 73)
                Vida.sprite = v73;
            else if (life >= 72)
                Vida.sprite = v72;
            else if (life >= 71)
                Vida.sprite = v71;
            else if (life >= 70)
                Vida.sprite = v70;
            else if (life >= 69)
                Vida.sprite = v69;
            else if (life >= 68)
                Vida.sprite = v68;
            else if (life >= 67)
                Vida.sprite = v67;
            else if (life >= 66)
                Vida.sprite = v66;
            else if (life >= 65)
                Vida.sprite = v65;
            else if (life >= 64)
                Vida.sprite = v64;
            else if (life >= 63)
                Vida.sprite = v63;
            else if (life >= 62)
                Vida.sprite = v62;
            else if (life >= 61)
                Vida.sprite = v61;
            else if (life >= 60)
                Vida.sprite = v60;
            else if (life >= 59)
                Vida.sprite = v59;
            else if (life >= 58)
                Vida.sprite = v58;
            else if (life >= 57)
                Vida.sprite = v57;
            else if (life >= 56)
                Vida.sprite = v56;
            else if (life >= 55)
                Vida.sprite = v55;
            else if (life >= 54)
                Vida.sprite = v54;
            else if (life >= 53)
                Vida.sprite = v53;
            else if (life >= 52)
                Vida.sprite = v52;
            else if (life >= 51)
                Vida.sprite = v51;
            else if (life >= 50)
                Vida.sprite = v50;
            else if (life >= 49)
                Vida.sprite = v49;
            else if (life >= 48)
                Vida.sprite = v48;
            else if (life >= 47)
                Vida.sprite = v47;
            else if (life >= 46)
                Vida.sprite = v46;
            else if (life >= 45)
                Vida.sprite = v45;
            else if (life >= 44)
                Vida.sprite = v44;
            else if (life >= 43)
                Vida.sprite = v43;
            else if (life >= 42)
                Vida.sprite = v42;
            else if (life >= 41)
                Vida.sprite = v41;
            else if (life >= 40)
                Vida.sprite = v40;
            else if (life >= 39)
                Vida.sprite = v39;
            else if (life >= 38)
                Vida.sprite = v38;
            else if (life >= 37)
                Vida.sprite = v37;
            else if (life >= 36)
                Vida.sprite = v36;
            else if (life >= 35)
                Vida.sprite = v35;
            else if (life >= 34)
                Vida.sprite = v34;
            else if (life >= 33)
                Vida.sprite = v33;
            else if (life >= 32)
                Vida.sprite = v32;
            else if (life >= 31)
                Vida.sprite = v31;
            else if (life >= 30)
                Vida.sprite = v30;
            else if (life >= 29)
                Vida.sprite = v29;
            else if (life >= 28)
                Vida.sprite = v28;
            else if (life >= 27)
                Vida.sprite = v27;
            else if (life >= 26)
                Vida.sprite = v26;
            else if (life >= 25)
                Vida.sprite = v25;
            else if (life >= 24)
                Vida.sprite = v24;
            else if (life >= 23)
                Vida.sprite = v23;
            else if (life >= 22)
                Vida.sprite = v22;
            else if (life >= 21)
                Vida.sprite = v21;
            else if (life >= 20)
                Vida.sprite = v20;
            else if (life >= 19)
                Vida.sprite = v19;
            else if (life >= 18)
                Vida.sprite = v18;
            else if (life >= 17)
                Vida.sprite = v17;
            else if (life >= 16)
                Vida.sprite = v16;
            else if (life >= 15)
                Vida.sprite = v15;
            else if (life >= 14)
                Vida.sprite = v14;
            else if (life >= 13)
                Vida.sprite = v13;
            else if (life >= 12)
                Vida.sprite = v12;
            else if (life >= 11)
                Vida.sprite = v11;
            else if (life >= 10)
                Vida.sprite = v10;
            else if (life >= 9)
                Vida.sprite = v9;
            else if (life >= 8)
                Vida.sprite = v8;
            else if (life >= 7)
                Vida.sprite = v7;
            else if (life >= 6)
                Vida.sprite = v5;
            else if (life >= 5)
                Vida.sprite = v5;
            else if (life >= 4)
                Vida.sprite = v4;
            else if (life >= 3)
                Vida.sprite = v3;
            else if (life >= 2)
                Vida.sprite = v2;
            else if (life >= 1)
                Vida.sprite = v1;
            else if (life <= 0)
                Vida.sprite = v0;
        }
        catch (System.Exception e)
        {

        }
    }

    public void statusVidaPreservada()
    {
        try
        {
            int vidaPreservada = Heroi.GetComponent<Heroi>().protecao;
            if (vidaPreservada > 0)
            {
                Protecao.SetActive(true);
            }
            switch (vidaPreservada)
            {
                case 100:
                    Escudo.sprite = i100;
                    break;
                case 99:
                    Escudo.sprite = i99;
                    break;
                case 98:
                    Escudo.sprite = i98;
                    break;
                case 97:
                    Escudo.sprite = i97;
                    break;
                case 96:
                    Escudo.sprite = i96;
                    break;
                case 95:
                    Escudo.sprite = i95;
                    break;
                case 94:
                    Escudo.sprite = i94;
                    break;
                case 93:
                    Escudo.sprite = i93;
                    break;
                case 92:
                    Escudo.sprite = i92;
                    break;
                case 91:
                    Escudo.sprite = i91;
                    break;
                case 90:
                    Escudo.sprite = i90;
                    break;
                case 89:
                    Escudo.sprite = i89;
                    break;
                case 88:
                    Escudo.sprite = i88;
                    break;
                case 87:
                    Escudo.sprite = i87;
                    break;
                case 86:
                    Escudo.sprite = i86;
                    break;
                case 85:
                    Escudo.sprite = i85;
                    break;
                case 84:
                    Escudo.sprite = i84;
                    break;
                case 83:
                    Escudo.sprite = i83;
                    break;
                case 82:
                    Escudo.sprite = i82;
                    break;
                case 81:
                    Escudo.sprite = i81;
                    break;
                case 80:
                    Escudo.sprite = i80;
                    break;
                case 79:
                    Escudo.sprite = i79;
                    break;
                case 78:
                    Escudo.sprite = i78;
                    break;
                case 77:
                    Escudo.sprite = i77;
                    break;
                case 76:
                    Escudo.sprite = i76;
                    break;
                case 75:
                    Escudo.sprite = i75;
                    break;
                case 74:
                    Escudo.sprite = i74;
                    break;
                case 73:
                    Escudo.sprite = i73;
                    break;
                case 72:
                    Escudo.sprite = i72;
                    break;
                case 71:
                    Escudo.sprite = i71;
                    break;
                case 70:
                    Escudo.sprite = i70;
                    break;
                case 69:
                    Escudo.sprite = i69;
                    break;
                case 68:
                    Escudo.sprite = i68;
                    break;
                case 67:
                    Escudo.sprite = i67;
                    break;
                case 66:
                    Escudo.sprite = i66;
                    break;
                case 65:
                    Escudo.sprite = i65;
                    break;
                case 64:
                    Escudo.sprite = i64;
                    break;
                case 63:
                    Escudo.sprite = i63;
                    break;
                case 62:
                    Escudo.sprite = i62;
                    break;
                case 61:
                    Escudo.sprite = i61;
                    break;
                case 60:
                    Escudo.sprite = i60;
                    break;
                case 59:
                    Escudo.sprite = i59;
                    break;
                case 58:
                    Escudo.sprite = i58;
                    break;
                case 57:
                    Escudo.sprite = i57;
                    break;
                case 56:
                    Escudo.sprite = i56;
                    break;
                case 55:
                    Escudo.sprite = i55;
                    break;
                case 54:
                    Escudo.sprite = i54;
                    break;
                case 53:
                    Escudo.sprite = i53;
                    break;
                case 52:
                    Escudo.sprite = i52;
                    break;
                case 51:
                    Escudo.sprite = i51;
                    break;
                case 50:
                    Escudo.sprite = i50;
                    break;
                case 49:
                    Escudo.sprite = i49;
                    break;
                case 48:
                    Escudo.sprite = i48;
                    break;
                case 47:
                    Escudo.sprite = i47;
                    break;
                case 46:
                    Escudo.sprite = i46;
                    break;
                case 45:
                    Escudo.sprite = i45;
                    break;
                case 44:
                    Escudo.sprite = i44;
                    break;
                case 43:
                    Escudo.sprite = i43;
                    break;
                case 42:
                    Escudo.sprite = i42;
                    break;
                case 41:
                    Escudo.sprite = i41;
                    break;
                case 40:
                    Escudo.sprite = i40;
                    break;
                case 39:
                    Escudo.sprite = i39;
                    break;
                case 38:
                    Escudo.sprite = i38;
                    break;
                case 37:
                    Escudo.sprite = i37;
                    break;
                case 36:
                    Escudo.sprite = i36;
                    break;
                case 35:
                    Escudo.sprite = i35;
                    break;
                case 34:
                    Escudo.sprite = i34;
                    break;
                case 33:
                    Escudo.sprite = i33;
                    break;
                case 32:
                    Escudo.sprite = i32;
                    break;
                case 31:
                    Escudo.sprite = i31;
                    break;
                case 30:
                    Escudo.sprite = i30;
                    break;
                case 29:
                    Escudo.sprite = i29;
                    break;
                case 28:
                    Escudo.sprite = i28;
                    break;
                case 27:
                    Escudo.sprite = i27;
                    break;
                case 26:
                    Escudo.sprite = e26;
                    break;
                case 25:
                    Escudo.sprite = i25;
                    break;
                case 24:
                    Escudo.sprite = i24;
                    break;
                case 23:
                    Escudo.sprite = i23;
                    break;
                case 22:
                    Escudo.sprite = i22;
                    break;
                case 21:
                    Escudo.sprite = i21;
                    break;
                case 20:
                    Escudo.sprite = i20;
                    break;
                case 19:
                    Escudo.sprite = i19;
                    break;
                case 18:
                    Escudo.sprite = i18;
                    break;
                case 17:
                    Escudo.sprite = i17;
                    break;
                case 16:
                    Escudo.sprite = i16;
                    break;
                case 15:
                    Escudo.sprite = i15;
                    break;
                case 14:
                    Escudo.sprite = i14;
                    break;
                case 13:
                    Escudo.sprite = i13;
                    break;
                case 12:
                    Escudo.sprite = i12;
                    break;
                case 11:
                    Escudo.sprite = i11;
                    break;
                case 10:
                    Escudo.sprite = i10;
                    break;
                case 9:
                    Escudo.sprite = i9;
                    break;
                case 8:
                    Escudo.sprite = i8;
                    break;
                case 7:
                    Escudo.sprite = i7;
                    break;
                case 6:
                    Escudo.sprite = i6;
                    break;
                case 5:
                    Escudo.sprite = i5;
                    break;
                case 4:
                    Escudo.sprite = i4;
                    break;
                case 3:
                    Escudo.sprite = i3;
                    break;
                case 2:
                    Escudo.sprite = i2;
                    break;
                case 1:
                    Escudo.sprite = i1;
                    break;
                case 0:
                    Escudo.sprite = i0;
                    Protecao.SetActive(false);
                    break;
            }
        }
        catch (System.Exception)
        {


        }
    }

    public void refreshDoenca()
    {
        try
        {
            int porcetagemDoente = Heroi.GetComponent<Heroi>().porcetagemDoente;
            if (porcetagemDoente > 0)
            {

                Enfermidade.enabled = true;
                EnfermidadeCarregar.enabled = true;


            }

            switch (porcetagemDoente)
            {
                case 100:
                    EnfermidadeCarregar.sprite = e100;
                    break;
                case 99:
                    EnfermidadeCarregar.sprite = e99;
                    break;
                case 98:
                    EnfermidadeCarregar.sprite = e98;
                    break;
                case 97:
                    EnfermidadeCarregar.sprite = e97;
                    break;
                case 96:
                    EnfermidadeCarregar.sprite = e96;
                    break;
                case 95:
                    EnfermidadeCarregar.sprite = e95;
                    break;
                case 94:
                    EnfermidadeCarregar.sprite = e94;
                    break;
                case 93:
                    EnfermidadeCarregar.sprite = e93;
                    break;
                case 92:
                    EnfermidadeCarregar.sprite = e92;
                    break;
                case 91:
                    EnfermidadeCarregar.sprite = e91;
                    break;
                case 90:
                    EnfermidadeCarregar.sprite = e90;
                    break;
                case 89:
                    EnfermidadeCarregar.sprite = e89;
                    break;
                case 88:
                    EnfermidadeCarregar.sprite = e88;
                    break;
                case 87:
                    EnfermidadeCarregar.sprite = e87;
                    break;
                case 86:
                    EnfermidadeCarregar.sprite = e86;
                    break;
                case 85:
                    EnfermidadeCarregar.sprite = e85;
                    break;
                case 84:
                    EnfermidadeCarregar.sprite = e84;
                    break;
                case 83:
                    EnfermidadeCarregar.sprite = e83;
                    break;
                case 82:
                    EnfermidadeCarregar.sprite = e82;
                    break;
                case 81:
                    EnfermidadeCarregar.sprite = e81;
                    break;
                case 80:
                    EnfermidadeCarregar.sprite = e80;
                    break;
                case 79:
                    EnfermidadeCarregar.sprite = e79;
                    break;
                case 78:
                    EnfermidadeCarregar.sprite = e78;
                    break;
                case 77:
                    EnfermidadeCarregar.sprite = e77;
                    break;
                case 76:
                    EnfermidadeCarregar.sprite = e76;
                    break;
                case 75:
                    EnfermidadeCarregar.sprite = e75;
                    break;
                case 74:
                    EnfermidadeCarregar.sprite = e74;
                    break;
                case 73:
                    EnfermidadeCarregar.sprite = e73;
                    break;
                case 72:
                    EnfermidadeCarregar.sprite = e72;
                    break;
                case 71:
                    EnfermidadeCarregar.sprite = e71;
                    break;
                case 70:
                    EnfermidadeCarregar.sprite = e70;
                    break;
                case 69:
                    EnfermidadeCarregar.sprite = e69;
                    break;
                case 68:
                    EnfermidadeCarregar.sprite = e68;
                    break;
                case 67:
                    EnfermidadeCarregar.sprite = e67;
                    break;
                case 66:
                    EnfermidadeCarregar.sprite = e66;
                    break;
                case 65:
                    EnfermidadeCarregar.sprite = e65;
                    break;
                case 64:
                    EnfermidadeCarregar.sprite = e64;
                    break;
                case 63:
                    EnfermidadeCarregar.sprite = e63;
                    break;
                case 62:
                    EnfermidadeCarregar.sprite = e62;
                    break;
                case 61:
                    EnfermidadeCarregar.sprite = e61;
                    break;
                case 60:
                    EnfermidadeCarregar.sprite = e60;
                    break;
                case 59:
                    EnfermidadeCarregar.sprite = e59;
                    break;
                case 58:
                    EnfermidadeCarregar.sprite = e58;
                    break;
                case 57:
                    EnfermidadeCarregar.sprite = e57;
                    break;
                case 56:
                    EnfermidadeCarregar.sprite = e56;
                    break;
                case 55:
                    EnfermidadeCarregar.sprite = e55;
                    break;
                case 54:
                    EnfermidadeCarregar.sprite = e54;
                    break;
                case 53:
                    EnfermidadeCarregar.sprite = e53;
                    break;
                case 52:
                    EnfermidadeCarregar.sprite = e52;
                    break;
                case 51:
                    EnfermidadeCarregar.sprite = e51;
                    break;
                case 50:
                    EnfermidadeCarregar.sprite = e50;
                    break;
                case 49:
                    EnfermidadeCarregar.sprite = e49;
                    break;
                case 48:
                    EnfermidadeCarregar.sprite = e48;
                    break;
                case 47:
                    EnfermidadeCarregar.sprite = e47;
                    break;
                case 46:
                    EnfermidadeCarregar.sprite = e46;
                    break;
                case 45:
                    EnfermidadeCarregar.sprite = e45;
                    break;
                case 44:
                    EnfermidadeCarregar.sprite = e44;
                    break;
                case 43:
                    EnfermidadeCarregar.sprite = e43;
                    break;
                case 42:
                    EnfermidadeCarregar.sprite = e42;
                    break;
                case 41:
                    EnfermidadeCarregar.sprite = e41;
                    break;
                case 40:
                    EnfermidadeCarregar.sprite = e40;
                    break;
                case 39:
                    EnfermidadeCarregar.sprite = e39;
                    break;
                case 38:
                    EnfermidadeCarregar.sprite = e38;
                    break;
                case 37:
                    EnfermidadeCarregar.sprite = e37;
                    break;
                case 36:
                    EnfermidadeCarregar.sprite = e36;
                    break;
                case 35:
                    EnfermidadeCarregar.sprite = e35;
                    break;
                case 34:
                    EnfermidadeCarregar.sprite = e34;
                    break;
                case 33:
                    EnfermidadeCarregar.sprite = e33;
                    break;
                case 32:
                    EnfermidadeCarregar.sprite = e32;
                    break;
                case 31:
                    EnfermidadeCarregar.sprite = e31;
                    break;
                case 30:
                    EnfermidadeCarregar.sprite = e30;
                    break;
                case 29:
                    EnfermidadeCarregar.sprite = e29;
                    break;
                case 28:
                    EnfermidadeCarregar.sprite = e28;
                    break;
                case 27:
                    EnfermidadeCarregar.sprite = e27;
                    break;
                case 26:
                    EnfermidadeCarregar.sprite = e26;
                    break;
                case 25:
                    EnfermidadeCarregar.sprite = e25;
                    break;
                case 24:
                    EnfermidadeCarregar.sprite = e24;
                    break;
                case 23:
                    EnfermidadeCarregar.sprite = e23;
                    break;
                case 22:
                    EnfermidadeCarregar.sprite = e22;
                    break;
                case 21:
                    EnfermidadeCarregar.sprite = e21;
                    break;
                case 20:
                    EnfermidadeCarregar.sprite = e20;
                    break;
                case 19:
                    EnfermidadeCarregar.sprite = e19;
                    break;
                case 18:
                    EnfermidadeCarregar.sprite = e18;
                    break;
                case 17:
                    EnfermidadeCarregar.sprite = e17;
                    break;
                case 16:
                    EnfermidadeCarregar.sprite = e16;
                    break;
                case 15:
                    EnfermidadeCarregar.sprite = e15;
                    break;
                case 14:
                    EnfermidadeCarregar.sprite = e14;
                    break;
                case 13:
                    EnfermidadeCarregar.sprite = e13;
                    break;
                case 12:
                    EnfermidadeCarregar.sprite = e12;
                    break;
                case 11:
                    EnfermidadeCarregar.sprite = e11;
                    break;
                case 10:
                    EnfermidadeCarregar.sprite = e10;
                    break;
                case 9:
                    EnfermidadeCarregar.sprite = e9;
                    break;
                case 8:
                    EnfermidadeCarregar.sprite = e8;
                    break;
                case 7:
                    EnfermidadeCarregar.sprite = e7;
                    break;
                case 6:
                    EnfermidadeCarregar.sprite = e6;
                    break;
                case 5:
                    EnfermidadeCarregar.sprite = e5;
                    break;
                case 4:
                    EnfermidadeCarregar.sprite = e4;
                    break;
                case 3:
                    EnfermidadeCarregar.sprite = e3;
                    break;
                case 2:
                    EnfermidadeCarregar.sprite = e2;
                    break;
                case 1:
                    EnfermidadeCarregar.sprite = e1;
                    break;
                case 0:
                    EnfermidadeCarregar.sprite = e0;
                    Enfermidade.enabled = false;
                    EnfermidadeCarregar.enabled = false;
                    break;
            }
        }
        catch (System.Exception)
        {

        }

    }

    public void chamarPausa()
    {
        canvasHUD.SetActive(false);
        Instantiate(Pausa, Pausa.transform.position, Pausa.transform.rotation);

    }

    public void ReviverHud()
    {
        canvasHUD.SetActive(true);

    }


}

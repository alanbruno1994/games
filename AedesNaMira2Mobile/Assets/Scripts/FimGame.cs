using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FimGame : MonoBehaviour
{
    public GameObject Gerenciar, Placar, _Heroi, EfeitoProtecao, Camera, CadastrarRecorde, Caveiras, Fogos;
    public GameObject Venceu, Perdeu;
    public bool venceu, disparar;
    public InputField Nome;
    public Text NomeT;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        //  PlayerPrefs.SetFloat("Ponto", 0);
        time = 0;
        try
        {
            Gerenciar = GameObject.FindGameObjectWithTag("Gerenciar");
            _Heroi = GameObject.FindGameObjectWithTag("Heroi");
            EfeitoProtecao = GameObject.FindGameObjectWithTag("EfeitoProtecao");
            Camera = GameObject.FindGameObjectWithTag("MainCamera");
            GameObject.FindGameObjectWithTag("controledireito").SetActive(false);
            Camera.GetComponent<DesligarCamera>().enabled = false;
            Gerenciar.GetComponent<GerirFocos>().enabled = false;
            Gerenciar.GetComponent<ControleMosquito>().enabled = false;
            Gerenciar.GetComponent<ControleDificuldade>().enabled = false;
            if (_Heroi.GetComponent<Heroi>() != null)
            {
                _Heroi.GetComponent<Heroi>().enabled = false;
                _Heroi.GetComponent<PlayerMoveController>().enabled = false;
                Destroy(GameObject.FindGameObjectWithTag("HUD"));
            }
            else
            {
                Destroy(_Heroi);
            }

            disparar = false;
            Venceu.SetActive(false);
            Perdeu.SetActive(false);
            Placar.SetActive(false);
            Gerenciar.GetComponent<ControleQualidade>().Musica.volume = 0;
        }
        catch (System.Exception)
        {


        }
        try
        {
            EfeitoProtecao.SetActive(false);
        }
        catch (System.Exception e)
        {

        }
        if (Gerenciar.GetComponent<DadosFase>().pontos > PlayerPrefs.GetFloat("Ponto"))
        {
            venceu = true;
            Gerenciar.GetComponent<MusicaFim>().MusicaAlegre.enabled = true;
            Gerenciar.GetComponent<MusicaFim>().MusicaTriste.enabled = false;
            Gerenciar.GetComponent<MusicaFim>().MusicaFase.enabled = false;
            Gerenciar.GetComponent<MusicaFim>().MusicaAlegre.volume = PlayerPrefs.GetFloat("Musica");
            //  Caveiras.SetActive(false);
            //  Fogos.SetActive(true);
        }
        else
        {
            venceu = false;
            Gerenciar.GetComponent<MusicaFim>().MusicaAlegre.enabled = false;
            Gerenciar.GetComponent<MusicaFim>().MusicaTriste.enabled = true;
            Gerenciar.GetComponent<MusicaFim>().MusicaFase.enabled = false;
            Gerenciar.GetComponent<MusicaFim>().MusicaTriste.volume = PlayerPrefs.GetFloat("Musica");
            //   Caveiras.SetActive(true);
            //  Fogos.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {

        if (venceu && time < 10)
        {
            time += Time.deltaTime;
            Venceu.SetActive(true);
            Perdeu.SetActive(false);

        }
        else if (venceu && disparar == false)
        {
            CadastrarRecorde.SetActive(true);
            disparar = true;
            Venceu.SetActive(false);
            Perdeu.SetActive(false);
        }
        else if (venceu == false && time < 10)
        {
            time += Time.deltaTime;
            Venceu.SetActive(false);
            Perdeu.SetActive(true);
        }
        else if (venceu == false && disparar == false)
        {
            disparar = true;
            Placar.SetActive(true);
            Venceu.SetActive(false);
            Perdeu.SetActive(false);
        }

    }

    public void RegistrarRecorde()
    {
        if (Nome != null)
        {
            if (Nome.text.Length > 0)
            {
                PlayerPrefs.SetString("Nome", Nome.text);
                PlayerPrefs.SetFloat("Ponto", Gerenciar.GetComponent<DadosFase>().pontos);
                PlayerPrefs.SetInt("MosquitoNormal", Gerenciar.GetComponent<DadosFase>().MosquitoNormalMorto);
                PlayerPrefs.SetInt("MosquitoDengue", Gerenciar.GetComponent<DadosFase>().MosquitoDengueMorto);
                PlayerPrefs.SetInt("MosquitoChikungunya", Gerenciar.GetComponent<DadosFase>().MosquitoChMorto);
                PlayerPrefs.SetInt("MosquitoZika", Gerenciar.GetComponent<DadosFase>().MosquitoZikaMorto);
                PlayerPrefs.SetInt("Focos", Gerenciar.GetComponent<DadosFase>().FocoDestruido);
                CadastrarRecorde.SetActive(false);
                Placar.SetActive(true);
                if (Gerenciar.GetComponent<DadosFase>().pontos >= 200)
                {
                    PlayerPrefs.SetInt("Fase2", 1);
                }

                if (Gerenciar.GetComponent<DadosFase>().pontos >= 400)
                {
                    PlayerPrefs.SetInt("Fase3", 1);
                }
            }
        }
        else 
        {
            if (NomeT.text.Length > 0)
            {
                PlayerPrefs.SetString("Nome", NomeT.text);
                PlayerPrefs.SetFloat("Ponto", Gerenciar.GetComponent<DadosFase>().pontos);
                PlayerPrefs.SetInt("MosquitoNormal", Gerenciar.GetComponent<DadosFase>().MosquitoNormalMorto);
                PlayerPrefs.SetInt("MosquitoDengue", Gerenciar.GetComponent<DadosFase>().MosquitoDengueMorto);
                PlayerPrefs.SetInt("MosquitoChikungunya", Gerenciar.GetComponent<DadosFase>().MosquitoChMorto);
                PlayerPrefs.SetInt("MosquitoZika", Gerenciar.GetComponent<DadosFase>().MosquitoZikaMorto);
                PlayerPrefs.SetInt("Focos", Gerenciar.GetComponent<DadosFase>().FocoDestruido);
                CadastrarRecorde.SetActive(false);
                Placar.SetActive(true);
                if (Gerenciar.GetComponent<DadosFase>().pontos >= 200)
                {
                    PlayerPrefs.SetInt("Fase2", 1);
                }

                if (Gerenciar.GetComponent<DadosFase>().pontos >= 400)
                {
                    PlayerPrefs.SetInt("Fase3", 1);
                }
            }
        }
    }

}

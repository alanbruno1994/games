using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPrincipal : MonoBehaviour
{
    public GameObject TelaPlacar, TelaJogar, TelaConfiguracoes;
    public Button Jogar, Configuracoes, Placar, Sair;
    public Sprite Nada, Borda;
    private AsyncOperation async;


    // Start is called before the first frame update


    void Awake()
    {
        if (!PlayerPrefs.HasKey("Musica"))
        {
            PlayerPrefs.SetString("Nome", "");
            PlayerPrefs.SetFloat("Ponto", 0);
            PlayerPrefs.SetInt("MosquitoNormal", 0);
            PlayerPrefs.SetInt("MosquitoDengue", 0);
            PlayerPrefs.SetInt("MosquitoChikungunya", 0);
            PlayerPrefs.SetInt("MosquitoZika", 0);
            PlayerPrefs.SetInt("Focos", 0);
            PlayerPrefs.SetInt("Texturas", 1);
            PlayerPrefs.SetInt("Vegetacao", 1);
            PlayerPrefs.SetInt("Sombras", 1);
            PlayerPrefs.SetInt("Joystick", 1);
            PlayerPrefs.SetFloat("Musica", 1);
            PlayerPrefs.SetFloat("Efeitos", 0.5f);
        }
    }


    void Start()
    {
        // StartCoroutine(LoadYourAsyncScene());
        chamarJogar();
    }



    void Update()
    {
        // Press the space key to start coroutine
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Use a coroutine to load the Scene in the background

        }
    }

    IEnumerator LoadYourAsyncScene(string fase)
    {
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(fase);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }


    public void showScene()
    {
        async.allowSceneActivation = true;
    }


    public void chamarJogar()
    {
        TelaJogar.SetActive(true);
        TelaPlacar.SetActive(false);
        TelaConfiguracoes.SetActive(false);
        Jogar.GetComponent<Image>().sprite = Borda;
        Configuracoes.GetComponent<Image>().sprite = Nada;
        Placar.GetComponent<Image>().sprite = Nada;
        Sair.GetComponent<Image>().sprite = Nada;

    }

    public void chamarConfiguracoes()
    {
        TelaJogar.SetActive(false);
        TelaPlacar.SetActive(false);
        TelaConfiguracoes.SetActive(true);
        Jogar.GetComponent<Image>().sprite = Nada;
        Configuracoes.GetComponent<Image>().sprite = Borda;
        Placar.GetComponent<Image>().sprite = Nada;
        Sair.GetComponent<Image>().sprite = Nada;
        if (PlayerPrefs.HasKey("Texturas"))
        {
            TelaConfiguracoes.GetComponent<Configuracoes>().pegarConfiguracoes();
        }
    }

    public void chamarPlacar()
    {
        TelaJogar.SetActive(false);
        TelaPlacar.SetActive(true);
        TelaConfiguracoes.SetActive(false);
        Jogar.GetComponent<Image>().sprite = Nada;
        Configuracoes.GetComponent<Image>().sprite = Nada;
        Placar.GetComponent<Image>().sprite = Borda;
        Sair.GetComponent<Image>().sprite = Nada;
        if (PlayerPrefs.HasKey("Nome"))
        {
            TelaPlacar.GetComponent<Placar>().configurarPlacar();
        }
    }

    public void aplicarConfiguracoes()
    {
        TelaConfiguracoes.GetComponent<Configuracoes>().aplicarConfiguracoes();

    }

    public void Exit()
    {

        TelaJogar.SetActive(false);
        TelaPlacar.SetActive(false);
        TelaConfiguracoes.SetActive(false);
        Jogar.GetComponent<Image>().sprite = Nada;
        Configuracoes.GetComponent<Image>().sprite = Nada;
        Placar.GetComponent<Image>().sprite = Nada;
        Sair.GetComponent<Image>().sprite = Borda;
        Application.Quit();

    }


    public void jogarMesmo()
    {


    }





}

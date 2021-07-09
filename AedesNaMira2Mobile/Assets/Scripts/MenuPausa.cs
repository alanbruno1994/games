using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPausa : MonoBehaviour
{
    public GameObject TelaPlacar, TelaCompra, TelaConfiguracoes;
    public Button Retornar,Comprar, Configuracoes, Placar, Sair;
    public Sprite Nada, Borda;
    public Text Menu;
    public GameObject HUD;

    void Start()
    {
        Time.timeScale = 0;
        HUD = GameObject.FindGameObjectWithTag("HUD");      
        chamarCompra();
    }

    public void chamarRetornar()
    {
        Time.timeScale = 1;
        TelaCompra.SetActive(false);
        TelaPlacar.SetActive(false);
        TelaConfiguracoes.SetActive(false);
        Retornar.GetComponent<Image>().sprite = Borda;
        Configuracoes.GetComponent<Image>().sprite = Nada;
        Placar.GetComponent<Image>().sprite = Nada;
        Sair.GetComponent<Image>().sprite = Nada;
        Comprar.GetComponent<Image>().sprite = Nada;
        HUD.GetComponent<HUD>().ReviverHud();
        HUD.GetComponent<HUD>().QuantidadePilha.text = "" + RamSystem.QuantidadePilhas;
        HUD.GetComponent<HUD>().RepelenteAzul.text = "" + RamSystem.RepelenteAzul;
        HUD.GetComponent<HUD>().RepelenteVermelho.text = "" + RamSystem.RepelenteVermelho;
        HUD.GetComponent<HUD>().RepelenteDourado.text = "" + RamSystem.RepelenteDourada;
        HUD.GetComponent<HUD>().Dinheiro.text=""+GameObject.FindGameObjectWithTag("Gerenciar").GetComponent<DadosFase>().Saldo;
        Destroy(this.gameObject);
    }


    public void chamarCompra()
    {
        TelaCompra.SetActive(true);
        TelaPlacar.SetActive(false);
        TelaConfiguracoes.SetActive(false);
        Retornar.GetComponent<Image>().sprite = Nada;
        Configuracoes.GetComponent<Image>().sprite = Nada;
        Placar.GetComponent<Image>().sprite = Nada;
        Sair.GetComponent<Image>().sprite = Nada;
        Comprar.GetComponent<Image>().sprite = Borda;

    }

    public void chamarConfiguracoes()
    {
        TelaCompra.SetActive(false);
        TelaPlacar.SetActive(false);
        TelaConfiguracoes.SetActive(true);
        Retornar.GetComponent<Image>().sprite = Nada;
        Configuracoes.GetComponent<Image>().sprite = Borda;
        Placar.GetComponent<Image>().sprite = Nada;
        Sair.GetComponent<Image>().sprite = Nada;
        Comprar.GetComponent<Image>().sprite = Nada;
        if (PlayerPrefs.HasKey("Texturas"))
        {
            TelaConfiguracoes.GetComponent<Configuracoes>().pegarConfiguracoes();
        }
    }

    public void chamarPlacar()
    {
        TelaCompra.SetActive(false);
        TelaPlacar.SetActive(true);
        TelaConfiguracoes.SetActive(false);
        Retornar.GetComponent<Image>().sprite = Nada;
        Configuracoes.GetComponent<Image>().sprite = Nada;
        Placar.GetComponent<Image>().sprite = Borda;
        Sair.GetComponent<Image>().sprite = Nada;
        Comprar.GetComponent<Image>().sprite = Nada;
        if (PlayerPrefs.HasKey("Nome"))
        {
            TelaConfiguracoes.GetComponent<Configuracoes>().pegarConfiguracoes();
        }
    }

    public void aplicarConfiguracoes()
    {
        TelaConfiguracoes.GetComponent<Configuracoes>().aplicarConfiguracoes();

    }

    public void MenuSair()
    {
        Retornar.GetComponent<Image>().sprite = Nada;
        Configuracoes.GetComponent<Image>().sprite = Nada;
        Placar.GetComponent<Image>().sprite = Nada;
        Sair.GetComponent<Image>().sprite = Nada;
        Comprar.GetComponent<Image>().sprite = Nada;
        Menu.text = "Aguarde...";
        Sair.GetComponent<Image>().enabled = false;
        Application.LoadLevel("Menu");

    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDUpatate : MonoBehaviour
{
    public Text Pontos, Grama, RepelenteAzul, RepelenteVermelho, RepelenteDourado,MosquitoMorto, Relogio, AguaParada;
    public DadosFase dados;
    public Image RelogioImage;

    // Start is called before the first frame update
    void Start()
    {
        dados= GameObject.FindGameObjectWithTag("Gerenciar").GetComponent<DadosFase>();
    }


    public void Atualizar()
    {
        Pontos.text = "" + dados.pontos;
        Grama.text = "" + dados.Saldo;
        RepelenteAzul.text = "" + RamSystem.RepelenteAzul;
        RepelenteVermelho.text = "" + RamSystem.RepelenteVermelho;
        RepelenteDourado.text = "" + RamSystem.RepelenteDourada;
        MosquitoMorto.text = "" + (dados.MosquitoNormalMorto + dados.MosquitoZikaMorto + dados.MosquitoDengueMorto + dados.MosquitoChMorto);

    }
}

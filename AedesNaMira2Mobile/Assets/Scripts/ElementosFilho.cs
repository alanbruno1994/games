using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElementosFilho : MonoBehaviour
{
    public ControleArmaUsada controle;
    public GameObject HUD,Embacamento,Irritacao;
    public Text RepelenteAzul, RepelenteVermelho, RepelenteDourado;
    public GameObject CompraMovimento,ConquistaF2,ConquistaF3;
    public HUDUpatate hudAtualizar;
    public CompraMovimento360 compraMovimento;
    public Transform RaqueteAzul, RaqueteVermelha, RaqueteDourada, RaqueteCinza;
    public Controle_trocaHUD controle_TrocaHUD;
    public LifeHud lifeHud;
    public EnfermidadeHUD enfermidadeHUD;
    public protecaoHUD protecao_HUD;
    public ArmaHUD armaHUD;
}

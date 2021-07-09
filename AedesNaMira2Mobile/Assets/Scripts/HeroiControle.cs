using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroiControle : MonoBehaviour
{
    MovementeControler movemente;
    public Input360 input;
    //public LifeHud lifeHud;
    public float life;
    //public ControleArmaUsada controleArmaUsada;
    // public HUDUpdate hudUpdate;
    public int timeProtecao, contadorRecarga, relogioTime, segundos, protecao, timeProtecaoLimite, contadorDoenca;
    public int porcetagemDoente = 0, tipoDoenca;
    public GameObject Pausa;
    public DadosFase dados;
    public ControleDificuldade nivel;
    public Rigidbody rigidbody;
    public bool RealidadeVirtual, doente, fimJogo, compra; 
    public GerirDano gerirDano;  
    public GameObject FimGame;   
    public bool parede;    
    public GameObject Dor, camera;
    public bool estaChao = false;
    public Vector3 posicaoAnterior;
    public float andar, correr, x, y;
    public ElementosFilho elementos;

    // Start is called before the first frame update
    void Start()
    {
        parede = compra = fimJogo = false;
        movemente = new MovementeControler(this.transform, input);
        life = 100;
        relogioTime = segundos = contadorRecarga = 0;
        timeProtecao = 0;
        RamSystem.pausa = false;
        dados = GameObject.FindGameObjectWithTag("Gerenciar").GetComponent<DadosFase>();
        nivel = GameObject.FindGameObjectWithTag("Gerenciar").GetComponent<ControleDificuldade>();
       
        start();
        if (PlayerPrefs.HasKey("Fase2") == false)
        {
            PlayerPrefs.SetInt("Fase2", 0);
            PlayerPrefs.SetInt("Fase3", 0);
        }
        andar = 3;
        correr = 6;
        RamSystem.resetRam();
        //nivel = GameObject.FindGameObjectWithTag("Gerenciar").GetComponent<NivelDificuldade>();

    }

    // Update is called once per frame
    void Update()
    {
        start();
        if (RamSystem.pausa == false)
        {
          
            if (PlayerPrefs.GetInt("Fase2") != 1 && dados.pontos >= 200)
            {
                PlayerPrefs.SetInt("Fase2", 1);
                elementos.ConquistaF2.SetActive(true);


            }

            if (PlayerPrefs.GetInt("Fase3") != 1 && dados.pontos >= 400)
            {
                PlayerPrefs.SetInt("Fase3", 1);
                elementos.ConquistaF3.SetActive(true);

            }

            if ((life <= 0) && fimJogo == false)
            {
                fimJogo = true;
                Instantiate(FimGame, FimGame.transform.position, FimGame.transform.rotation);
            }
            else if (doente)
            {
                switch (tipoDoenca)
                {
                    case 1:
                        Dor.SetActive(true);
                        break;
                    case 2:
                        elementos.Irritacao.SetActive(true);
                        break;
                    case 3:
                        elementos.Embacamento.SetActive(true);
                        break;

                }

            }
            else if (doente == false)
            {
                elementos.Embacamento.SetActive(false);
                elementos.Irritacao.SetActive(false);
                Dor.SetActive(false);
            }

            elementos.HUD.SetActive(true);
            elementos.hudAtualizar.Atualizar();
            if (input.JoystickDireitoCima.positivoBotao())
            {
                elementos.controle_TrocaHUD.avancar();
            }
            else if (input.JoystickDireitoCima.negativoBotao())
            {
                elementos.controle_TrocaHUD.voltar();
            }
            else if (input.X.isBotao())//Protecao Azul 
            {
                if (RamSystem.RepelenteAzul >= 1 && elementos.protecao_HUD.desabilitarRepelente == false)
                {
                    protecao = 100;
                    timeProtecao = 0;
                    timeProtecaoLimite = 2;
                    RamSystem.RepelenteAzul -= 1;
                    elementos.RepelenteAzul.text = "" + RamSystem.RepelenteAzul;
                }

            }
            else if (input.Y.isBotao())//Protecao Vermelho 
            {
                if (RamSystem.RepelenteAzul >= 1 && elementos.protecao_HUD.desabilitarRepelente == false)
                {
                    protecao = 100;
                    timeProtecao = 0;
                    timeProtecaoLimite = 3;
                    RamSystem.RepelenteVermelho -= 1;
                    elementos.RepelenteVermelho.text = "" + RamSystem.RepelenteVermelho;
                }
            }
            else if (input.B.isBotao())//Protecao Dourado 
            {
                if (RamSystem.RepelenteAzul >= 1 && elementos.protecao_HUD.desabilitarRepelente == false)
                {
                    protecao = 100;
                    timeProtecao = 0;
                    timeProtecaoLimite = 5;
                    RamSystem.RepelenteDourada -= 1;
                    elementos.RepelenteDourado.text = "" + RamSystem.RepelenteDourada;
                }
            }
            else if (input.Lb.isBotao())
            {
                if (elementos.controle != null)
                {
                    elementos.controle.TrocarArma();
                }
            }
            else if (input.Rb.isBotao())
            {
                elementos.controle.dispararAgua();
            }
            else if (input.start.isBotao())
            {
                Instantiate(Pausa);
            }
            else if (input.direcionalDireita.positivoBotao() && compra)//Ir compra
            {
                elementos.compraMovimento.AvancarID();
            }
            else if (input.direcionalDireita.negativoBotao() && compra)//Voltar compra
            {
                elementos.compraMovimento.RetornarID();
            }
            else if (input.direcionalCima.negativoBotao() && compra)//Compra
            {
                elementos.compraMovimento.comprar();
            }
            else if (input.BjoystickEsquerdo.isBotao() && compra)//Desativa
            {
                elementos.CompraMovimento.SetActive(false);
                compra = false;
            }
            else if (input.BjoystickEsquerdo.isBotao() && compra == false)//Ativa Compra
            {
                elementos.CompraMovimento.SetActive(true);
                compra = true;
            }
            else if (input.A.isBotao() && estaChao)
            {
                posicaoAnterior = this.transform.position;
                saltarHeroi();
            }
            elementos.lifeHud.atualizarLife(life);
            elementos.armaHUD.armaRefresh();
            if (camera != null)
            {
                transform.rotation = Quaternion.Euler(0, camera.transform.rotation.eulerAngles.y, 0);
                x = input.JoystickEsquerdoDireita.return_Value();
                y = input.JoystickEsquerdoCima.return_Value();
                if (x < 0.2f && y < 0.2f && x > -0.2f && y > -0.2f)//parado
                {

                }
                else if (x < 0.4f && x > -0.4f && y > 0.2f && y < 0.8f)//andar para frente 
                {
                    transform.Translate(0, 0, andar * Time.deltaTime);
                }
                else if (x > 0.4f && x < 0.8f && y > 0.2f)//andar para frente e para direita
                {
                    transform.Translate(andar * Time.deltaTime, 0, andar * Time.deltaTime);
                }
                else if (x < 0.4f && x > -0.4f && y > 0.2f && y < 0.8f)//andar para frente 
                {
                    transform.Translate(0, 0, andar * Time.deltaTime);
                }
                else if (x > 0.8f && y > 0.2f)//correr para frente e para direita 
                {
                    transform.Translate(correr * Time.deltaTime, 0, correr * Time.deltaTime);
                }
                else if (x < -0.4f && x > -0.8f && y > 0.2f)//andar para frente e para esquerda
                {
                    transform.Translate(-andar * Time.deltaTime, 0, andar * Time.deltaTime);
                }
                else if (x < -0.8f && y > 0.2f)//correr para frente  e para esquerda
                {
                    transform.Translate(-correr * Time.deltaTime, 0, correr * Time.deltaTime);
                }
                else if (x < 0.4f && x > -0.4f && y < 0.2f && y > -0.8f)//andar para tras 
                {
                    transform.Translate(0, 0, -andar * Time.deltaTime);
                }
                else if (x > 0.4f && x < 0.8f && y < -0.2f)//andar para tras e para direita 
                {
                    transform.Translate(andar * Time.deltaTime, 0, -andar * Time.deltaTime);
                }
                else if (x > 0.8f && y < -0.2f)//correr para tras  e para direita 
                {
                    transform.Translate(correr * Time.deltaTime, 0, -correr * Time.deltaTime);
                }
                else if (x < -0.4f && x > -0.8f && y < -0.2f)//andar para tras e para esquerda 
                {
                    transform.Translate(-andar * Time.deltaTime, 0, -andar * Time.deltaTime);
                }
                else if (x < -0.8f && y < -0.2f)//correr para tras e para esquerda 
                {
                    transform.Translate(-correr * Time.deltaTime, 0, -correr * Time.deltaTime);
                }
                else if (x < 0.4f && x > -0.4f && y > 0.8f)//correr para frente 
                {
                    transform.Translate(0, 0, correr * Time.deltaTime);
                }
                else if (x < 0.4f && x > -0.4f && y < -0.8f)//andar para frente 
                {
                    transform.Translate(0, 0, -correr * Time.deltaTime);
                }
                else if (x > 0.2f && x < 0.8f && y < 0.4f && y > -0.4f)//andar para direita 
                {
                    transform.Translate(andar * Time.deltaTime, 0, 0);
                }
                else if (x > 0.8f && y < 0.4f && y > -0.4f)//correr para direita 
                {
                    transform.Translate(correr * Time.deltaTime, 0, 0);
                }
                else if (x < -0.2f && x > -0.8f && y < 0.4f && y > -0.4f)//andar para esquerda 
                {
                    transform.Translate(-andar * Time.deltaTime, 0, 0);
                }
                else if (x < -0.8f && y < 0.4f && y > -0.4f)//correr para esquerda 
                {
                    transform.Translate(-correr * Time.deltaTime, 0, 0);
                }
            }
            else
            {
                camera = GameObject.FindGameObjectWithTag("MainCamera");
            }
        }
        else
        {
            elementos.HUD.SetActive(false);
        }
    }


    public void saltarHeroi()
    {

        if (estaChao)
        {
            transform.position = new Vector3(posicaoAnterior.x, posicaoAnterior.y + 2.5f, posicaoAnterior.z);

        }

    }

    void start() 
    {
        try
        {
            if (elementos == null)
            {
                elementos = GameObject.FindGameObjectWithTag("seguidor").GetComponent<ElementosFilho>();
                elementos.Embacamento.SetActive(false);
                elementos.Irritacao.SetActive(false);
                Physics.IgnoreCollision(elementos.RaqueteAzul.GetComponent<Collider>(), GetComponent<Collider>());
                Physics.IgnoreCollision(elementos.RaqueteVermelha.GetComponent<Collider>(), GetComponent<Collider>());
                Physics.IgnoreCollision(elementos.RaqueteDourada.GetComponent<Collider>(), GetComponent<Collider>());
                Physics.IgnoreCollision(elementos.RaqueteCinza.GetComponent<Collider>(), GetComponent<Collider>());
            }
        }
        catch (System.Exception) 
        {
        
        }
    }


    void FixedUpdate()
    {
        if (RamSystem.pausa == false)
        {
            if (doente)
            {
                contadorDoenca++;
                if (contadorDoenca > 5 + nivel.NivelDificulade)
                {
                    elementos.enfermidadeHUD.refreshDoenca();
                    contadorDoenca = 0;
                }
                else if (contadorDoenca == 5)
                {
                    switch (tipoDoenca)
                    {
                        case 1:
                            life -= 0.01f;
                            break;
                        case 2:
                            life -= 0.02f;
                            break;
                        case 3:
                            life -= 0.03f;
                            break;

                    }
                }
            }
            else
            {
                contadorDoenca = 0;
            }

            if (elementos.protecao_HUD.desabilitarRepelente)
            {
                timeProtecao++;
                elementos.protecao_HUD.protecaoAtualizar(protecao, timeProtecaoLimite, timeProtecao);
                relogioTime += 1;
                if (relogioTime == 50)
                {
                    relogioTime = 0;
                    segundos += 1;
                }
            }
            else
            {
                timeProtecao = 0;
            }
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (RamSystem.pausa == false)
        {
            gerirDano.realizarDano(collision, protecao);
            if (collision.gameObject.tag == "Parede")
            {
                parede = true;
            }
            else if (collision.gameObject.tag == "chao")
            {
                estaChao = true;
            }
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (RamSystem.pausa == false)
        {
            if (collision.gameObject.tag == "Parede")
            {
                parede = true;
            }
            else if (collision.gameObject.tag == "chao")
            {
                estaChao = true;
            }

        }

    }

    void OnCollisionExit(Collision collision)
    {
        // Debug-draw all contact points and normals
        if (RamSystem.pausa == false)
        {
            if (collision.gameObject.tag == "Parede")
            {
                parede = false;
            }
            else if (collision.gameObject.tag == "chao")
            {
                estaChao = false;
            }
        }


    }

    private void OnTriggerEnter(Collider other)
    {

    }

    private void OnTriggerStay(Collider other)
    {

    }

    private void OnTriggerExit(Collider other)
    {

    }

}

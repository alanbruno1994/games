using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionDetect : MonoBehaviour
{
    public bool frente, atras, direita, esquerda;
    public static bool Frente, Atras, Direita, Esquerda;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Chamou");
        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position, transform.forward, 100.0F);
        for (int i = 0; i < hits.Length; i++)
        {
            RaycastHit hit = hits[i];
            Debug.Log("hits-> " + hit.collider.tag);
            switch (hit.collider.tag)
            {
                case "frente":
                    frente = Frente = true;
                    atras = Atras = false;
                    direita = Direita = false;
                    esquerda = Esquerda = false;
                    break;
                case "atras":
                    frente = Frente = false;
                    atras = Atras = true;
                    direita = Direita = false;
                    esquerda = Esquerda = false;
                    break;
                case "direita":
                    frente = Frente = false;
                    atras = Atras = false;
                    direita = Direita = true;
                    esquerda = Esquerda = false;
                    break;
                case "esquerda":
                    frente = Frente = false;
                    atras = Atras = false;
                    direita = Direita = false;
                    esquerda = Esquerda = true;
                    break;
                default:
                    frente = Frente = true;
                    atras = Atras = false;
                    direita = Direita = false;
                    esquerda = Esquerda = false;
                    break;

            }
        }
    }
}

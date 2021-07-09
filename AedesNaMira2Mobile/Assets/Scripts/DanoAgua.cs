using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanoAgua : MonoBehaviour
{
    void OnTriggerStay(Collider other)
    {

        if (other.tag=="Heroi")
        {
            if (other.gameObject.GetComponent<Heroi>() != null)
            {
                other.gameObject.GetComponent<Heroi>().life -= 0.05f;
                other.gameObject.GetComponent<Heroi>().huds.vidaRefresh();
                Handheld.Vibrate();
            }
            else
            {
                Debug.Log("teste dano");
                other.gameObject.GetComponent<HeroiControle>().life -= 0.05f;
            }
        }
    }
}

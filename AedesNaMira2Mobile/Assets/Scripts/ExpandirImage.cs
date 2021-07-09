using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ExpandirImage : MonoBehaviour
{

    public float escala;
    public float fator;
    public Image image;

    // Start is called before the first frame update
    void Start()
    {
        image.rectTransform.localScale = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        escala += (Time.deltaTime * fator);
        if (escala>=1) {
            image.rectTransform.localScale = new Vector3(0, 0, 0);
            escala = 0;

        }
        else
        {
            image.rectTransform.localScale = new Vector3(escala, escala, escala);
           

        }
     
    }
}

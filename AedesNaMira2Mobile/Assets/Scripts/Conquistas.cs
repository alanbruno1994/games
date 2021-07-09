using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Conquistas : MonoBehaviour
{
    public Image image;
    public float escala;
    public float rotate;

    // Start is called before the first frame update
    void Start()
    {
        escala = 0;
        image.rectTransform.localScale = new Vector3(escala, escala, escala);
    }

    // Update is called once per frame
    void Update()
    {
        escala += (Time.deltaTime*0.25f);
        image.rectTransform.localScale = new Vector3(escala, escala, escala);
        rotate = (Time.deltaTime * 200);
        image.rectTransform.Rotate(new Vector3(0,rotate,0));
        if (escala>=5)
        {
            Destroy(this.gameObject);
        }
    }
}

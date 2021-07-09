using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementeControler
{
    public float x;
    public float y;
    public float girar, subir;
    public Input360 input;
    public float andar, correr;
    public float dado1, dado2, dado3, dado4;
    public float contador, contador2;
    public int time;
    public Transform transform;

    public MovementeControler(Transform transform,Input360 entrada)
    {
        time = 0;
        contador = contador2 = 0;
        this.transform = transform;
        input = entrada;
        andar = 4;
        correr = 8;
    }

    public void mover() 
    {
        x = input.JoystickEsquerdoCima.return_Value();
        y = input.JoystickEsquerdoCima.return_Value();
        girar = input.JoystickDireitoDireita.return_Value();
        if (girar < 0.5f && girar > 0.2f)
        {
            contador2 = contador2 + 4 * andar * Time.deltaTime;
            if (contador2 > 360)
            {
                contador2 = 0;
            }

        }
        else if (girar > 0.5f)
        {
            contador2 = contador2 + 8 * correr * Time.deltaTime;
            if (contador2 > 360)
            {
                contador2 = 0;
            }
        }
        else if (girar > -0.5f && girar < -0.2f)
        {
            contador2 = contador2 - 4 * andar * Time.deltaTime;
            if (contador2 < -360)
            {
                contador2 = 0;
            }
        }
        else if (girar < -0.5f)
        {
            contador2 = contador2 - 8 * correr * Time.deltaTime;
            if (contador2 < -360)
            {
                contador2 = 0;
            }
        }

        subir = input.JoystickDireitoCima.return_Value();
        if (subir < 0.5f && subir > 0.2f)
        {
            contador = contador + 2 * andar * Time.deltaTime;
            if (contador > 15)
            {
                contador = 15;
            }

        }
        else if (subir > 0.5f)
        {
            contador = contador + 2 * correr * Time.deltaTime;
            if (contador > 15)
            {
                contador = 15;
            }
        }
        else if (subir > -0.5f && subir < -0.2f)
        {
            contador = contador - 2 * andar * Time.deltaTime;
            if (contador < -15)
            {
                contador = -15;
            }
        }
        else if (subir < -0.5f)
        {
            contador = contador - 2 * correr * Time.deltaTime;
            if (contador < -15)
            {
                contador = -15;
            }
        }
        transform.rotation = Quaternion.Euler(contador, contador2, 0);



        if ((x < 0.2f && y < 0.2f) && (x > -0.2f && y > -0.2f))
        {
            Debug.Log("parar");

        }
        else if (x < 0.4f && x > -0.4f && y > 0.2f && y < 0.8f)
        {
            Debug.Log("andar");
            transform.Translate(0, 0, andar * Time.deltaTime);
        }
        else if (x > 0.4f && x < 0.8f && y > 0.2f)
        {
            Debug.Log("andar frente p direita");
            transform.Translate(andar * Time.deltaTime, 0, andar * Time.deltaTime);
        }
        else if (x > 0.8f && y > 0.2f)
        {
            Debug.Log("correr frente p direita");
            transform.Translate(correr * Time.deltaTime, 0, correr * Time.deltaTime);
        }
        else if (x < -0.4f && x > -0.8f && y > 0.2f)
        {
            Debug.Log("andar frente p esquerda");
            transform.Translate(-andar * Time.deltaTime, 0, andar * Time.deltaTime);
        }
        else if (x < -0.8f && y > 0.2f)
        {
            Debug.Log("correr frente p esquerda");
            transform.Translate(-correr * Time.deltaTime, 0, correr * Time.deltaTime);
        }
        else if (x < 0.4f && x > -0.4f && y < 0.2f && y > -0.8f)
        {
            Debug.Log("andar p tras");
            transform.Translate(0, 0, -andar * Time.deltaTime);
        }
        else if (x > 0.4f && x < 0.8f && y < -0.2f)
        {
            Debug.Log("andar p tras direita");
            transform.Translate(andar * Time.deltaTime, 0, -andar * Time.deltaTime);
        }
        else if (x > 0.8f && y < -0.2f)
        {
            Debug.Log("correr p tras direita");
            transform.Translate(correr * Time.deltaTime, 0, -correr * Time.deltaTime);
        }
        else if (x < -0.4f && x > -0.8f && y < -0.2f)
        {
            Debug.Log("andar p tras esquerda");
            transform.Translate(-andar * Time.deltaTime, 0, -andar * Time.deltaTime);
        }
        else if (x < -0.8f && y < -0.2f)
        {
            Debug.Log("correr p tras esquerda");
            transform.Translate(-correr * Time.deltaTime, 0, -correr * Time.deltaTime);
        }
        else if (x < 0.4f && x > -0.4f && y > 0.8f)
        {
            Debug.Log("correr");
            transform.Translate(0, 0, correr * Time.deltaTime);
        }
        else if (x < 0.4f && x > -0.4f && y < -0.8f)
        {
            Debug.Log("correr p tras");

            transform.Translate(0, 0, -correr * Time.deltaTime);
        }
        else if ((x > 0.2f && x < 0.8f) && (y < 0.4f && y > -0.4f))
        {
            Debug.Log("andar p direita");
            transform.Translate(andar * Time.deltaTime, 0, 0);

        }
        else if ((x > 0.8f) && (y < 0.4f && y > -0.4f))
        {
            Debug.Log("correr p direita");
            transform.Translate(correr * Time.deltaTime, 0, 0);

        }
        else if ((x < -0.2f && x > -0.8f) && (y < 0.4f && y > -0.4f))
        {
            Debug.Log("andar p esquerda");
            transform.Translate(-andar * Time.deltaTime, 0, 0);

        }
        else if ((x < -0.8f) && (y < 0.4f && y > -0.4f))
        {
            Debug.Log("correr p esquerda");
            transform.Translate(-correr * Time.deltaTime, 0, 0);

        }
        else
        {
            Debug.Log("fali");

        }

    }


}

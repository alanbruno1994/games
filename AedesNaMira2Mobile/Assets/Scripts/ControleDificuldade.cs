using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDificuldade : MonoBehaviour
{
    public int NivelDificulade=1;
    public float time = 0;
    public bool evento1=false, evento2=false;
    public GameObject Airplane, Helicopter, Car1, Car2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (RamSystem.pausa==false) {
            if (time > 120)
            {
                time = 0;
                NivelDificulade = NivelDificulade + 1;
                evento1 = false; evento2 = false;
            }
            if (time<60 && evento1==false)
            {
                int numeroSorte = Random.Range(0, 10);
                if (numeroSorte<2 && Airplane != null)
                {
                    Instantiate(Airplane, Airplane.transform.position, Airplane.transform.rotation);
                }
                else if (numeroSorte < 4 && Helicopter != null)
                {
                    Instantiate(Helicopter, Helicopter.transform.position, Helicopter.transform.rotation);
                }
                else if (numeroSorte < 7 && Car1!=null)
                {
                    Instantiate(Car1, Car1.transform.position, Car1.transform.rotation);
                }
                else if (numeroSorte < 10 && Car2 != null)
                {
                    Instantiate(Car2, Car2.transform.position, Car2.transform.rotation);
                }
                evento1 = true;


            }
            else if (time <120 && time>60 && evento2 == false)
            {
                int numeroSorte = Random.Range(0, 10);
                if (numeroSorte < 2)
                {
                    Instantiate(Airplane, Airplane.transform.position, Airplane.transform.rotation);
                }
                else if (numeroSorte < 4)
                {
                    Instantiate(Helicopter, Helicopter.transform.position, Helicopter.transform.rotation);
                }
                else if (numeroSorte < 7)
                {
                    if (Car1!=null) { 
                    Instantiate(Car1, Car1.transform.position, Car1.transform.rotation);
                    }
                }
                else if (numeroSorte < 10)
                {
                    if (Car2 != null) { 
                    Instantiate(Car2, Car2.transform.position, Car2.transform.rotation);
                    }
                }
                evento2 = true;

            }           
            time = time + Time.deltaTime;
        }
    }
}

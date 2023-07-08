using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crack5 : MonoBehaviour
{
    public int counter = 0;
    public int crack = 1;
    public MeshRenderer rend;
    public MeshRenderer soil;
    public MeshRenderer cement;
    public MeshRenderer alum;
    public MeshRenderer steel;
    public GameObject button;
    public int starter = 1;

    public void addSoil()
    {
        counter = 1;
        crack = 1;
        starter = 0;

    }

    public void addCem()
    {
        counter = 2;
        crack = 1;
        starter = 0;

    }

    public void addAlum()
    {
        counter = 3;
        crack = 1;
        starter = 0;

    }

    public void addStl()
    {
        counter = 4;
        crack = 1;
        starter = 0;

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "light")
        {
            
        }
        else if (other.tag == "Medium")
        {   // if a material is present
            if (counter > 0)
            {   // damage the material
                counter = counter - 1;
                // if the material is spent, create a crack
                if (counter <= 0)
                {
                    rend.enabled = true;
                    soil.enabled = false;
                    cement.enabled = false;
                    alum.enabled = false;
                    steel.enabled = false;
                    counter = 0;
                    button.SetActive(true);
                }
            }
            else
            {
                if (counter == 0)
                {
                    crack = 0;
                }
            }
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Crack0 : MonoBehaviour
{   //# of hits before cracked
    public int counter = 0;
    //used to tell program if crack was just made (should plane explode or pass over)
    public int crack = 1;
    //records if spot has been initially cracked yet
    public int starter = 1;
    // crack renders and button
    public MeshRenderer rend;
    public MeshRenderer soil;
    public MeshRenderer cement;
    public MeshRenderer alum;
    public MeshRenderer steel;
    public GameObject button;

    // Functions called when a material fills crack
    // - Adds hit points to counter
    // - updates starter that the spot isn't empty/ had its first crack
    // - Sets crack back to 1, planes safely fly over
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
    
    // When a plane collides with the crack spot
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "light")
        {
            
        }
        // Action for medium plane collision
        else if (other.tag == "Medium")
        {   // if a material is present
            if (counter > 0)
            {   // damage the material
                counter = counter - 1;
                // if the material is spent, create a crack
                if (counter <= 0)
                {   // turn off material rends, and turn on crack rend
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
            {   // If the material has lost all hit points, the crack is not able to destroy a plane
                // crack is turned to 0, which enables destruction code in plane interp.
                if (counter == 0)
                {
                    crack = 0;
                }
            } 
        }
    }

}
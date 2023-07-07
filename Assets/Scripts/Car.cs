using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Car : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject target;
    public List<MeshRenderer> rends;
    public List<MeshRenderer> rends_Soil;
    public List<MeshRenderer> rends_Cem;
    public List<MeshRenderer> rends_Alum;
    public List<MeshRenderer> rends_Stl;
    public List<GameObject> btns;
    public GameObject home;
    public int targetNum;
    public Master master;


    public bool isSoil;
    void Update()
    {
        agent.SetDestination(target.transform.position);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "home")
        {
            Destroy(this.gameObject);
        }
        
        
        
        if (other.tag == "Crack1" && targetNum == 0)
        {
            //fix
            Debug.Log("fixed");
            rends[0].enabled = false;
            btns[0].SetActive(false);
            target = home;
            if (master.crackMtrl[0] == 1)
            {
                rends_Soil[0].enabled = true;
                master.isSoil = false;
            }
            else if (master.crackMtrl[0] == 2)
            {
                rends_Cem[0].enabled = true;
                
                master.isCem = false;
            }
            else if (master.crackMtrl[0] == 3)
            {
                rends_Alum[0].enabled = true;
                master.isAlum = false;
            }
            else if (master.crackMtrl[0] == 4)
            {
                rends_Stl[0].enabled = true;
                master.isStl = false;
            }

            master.crackMtrl[0] = 0;
        } else if (other.tag == "Crack2" && targetNum == 1)
        {
            //fix
            Debug.Log("fixed");
            rends[1].enabled = false;
            btns[1].SetActive(false);
            target = home;
            if (master.crackMtrl[1] == 1)
            {
                rends_Soil[1].enabled = true;
                master.isSoil = false;
            }
            else if (master.crackMtrl[1] == 2)
            {
                rends_Cem[1].enabled = true;
                master.isCem = false;
            }
            else if (master.crackMtrl[1] == 3)
            {
                rends_Alum[1].enabled = true;
                master.isAlum = false;
            }
            else if (master.crackMtrl[1] == 4)
            {
                rends_Stl[1].enabled = true;
                master.isStl = false;
            }

            master.crackMtrl[1] = 0;
        } else if (other.tag == "Crack3" && targetNum == 2)
        {
            //fix
            Debug.Log("fixed");
            rends[2].enabled = false;
            btns[2].SetActive(false);
            target = home;
            if (master.crackMtrl[2] == 1)
            {
                rends_Soil[2].enabled = true;
                master.isSoil = false;
            }
            else if (master.crackMtrl[2] == 2)
            {
                rends_Cem[2].enabled = true;
                master.isCem = false;
            }
            else if (master.crackMtrl[2] == 3)
            {
                rends_Alum[2].enabled = true;
                master.isAlum = false;
            }
            else if (master.crackMtrl[2] == 4)
            {
                rends_Stl[2].enabled = true;
                master.isStl = false;
            }

            master.crackMtrl[2] = 0;
        } else if (other.tag == "Crack4" && targetNum == 3)
        {
            //fix
            Debug.Log("fixed");
            rends[3].enabled = false;
            btns[3].SetActive(false);
            target = home;
            if (master.crackMtrl[3] == 1)
            {
                rends_Soil[3].enabled = true;
                master.isSoil = false;
            }
            else if (master.crackMtrl[3] == 2)
            {
                rends_Cem[3].enabled = true;
                master.isCem = false;
            }
            else if (master.crackMtrl[3] == 3)
            {
                rends_Alum[3].enabled = true;
                master.isAlum = false;
            }
            else if (master.crackMtrl[3] == 4)
            {
                rends_Stl[3].enabled = true;
                master.isStl = false;
            }

            master.crackMtrl[3] = 0;
        } else if (other.tag == "Crack5" && targetNum == 4)
        {
            //fix
            Debug.Log("fixed");
            rends[4].enabled = false;
            btns[4].SetActive(false);
            target = home;
            if (master.crackMtrl[4] == 1)
            {
                rends_Soil[4].enabled = true;
                master.isSoil = false;
            }
            else if (master.crackMtrl[4] == 2)
            {
                rends_Cem[4].enabled = true;
                master.isCem = false;
            }
            else if (master.crackMtrl[4] == 3)
            {
                rends_Alum[4].enabled = true;
                master.isAlum = false;
            }
            else if (master.crackMtrl[4] == 4)
            {
                rends_Stl[4].enabled = true;
                master.isStl = false;
            }

            master.crackMtrl[4] = 0;
        } else if (other.tag == "Crack6" && targetNum == 5)
        {
            //fix
            Debug.Log("fixed");
            rends[5].enabled = false;
            btns[5].SetActive(false);
            target = home;
            if (master.crackMtrl[5] == 1)
            {
                rends_Soil[5].enabled = true;
                master.isSoil = false;
            }
            else if (master.crackMtrl[5] == 2)
            {
                rends_Cem[5].enabled = true;
                master.isCem = false;
            }
            else if (master.crackMtrl[5] == 3)
            {
                rends_Alum[5].enabled = true;
                master.isAlum = false;
            }
            else if (master.crackMtrl[5] == 4)
            {
                rends_Stl[5].enabled = true;
                master.isStl = false;
            }

            master.crackMtrl[5] = 0;
        } else if (other.tag == "Crack7" && targetNum == 6)
        {
            //fix
            Debug.Log("fixed");
            rends[6].enabled = false;
            btns[6].SetActive(false);
            target = home;
            if (master.crackMtrl[6] == 1)
            {
                rends_Soil[6].enabled = true;
                master.isSoil = false;
            }
            else if (master.crackMtrl[6] == 2)
            {
                rends_Cem[6].enabled = true;
                master.isCem = false;
            }
            else if (master.crackMtrl[6] ==3)
            {
                rends_Alum[6].enabled = true;
                master.isAlum = false;
            }
            else if (master.crackMtrl[6] == 4)
            {
                rends_Stl[6].enabled = true;
                master.isStl = false;
            }

            master.crackMtrl[6] = 0;
        } else if (other.tag == "Crack8" && targetNum == 7)
        {
            //fix
            Debug.Log("fixed");
            rends[7].enabled = false;
            btns[7].SetActive(false);
            target = home;
            if (master.crackMtrl[7] == 1)
            {
                rends_Soil[7].enabled = true;
                master.isSoil = false;
            }
            else if (master.crackMtrl[7] == 2)
            {
                rends_Cem[7].enabled = true;
                master.isCem = false;
            }
            else if (master.crackMtrl[7] == 3)
            {
                rends_Alum[7].enabled = true;
                master.isAlum = false;
            }
            else if (master.crackMtrl[7] == 4)
            {
                rends_Stl[7].enabled = true;
                master.isStl = false;
            }

            master.crackMtrl[7] = 0;
        } else if (other.tag == "Crack9" && targetNum == 8)
        {
            //fix
            Debug.Log("fixed");
            rends[8].enabled = false;
            btns[8].SetActive(false);
            target = home;
            if (master.crackMtrl[8] == 1)
            {
                rends_Soil[8].enabled = true;
                master.isSoil = false;
            }
            else if (master.crackMtrl[8] == 2)
            {
                rends_Cem[8].enabled = true;
                master.isCem = false;
            }
            else if (master.crackMtrl[8] == 3)
            {
                rends_Alum[8].enabled = true;
                master.isAlum = false;
            }
            else if (master.crackMtrl[8] == 4)
            {
                rends_Stl[8].enabled = true;
                master.isStl = false;
            }

            master.crackMtrl[8] = 0;
        } else if (other.tag == "Crack10" && targetNum == 9)
        {
            //fix
            Debug.Log("fixed");
            rends[9].enabled = false;
            btns[9].SetActive(false);
            target = home;
            if (master.crackMtrl[9] == 1)
            {
                rends_Soil[9].enabled = true;
                master.isSoil = false;
            }
            else if (master.crackMtrl[9] == 2)
            {
                rends_Cem[9].enabled = true;
                master.isCem = false;
            }
            else if (master.crackMtrl[9] == 3)
            {
                rends_Alum[9].enabled = true;
                master.isAlum = false;
            }
            else if (master.crackMtrl[9] == 4)
            {
                rends_Stl[9].enabled = true;
                master.isStl = false;
            }

            master.crackMtrl[9] = 0;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlaneInterp : MonoBehaviour
{
     public Transform startPos;  // Starting position
        public Transform endPos;    // Ending position
        public float speed = 5f;    // Movement speed
        public int numOfHoles;

        public bool light;
        public bool medium;
        public bool heavy;
        public Master master;
        public Car car;
        private float startTime;
        private float journeyLength;
        public MoveEm MoveEmScript;
    
        private void Start()
        {
            startTime = Time.time;
            journeyLength = Vector3.Distance(startPos.position, endPos.position);
        }
    
        private void Update()
        {
            float distanceCovered = (Time.time - startTime) * speed;
            float fractionOfJourney = distanceCovered / journeyLength;
    
            transform.position = Vector3.Lerp(startPos.position, endPos.position, fractionOfJourney);
    
            if (fractionOfJourney >= 1f)
            {
                
                master.planeCount--;
                
                if (master.planeCount >= 1 && master.isPlaying)
                {
                    if (gameObject.tag == "Light")
                    {
                        master.addCoin(10);
                    }
                    else if (gameObject.tag == "Medium")
                    {
                        master.addCoin(15);
                    }
                    else if (gameObject.tag == "Heavy")
                    {
                        master.addCoin(20);
                    }
                }
                Destroy(gameObject);

            }
        }



        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Crack1")
            {
                MeshRenderer rend = other.GetComponent<MeshRenderer>();
                
                int randoNum = Random.Range(0, 3);
                
                if (rend.enabled == true)
                {
                    master.LoseStar();
                    MoveEmScript.MoveEmNow(this.gameObject.transform);
                    Destroy(this.gameObject);
                }
                else if(numOfHoles > 0 && randoNum == 1)
                {
                    car.rends_Soil[0].enabled = false;
                    car.rends_Cem[0].enabled = false;
                    car.rends_Alum[0].enabled = false;
                    car.rends_Stl[0].enabled = false;
                    rend.enabled = true;
                    master.IndiCrckBtns[0].SetActive(true);
                    //master.currHole = 0;
                    numOfHoles--;
                }
            }
            else if (other.tag == "Crack2")
            {
                MeshRenderer rend = other.GetComponent<MeshRenderer>();
                int randoNum = Random.Range(0, 3);
                if (rend.enabled == true)
                {
                    master.LoseStar();
                    MoveEmScript.MoveEmNow(this.gameObject.transform);
                    Destroy(this.gameObject);
                }
                else if(numOfHoles > 0 && randoNum == 1)
                {
                    car.rends_Soil[1].enabled = false;
                    car.rends_Cem[1].enabled = false;
                    car.rends_Alum[1].enabled = false;
                    car.rends_Stl[1].enabled = false;
                    rend.enabled = true;
                    master.IndiCrckBtns[1].SetActive(true);
                    //master.currHole = 1;
                    numOfHoles--;
                }
            }
            else if (other.tag == "Crack3")
            {
                MeshRenderer rend = other.GetComponent<MeshRenderer>();
                int randoNum = Random.Range(0, 3);
                if (rend.enabled == true)
                {
                    master.LoseStar();
                    MoveEmScript.MoveEmNow(this.gameObject.transform);
                    Destroy(this.gameObject);
                }
                else if(numOfHoles > 0 && randoNum == 1)
                {
                    car.rends_Soil[2].enabled = false;
                    car.rends_Cem[2].enabled = false;
                    car.rends_Alum[2].enabled = false;
                    car.rends_Stl[2].enabled = false;
                    rend.enabled = true;
                    master.IndiCrckBtns[2].SetActive(true);
                   // master.currHole = 2;
                    numOfHoles--;
                }
            }
            else if (other.tag == "Crack4")
            {
                MeshRenderer rend = other.GetComponent<MeshRenderer>();
                int randoNum = Random.Range(0, 3);
                if (rend.enabled == true)
                {
                    master.LoseStar();
                    MoveEmScript.MoveEmNow(this.gameObject.transform);
                    Destroy(this.gameObject);
                }
                else if(numOfHoles > 0 && randoNum == 1)
                {
                    car.rends_Soil[3].enabled = false;
                    car.rends_Cem[3].enabled = false;
                    car.rends_Alum[3].enabled = false;
                    car.rends_Stl[3].enabled = false;
                    rend.enabled = true;
                    master.IndiCrckBtns[3].SetActive(true);
                    //master.currHole = 3;
                    numOfHoles--;
                }
            }
            else if (other.tag == "Crack5")
            {
                MeshRenderer rend = other.GetComponent<MeshRenderer>();
                int randoNum = Random.Range(0, 3);
                if (rend.enabled == true)
                {
                    master.LoseStar();
                    MoveEmScript.MoveEmNow(this.gameObject.transform);
                    Destroy(this.gameObject);
                }
                else if(numOfHoles > 0 && randoNum == 1)
                {
                    car.rends_Soil[4].enabled = false;
                    car.rends_Cem[4].enabled = false;
                    car.rends_Alum[4].enabled = false;
                    car.rends_Stl[4].enabled = false;
                    rend.enabled = true;
                    master.IndiCrckBtns[4].SetActive(true);
                    //master.currHole = 4;
                    numOfHoles--;
                }
            }
            else if (other.tag == "Crack6")
            {
                MeshRenderer rend = other.GetComponent<MeshRenderer>();
                int randoNum = Random.Range(0, 3);
                if (rend.enabled == true)
                {
                    master.LoseStar();
                    MoveEmScript.MoveEmNow(this.gameObject.transform);
                    Destroy(this.gameObject);
                }
                else if(numOfHoles > 0 && randoNum == 1)
                {
                    car.rends_Soil[5].enabled = false;
                    car.rends_Cem[5].enabled = false;
                    car.rends_Alum[5].enabled = false;
                    car.rends_Stl[5].enabled = false;
                    rend.enabled = true;
                    master.IndiCrckBtns[5].SetActive(true);
                    //master.currHole = 5;
                    numOfHoles--;
                }
            }
            else if (other.tag == "Crack7")
            {
                MeshRenderer rend = other.GetComponent<MeshRenderer>();
                int randoNum = Random.Range(0, 3);
                if (rend.enabled == true)
                {
                    master.LoseStar();
                    MoveEmScript.MoveEmNow(this.gameObject.transform);
                    Destroy(this.gameObject);
                }
                else if(numOfHoles > 0 && randoNum == 1)
                {
                    car.rends_Soil[6].enabled = false;
                    car.rends_Cem[6].enabled = false;
                    car.rends_Alum[6].enabled = false;
                    car.rends_Stl[6].enabled = false;
                    rend.enabled = true;
                    master.IndiCrckBtns[6].SetActive(true);
                    //master.currHole = 6;
                    numOfHoles--;
                }
            }
            else if (other.tag == "Crack8")
            {
                MeshRenderer rend = other.GetComponent<MeshRenderer>();
                int randoNum = Random.Range(0, 3);
                if (rend.enabled == true)
                {
                    master.LoseStar();
                    MoveEmScript.MoveEmNow(this.gameObject.transform);
                    Destroy(this.gameObject);
                }
                else if(numOfHoles > 0 && randoNum == 1)
                {
                    car.rends_Soil[7].enabled = false;
                    car.rends_Cem[7].enabled = false;
                    car.rends_Alum[7].enabled = false;
                    car.rends_Stl[7].enabled = false;
                    rend.enabled = true;
                    master.IndiCrckBtns[7].SetActive(true);
                   // master.currHole = 7;
                    numOfHoles--;
                }
            }
            else if (other.tag == "Crack9")
            {
                MeshRenderer rend = other.GetComponent<MeshRenderer>();
                int randoNum = Random.Range(0, 3);
                if (rend.enabled == true)
                {
                    master.LoseStar();
                    MoveEmScript.MoveEmNow(this.gameObject.transform);
                    Destroy(this.gameObject);
                }
                else if(numOfHoles > 0 && randoNum == 1)
                {
                    car.rends_Soil[8].enabled = false;
                    car.rends_Cem[8].enabled = false;
                    car.rends_Alum[8].enabled = false;
                    car.rends_Stl[8].enabled = false;
                    rend.enabled = true;
                    master.IndiCrckBtns[8].SetActive(true);
                   // master.currHole = 8;
                    numOfHoles--;
                }
            }
            else if (other.tag == "Crack10")
            {
                MeshRenderer rend = other.GetComponent<MeshRenderer>();
                int randoNum = Random.Range(0, 3);
                if (rend.enabled == true)
                {
                    master.LoseStar();
                    MoveEmScript.MoveEmNow(this.gameObject.transform);
                    Destroy(this.gameObject);
                }
                else if(numOfHoles > 0 && randoNum == 1)
                {
                    car.rends_Soil[9].enabled = false;
                    car.rends_Cem[9].enabled = false;
                    car.rends_Alum[9].enabled = false;
                    car.rends_Stl[9].enabled = false;
                    rend.enabled = true;
                    master.IndiCrckBtns[9].SetActive(true);
                   // master.currHole = 9;
                    numOfHoles--;
                }
            }
        }
        
}

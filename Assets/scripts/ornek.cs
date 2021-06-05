using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ornek : MonoBehaviour
{
    public GameObject bulut;
    GameObject bul;
    public GameObject bulut2;
    public GameObject bulut3;
    float xSpawn;
    float ySpawn;
    float x;
    void Start()
    {

    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))

        {
            int sayi = Random.Range(1, 4);
            switch (sayi)
            {
                case 1:
                    bul = bulut;
                    break;
                case 2:
                    bul = bulut2;
                    break;
                case 3:
                    bul = bulut3;
                    break;
            }

            xSpawn = Random.Range(200, -200);
            ySpawn = Random.Range(200, -200);
            x = Random.Range(1, 25);
            GameObject bu = Instantiate(bul, new Vector3(xSpawn, ySpawn, 75), bulut.transform.rotation) as GameObject;
            bu.transform.localScale += new Vector3(x, x, x);

        }

    }
}

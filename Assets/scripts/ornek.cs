using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ornek : MonoBehaviour
{
    public GameObject bulut;
    GameObject bul;
    public GameObject bulut2;
    public GameObject bulut3;
    float sayac;
    void Start()
    {

    }


    void Update()
    {
        sayac -= Time.deltaTime;
        if (sayac < 0)

        {
            sayac += 1;
            int sayi = Random.Range(1, 2);
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
            float z = Random.Range(1000, 1800);
            float x = Random.Range(10, 20);
            GameObject bu = Instantiate(bul, new Vector3(Random.Range(-2000, 2000), Random.Range(-150, 150), Random.Range(-2000, 2000)), bulut.transform.rotation) as GameObject;
            bu.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, z));
            bu.transform.localScale += new Vector3(x, x, x);
            GameObject.Destroy(bu, 30f);
        }
    }
}
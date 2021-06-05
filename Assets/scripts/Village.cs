using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Village : MonoBehaviour
{
    playerController playerControl;

    public playerController playerScript;

    //----------Bool-------
    public bool HaveBalta;
    public bool killed;
    public bool HaveAnahtar;
    public bool Konustumu;

    //------------------------------------
    public GameObject Balta;
    public GameObject Anahtar;
    void Start()
    {
        playerControl = GameObject.Find("player").GetComponent<playerController>();   
    }


    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        string obj = other.gameObject.name;

        if (obj.Equals("Balta") && Konustumu) { 
            print("Balta");
            playerControl.ButtonE.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine(BaltaAlma());
                HaveBalta = true;
            }
        }

        if (obj.Equals("Anahtar") && killed && HaveBalta)
        {
            print("Anahtar");
            playerControl.ButtonE.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                HaveAnahtar = true;
            }
        }
        if(obj.Equals("Cifci") && HaveBalta && Konustumu)
        {
            print("Cifci");
            playerControl.ButtonE.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                killed = true;
                Instantiate(Anahtar, Anahtar.transform.position,Anahtar.transform.rotation );
            }
        }
        if(obj.Equals("Cifci") && !Konustumu)
        {
            playerControl.ButtonE.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                playerScript.enabled = false;
                Konustumu = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        playerControl.ButtonE.SetActive(false);
    }

    IEnumerator BaltaAlma()
    {
        yield return new WaitForSeconds(.5f);
        GameObject.Destroy(Balta);
        playerControl.ButtonE.SetActive(false);

    }
}

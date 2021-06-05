using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    mouse esc;

 
    public GameObject ButtonE;
    public UnityEngine.CharacterController controller;
    Vector3 velocity;

    //SAYI DEĞERLERİ
    public float speed;
    public float gravity;
    
    //-------------------------------------------------------------
    public Camera fpsCamera;
    

    private void Start()
    {
        esc = FindObjectOfType<mouse>();

    }
    private void Update()
    {
        //if (esc.oyunDevam)
        //{ 

        #region Movement

            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            Vector3 move = transform.right * horizontal + transform.forward * vertical;
            controller.Move(move * speed * Time.deltaTime);

            #endregion
        //}

            //-----------yer çekimi----------------
            velocity.y += gravity + Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
            //--------------------------------------------

    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour
{

    private float _speed;
    private float _endPosZ;


    public void StartFloating(float speed, float endPosZ)
    {
        _speed = speed;
        _endPosZ = endPosZ;
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * (Time.deltaTime * _speed));

        if(transform.position.z > _endPosZ)
        {
            Destroy(gameObject);
        }
    }
}

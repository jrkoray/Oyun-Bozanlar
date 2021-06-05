using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demomove : MonoBehaviour
{
    Rigidbody rb;
    float x;
    float y;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector3(x * 7 , rb.velocity.y, y * 7);
    }
}

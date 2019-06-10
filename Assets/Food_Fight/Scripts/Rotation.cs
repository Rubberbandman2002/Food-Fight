using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float magnitude;
    private Rigidbody rb;
    public float torque = 50f;

   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update()
    {
        //mouse rotation
         float r = Input.GetAxis("Mouse X");
         this.transform.Rotate(transform.up * r * magnitude * Time.deltaTime * 50);

         //movement with right and left key
        //float input = Input.GetAxis("Horizontal");
        //float zAxis = Input.GetAxis("Vertical");
        //rb.AddTorque(transform.up * input * torque);
    }
}

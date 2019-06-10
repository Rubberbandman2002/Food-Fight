using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class Movement : MonoBehaviour
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

        float input = Input.GetAxis("Horizontal");
        float zAxis = Input.GetAxis("Vertical");

        //this.transform.Translate( zAxis * magnitude * Time.deltaTime,0, 0);
        
         //rb.AddForce(transform.forward * magnitude * zAxis );
         //rb.AddForce(transform.right * magnitude * input);
        
          transform.Translate(new Vector3(0, 0, 5f) * Time.deltaTime * zAxis * magnitude, Space.Self);
          transform.Translate(new Vector3(5f, 0, 0) * Time.deltaTime * input * magnitude, Space.Self);


    }
}

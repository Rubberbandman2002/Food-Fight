using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Jump : MonoBehaviour
{
    public GUITexture grapgic;
    public Texture2D standard;
    public Texture2D downgfxl;
    public Texture2D upgfx;
    public Texture2D heights;
    private Rigidbody rb;
    public float force;
    private bool grounded = true;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
   
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "ground" || collision.gameObject.tag == "object")
            grounded = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump") && grounded)
        {
            rb.AddForce(Vector3.up * force); //0, force, 0);
            grounded = false;
        }
    }
}

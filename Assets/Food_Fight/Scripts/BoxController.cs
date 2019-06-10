using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour {
    public float thrust;
    public float RT;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody>().AddForce(transform.forward * thrust); 
        transform.Rotate(0, RT * Time.deltaTime, 0);
    }
}

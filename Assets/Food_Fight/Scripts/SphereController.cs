using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour {
    public float mSpeed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ocillate();
    }

    void Ocillate()
    {
        transform.Translate(0, 0, mSpeed * Random.Range(-3, 3) * Time.deltaTime);
        transform.Rotate(0, 10 * Time.deltaTime, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsOnCollide : MonoBehaviour
{
    GameObject projectile;
    PickUp pickUp;
    //public GameObject target;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Target")) { // Score points 
            ScoreKeeper.instance.AddScore(1);
        }

        if (col.gameObject.name == "Ground") { Destroy(gameObject); }
    }

}

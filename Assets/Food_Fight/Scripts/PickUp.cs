using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject player;
    public bool holding = false;
    public GameObject heldFruit;
    public GameObject tempHeldFruit;
    // Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        if (heldFruit != null) { return; } // Exit this method if we are already holding the object.

        if (col.gameObject.name == "Pear" || col.gameObject.name == "Apple")
        {
            col.gameObject.transform.SetParent(GameObject.FindGameObjectWithTag("Player").transform, false);
            col.gameObject.transform.position = player.transform.TransformPoint(new Vector3(0, 0, 1));
            heldFruit = col.gameObject;
            heldFruit.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            //holding = true;
            //if()
              //  col.gameObject.transform.parent = null
        }
    }


    public GameObject getHeldFruit()
    {
        return heldFruit;
    }

    public GameObject getTempFruitProjectile()
    {
        return tempHeldFruit;
    }

    public void setTempFruitProjectile()
    {
        tempHeldFruit = heldFruit;
    }
}

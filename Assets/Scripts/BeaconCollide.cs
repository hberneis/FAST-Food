using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeaconCollide : MonoBehaviour
{
    public GameObject car;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("o"))
        {
            this.GetComponent<CarController>().enabled=true;
        }
    }
    
    //if collide with car then...
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject == car)
            {
            //activate minigame and destroy beacon
                Destroy(gameObject);
                Debug.Log("hit beacon");
            }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BeaconCollide : MonoBehaviour
{
    public GameObject car;
    public static int points = 0;
    public TextMeshProUGUI pointsTxt;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    public void Update()
    {
    }
    
    //if collide with car then...
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject == car)
            {
            //activate minigame and destroy beacon
                points += 100;
                pointsTxt.text = "Points: " + points;
                Debug.Log("hit beacon");
                Debug.Log(points);
                Destroy(gameObject);
            }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Freeze()
    {
        this.GetComponent<CarController>().enabled=false;
    }
    
    
}

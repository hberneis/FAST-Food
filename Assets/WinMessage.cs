using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinMessage : MonoBehaviour
{   
    public int points = 0;
    public int seconds = 0;
    public string strpoints = Convert.ToString(points);
    public string strseconds = Convert.ToString(seconds);
    
    
    public GameObject winText;
    // Start is called before the first frame update
    void Start()
    {
        winText.SetActive(false);
        //getcomponent seconds and points from other scripts
    }

    // Update is called once per frame
    void Update()
    {
        winText.GetComponent<Text>().text = ("You won {} points in {} seconds", strpoints, strseconds);
    }
}

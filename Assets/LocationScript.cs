using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationScript : MonoBehaviour
{
    // to keep track of the actual location of the event
    public Transform location;
    
    //4 different Location objects for the 4 different possible adjacent events
    public LocationScript adjacentW;
    public LocationScript adjacentA;
    public LocationScript adjacentS;
    public LocationScript adjacentD;
    
    //to keep track of what stage in the event process we are in. Also, stage 1 or 2 indicates which aftermath we get
    public int stage = 0; 
    
    //the cost for selecting each option
    public int option1Cost;
    public int option2Cost;

    //an object to keep track of all the text options: prompt, option 1, option 2, result 1, result 2, aftermath 1, aftermath 2
    public string prompt;
    public string option1;
    public string option2;
    public string result1;
    public string result2;
    public string aftermath1;
    public string aftermath2;

    //to add: a method that takes us to the event screen, and sets the visitedToday tag to true
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

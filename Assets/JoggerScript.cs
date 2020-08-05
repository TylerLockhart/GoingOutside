using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoggerScript : MonoBehaviour
{
    //Things to add to player script
    public Transform transform;
    public Rigidbody rb;
    public LocationScript currentLocation;
    public LocationScript home;
    //stress
    public int maxStress;
    public int currentStress;

    //method for returning home
    //when this method executes we need to do a few different things. We first need to return to the home location. We also need to increment the maximum stress and set current stress = max stress
    //all visitedToday tags need to be set to uncalled
    
    
    IEnumerator switchLocation (LocationScript destination){
        //if we have arrived at the destination, call the function that starts a new event

        float differenceX = 0;
        float differenceY = 0;
        float differenceZ = 0;
        differenceX = (destination.gameObject.transform.position.x - currentLocation.gameObject.transform.position.x);
        differenceY = (destination.gameObject.transform.position.y - currentLocation.gameObject.transform.position.y);
        differenceZ = (destination.gameObject.transform.position.z - currentLocation.gameObject.transform.position.z);
        rb.velocity = new Vector3(differenceX,differenceY,differenceZ);
        yield return new WaitForSeconds(1f);
        rb.velocity = new Vector3(0,0,0);
        currentLocation = destination;
        //Call event coroutines
    }

    void ReturnHome (){
        switchLocation(home);
    }

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(home.gameObject.transform.position.x, home.gameObject.transform.position.y + 0.4f, home.gameObject.transform.position.z);
    } 


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("d")){
            StartCoroutine(switchLocation(currentLocation.adjacentD));
        }
        if(Input.GetKey("a")){
            StartCoroutine(switchLocation(currentLocation.adjacentA));
        }
    }
}

/*
 To be used together with the free Unity asset Path Creator
 https://www.youtube.com/watch?v=saAQNRSYU9k
 */

using System.Collections;
using System.Collections.Generic;
using PathCreation;
using UnityEngine;

public class Follower : MonoBehaviour
{
    /* Public fields that can be adapted with the Inspector panel */
    public PathCreator pathCreator;
    // Default speed for the car. 
    public float speed = 5;
    // Start position of the car on the path.
    public float position = 0;
    float distanceTravelled; 
    // Start is called before the first frame update
    void Start()
    {
        //Nothing
    }

    // Update is called once per frame
    void Update()
    {
        distanceTravelled += speed + Time.deltaTime + position;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
    }
}

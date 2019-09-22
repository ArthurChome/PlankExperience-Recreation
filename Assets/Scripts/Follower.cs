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
    public PathCreator pathCreator;
    public float speed = 5;
    float distanceTravelled; 
    // Start is called before the first frame update
    void Start()
    {
        //Nothing
    }

    // Update is called once per frame
    void Update()
    {
        distanceTravelled += speed + Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
    }
}

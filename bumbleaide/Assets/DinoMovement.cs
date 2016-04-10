using UnityEngine;
using System.Collections;

public class DinoMovement : MonoBehaviour {

    public Transform destination;
    //the speed, in units per second, we want to move towards the target
    public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        MoveDino();
	}

    public void MoveDino()
    {
        Vector3 currentPosition = this.transform.position;

        //first, check to see if we're close enough to the target
        if (Vector3.Distance(currentPosition, destination.position) > .1f)
        {
            Vector3 directionOfTravel = destination.position - currentPosition;
            //now normalize the direction, since we only want the direction information
            directionOfTravel.Normalize();
            //scale the movement on each axis by the directionOfTravel vector components

            // translating the object
            this.transform.Translate(
                (directionOfTravel.x * speed * Time.deltaTime),
                (directionOfTravel.y * speed * Time.deltaTime),
                (directionOfTravel.z * speed * Time.deltaTime),
                Space.World);
            
        }
    }
}

using UnityEngine;
using System.Collections;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    public class FlowerMovement : MonoBehaviour
    {

        public Transform[] checkpoints;
        public int checkpointIndex;
        Transform destination;

        bool deathHasEntered;
        bool accountedFor;
        KeyCode keyAction = KeyCode.DownArrow;
        int numberPressedAccidently = 0;
        int numberMissed = 0;
        int numberCorrect = 0; // mapped with time stamps

        public GameObject scoreIndictator;
        public Material[] materials; // 0: green 1: red

        // start time, end time, 
        // time of distractor

        Renderer rend;

        // Use this for initialization
        void Start()
        {
            // set up where the flower will initially go
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.detectCollisions = false;
            checkpointIndex++;
            destination = checkpoints[checkpointIndex % checkpoints.Length];

            deathHasEntered = false;
            accountedFor = false;
            rend = scoreIndictator.GetComponent<Renderer>();

        }

        // Update is called once per frame
        void Update()
        {
            MoveTowardsCheckpoint();
            CheckForInput();
        }
        
        private void MoveTowardsCheckpoint()
        {
            //the speed, in units per second, we want to move towards the target
            float speed = 1;

            Vector3 currentPosition = this.transform.position;

            // If the dead flower enters
            if (checkpointIndex == checkpoints.Length - 1)
            {
                if (this.tag == "DeadFlower")
                {
                    Debug.Log("DeadFlower has entered");
                    deathHasEntered = true;
                }
            }

            // If the dead flower exits and we miss it
            if (checkpointIndex == 0)
            {
                if (this.tag == "DeadFlower")
                {
                    Debug.Log("DeadFlower has exited");
                    if (!accountedFor)
                    {
                        numberMissed++;
                        rend.material = materials[1]; // red for incorrect
                    }
                    deathHasEntered = false;
                } else if (this.tag == "NormalFlower")
                {

                }
            }

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

                // rotating the object
                this.transform.Rotate(0, 0, 20 * Time.deltaTime);
            } else
            {
                setNewDestination();
            }
        }

        private void CheckForInput()
        {
            // Detect key press
            GameObject[] deadFlowers = GameObject.FindGameObjectsWithTag("DeadFlower");
            if (Input.GetKeyDown(keyAction))
            {
                if (!deathHasEntered)
                {
                    Debug.Log("Incorrect!");
                    numberPressedAccidently++;
                    rend.material = materials[1]; // red for incorrect!
                }
                else
                {
                    Debug.Log("Correct!");
                    accountedFor = true;
                    numberCorrect++;
                    rend.material = materials[0]; // green for correct!
                }

            }
        }

        void OnTriggerEnter(Collider collider)
        {

        }

        void setNewDestination()
        {
            // To continue our patrol, set our destination to the next checkpoint
            checkpointIndex++;
            // When we enter a collider, set destination to the next collider's position
            if (checkpointIndex >= checkpoints.Length)
            {
                checkpointIndex = 0;
            }
            // Set the target!
         //   Debug.Log("Setting new target: " + checkpointIndex);
            destination = checkpoints[checkpointIndex];

        }
    }

}

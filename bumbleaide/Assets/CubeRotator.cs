using UnityEngine;
using System.Collections;

public class CubeRotator : MonoBehaviour {

    public Vector3 RotateAmount;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        // Rotate cube
        transform.Rotate(RotateAmount * Time.deltaTime);

    }





}
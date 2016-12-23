using UnityEngine;
using System.Collections;

public class RotateAround_Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//if (Input.GetKey(KeyCode.A))
			transform.RotateAround (Vector3.zero, Vector3.up, 20 * Time.deltaTime);
	}
}

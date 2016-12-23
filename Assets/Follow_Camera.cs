using UnityEngine;
using System.Collections;

public class Follow_Camera : MonoBehaviour {
	public Transform target;
	// Use this for initialization
	void Start () {
		this.transform.position = target.transform.position;
		this.transform.rotation = target.transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = target.transform.position;
		this.transform.rotation = target.transform.rotation;
	}
}

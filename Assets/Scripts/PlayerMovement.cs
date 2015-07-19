using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float moveSpeed;

	public Vector3 input;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		GetComponent<Rigidbody>().AddForce (input * moveSpeed);
	}
}

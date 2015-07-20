  using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float moveSpeed = 10;
	public Vector3 input;
	public float rotation;
	public float velocity;
	float temprotation;
	float horizontalVelocity;
	float verticalVelocity;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {


		velocity = Input.GetAxis ("Vertical");
		rotation = Input.GetAxis ("Horizontal");
		if (velocity != 0) {
			float rotateSpeed = 18 * moveSpeed;
			var distance = velocity * moveSpeed * Time.deltaTime;
			var turn = rotation * rotateSpeed * Time.deltaTime * velocity;
			transform.Rotate (0, turn, 0);
			transform.Translate (Vector3.forward * distance);
			print (rotation);

		}

	}
}

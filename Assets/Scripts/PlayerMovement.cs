using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float moveSpeed;
	public float rotateSpeed;
	public Vector3 input;
	public float rotation;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		private float temprotation;
		rotation = transform.eulerAngles.y;//Rotation from left and right keys
		transform.Rotate (0, Input.GetAxis ("Horizontal") * rotateSpeedn, 0);
		input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		if (rotation > 270) {
			temprotation -= 270;
		} else if (this.rotation > 180) {
			temprotation -= 180;
		} else if (this.rotation > 90) {
			temprotation -= 90;
		}else{
			temprotation = rotation;
		}
		print (rotation);
		//GetComponent<Rigidbody> ().AddForce (input * moveSpeed);
	}
}

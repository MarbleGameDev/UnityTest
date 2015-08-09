  using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float moveSpeed = 10.0f;
	public Vector3 input;
	public float rotation;
	public float velocity;
	public float turn;
	public bool shouldMove;
	public float velocityMod;



	// Use this for initialization
	void Start () 
	{


	}

	// Update is called once per frame
	void Update () 
	{
	


		velocity = Input.GetAxis ("Vertical");
		rotation = Input.GetAxis ("Horizontal");
			
			if (velocity != 0)
		{
			float rotateSpeed = 18 * moveSpeed;
			var distance = velocity * moveSpeed * Time.deltaTime;
			this.turn = rotation * rotateSpeed * Time.deltaTime * velocity;
			if (velocity < 0){
				velocityMod = (Mathf.Sqrt(Mathf.Abs(velocity)) * .8f);
			}else if (velocity > 0){
				velocityMod = (Mathf.Sqrt(velocity) * 1.1f);
			}
			if (shouldMove){
				transform.Rotate (0, turn, 0);
				transform.Translate (Vector3.forward * distance * velocityMod);
			}else{
				transform.Translate (Vector3.forward * distance * (velocityMod * .8f));
			}
		
			//moveSpeed = 
		}

			if (velocity == 0)
		{
			//moveSpeed = 
		}
		
			
		if ( transform.eulerAngles.z > 35 & 255 > transform.eulerAngles.z  )
		{
			transform.Rotate (0,0,-2);
		}
		if ( transform.eulerAngles.z > 265 & 325 > transform.eulerAngles.z  )
		{
			transform.Rotate (0,0,2);
		}

	}
}



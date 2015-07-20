using UnityEngine;
using System.Collections;
public class Move_dem_wheels : MonoBehaviour


{
	public bool Turning = false;
	public float velocity;
	public float rotation;
	public float fuckingVariable;

	
	void Start () 
	{
		

	}
	



	public void Update () 
	{

		velocity = Input.GetAxis ("Vertical");
		rotation = Input.GetAxis ("Horizontal");
		if (velocity > 0) 
		{
			transform.Rotate (10, 0, 0);
		}
		if (velocity < 0) 
		{
			transform.Rotate (-10, 0, 0);
		}

		//this code is for the fucking bullshit that is turning the front wheels. hint : its fucking bullshit.
		/*if (rotation != 0) 
		{
			fuckingVariable = rotation * "I dont even fucking know";
			transform.Rotate (0,fuckingVariable,0);
		}
		*/
	}
}
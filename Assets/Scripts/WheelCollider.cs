using UnityEngine;
using System.Collections;

public class WheelCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col)
	{
		GameObject player = GameObject.Find("SkyCar");
		PlayerMovement playerMovement = player.GetComponent<PlayerMovement> ();
		playerMovement.shouldMove = true;
	}
	void OnCollisionExit(Collision col){
		GameObject player = GameObject.Find("SkyCar");
		PlayerMovement playerMovement = player.GetComponent<PlayerMovement> ();
		playerMovement.shouldMove = false;
	}
}

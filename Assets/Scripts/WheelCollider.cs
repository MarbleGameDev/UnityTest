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
		if (col.gameObject.name != "floopy") {
			playerMovement.shouldMove = true;
		} else {
			playerMovement.shouldMove = false;
		}
	}
}

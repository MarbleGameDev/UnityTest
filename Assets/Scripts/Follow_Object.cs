using UnityEngine;
using System.Collections;
public class Follow_Object : MonoBehaviour 
{
	public GameObject target = null;
	Vector3 positionOffset = Vector3.zero;



	void Start () 
	{
		positionOffset = target.transform.position; 
	}
	
	
	void Update () 
	{
		GameObject player = GameObject.Find("SkyCar");
		PlayerMovement playerMovement = player.GetComponent<PlayerMovement> ();
		if (target != null) 
		{
			transform.LookAt (target.transform);
		}
		transform.position = target.transform.position + positionOffset;
		if (playerMovement.turn != 0) {
			transform.Rotate (0, playerMovement.turn, 0);
		}
		
	}
	
}

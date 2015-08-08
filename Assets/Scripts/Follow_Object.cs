using UnityEngine;
using System.Collections;
public class Follow_Object : MonoBehaviour 
{
	public GameObject target = null;
	Vector3 positionOffset = Vector3.zero;


	void Start () 
	{
		positionOffset = target.transform.position + transform.position; 
	}
	
	
	void Update () 
	{
		if (target != null) 
		{
			transform.LookAt (target.transform);
		}
		transform.position = target.transform.position + positionOffset;
		transform.rotation = target.transform.rotation;
		
	}
	
}

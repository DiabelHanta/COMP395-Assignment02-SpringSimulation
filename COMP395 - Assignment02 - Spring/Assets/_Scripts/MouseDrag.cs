using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
	//PUBLIC INSTANCES
	public float distance = 15f; //Floating variable for distance (z-axis)

//	private Transform _springTransform;
//
//	void Start()
//	{
//		//References to componens in Unity
//		this._springTransform = gameObject.GetComponent<Transform>();
//	}

	//METHODS
	//Dragging the "spring" object with mouse
	void OnMouseDrag()
	{
		//Instantiating a Vector3 object with x, y, and z axis values.
		Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
		//
		Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);

		//The position of the object is assigned to the Vector3 object,"objPOsition"
		transform.position = objPosition;
	}

}

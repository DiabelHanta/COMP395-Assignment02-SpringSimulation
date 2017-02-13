using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditMass : MonoBehaviour 
{
	//PUBLIC INSTANCES
	public float mass;
	public Rigidbody spring;


	// Use this for initialization
	void Start () 
	{
		spring = GetComponent<Rigidbody> ();
		//spring.mass = mass;
	}
//	
//	// Update is called once per frame
//	void Update () 
//	{
//		
//	}

	//METHODS
//	//Method for Changing Mass during simulation
//	public void Text_Changed(string newText)
//	{
//		//Converting the input field's text into a float datatype
//		float temp = float.Parse(newText);
//
//		//Setting user's input of mass to the spring object
//		spring.mass = new 
//	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditingValues : MonoBehaviour 
{
//	//PUBLIC INSTANCES
//	public InputField inputSpringConst;
//	public InputField inputMass;
	public Rigidbody mass;

	//PRIVATE INSTANCES
	private InputField _inputSpringConst;
	private InputField _inputMass;
//	private Rigidbody _rigidbody;

	// Use this for initialization
	void Start ()
	{
		//Referrencing to GameObjects in Unity
		_inputSpringConst = GetComponent<InputField>();
		_inputMass = GetComponent<InputField>();
		//rigidbody = GetComponent<Rigidbody>();
	}

	//METHODS
	//Change Mass via input field, "inputMass"
	public void EditMass(string newText)
	{
		//Converting Float into String
		float temp = float.Parse(newText);

		//
//		mass = new 
	}
}

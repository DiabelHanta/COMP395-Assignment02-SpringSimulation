using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutputProperties : MonoBehaviour 
{
	//PUBLIC INSTANCES
	public Text textProperties;

	//PRIVATE INSTANCES

	//METHODS
	//Output both the "Spring Constant" and the "Mass"
	private void _PropertiesOutput()
	{
		//Setting/Updating the text (INCOMPLETE)
		textProperties.text = "Spring Constant:";
	}

	//EXTRA
//	//Resets transform of the base and spring objects
//	public void Reset()
//	{
//		
//	}

	//Exit
	public void Exit()
	{
		Application.Quit ();
	}
}

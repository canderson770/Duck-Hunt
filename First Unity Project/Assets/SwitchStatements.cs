using UnityEngine;
using System.Collections;

public class SwitchStatements : MonoBehaviour
{
	public int age = 3;

	void Start ()
	{
		switch (age)
		{
			case 1: Debug.Log ("Happy 1st Birthday!"); break;
			case 2: Debug.Log ("Happy 2nd Birthday!"); break;
			case 3: Debug.Log ("Happy 3rd Birthday!"); break;
			default: Debug.Log ("Error"); break;

		}
	}
	
	void Update ()
	{
	
	}
}

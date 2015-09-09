using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour
{

	int myInt = 5;

	// Use this for initialization
	void Start () 
	{
		myInt = MultiplyByTwo(myInt);
		Debug.Log(myInt);
	}

	int MultiplyByTwo(int number)
	{
		int retInt;
		retInt = number * 2;
		return retInt;
	}

	// Update is called once per frame
	void Update () 
	{
	
	}
}

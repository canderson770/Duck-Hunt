using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		int number = 10;

		while (number > 0)
		{
			Debug.Log (number);
			number--;
		}
	}
	
	// Update is called once per frame
	void Update () {

	}
}

using UnityEngine;
using System.Collections;

public class DoWhileLoop : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		int number = 10;
		
		do
		{
			Debug.Log (number);
			number--;
		}while (number > 10);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

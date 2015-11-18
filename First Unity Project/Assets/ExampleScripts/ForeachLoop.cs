using UnityEngine;
using System.Collections;

public class ForeachLoop : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		string[] countdown = new string[5];

		countdown [0] = "FIVE";
		countdown [1] = "FOUR";
		countdown [2] = "THREE";
		countdown [3] = "TWO";
		countdown [4] = "ONE";

		foreach (string number in countdown)
		{
			Debug.Log (number);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

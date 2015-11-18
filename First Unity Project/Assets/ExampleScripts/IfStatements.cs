using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour {

	// Use this for initialization
	void Start (){}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space))
			Debug.Log ("Space was pressed");
		else if (Input.GetKeyDown (KeyCode.Return))
			Debug.Log ("Enter was pressed");
		else if (Input.GetKeyDown (KeyCode.LeftShift) || Input.GetKeyDown (KeyCode.RightShift))
			Debug.Log ("Shift was pressed");
	}
}

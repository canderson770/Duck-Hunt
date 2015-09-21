using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		int max = 5;

		for (int i = 0; i < max; i++)
		{
			Debug.Log (i + 1);
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}

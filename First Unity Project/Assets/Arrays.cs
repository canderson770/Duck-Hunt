using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour
{
	 int[] myArray = {10, 12, 23, 34};

	// Use this for initialization
	void Start ()
	{
		for (int i =0; i < myArray.Length; i++)
		{
			Debug.Log (myArray[i]);
		}

	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

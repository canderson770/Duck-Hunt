using UnityEngine;
using System.Collections;
using System;

public class SetSpawnPoint : MonoBehaviour 
{
	public static Action<Transform> PassSpawnPointTransform;

	void Start () 
	{
		if (PassSpawnPointTransform != null)
			PassSpawnPointTransform (transform);
	}

}
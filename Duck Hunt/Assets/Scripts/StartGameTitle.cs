using UnityEngine;
using System.Collections;

public class StartGameTitle : MonoBehaviour
{
	void Update()
	{
		if (Input.GetButtonUp ("Fire1"))
			Application.LoadLevel ("DuckHunt");
	}
}

using UnityEngine;
using System.Collections;

public class BackToMenu : MonoBehaviour
{

	void Update ()
	{
		if(Input.GetButton("Fire1"))
			Application.LoadLevel("MainMenu");
	}
}

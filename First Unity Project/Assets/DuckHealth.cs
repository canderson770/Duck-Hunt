using UnityEngine;
using System.Collections;

public class DuckHealth : MonoBehaviour
{
	//void Start () {}
	
	//void Update () {}

	void OnTriggerEnter(Collider hit)
	{
		if (hit.tag == "KillZone")
		{
			Destroy (this.gameObject);
		}
	}
}

using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour
{
	RaycastHit hit;

	private int bulletAmount;
	public int maxBullets;

	// Use this for initialization
	void Start ()
	{
		GameManager.OnSpawnDucks += ResetBullets;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0))
		{
			bulletAmount--;
			if (bulletAmount <= 0)
			{
				GameManager.OnDuckMiss();
			}

			Vector3 mousePos = Input.mousePosition;
			mousePos.z = Camera.main.transform.position.z;

			if (Physics.Raycast (Camera.main.ScreenToWorldPoint(mousePos), Camera.main.transform.forward, out hit, Mathf.Infinity))
			{
				if (hit.transform.tag == "Duck")
				{
					hit.transform.GetComponent<DuckHealth>();
					//DuckHealth.Destroy();
				}
			}
		}
	}

	public void ResetBullets()
	{
		bulletAmount = maxBullets;
	}
}

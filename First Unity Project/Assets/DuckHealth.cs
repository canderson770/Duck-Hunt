using UnityEngine;
using System.Collections;

public class DuckHealth : MonoBehaviour
{
	Animator anim;

	bool isInvincible;

	void Start ()
	{
		//getcomponent
		GameManager.OnDuckMiss += MakeInvincible;
		GameManager.OnDuckShot += MakeInvincible;

	}
	
	//void Update () {}

	void OnTriggerEnter(Collider hit)
	{
		if (hit.tag == "KillZone")
		{
			Destroy (this.gameObject);
		}
		if (hit.tag == "FlyAwayZone")
		{
			GameManager.OnDuckFlyAway();
			Destroy (this.gameObject);
		}
	}

	public void KillDuck()
	{
		if (isInvincible == false)
		{
			anim.Play ("duck death");
			GameManager.OnDuckShot();
		}
	}

	public void MakeInvincible()
	{
		isInvincible = true;
	}

}

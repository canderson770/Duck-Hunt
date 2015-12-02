using UnityEngine;
using System.Collections;

public class DogControl : MonoBehaviour
{
	Animator anim;

	// Use this for initialization
	void Start ()
	{
	//getcomponent
		anim = gameObject.GetComponent<Animator>();
		GameManager.OnDuckDeath += PlayPopup;
		GameManager.OnDuckFlyAway += PlayLaugh;
	}
	
	// Update is called once per frame
	//void Update (){}

	public void SpawnDucks()
	{
		GameManager.OnSpawnDucks ();
	}

	public void PlayLaugh()
	{
		anim.Play ("dog laugh");
	}

	public void PlayPopup()
	{
		anim.Play ("dog popup");
	}
}
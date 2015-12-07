using UnityEngine;
using System.Collections;

public class DogControl : MonoBehaviour
{
	Animator anim;
    public AudioClip laugh;
    public AudioClip bark;
	public AudioClip gotDuck;
    public AudioClip intro;
    public AudioSource source;

	// Use this for initialization
	void Start ()
	{
	//getcomponent
		anim = gameObject.GetComponent<Animator>();
		GameManager.OnDuckDeath += PlayPopup;
		GameManager.OnDuckFlyAway += PlayLaugh;
        GameManager.OnStartGame += PlayIntro;
	}
	
	// Update is called once per frame
	//void Update (){}

	public void SpawnDucks()
	{
		GameManager.OnSpawnDucks();
	}

	public void PlayLaugh()
	{
        anim.Play ("dog laugh");
        source.PlayOneShot(laugh, 1);
    }

    public void PlayIntro()
    {
        anim.Play("dog walking");
        source.PlayOneShot(intro, 1);
    }

    public void PlayBark()
    {
        source.PlayOneShot(bark, 1);
    }

    public void PlayPopup()
	{
		anim.Play ("dog popup");
		source.PlayOneShot(gotDuck, 1);
	}
}
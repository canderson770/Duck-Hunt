using UnityEngine;
using System.Collections;

public class titleScreen : MonoBehaviour
{
    public GameObject title;
    public AudioClip startMusic;
    public AudioSource source;
    DogControl dog;

	// Use this for initialization
	void Start ()
    {
        title.SetActive(true);
        source.PlayOneShot(startMusic, 1);
    }
	
	// Update is called once per frame
	void Update ()
    {
        TitleScreenStart();
	}

    public void TitleScreenStart()
    {
        if (Input.anyKey)
        {
			GameManager.OnStartGame();
            title.SetActive(false);
        }
    }
}

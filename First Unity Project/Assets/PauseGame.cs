using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour
{
	public GameObject pausedPopup;
	public AudioClip pauseSound;
	public AudioSource source;
	bool paused;

	// Use this for initialization
	void Start ()
	{
		paused = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyUp (KeyCode.P) || Input.GetKeyUp (KeyCode.Escape))
		{
			paused = !paused;

			if (paused)
			{
				source.PlayOneShot (pauseSound);
				pausedPopup.SetActive (true);
			}
			else if (!paused)
				pausedPopup.SetActive (false);
		}

		if (paused) 
		{
			Time.timeScale = 0;
		}

		else if (!paused)
		{
			Time.timeScale = 1;
		}
	}
}

using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour
{
	public GameObject pausedPopup;
	public AudioClip pauseSound;
	public AudioSource source;
	public GameObject pausedText;
	bool paused = false;
	int EscapeNum = 0;



	void Update ()
	{
		if (Input.GetKeyUp (KeyCode.P))
		{
			paused = !paused;

			if (paused)
			{
				source.PlayOneShot (pauseSound);
				pausedPopup.SetActive (true);
				pausedText.SetActive (true);
			}
			else if (!paused)
			{
				pausedPopup.SetActive (false);
				pausedText.SetActive (false);
			}
		}

		if (Input.GetKeyUp (KeyCode.Escape))
		{
			paused = !paused;
			
			if (paused)
			{
				source.PlayOneShot (pauseSound);
				pausedPopup.SetActive (true);
				pausedText.SetActive (true);
			}
			else if (!paused)
				Application.Quit ();
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

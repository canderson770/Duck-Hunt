using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour
{
	public GameObject pausedPopup;
	public AudioClip pauseSound;
	public AudioSource source;
	public GameObject pausedText;
	int EscapeNum = 0;



	void Update ()
	{
		if (Input.GetKeyUp (KeyCode.P))
		{
			StaticVars.paused = !StaticVars.paused;

			if (StaticVars.paused)
			{
				source.PlayOneShot (pauseSound);
				pausedPopup.SetActive (true);
				pausedText.SetActive (true);
			}
			else if (!StaticVars.paused)
			{
				pausedPopup.SetActive (false);
				pausedText.SetActive (false);
			}
		}

		if (Input.GetKeyUp (KeyCode.Escape))
		{
			StaticVars.paused = !StaticVars.paused;
			
			if (StaticVars.paused)
			{
				source.PlayOneShot (pauseSound);
				pausedPopup.SetActive (true);
				pausedText.SetActive (true);
			}
			else if (!StaticVars.paused)
				Application.Quit ();
		}

		if (StaticVars.paused) 
		{
			Time.timeScale = 0;
		}

		else if (!StaticVars.paused)
		{
			Time.timeScale = 1;
		}
	}
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Shooter : MonoBehaviour
{
	RaycastHit hit;

    public AudioClip shot;
    public AudioSource source;
    private float volMin = .7f;
    private float volMax = .9f;

    public GameObject bullet1;
    public GameObject bullet2;
    public GameObject bullet3;

	public Text scoreTxt;
	private int score;
	public GameObject scoreObject;

    private int bulletAmount;
	public int maxBullets;

	public GameObject redDuck1;
	public GameObject redDuck2;
	public GameObject redDuck3;
	public GameObject redDuck4;
	public GameObject redDuck5;
	public GameObject redDuck6;
	public GameObject redDuck7;
	public GameObject redDuck8;
	public GameObject redDuck9;
	public GameObject redDuck10;
	DuckSpawn duck;
	bool duckShot;

	// Use this for initialization
	void Start ()
	{
		scoreTxt = scoreObject.GetComponent<Text>();

        maxBullets = 3;
        bulletAmount = 50;
        GameManager.OnSpawnDucks += ResetBullets;
    }
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0))
		{
			bulletAmount--;
            BulletGUI(bulletAmount);
			if (-1 < bulletAmount && bulletAmount < 4)
			{
	            float vol = Random.Range(volMin, volMax);
	            source.PlayOneShot(shot, vol);
			}

			if (bulletAmount <= 0)
			{
				GameManager.OnDuckMiss();
			}

			Vector3 mousePos = Input.mousePosition;
			mousePos.z = Camera.main.transform.position.z;

			Debug.DrawRay(Camera.main.ScreenToWorldPoint(mousePos), Camera.main.transform.forward,Color.red, 3f);

			if (Physics.Raycast(Camera.main.ScreenToWorldPoint(mousePos), Camera.main.transform.forward, out hit, Mathf.Infinity))
			{
                if (hit.transform.tag == "Duck")
                {
					DuckHealth health;
                    health = hit.transform.GetComponent<DuckHealth>();
                    health.KillDuck();
					SetScore();
                    //print("Duck Shot!");
					duckShot =  true;
					DuckGUI();
                }
      		}
		}
	}

	public void SetScore()
	{
		score += 500;
		scoreTxt.text = score.ToString().PadLeft(6, '0');
	}

	public void DuckGUI()
	{
		if (duckShot == true)
		{
			switch (duck.duckNum)
			{
			case 1:
				redDuck1.SetActive (true);
				break;
			case 2:
				redDuck2.SetActive (true);
				break;
			case 3:
				redDuck3.SetActive (true);
				break;
			case 4:
				redDuck4.SetActive (true);
				break;
			case 5:
				redDuck5.SetActive (true);
				break;
			case 6:
				redDuck6.SetActive (true);
				break;
			case 7:
				redDuck7.SetActive (true);
				break;
			case 8:
				redDuck8.SetActive (true);
				break;
			case 9:
				redDuck9.SetActive (true);
				break;
			case 10:
				redDuck10.SetActive (true);
				break;
			default:
				redDuck1.SetActive (false);
				redDuck2.SetActive (false); 
				redDuck3.SetActive (false); 
				redDuck4.SetActive (false); 
				redDuck5.SetActive (false); 
				redDuck6.SetActive (false); 
				redDuck7.SetActive (false); 
				redDuck8.SetActive (false); 
				redDuck9.SetActive (false); 
				redDuck10.SetActive (false);
				break;
			}
		} else
		{
			redDuck1.SetActive (false);
			redDuck2.SetActive (false); 
			redDuck3.SetActive (false); 
			redDuck4.SetActive (false); 
			redDuck5.SetActive (false); 
			redDuck6.SetActive (false); 
			redDuck7.SetActive (false); 
			redDuck8.SetActive (false); 
			redDuck9.SetActive (false); 
			redDuck10.SetActive (false);
		}
	}

	public void ResetBullets()
	{
		bulletAmount = maxBullets;
        bullet3.SetActive(true);
        bullet2.SetActive(true);
        bullet1.SetActive(true);
    }

    public void BulletGUI(int bullets)
    {
        if (bullets == 2)
        {
            bullet3.SetActive(false);
        }
        else if (bullets == 1)
        {
            bullet3.SetActive(false); bullet2.SetActive(false);
        }
        else if (bullets <= 0)
        {
            bullet3.SetActive(false); bullet2.SetActive(false); bullet1.SetActive(false);
        }
        else
        {
            bullet3.SetActive(true); bullet2.SetActive(true); bullet1.SetActive(true);
        }

    }
}

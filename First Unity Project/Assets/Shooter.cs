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

    public AudioClip win;
    public AudioClip lose;

    public GameObject bullet1;
    public GameObject bullet2;
    public GameObject bullet3;

	private Text scoreTxt;
	private int score;
	public GameObject scoreObject;

    private Text roundText;
    private int roundNum;
    public GameObject roundObject;

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
    private int duckNum;
    private int duckShotNum;

	// Use this for initialization
	void Start ()
	{
		scoreTxt = scoreObject.GetComponent<Text>();
        roundText = roundObject.GetComponent<Text>();
        duckNum = 0;
        duckShotNum = 0;
        roundNum = 1;

        maxBullets = 3;
        bulletAmount = 50;
        GameManager.OnSpawnDucks += ResetBullets;
        GameManager.OnNewRound += ResetRound;
    }
	
	// Update is called once per frame
	void Update ()
	{
     //   if duckHealth.
		if (Input.GetMouseButtonDown (0))
		{
			bulletAmount--;
            BulletGUI(bulletAmount);
			if (-1 < bulletAmount && bulletAmount < 4)
			{
	            float vol = Random.Range(volMin, volMax);
	            source.PlayOneShot(shot, vol);
			}

			if (bulletAmount < 0)
			{
                bulletAmount = 20;
                duckNum++;
                GameManager.OnDuckMiss();
			}

            if (bulletAmount == 0)
            {
                Vector3 mousePos = Input.mousePosition;
                mousePos.z = Camera.main.transform.position.z;

                Debug.DrawRay(Camera.main.ScreenToWorldPoint(mousePos), Camera.main.transform.forward, Color.red, 3f);

                if (Physics.Raycast(Camera.main.ScreenToWorldPoint(mousePos), Camera.main.transform.forward, out hit, Mathf.Infinity))
                {
                    if (hit.transform.tag == "Duck")
                    {
                        bulletAmount = 20;
                        DuckHealth health;
                        health = hit.transform.GetComponent<DuckHealth>();
                        health.KillDuck();
                        SetScore();
                        duckNum++;
                        DuckGUI();
                    }
                }
                else
                {
                    duckNum++;
                    GameManager.OnDuckMiss();
                }
            }
            else
            {
                Vector3 mousePos = Input.mousePosition;
                mousePos.z = Camera.main.transform.position.z;

                Debug.DrawRay(Camera.main.ScreenToWorldPoint(mousePos), Camera.main.transform.forward, Color.red, 3f);

                if (Physics.Raycast(Camera.main.ScreenToWorldPoint(mousePos), Camera.main.transform.forward, out hit, Mathf.Infinity))
                {
                    if (hit.transform.tag == "Duck")
                    {
                        bulletAmount = 20;
                        DuckHealth health;
                        health = hit.transform.GetComponent<DuckHealth>();
                        health.KillDuck();
                        SetScore();
                        duckNum++;
                        DuckGUI();
                    }
                }
            }
		}

        if (duckNum >= 10)
        {
            GameManager.OnNewRound();
        }
	}

	public void SetScore()
	{
		score += 500;
		scoreTxt.text = score.ToString().PadLeft(6, '0');
	}

    public void ResetRound()
    {
        redDuck1.SetActive(false);
        redDuck2.SetActive(false);
        redDuck3.SetActive(false);
        redDuck4.SetActive(false);
        redDuck5.SetActive(false);
        redDuck6.SetActive(false);
        redDuck7.SetActive(false);
        redDuck8.SetActive(false);
        redDuck9.SetActive(false);
        redDuck10.SetActive(false);
        duckNum = 0;
        if (duckShotNum >= 6)
        {
            source.PlayOneShot(win, 1);
            roundNum++;
            roundText.text = "R = " + roundNum.ToString();
        }
        else
        {
            source.PlayOneShot(lose, 1);
            roundNum = 1;
            roundText.text = "R = " + roundNum.ToString();
        }
    }

	public void DuckGUI()
	{
			switch (duckNum)
			{
			case 1:
				redDuck1.SetActive (true);
                duckShotNum++;
                print(duckShotNum);
				break;
			case 2:
				redDuck2.SetActive (true);
                duckShotNum++;
                print(duckShotNum);
                break;
			case 3:
				redDuck3.SetActive (true);
                duckShotNum++;
                print(duckShotNum);
                break;
			case 4:
				redDuck4.SetActive (true);
                duckShotNum++;
                print(duckShotNum);
                break;
			case 5:
				redDuck5.SetActive (true);
                duckShotNum++;
                print(duckShotNum);
                break;
			case 6:
				redDuck6.SetActive (true);
                duckShotNum++;
                print(duckShotNum);
                break;
			case 7:
				redDuck7.SetActive (true);
                duckShotNum++;
                print(duckShotNum);
                break;
			case 8:
				redDuck8.SetActive (true);
                duckShotNum++;
                print(duckShotNum);
                break;
			case 9:
				redDuck9.SetActive (true);
                duckShotNum++;
                print(duckShotNum);
                break;
			case 10:
				redDuck10.SetActive (true);
                duckShotNum++;
                print(duckShotNum);
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

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
    public int roundNum;
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

	public GameObject whiteDucks;
	Animator anim;

    public int duckNum;
    private int duckShotNum;
    bool noClick;

    // Use this for initialization
    void Start()
    {
		anim = whiteDucks.GetComponent<Animator> ();

        scoreTxt = scoreObject.GetComponent<Text>();
        roundText = roundObject.GetComponent<Text>();
        duckNum = 1;
        duckShotNum = 0;
        roundNum = 1;

        maxBullets = 3;
        bulletAmount = 50;
        GameManager.OnSpawnDucks += ResetBullets;
        GameManager.OnSpawnDucks += ClickOn;
		GameManager.OnSpawnDucks += DuckGUI;
		GameManager.OnDuckMiss += DuckGUIStop;
		GameManager.OnDuckShot += DuckGUIStop;
        GameManager.OnNewRound += ResetRound;
        GameManager.OnNewRound += ResetBullets;
        GameManager.OnNewRound += RoundNum;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (noClick == false)
            {
                bulletAmount--;
                BulletGUI(bulletAmount);

                if (bulletAmount < 0)
                {
                    bulletAmount = 20;
                    duckNum++;
                    noClick = true;
                    GameManager.OnDuckMiss();
                }

                if (-1 < bulletAmount && bulletAmount < 4)
                {
                    float vol = Random.Range(volMin, volMax);
                    source.PlayOneShot(shot, vol);
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
                            noClick = true;
                            DuckHealth health = hit.transform.GetComponent<DuckHealth>();
                            health.KillDuck();
                            SetScore();
                            duckShotNum++;
                            DuckGUIShot();
							duckNum++;
						}
                    }
                    else
                    {
                        duckNum++;
                        noClick = true;
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
                            noClick = true;
                            DuckHealth health = hit.transform.GetComponent<DuckHealth>();
                            health.KillDuck();
                            SetScore();
                            duckShotNum++;
                            DuckGUIShot();
							duckNum++;
						}
                    }
                }
            }
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
        duckNum = 1;
    }

    public void DuckGUIShot()
    {
        switch (duckNum)
        {
            case 1:
                redDuck1.SetActive(true); break;
            case 2:
                redDuck2.SetActive(true); break;
            case 3:
                redDuck3.SetActive(true); break;
            case 4:
                redDuck4.SetActive(true); break;
            case 5:
                redDuck5.SetActive(true); break;
            case 6:
                redDuck6.SetActive(true); break;
            case 7:
                redDuck7.SetActive(true); break;
            case 8:
                redDuck8.SetActive(true); break;
            case 9:
                redDuck9.SetActive(true); break;
            case 10:
                redDuck10.SetActive(true); break;
            default:
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
                break;
        }
    }

	public void DuckGUI()
	{
		print ("duckNum = " + duckNum);
		switch (duckNum)
		{
		case 1:
			anim.Play ("1"); break;
		case 2:
			anim.Play ("2"); break;
		case 3:
			anim.Play ("3"); break;
		case 4:
			anim.Play ("4"); break;
		case 5:
			anim.Play ("5"); break;
		case 6:
			anim.Play ("6"); break;
		case 7:
			anim.Play ("7"); break;
		case 8:
			anim.Play ("8"); break;
		case 9:
			anim.Play ("9"); break;
		case 10:
			anim.Play ("10"); break;
		default:break;
		}
	}

	public void DuckGUIStop()
	{
			anim.Play ("no flash");
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

    public void RoundNum()
    {
        if (duckShotNum > 6)
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
			score = 0;
			scoreTxt.text = score.ToString().PadLeft(6, '0');
        }
        duckShotNum = 0;
    }

    public void ClickOn()
    {
        noClick = false;
    }
}
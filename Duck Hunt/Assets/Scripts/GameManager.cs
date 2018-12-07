using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour
{
	public delegate void DuckDel();
	public static DuckDel OnSpawnDucks;
	public static DuckDel OnDuckShot;
	public static DuckDel OnDuckDeath;
	public static DuckDel OnDuckFlyAway;
	public static DuckDel OnDuckMiss;
    public static DuckDel OnStartGame;
	public static DuckDel OnNewRound;


	public GameObject flyAwaySky;
    public GameObject roundPopup;
    public GameObject roundPopupNumText;
    Text roundPopupText;
    Shooter shoot;

    // Use this for initialization
    void Start ()
	{
        GameObject shooter = GameObject.Find("Main Camera");
        shoot = shooter.GetComponent<Shooter>();
        roundPopupText = roundPopupNumText.GetComponent<Text>();

		GameManager.OnDuckMiss += FlyAwaySkyOn;
		GameManager.OnDuckFlyAway += FlyAwaySkyOff;
		GameManager.OnSpawnDucks += FlyAwaySkyOff;
        GameManager.OnNewRound += FlyAwaySkyOff;
        GameManager.OnStartGame += DisplayRoundNumOn;
        GameManager.OnNewRound += DisplayRoundNumOn;
        GameManager.OnSpawnDucks += DisplayRoundNumOff;
    }
		

	public void FlyAwaySkyOn()
	{
		flyAwaySky.SetActive (true);
	}

	public void FlyAwaySkyOff()
	{
		flyAwaySky.SetActive (false);
	}

    public void DisplayRoundNumOn()
    {
        roundPopupText.text = "ROUND\n" + StaticVars.roundNum;
        roundPopup.SetActive(true);
    }

    public void DisplayRoundNumOff()
    {
        roundPopupText.text = "ROUND\n" + StaticVars.roundNum;
        roundPopup.SetActive(false);
    }
}

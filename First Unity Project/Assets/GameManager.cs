using UnityEngine;
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

    // Use this for initialization
    void Start ()
	{
		GameManager.OnDuckMiss += FlyAwaySkyOn;
		GameManager.OnDuckFlyAway += FlyAwaySkyOff;
		GameManager.OnSpawnDucks += FlyAwaySkyOff;
	}

    // Update is called once per frame
    //void Update () {}

	public void FlyAwaySkyOn()
	{
		flyAwaySky.SetActive (true);
	}

	public void FlyAwaySkyOff()
	{
		flyAwaySky.SetActive (false);
	}
}

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


    // Use this for initialization
    //void Start () {}

    // Update is called once per frame
    //void Update () {}
}

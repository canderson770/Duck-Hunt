using UnityEngine;
using System.Collections;

public class DuckSpawn : MonoBehaviour
{
	public GameObject duck;
    public int roundNum;
	void Start ()
	{
        roundNum = 1;
        GameManager.OnSpawnDucks += SpawnDuck;
	}
	
	//void Update (){}

	public void SpawnDuck()
	{
		Instantiate(duck, transform.position, Quaternion.identity);
        roundNum++;
	}
}

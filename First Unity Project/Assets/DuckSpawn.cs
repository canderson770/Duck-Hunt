using UnityEngine;
using System.Collections;

public class DuckSpawn : MonoBehaviour
{
	public GameObject duck;
    public int duckNum;
	void Start ()
	{
        duckNum = 0;
        GameManager.OnSpawnDucks += SpawnDuck;
	}
	
	//void Update (){}

	public void SpawnDuck()
	{
		Instantiate(duck, transform.position, Quaternion.identity);
        duckNum++;
		print (duckNum);
	}
}

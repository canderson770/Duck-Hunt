using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GUI : MonoBehaviour
{
    Text text;
    private DuckSpawn duckSpawnClass;

    // Use this for initialization
    void Start ()
    {
        text = GetComponent<Text>();
        //        GameManager.OnSpawnDucks += setRoundNumber;
    }
	
	// Update is called once per frame
	//void Update () {}

    public void setRoundNumber()
    {
        text.text = "R = " + duckSpawnClass.roundNum;
    }
}

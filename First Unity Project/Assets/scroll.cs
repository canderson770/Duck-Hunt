using UnityEngine;
using System.Collections;

public class scroll : MonoBehaviour
{

    public float speed = -.01f;

	// Use this for initialization
	void Start ()
    {
        speed = -.01f;
    }
	
	// Update is called once per frame
	void Update ()
    {
        Vector2 offset = new Vector2(Time.time * speed, 0);

        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}

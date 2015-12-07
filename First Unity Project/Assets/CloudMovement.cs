using UnityEngine;
using System.Collections;

public class CloudMovement : MonoBehaviour
{
    public float speed;
    public Vector3 direction;

    // Use this for initialization
    //void Start (){}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = transform.position + (direction * speed);
    }
}

using UnityEngine;
using System.Collections;

public class Enumerations : MonoBehaviour
{
	enum Direction {North, South, East, West};

	Direction ReverseDirection(Direction dir)
	{
		if (dir == Direction.North)
			dir = Direction.South;
		else if(dir == Direction.South)
			dir = Direction.North;

		return dir;
	}


	void Start ()
	{
		Direction newDirection;
		newDirection = Direction.North;

		Debug.Log (ReverseDirection(newDirection));
	}
	
	void Update ()
	{
	
	}
}

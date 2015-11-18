using UnityEngine;
using System.Collections;

public class ClassesAndDataTypes : MonoBehaviour {

	public class Example
	{
		public int number1;
		public int number2;
	
		public Example()
		{
			number1 = 1;
			number2 = 2;
		}

		public Example(int num1, int num2)
		{
			number1 = num1;
			number2 = num2;
		}
		
	}

	void Start ()
	{
		Example myExample = new Example (10, 12);

		Example myExample2 = myExample;
		myExample.number1 = 100;

		int num1 = 5;
		int num2 = num1;
		num1 = 10;

	}
	
	void Update ()
	{
	}
}

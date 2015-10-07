using UnityEngine;
using System.Collections;

public class ClassesAndDataTypes : MonoBehaviour {

	public class Example
	{
		public int number1;
		public int number2;
		public int number3;

		public Example(int num1, int num2, int num3)
		{
			number1 = num1;
			number2 = num2;
			number3 = num3;
		}

		public Example()
		{
			number1 = 1;
			number2 = 2;
			number3 = 3;
		}
	}

	public Example myExample =  new Example(10,12,5);





	void Start ()
	{
	}
	
	void Update ()
	{
	}
}

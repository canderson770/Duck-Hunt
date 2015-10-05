using UnityEngine;
using System.Collections;

public class AnotherClass
{
	public int A = 1;
	public int B = 2;
	private int C = 3;
	private int D = 4;

	public void PublicFunction (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log("PublicFunction: " + answer);
	}

	private void PrivateFunction (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log("PrivateFunction:" + answer);
	}
}
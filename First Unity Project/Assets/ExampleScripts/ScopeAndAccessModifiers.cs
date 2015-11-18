using UnityEngine;
using System.Collections;

public class ScopeAndAccessModifiers : MonoBehaviour
{
	public int alpha = 1;
	private int beta = 2;
	private int gamma = 3;
	private AnotherClass myOtherClass;

	void Start ()
	{
		alpha = 1;
		myOtherClass = new AnotherClass();
		myOtherClass.PublicFunction (beta, myOtherClass.B);
	}

	private void ExampleFunction (int num1, int num2)
	{
		int answer;
		answer = num1 * num2 * alpha;
		Debug.Log(answer);
	}
	
	void Update ()
	{
		//Debug.Log ("Alpha: " + alpha);
	}
}
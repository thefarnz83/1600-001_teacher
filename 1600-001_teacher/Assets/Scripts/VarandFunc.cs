using UnityEngine;
using System.Collections;

public class VarandFunc : MonoBehaviour 
{
	int myInt = 10;

	// Use this for initialization
	void Start () 
	{
		myInt = DivideByTwo(myInt);
		Debug.Log (myInt);
	}

	int DivideByTwo (int number)
	{
		int ret;
		ret = number / 2;
		return ret;
	}
}
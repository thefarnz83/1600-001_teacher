﻿using UnityEngine;
using System.Collections;

public class PublicVarandFunc : MonoBehaviour 
{
	public int myInt = 2;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		myInt = MultiplyByTwo(myInt);
		Debug.Log (myInt);
	}

	int MultiplyByTwo (int number)
	{
		int ret;
		ret = number * 2;
		return ret;
	}
}

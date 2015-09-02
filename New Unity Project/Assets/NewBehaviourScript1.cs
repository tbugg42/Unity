using UnityEngine;
using System.Collections;

public class NewBehaviourScript1 : MonoBehaviour {

	int myint=9;
	// Use this for initialization
	void Start () 
	{
		myint = multiplytwo (myint);
		Debug.Log (myint);


	}
	
	// Update is called once per frame
	int multiplytwo(int number) 
	{
		int ret;
		ret = number * 2;
		return ret;
	}
}

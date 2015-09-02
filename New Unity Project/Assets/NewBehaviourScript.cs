using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour
{   
	int myInt = 7;

	void Start ()
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

using UnityEngine;
using System.Collections;

public class Whileloop : MonoBehaviour 
{
	int cupsInTheSink = 7;
	
	
	void Start ()
	{
		while(cupsInTheSink>0)
		{
		Debug.Log ("Still cleaning");
		cupsInTheSink--;
		}
	}
}

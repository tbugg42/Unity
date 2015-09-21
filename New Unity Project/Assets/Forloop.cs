using UnityEngine;
using System.Collections;

public class Forloop : MonoBehaviour 

{
	int numEnemies = 5;
		
		
	void Start ()
	{
		for(int i = 0; i < numEnemies; i++)
		{
			Debug.Log("Creating enemy number: " + i);
		}
	}
}

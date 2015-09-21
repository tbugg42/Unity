using UnityEngine;
using System.Collections;

public class Dowhileloop : MonoBehaviour 
{
	void Start()
	{
		bool shouldContinue = true;
		
		do
		{
			print ("Hello World");
			shouldContinue = false;
		}while(shouldContinue == true);
	}
}
using UnityEngine;
using System.Collections;

public class Dowhileloop : MonoBehaviour 
{
	void Start()
	{
		bool shouldContinue = true;
		
		do
		{
		print("I just came to say hello");
		shouldContinue=false;
		}while(shouldContinue==true);
	}
}
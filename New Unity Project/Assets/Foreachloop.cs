using UnityEngine;
using System.Collections;

public class Foreachloop : MonoBehaviour 
{   
	void Start () 
	{
		string[] strings = {"Doc", "Grumpy", "Happy", "Sleepy", "Bashful", "Sneezy", "Dopey"};
		
		/*strings[0] = "Doc";
		strings[1] = "Grumpy";
		strings[2] = "Happy";
		strings[3] = "Sleepy";
		strings[4] = "Bashful";
		strings[5] = "Sneezy";
		strings[5] = "Dopey";*/
		
		foreach (string each in strings) 
		{
			print (each);
		}
	}
}

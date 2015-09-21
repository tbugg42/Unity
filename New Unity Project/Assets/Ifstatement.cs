using UnityEngine;
using System.Collections;

public class Ifstatement : MonoBehaviour 
{
	float currentTemp = 85.0f;
	float hotlimit = 70.0f;
	float coldlimit = 40.0f;
	float frozen = 0.0f;

		
		
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
			deployTest();
			
		currentTemp -= Time.deltaTime * 5f;
	}
		
		
	void deployTest ()
	{
		if (currentTemp > hotlimit) 
		{
			print ("I burnt my tongue");
		} 
		else if (currentTemp > frozen && currentTemp < coldlimit) 
		{
			print ("it's too cold");
		} 
		else if (currentTemp < frozen) 
		{
			print ("ice ice baby");
		}
		else 
		{
			print ("Delicious");
		}
	}
}
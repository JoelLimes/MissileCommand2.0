using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {

	public static int points;
	
	
	Text text;
	
	void Start ()
	{
		text = GetComponent<Text> ();
		
		points = 0;
		
	}
	
	void Update ()
	{
		if (points < 0)
			points = 0;
		
		text.text = "" + points;
	}
	
	public static void addPoints (int pointsToAdd)
	{
		points += pointsToAdd;
		
	}
	
	public static void Reset ()
	{
		points = 0;
	}
}
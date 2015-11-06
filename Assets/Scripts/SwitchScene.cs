using UnityEngine;
using System.Collections;

public class SwitchScene : MonoBehaviour 
{
	
	public void Change(int scene) {
		Application.LoadLevel (scene);
	}
}
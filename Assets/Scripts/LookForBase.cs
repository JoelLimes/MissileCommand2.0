using UnityEngine;
using System.Collections;

public class LookForBase
{

	[SerializeField]private GameObject[] cubes;
	 Vector3 pos;
	 
	 public Vector3 Pos(){
		cubes = GameObject.FindGameObjectsWithTag("Target");
		pos = new Vector3(cubes[Random.Range(0, cubes.Length)].transform.position.x, cubes[Random.Range(0, cubes.Length)].transform.position.y, 0);
		Debug.Log (pos);
		return pos;
	 }
}
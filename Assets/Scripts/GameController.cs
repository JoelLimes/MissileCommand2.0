using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour 
{

	public GameObject Missiles;


	void Start ()
	{

	}

	void Update()
	{
		InvokeRepeating ("Spawn", 1.0f, 1.0f);
	}

	void OnTriggerExit(Collider other) {

		Destroy(other.gameObject);
	}

	void Spawn (){

		
		Instantiate (Missiles, transform.position, transform.rotation);
		CancelInvoke();
	}
}
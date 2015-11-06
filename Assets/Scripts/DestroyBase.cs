using UnityEngine;
using System.Collections;

public class DestroyBase : MonoBehaviour 
{
	[SerializeField]
	private GameObject explosion;
	

	void Update()
	{
	
	}

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "bullet")
		{
			Destroy(col.gameObject);
		}
	}

	void OnTriggerEnter(Collider other)
	{ 
		if (other.gameObject.tag == "bullet")  
		Destroy (other.gameObject);
		Destroy (gameObject);
		Instantiate (explosion, transform.position, transform.rotation);
		GameObject.Find("Main Camera").SendMessage("DoShake");  
		Debug.Log("The camera trigger has hit");
		Application.LoadLevel("Ending");
		
	}
}
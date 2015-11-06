using UnityEngine;
using System.Collections;

public class MoveRotate : MonoBehaviour {

	public float spinning;
	public float speed;
	
	void Start()
	{

	}


	void Update () 
	{
		transform.Rotate(Vector3.up, spinning);
		
		transform.Translate (new Vector3 (0,1,0) * speed * Time.deltaTime);
	}

	void OnTriggerExit (Collider col)
	{
		if(col.gameObject.name == "Boundary")
		{
			Destroy(this.gameObject);
		}
	}

	void OnCollisionEnter (Collision coll)
	{
		if (coll.gameObject.tag == "bullet") 
		{
			Destroy(this.gameObject);
		}
	}
}

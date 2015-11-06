using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MissileAI : MonoBehaviour 
{
		
	Vector3 moveTo;
	public Transform tr_Player;

	public int pointsToAdd;

	[SerializeField]
	private GameObject enemyExplosion;
	

	// Use this for initialization
	void Start () 
	{

		tr_Player = GameObject.FindGameObjectWithTag ("Target").transform;
		LookForBase lfb = new LookForBase();
		moveTo = lfb.Pos();
		 
	}
	
	// Update is called once per frame
	void Update () 
	{   
		// Look at player
		transform.LookAt (moveTo);
		
		// Move to Player
		transform.position = Vector3.MoveTowards(transform.position, moveTo, 0.2f);
	}

	void OnCollisionEnter (Collision coll)
	{
		if (coll.gameObject.tag == "Bullet") 
		{
			Destroy(this.gameObject);
			Instantiate(enemyExplosion,transform.position, transform.rotation);
			ScoreCounter.addPoints (pointsToAdd);
		}
	}
}
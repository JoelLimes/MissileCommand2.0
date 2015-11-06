using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour {

	[SerializeField]
	private GameObject bullet;

	[SerializeField]
	private Transform ShotSpawner;

	[SerializeField]
	private float fireRate;

	[SerializeField]
	private float nextFire;

	[SerializeField]
	private GameObject ShotFlare;
	
	
	void Start () 
	{

	}
	
	void Update ()
	{
		if(Input.GetButtonDown("Fire1")&& Time.time > nextFire)
			
		{
			nextFire = Time.time + fireRate; 
			Instantiate(bullet, ShotSpawner.position, ShotSpawner.rotation);
			Instantiate(ShotFlare, ShotSpawner.position, ShotSpawner.rotation);
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
		}
	}
}
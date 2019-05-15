using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public GameObject player;
	private Rigidbody2D bulletRB;
	public float bulletSpeed;
	public float bulletLife;



	void Awake(){
		bulletRB = GetComponent<Rigidbody2D> ();
		player = GameObject.FindGameObjectWithTag ("Player");

	}


	// Use this for initialization
	void Start () {
		//print ();
		//print (bulletRB.velocity.y);
		float movX = (player.transform.eulerAngles.z);

		if (movX >= 121 && movX <= 140)
			bulletRB.velocity = new Vector3 (20, 0, 0);
		else if (movX >= 141 && movX <= 170)
			bulletRB.velocity = new Vector3 (15, 15, 0);
		else if (movX >= 171 && movX <= 180)
			bulletRB.velocity = new Vector3 (10, 20, 0);
		else if (movX >= 181 && movX <= 200)
			bulletRB.velocity = new Vector3 (0, 20, 0);
		else if (movX >= 201 && movX <= 220) 
			bulletRB.velocity = new Vector3 (-5, 15, 0);
		else if(movX >=221 && movX <=240)
			bulletRB.velocity = new Vector3 (-10,15,0);
		else if(movX >=241 && movX <=260)
			bulletRB.velocity = new Vector3 (-10,10,0);
		else if(movX >=261 && movX <=280)
			bulletRB.velocity = new Vector3 (-15,0,0);
		else if(movX >=281 && movX <=300)
			bulletRB.velocity = new Vector3 (-10,-5,0);
		else if(movX >=301 && movX <=320)
			bulletRB.velocity = new Vector3 (-10,-10,0);
		else if(movX >=321 && movX <=340)
			bulletRB.velocity = new Vector3 (-5,-15,0);
		else if(movX >=341 && movX <=370)
			bulletRB.velocity = new Vector3 (-5,-10,0);
		else if(movX >=0 && movX <=40)
			bulletRB.velocity = new Vector3 (0,-15,0);
		else if(movX >=41 && movX <=70)
			bulletRB.velocity = new Vector3 (5,-10,0);
		else if(movX >=71 && movX <=80)
			bulletRB.velocity = new Vector3 (10,-15,0);
		else if(movX >=81 && movX <=100)
			bulletRB.velocity = new Vector3 (15,-10,0);
		else if(movX >=101 && movX <=120)
			bulletRB.velocity = new Vector3 (15,0,0);
	}

	// Update is called once per frame
	void Update () {
		Destroy (gameObject, bulletLife);
	}

}
	
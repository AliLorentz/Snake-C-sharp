using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public List<Transform> tail;
	Vector3 lastPos;
	public GameObject tailPrefab;
	private GameObject healthBar;
	private GameObject point;

	[Header("Shooting")]
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	private float nextFire;


	// Use this for initialization
	void Start () {
		healthBar = GameObject.Find ("HealthBar");
		point = GameObject.FindGameObjectWithTag ("Punto");
	}
	
	// Update is called once per frame
	void Update ()
	{
		//gameObject.transform.Translate (50f * Time.deltaTime, 0, 0);
		
		transform.Translate (0, -5* Time.deltaTime, 0);

		if (Input.GetKey (KeyCode.LeftArrow))
			transform.Rotate (0, 0, 500f* Time.deltaTime);
		if(Input.GetKey(KeyCode.RightArrow))
			transform.Rotate (0, 0, -500f* Time.deltaTime);
		if (Input.GetKey (KeyCode.UpArrow)) {
			tail.Add(Instantiate(tailPrefab, tail[tail.Count-1].position, Quaternion.identity).transform);
		}

		PlayerShooting ();

		lastPos = transform.position;

		moveTail();
	}


	void moveTail()
	{
		for (int i = 0; i < tail.Count; i++)
		{
			Vector3 temp = tail[i].position;
			tail[i].position = lastPos;
			lastPos = temp;
	
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.CompareTag ("Enemy"))
			healthBar.SendMessage ("takeDamage", 15);
		if (col.CompareTag ("Block")) {
			healthBar.SendMessage ("takeDamage", 15);
			transform.position = point.transform.position;
		}
			
			
	}

	public void PlayerShooting(){
		if (Input.GetButtonDown ("Fire1")) {
			Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
		}
	}

	//Maxima puntuacion
	/*
	public int GetMaxScore(){
		return PlayerPrefs.GetInt ("Max Points", 0);
	}

	public void saveScore(int curretPoints){
		PlayerPrefs.SetInt ("Max Points", curretPoints);
	}*/

}



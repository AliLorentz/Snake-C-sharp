using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour {
	public float visionRadius;
	public float speed;
	public static int  enemigo;
	GameObject player;
	Vector3 initialPosition;
	// Use this for initialization
	void Start () {
		//recuperamos el jugador gracias el tag
		player = GameObject.FindGameObjectWithTag ("Player");
		//guardamos nuestra posicion inicial
		initialPosition = transform.position;
		enemigo = 0;
	}
	
	// Update is called once per frame
	void Update () {
		//por defecto nuestro objetivo siempre sera nuestra posicion inicial
		Vector3 target = initialPosition;

		//Pero si la distancia hasta el jugador es menor que el radio  de vision el objetivo sera el
		float dist = Vector3.Distance (player.transform.position, transform.position);
		if (dist < visionRadius)
			target = player.transform.position;

		//Finalmente movemos al enemigo en direccion a su target
		float fixedSpeed = speed*Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, target, fixedSpeed);

		//Y colocamos unas lineas para ver vision
		Debug.DrawLine(transform.position,target, Color.green);
	}

	//Dibujar el radio
	void OnDrawnGizmos(){
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireSphere(transform.position, visionRadius);
	}

	//Elimina al enemigo cuando la bala lo toca

	void OnTriggerEnter2D(Collider2D other){
		
		string levelName = Application.loadedLevelName;
			

		if (other.gameObject.tag == "Destroyer") {
			Destroy (gameObject);
			enemigo++;

			if (levelName == "Nivel 1" && enemigo == 1) {
				SceneManager.LoadScene ("Nivel 2");
			} else if (levelName == "Nivel 2" && enemigo == 2) {
				SceneManager.LoadScene ("Nivel 3");
			} else if (levelName == "Nivel 3" && enemigo == 3) {
				SceneManager.LoadScene ("Nivel 4");
			} else if (levelName == "Nivel 4" && enemigo == 4) {
				SceneManager.LoadScene ("Nivel 5");
			} else if (levelName == "Nivel 5" && enemigo == 5) {
				SceneManager.LoadScene ("Inicio");
			}
		}
		print (enemigo);
				
	}



}

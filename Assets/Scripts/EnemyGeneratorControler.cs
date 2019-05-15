using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneratorControler : MonoBehaviour {

	public GameObject enemyPrefabs; 
	public float generatorTimer  = 1.75f; 

	// Use this for initialization
	void Start () {
		//CreateEnemy ();
		InvokeRepeating ("CreateEnemy",0F,generatorTimer);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Crea el enemigo en la posicion del EnemyGenerator
	void CreateEnemy(){
		Instantiate (enemyPrefabs, transform.position, Quaternion.identity);
	}

	//Crea enemigos cuando el juego empieza 
	/*public void StartGenerator(){
		InvokeRepeating ("CreateEnemy",0F,generatorTimer);
	}

	public void CancelGenerator(){
		CancelInvoke ("CreateEnemy");
	}*/


}

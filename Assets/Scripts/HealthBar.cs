using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour {

	public Image health;
	public float hp,maxHp=100f;
	// Use this for initialization
	void Start () {
		hp = maxHp;
	}
	
	// Update is called once per frame
	public void takeDamage(float amount){
		hp = Mathf.Clamp (hp - amount, 0f, maxHp);
		health.transform.localScale = new Vector2 (hp / maxHp, 1);
		if (hp == 0) {
			SceneManager.LoadScene ("Nivel 1");
		}
	}
}

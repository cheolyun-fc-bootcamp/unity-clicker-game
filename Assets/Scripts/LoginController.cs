using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// called when start game
	}
	
	// Update is called once per frame
	void Update () {
		// called each frame 
	}
	public void MoveGame(){
		SceneManager.LoadScene ("Game");
	}
}

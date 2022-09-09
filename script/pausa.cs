using UnityEngine;
using System.Collections;

public class pausa : MonoBehaviour {
	public GameObject menu, player;
	// Use this for initialization
	void Start () {
		menu.SetActive (false);   
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)){
			menu.SetActive(true);
		    player.SetActive (false);
	    }
    }
}

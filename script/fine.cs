using UnityEngine;
using System.Collections;

public class fine : MonoBehaviour {
	public GameObject menu;
	public GameObject player;

	// Use this for initialization
	void Start () {
		menu.SetActive (false);
		player.SetActive (true); 
	}
	
	// Update is called once per frame
	void Update () {

	}
		
	void OnTriggerEnter (Collider oggetto) {
		if(oggetto.tag == "Player") {
			menu.SetActive(true);
			player.SetActive(false); 
		}
	}
}

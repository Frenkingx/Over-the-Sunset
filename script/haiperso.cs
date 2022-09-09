using UnityEngine;
using System.Collections;

public class haiperso : MonoBehaviour {
	public GameObject menu;
	public GameObject player;

	// Use this for initialization
	void Start () {
		menu.SetActive (false);
		player.gameObject.GetComponent<CharacterController> ().enabled = true;
		player.gameObject.GetComponent<mirino> ().enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}	

	void OnTriggerEnter (Collider oggetto) {
		if(oggetto.tag == "Player") {
			menu.SetActive(true);
			player.gameObject.GetComponent<CharacterController> ().enabled = false;
			player.gameObject.GetComponent<mirino> ().enabled = false;
		}
	}
}
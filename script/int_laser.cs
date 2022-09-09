using UnityEngine;
using System.Collections;

public class int_laser : MonoBehaviour {
	public GameObject player,cubo;
	public Camera cameralaser;
	public AudioSource suono;
	public GameObject laser,menu;
	public bool valore1;
	
	// Use this for initialization
	void Start () {
		valore1 = false;
		player.SetActive (true);
		cameralaser.enabled = false;
		menu.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (valore1) {
			apri ();
		}
	}
	
	void OnTriggerEnter (Collider oggetto){
		if (oggetto.gameObject.tag == "Player") {
			valore1 = true;
		}
	}
	void apri(){
		if (Input.GetKey (KeyCode.E)) {
			suono.Play(); 
			valore1 = false;
			player.SetActive (false);
			cameralaser.enabled = true;
			menu.SetActive (true);
			Destroy (laser, 2F);
			Destroy (cubo,3F);
		}
	}

	void OnTriggerExit (Collider oggetto){
		valore1 = false;
	}
	
	
	
	void OnGUI(){
		if (valore1 == true) {
			GUIStyle Font = new GUIStyle ();
			Font.normal.textColor = Color.white;
			Font.fontSize = 45;
			GUILayout.BeginArea (new Rect (Screen.width - 1095, Screen.height - 250, 600, 600));
			GUI.Box (new Rect (Screen.width - 1095, Screen.height - 250, 900, 355), ""); 
			GUILayout.Label ("Premi E per interagire", Font);
			GUILayout.EndArea ();
		}
	}
}

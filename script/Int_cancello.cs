using UnityEngine;
using System.Collections;

public class Int_cancello : MonoBehaviour {
	public GameObject player, cubo, gate, menu;
	public AudioSource suono;
	public Camera cameracancello;
	public Animator cancello;
	public bool valore1;
	
	// Use this for initialization
	void Start () {
		valore1 = false;
		player.SetActive (true);
		cameracancello.enabled = false;
		menu.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (valore1) {
			apri ();
		} 
	}

	void OnTriggerEnter (Collider cubo){
		if (cubo.tag == "Player") {
			valore1 = true;
		}
	}

    void apri(){
		if (Input.GetKey (KeyCode.E)) {
			suono.Play (); 
			valore1 = false;
			player.SetActive (false);
			cameracancello.enabled = true;
			menu.SetActive (true);
			cancello.SetBool ("play", true);
			Destroy (gate, 2F);
			Destroy (cubo, 3F);
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

using UnityEngine;
using System.Collections;

public class int_entrata : MonoBehaviour {
	public GameObject player, cubo, menu;
	public AudioSource suono;
	public Camera cameraentrata;
	public GameObject cubo2;
	public bool key, valore;
	public Animator sx, dx;
	
	// Use this for initialization
	void Start () {
		valore = false;
		player.SetActive (true);
		cameraentrata.enabled = false;
		menu.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		key = cubo2.gameObject.GetComponent<chiave>().val; 
		if (key) {
			if (valore) {
				apri ();
			}
		}
	}
	
	void OnTriggerEnter (Collider oggetto){
		if (oggetto.gameObject.tag == "Player") {
			valore = true;
		}
	}

	void apri(){
		if (Input.GetKey (KeyCode.E)) {
			suono.Play (); 
			valore = false;
			player.SetActive (false);
			cameraentrata.enabled = true;
			menu.SetActive (true);
			sx.SetBool ("valore", true);
			dx.SetBool ("valore1", true);
			Destroy (cubo,3F);
		}
	}

	void OnTriggerExit (Collider oggetto){
		valore = false;
	}

	void OnGUI(){
		if (valore == true) {
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

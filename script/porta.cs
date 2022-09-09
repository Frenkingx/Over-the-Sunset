using UnityEngine;
using System.Collections;

public class porta : MonoBehaviour {
	public bool valore = false;
	public Animator open;
	public GameObject cubo;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (valore){
			apri();
		}
	}

	void OnTriggerEnter(Collider oggetto){
		if (oggetto.tag == "Player") {
			valore = true;
		}
	}
	
	void OnTriggerExit (Collider oggetto){
		valore = false;
		Destroy (cubo);
	}
	
	void apri(){
		if (Input.GetKey (KeyCode.F)) {   
			open.SetBool("valore", true);
			Destroy(open, 2) ;
		}
	}

	void OnGUI(){
		if (valore == true) {
			GUIStyle Font = new GUIStyle ();
			Font.normal.textColor = Color.white;
			Font.fontSize = 45;
			GUILayout.BeginArea (new Rect (Screen.width - 1095, Screen.height - 250, 600, 600));
			GUI.Box (new Rect (Screen.width - 1095, Screen.height - 250, 900, 355), ""); 
			GUILayout.Label ("Premi F", Font);
			GUILayout.EndArea ();
		}
	}
}

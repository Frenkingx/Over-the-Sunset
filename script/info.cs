using UnityEngine;
using System.Collections;

public class info : MonoBehaviour {
	public bool valore,valore1, valore5;
	public bool valore2,valore3,valore4, valore6;

	// Use this for initialization
	void Start () {
		valore = false; valore1 = false;
		valore2 = false; valore3 = false;
		valore4 = false; valore5 = false;
		valore6 = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider oggetto){	
		if (oggetto.gameObject.tag == "info") {
			valore = true;
		}
		if (oggetto.gameObject.tag == "obb1") {
			valore1 = true;
		}
		if (oggetto.gameObject.tag == "obb2") {
			valore2 = true;
		}
		if (oggetto.gameObject.tag == "obb3") {
			valore3 = true;
		}
		if (oggetto.gameObject.tag == "obb4") {
			valore4 = true;
		}
		if (oggetto.gameObject.tag == "door") {
			valore5 = true;
		}
		if (oggetto.gameObject.tag == "obb5") {
			valore6 = true;
		}
	}

	void OnTriggerExit(Collider oggetto){ 
		valore = false;valore1 = false;
		valore2 = false;valore3 = false;
		valore4 = false;valore5 = false;
		valore6 = false;
	}

	void OnGUI(){
		if (valore == true) {
			GUIStyle Font = new GUIStyle ();
			Font.normal.textColor = Color.white;
			Font.fontSize = 45;
			GUILayout.BeginArea (new Rect (Screen.width - 1095, Screen.height - 250, 600, 600));
			GUI.Box (new Rect (Screen.width - 1095, Screen.height - 250, 900, 355), ""); 
			GUILayout.Label ("L'elicottero è inutilizzabile!", Font);
			GUILayout.EndArea ();
		}

		if (valore1 == true) {
			GUIStyle Font = new GUIStyle ();
			Font.normal.textColor = Color.white;
			Font.fontSize = 45;
			GUILayout.BeginArea (new Rect (Screen.width - 1250, Screen.height - 800, 800, 800));
			GUI.Box (new Rect (Screen.width - 1705, Screen.height -1120, 920, 140), ""); 
			GUILayout.Label ("NUOVO OBIETTIVO: Segui il sentiero", Font);
			GUILayout.EndArea ();
		}

		if (valore2 == true) {
			GUIStyle Font = new GUIStyle ();
			Font.normal.textColor = Color.white;
			Font.fontSize = 45;
			GUILayout.BeginArea (new Rect (Screen.width - 1250, Screen.height - 800, 1000, 1000));
			GUI.Box (new Rect (Screen.width - 1705, Screen.height -1120, 980, 140), ""); 
			GUILayout.Label ("NUOVO OBIETTIVO: Trova un'altra strada", Font);
			GUILayout.EndArea ();
		}

		if (valore3 == true) {
			GUIStyle Font = new GUIStyle ();
			Font.normal.textColor = Color.white;
			Font.fontSize = 45;
			GUILayout.BeginArea (new Rect (Screen.width - 1250, Screen.height - 800, 800, 800));
			GUI.Box (new Rect (Screen.width - 1705, Screen.height -1120, 920, 140), ""); 
			GUILayout.Label ("NUOVO OBIETTIVO: Supera il ponte", Font);
			GUILayout.EndArea ();
		}

		if (valore4 == true) {
			GUIStyle Font = new GUIStyle ();
			Font.normal.textColor = Color.white;
			Font.fontSize = 45;
			GUILayout.BeginArea (new Rect (Screen.width - 1250, Screen.height - 800, 800, 800));
			GUI.Box (new Rect (Screen.width - 1705, Screen.height -1120, 920, 140), ""); 
			GUILayout.Label ("NUOVO OBIETTIVO: Esci dalla base", Font);
			GUILayout.EndArea ();
		}

		if (valore5 == true) {
			GUIStyle Font = new GUIStyle ();
			Font.normal.textColor = Color.white;
			Font.fontSize = 45;
			GUILayout.BeginArea (new Rect (Screen.width - 1095, Screen.height - 250, 600, 600));
			GUI.Box (new Rect (Screen.width - 1095, Screen.height - 250, 900, 355), ""); 
			GUILayout.Label ("La porta è chiusa", Font);
			GUILayout.EndArea ();
		}

		if (valore6 == true) {
			GUIStyle Font = new GUIStyle ();
			Font.normal.textColor = Color.white;
			Font.fontSize = 45;
			GUILayout.BeginArea (new Rect (Screen.width - 1250, Screen.height - 800, 1200, 1200));
			GUI.Box (new Rect (Screen.width - 1705, Screen.height - 1120, 920, 140), ""); 
			GUILayout.Label ("NUOVO OBIETTIVO: Disattiva la corrente", Font);
			GUILayout.EndArea ();
		}
	}	
}

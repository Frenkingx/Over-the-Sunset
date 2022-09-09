using UnityEngine;
using System.Collections;

public class chiave : MonoBehaviour {
	public bool val;
	public bool valore;
	public GameObject cubo; 
	public GameObject card;

	// Use this for initialization
	void Start () {
		valore=false;
		val = false;
		cubo.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
	    if (valore)
			prendi ();
	}

	void OnTriggerEnter(Collider oggetto){
		if (oggetto.tag == "Player") {  
			valore=true;
		}
	}

    void prendi(){
		if (Input.GetKey (KeyCode.E)) {
			Destroy (card);
			cubo.SetActive(false); 
			val = true;
		}
	}
	
	void OnTriggerExit(Collider oggetto){
		valore = false;
	}

	void OnGUI(){
		if (valore == true) {
			GUIStyle Font = new GUIStyle ();
			Font.normal.textColor = Color.white;
			Font.fontSize = 45;
			GUILayout.BeginArea (new Rect (Screen.width - 1095, Screen.height - 250, 700, 700));
			GUI.Box (new Rect (Screen.width - 1095, Screen.height - 250, 900, 355), ""); 
			GUILayout.Label ("Premi E per prendere le chiavi", Font);
			GUILayout.EndArea ();
		}
	}
}

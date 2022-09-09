using UnityEngine;
using System.Collections;

public class controlcamera : MonoBehaviour {
	public GameObject arma1;
	public GameObject player, menu, weapon;
	public Camera arma;
	public bool valor;

	//Use this for initialization
	void Start () { 
		valor = false;
		weapon.SetActive (false);
		player.SetActive (true);
		menu.SetActive (false);
		arma1.gameObject.GetComponent<MouseLook>().enabled = false;   
	}
	
	// Update is called once per frame
	void Update () {    
		if (valor == true) {
			arma1.gameObject.GetComponent<MouseLook> ().enabled = true;
			usa (); 
		}
	}

	void usa() {
		if (Input.GetKey(KeyCode.E)) {  
			valor = false;
			weapon.SetActive(true);
			player.SetActive (false);
			arma.enabled = true;
			menu.SetActive (true);
		}
	}

	void OnTriggerEnter(Collider oggetto){	
		if (oggetto.gameObject.tag == "Player") {
			valor = true;
		}
	}
	
	void OnTriggerExit(Collider oggetto){
		valor = false;	  
	}

	void OnGUI(){
		if (valor == true) {
			GUIStyle Font = new GUIStyle ();
			Font.normal.textColor = Color.white;
			Font.fontSize = 45;
			GUILayout.BeginArea (new Rect (Screen.width - 1095, Screen.height - 250, 800, 800));
			GUI.Box (new Rect (Screen.width - 1095, Screen.height - 250, 900, 355), ""); 
			GUILayout.Label ("Premi E per usare la mitragliatrice", Font);
			GUILayout.EndArea ();
		}
	}
}

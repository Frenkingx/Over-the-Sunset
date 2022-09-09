using UnityEngine;
using System.Collections;

public class timer : MonoBehaviour {
	public bool valore;
	public bool valore1;
	public float time; 
	public GameObject menu;
	public GameObject player;

	// Use this for initialization
	void Start () {
		menu.SetActive (false);
		player.SetActive (true);
		valore = false;
		valore1 = false;
		time = 50;
	}
	
	// Update is called once per frame
	void Update () {
		if (valore1) {
			time -= Time.deltaTime;
		}
		if (time <= 0) {
			menu.SetActive (true);
			player.SetActive (false);
		}
	}

	void OnTriggerEnter(Collider oggetto){	
		if (oggetto.gameObject.tag == "Player") {
			valore1 = true;
			valore= true; 
		}
	}

	void OnGUI(){
		if (valore == true) {
			GUIStyle Font = new GUIStyle ();
			Font.normal.textColor = Color.white;
			Font.fontSize = 20;
			GUILayout.BeginArea (new Rect (Screen.width - 1080, Screen.height - 500, 300, 300));
			GUI.Box (new Rect (Screen.width - 1080, Screen.height - 850, 100, 100), ""); 
			GUILayout.Label ("Tempo rimanente" + " " + "00" + "." + "00" + "." + time.ToString (), Font);
			GUILayout.EndArea ();
		}
	}
	
}

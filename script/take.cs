using UnityEngine;
using System.Collections;

public class take : MonoBehaviour {
	public GameObject arma, balestra;
	public GameObject cubo, muro;
	public bool valore;
	public Animator anim;

	// Use this for initialization
	void Start () {
		valore = false;
		balestra.SetActive (false); 
	}
	
	// Update is called once per frame
	void Update () {
		if (valore)
			prendi ();
	}

	void OnTriggerEnter(Collider oggetto){
		if (oggetto.gameObject.tag == "Player") {
			valore = true;
		}
	}

	void prendi(){
		if (Input.GetKey(KeyCode.Mouse0)){
			balestra.SetActive (true);
			anim.SetBool("bool",true); 
			Destroy (arma);
			Destroy (cubo);
			Destroy (muro);
			Destroy (anim, 1F);
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
			GUILayout.BeginArea (new Rect (Screen.width - 1095, Screen.height - 250, 600, 600));
			GUI.Box (new Rect (Screen.width - 1095, Screen.height - 250, 900, 355), ""); 
			GUILayout.Label ("Raccogli la balestra", Font);
			GUILayout.EndArea ();
		}
	}
}

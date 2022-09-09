using UnityEngine;
using System.Collections;

public class mirino : MonoBehaviour {
	public Camera main;
	public Camera cam;
	public bool valore;
	public GameObject mira,balestra;

	// Use this for initialization
	void Start () {
		valore = false;
		main.enabled=true;
		cam.enabled = false;
		mira.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Mouse1)){
			main.enabled=false;
			cam.enabled = true;
			valore=true;
			mira.SetActive (true);
			balestra.SetActive (false);

		}else{
			main.enabled=true;
			cam.enabled = false;
			valore=false;
			mira.SetActive (false);
			balestra.SetActive (true);
		}
	}
}

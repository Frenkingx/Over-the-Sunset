using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {
	public int valore;

	// Use this for initialization
	void Start () {
		valore = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider oggetto){
		if (oggetto.gameObject.tag == "lose") {
			valore = 1;
		}
		if (oggetto.gameObject.tag == "lose2") {
			valore = 2;
		}
		if (oggetto.gameObject.tag == "lose3") {
			valore = 3;
		}
		if (oggetto.gameObject.tag == "lose4") {
			valore = 4;
		}
	}
}

using UnityEngine;
using System.Collections;

public class distruggi : MonoBehaviour {
	public GameObject alberi;
	public GameObject cubo, rocce;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider cubo){
		if (cubo.tag == "Player") {
			Destroy (alberi);
			Destroy (rocce);
		}
	}

	void OnTriggerExit (Collider cubo){
		Destroy (cubo);
	}
}

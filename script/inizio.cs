using UnityEngine;
using System.Collections;

public class inizio : MonoBehaviour {
	public Animator vai;
	public GameObject player,menu;
	public bool valore;

	// Use this for initialization
	void Start () {
		menu.SetActive (true);
		player.SetActive (false); 
	}
	
	// Update is called once per frame
	void Update () {
		if (valore) {
			player.SetActive (true);
			menu.SetActive(false);
			vai.SetBool("val",true);
		}
		Destroy (player.gameObject.GetComponent<inizio>(), 6F);
		Destroy (vai, 6F);
	}	
}

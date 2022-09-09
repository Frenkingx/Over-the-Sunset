using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {
	public Animator bottoneControl;
	public GameObject pause,player, skyp, perso,arma;
	public Transform spawn1, spawn2, spawn3, spawn4;
	public bool flag;
	public int key;

	public void AperturaSetting(){ 
		bottoneControl.enabled = true; 
		bottoneControl.SetBool("fuoriVista", false);
	}

	public void ChiusuraSetting(){ 
		bottoneControl.SetBool("fuoriVista", true);
	}

	// Use this for initialization
	void Start () {
		key = 0;
		flag = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void spawn(){
		key = player.gameObject.GetComponent<spawn>().valore;
		if (key == 1) {
			player.transform.position = new Vector3 (spawn1.position.x, spawn1.position.y, spawn1.position.z);
			perso.SetActive (false);
			player.gameObject.GetComponent<CharacterController> ().enabled = true;
			player.gameObject.GetComponent<mirino> ().enabled = true;
		}

		if (key == 2) {
			player.transform.position = new Vector3 (spawn2.position.x, spawn2.position.y, spawn2.position.z);
			perso.SetActive (false);
			player.gameObject.GetComponent<CharacterController> ().enabled = true;
			player.gameObject.GetComponent<mirino> ().enabled = true;
		}

		if (key == 3) {
			player.transform.position = new Vector3 (spawn3.position.x, spawn3.position.y, spawn3.position.z);
			perso.SetActive (false);
			player.gameObject.GetComponent<CharacterController> ().enabled = true;
			player.gameObject.GetComponent<mirino> ().enabled = true;
		}

		if (key == 4) {
			player.transform.position = new Vector3 (spawn4.position.x, spawn4.position.y, spawn4.position.z);
			perso.SetActive (false);
			player.gameObject.GetComponent<CharacterController> ().enabled = true;
			player.gameObject.GetComponent<mirino> ().enabled = true;
		}
	}

	public void startGioco3D(){
		Application.LoadLevel("Gioco3D");
	}

	public void restart(){
		pause.SetActive (false);
		player.SetActive (true);
	}

	public void salta(){   
		skyp.SetActive (false);
		player.SetActive (true);
	}

	public void continua(){
		player.gameObject.GetComponent<inizio> ().valore = true;   
		skyp.SetActive (false);
		player.SetActive (true);
	}

	public void exit(){
		Application.Quit(); 
	}	
}

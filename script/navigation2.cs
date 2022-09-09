using UnityEngine;
using System.Collections;

public class navigation2 : MonoBehaviour {
	public Transform partenza;
	public GameObject nemico;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void torna(){
		NavMeshAgent agent = GetComponent<NavMeshAgent> ();
		agent.destination = partenza.position;
		cambia ();
	}

	void cambia(){
		nemico.gameObject.GetComponent<controllo_nemico> ().flag = false;
	}
		
}

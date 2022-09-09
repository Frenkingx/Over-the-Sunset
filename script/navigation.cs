using UnityEngine;
using System.Collections;

public class navigation : MonoBehaviour {
	public Transform arrivo;
	public GameObject nemico;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void vai(){
		NavMeshAgent agent = GetComponent<NavMeshAgent> ();
		agent.destination = arrivo.position;
		cambia ();
	}

	void cambia(){
		nemico.gameObject.GetComponent<controllo_nemico> ().flag = true;
	}
		
}

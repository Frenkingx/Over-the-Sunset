using UnityEngine;
using System.Collections;

public class mirino_ray : MonoBehaviour {
	public Camera mirino;
	public GameObject freccia= null,player;
	public Animator nemico1,nemico2,nemico3,nemico4,nemico5,nemico6,nemico7;
	public GameObject visuale, visuale2, visuale3, visuale4,visuale5,visuale6,visuale7;
	public GameObject coll,coll2,coll3,coll4,coll5,coll6,coll7;
	float tempoTraProiettili = 0.5F;
	float tempoProssimoSparo = 0F;
	public bool val;

	// Use this for initialization
	void Start () {
		mirino.enabled = false;
		val = false;
	}
	
	// Update is called once per frame
	void Update () {
		val = player.gameObject.GetComponent<mirino> ().valore;
		if (val == true) {
			if (Input.GetButton ("Fire1") && Time.time > tempoProssimoSparo) {
				tempoProssimoSparo = Time.time + tempoTraProiettili;
				GameObject clone = (GameObject)Instantiate (freccia, transform.position, transform.rotation);
				clone.rigidbody.AddRelativeForce (new Vector3 (0, 0, -120), ForceMode.Impulse);
				sparo ();
				Destroy (clone, 2F);
			}
		}
	}

	void sparo(){
		Ray ray = mirino.ViewportPointToRay(new Vector3 (0.5f, 0.5f,0));
		RaycastHit hit;
			if (Physics.Raycast (ray, out hit,100)){    
				if (hit.collider.gameObject.tag == "Enemy") {
					nemico1.SetBool("var", true);
				    Destroy(visuale);
				    nemico1.gameObject.GetComponent<NavMeshAgent>().enabled = false;
				    nemico1.gameObject.GetComponent<navigation >().enabled = false;
				    nemico1.gameObject.GetComponent<navigation2 >().enabled = false;
				    nemico1.gameObject.GetComponent<controllo_nemico>().enabled = false;
				    Destroy (coll);
				}

			    if (hit.collider.gameObject.tag == "Enemy2") {
				    nemico2.SetBool("var", true);
				    Destroy(visuale2);
				    Destroy (coll2);
			    }

			    if (hit.collider.gameObject.tag == "Enemy3") {
				    nemico3.SetBool("var", true);
				    Destroy(visuale3);
				    Destroy (coll3);
			    }

			    if (hit.collider.gameObject.tag == "Enemy4") {
				    nemico4.SetBool("var", true);
				    Destroy(visuale4);
				    nemico4.gameObject.GetComponent<NavMeshAgent>().enabled = false;
				    nemico4.gameObject.GetComponent<navigation >().enabled = false;
				    nemico4.gameObject.GetComponent<navigation2 >().enabled = false;
				    nemico4.gameObject.GetComponent<controllo_nemico>().enabled = false;
				    Destroy (coll4);
			    }
			    if (hit.collider.gameObject.tag == "Enemy5") {
				    nemico5.SetBool("var", true);
				    Destroy(visuale5);
				    nemico5.gameObject.GetComponent<NavMeshAgent>().enabled = false;
				    nemico5.gameObject.GetComponent<navigation >().enabled = false;
				    nemico5.gameObject.GetComponent<navigation2 >().enabled = false;
				    nemico5.gameObject.GetComponent<controllo_nemico>().enabled = false;
				    Destroy (coll5);
			    }

			    if (hit.collider.gameObject.tag == "Enemy6") {
				    nemico6.SetBool("var", true);
				    Destroy(visuale6);
			    	Destroy (coll6);
			    }

			    if (hit.collider.gameObject.tag == "Enemy7") {
				    nemico7.SetBool("var", true);
				    Destroy(visuale7);
				    Destroy (coll7);
			    }
			}
	}
}

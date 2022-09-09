using UnityEngine;
using System.Collections;

public class sparo : MonoBehaviour {
	public Animator die;
	public Camera arma;
	public AudioSource colpo; 
	public GameObject proiettile = null,weapon;
	public GameObject enemy,campovisivo,cubo;
	float tempoTraProiettili = 0.5F;
	float tempoProssimoSparo = 0F;
	public int danno_c = 25, vita;
	public bool valore;

	// Use this for initialization
	void Start () {
		vita = 100;
		valore = false;
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetButton("Fire1")&&Time.time>tempoProssimoSparo){
			tempoProssimoSparo = Time.time+tempoTraProiettili;
		    GameObject clone = (GameObject)Instantiate(proiettile, transform.position, transform.rotation);
			clone.rigidbody.AddRelativeForce(new Vector3(0,120,0), ForceMode.Impulse);
			shoot();
			colpo.Play();
			Destroy(clone, 2F);
	}
    }

	void shoot(){
		valore = true;
		Ray ray = arma.ViewportPointToRay(new Vector3 (0.5f, 0.5f,0));
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit)){    
			if (hit.collider.gameObject.tag == "Enemy") {
				vita -= danno_c;
				if(vita==0){
					die.SetBool("var", true);
					Destroy (campovisivo);
					Destroy (cubo);
					Destroy (weapon,10F);
				}
			}
		}
	}
}

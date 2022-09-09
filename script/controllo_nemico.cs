using UnityEngine;
using System.Collections;

public class controllo_nemico : MonoBehaviour {
	public bool flag;
	public GameObject nemico;

	// Use this for initialization
	void Start () {
		flag = false;
		nemico.gameObject.GetComponent<navigation2> ().enabled = false;
		nemico.gameObject.GetComponent<navigation> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update (){
		if (flag == false) {
			nemico.gameObject.GetComponent<navigation2> ().enabled = false;
			nemico.gameObject.GetComponent<navigation> ().enabled = true;
			nemico.gameObject.GetComponent<navigation>().vai();
		}else{
			nemico.gameObject.GetComponent<navigation2> ().enabled  = true;
			nemico.gameObject.GetComponent<navigation> ().enabled = false;
			nemico.gameObject.GetComponent<navigation2>().torna();
		}
	}
}

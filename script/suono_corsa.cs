using UnityEngine;
using System.Collections;

public class suono_corsa : MonoBehaviour {
	public AudioSource passi;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () { 
		if (Input.GetKeyDown(KeyCode.W)){
			passi.Play ();
		    passi.loop = true;
		}

	    if (Input.GetKeyDown(KeyCode.A)){
		    passi.Play ();
		    passi.loop = true;
		}

		if (Input.GetKeyDown(KeyCode.S)){
		    passi.Play ();
		    passi.loop = true;
		    }

		if (Input.GetKeyDown(KeyCode.D)){
		    passi.Play ();
		    passi.loop = true;
		    }
	

		if (Input.GetKeyUp(KeyCode.W) && !Input.GetKeyUp(KeyCode.D) && !Input.GetKeyUp(KeyCode.A) && !Input.GetKeyUp(KeyCode.S)){   
			passi.loop = false;  
		}

		if (Input.GetKeyUp(KeyCode.A) && !Input.GetKeyUp(KeyCode.D) && !Input.GetKeyUp(KeyCode.W) && !Input.GetKeyUp(KeyCode.S)){   
			passi.loop = false;  
		}

		if (Input.GetKeyUp(KeyCode.S) && !Input.GetKeyUp(KeyCode.D) && !Input.GetKeyUp(KeyCode.A) && !Input.GetKeyUp(KeyCode.W)){     
			passi.loop = false;  
		}

		if (Input.GetKeyUp(KeyCode.D) && !Input.GetKeyUp(KeyCode.W) && !Input.GetKeyUp(KeyCode.A) && !Input.GetKeyUp(KeyCode.S)){      
			passi.loop = false;  
		}
	}
}

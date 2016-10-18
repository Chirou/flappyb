using UnityEngine;
using System.Collections;


public class flappyinput : MonoBehaviour {
	
	public float jumpforce = 100f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		detectInput();


	}
	void detectInput(){
		if (Input.GetKeyDown ("b")) {
			Debug.Log ("ButtonPressed");
			Jump ();
		}
		if (Input.GetKeyDown ("r")) {
			Time.timeScale = 1;
			Application.LoadLevel (Application.loadedLevel);
		}
	}

	void Jump(){
		gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (0f, 0f, 0f);
		gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0f,jumpforce,0f));
			
			}
	void Dead(){
		Time.timeScale = 0;

	}

	void OnCollisionEnter(){
		Debug.Log ("wat");
		Dead ();

	}
	//instanciate
	//mathf.random
			//JetBrains
}

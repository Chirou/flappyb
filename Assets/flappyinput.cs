using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class flappyinput : MonoBehaviour {
	
	public float jumpforce = 100f;
	public Text count;
	// Use this for initializatio
	void Start () {
		count.text = "Points:" + 0.ToString ();

	}
	
	// Update is called once per frame
	void Update () {

		detectInput();


	}




	void detectInput(){
		if (Input.GetKeyDown ("space")) {
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
		count.text = "Dead. [R]etry?";

	}


	void OnCollisionEnter(){
		Debug.Log ("wat");
		Dead ();

	}
	//instanciate
	//mathf.random
			//JetBrains
}

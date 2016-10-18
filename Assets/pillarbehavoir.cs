using UnityEngine;
using System.Collections;

public class pillarbehavoir : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame

	void Update () {
		gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (-3f, 0f, 0f);

		if (gameObject.transform.position.x < -5) {

			transform.position = new Vector3 (5, Random.Range(-2,2), 0);
			
			Debug.Log ("yooooo");
		}
	}
}

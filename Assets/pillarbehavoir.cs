using UnityEngine;
using System.Collections;

public class pillarbehavoir : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (-3f, 0f, 0f);
	}
}

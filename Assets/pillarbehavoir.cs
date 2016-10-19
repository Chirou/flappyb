using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pillarbehavoir : MonoBehaviour {
	public float point= 0;
	public Text count;
	// Use this for initialization
	void Start () {
		count.text = "Points:" + 0.ToString ();
	}
	
	// Update is called once per frame

	void Update () {
		gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (-3.5f, 0f, 0f);

		if (gameObject.transform.position.x < -4) {

			transform.position = new Vector3 (6, Random.Range(-4,4), 0);
			point++;
			count.text = "Points:" + point.ToString ();
			Debug.Log ("yooooo");
		}
	}
}

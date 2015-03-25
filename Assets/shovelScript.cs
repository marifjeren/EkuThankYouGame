using UnityEngine;
using System.Collections;

public class shovelScript : MonoBehaviour {
	public float Power; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.rigidbody)
		{
			if(collision.gameObject.tag == "snow")
			{
				collision.rigidbody.AddForce(Vector3.up * Power);
				collision.rigidbody.AddForce(Vector3.forward * Power);
			}

		}

		
	}
}

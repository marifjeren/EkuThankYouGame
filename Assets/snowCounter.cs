using UnityEngine;
using System.Collections;

public class snowCounter : MonoBehaviour {
	public int numberOfSnow; 
	// Use this for initialization
	void Start () {
		numberOfSnow = 0; 
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.rigidbody)
		{
			if(collision.gameObject.tag == "snow")
			{
				numberOfSnow +=1; 
				
				Debug.Log (numberOfSnow); 
			}
			
		}

	}

	void OnCollisionExit(Collision collision) {
			if (collision.rigidbody)
			{
				if(collision.gameObject.tag == "snow")
				{
					numberOfSnow -=1; 
				
				Debug.Log (numberOfSnow); 
				}
				
			}
		}
}
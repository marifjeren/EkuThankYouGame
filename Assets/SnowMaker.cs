using UnityEngine;
using System.Collections;

public class SnowMaker : MonoBehaviour {
	public Transform startPoint; 
	public Transform endPoint; 
	public float speed = 15.0f;

	private float startTime;
	private float journeyLength;
	public float distCovered;

	public GameObject snowFlake; 
	// Use this for initialization
	void Start () {
		StartCoroutine (spawn ()); 
		distCovered = 0;

		startTime = Time.time;
		journeyLength = Vector3.Distance (startPoint.position, endPoint.position); 
	}
	
	// Update is called once per frame
	void Update () {
		distCovered = (Time.time -startTime ) *speed;
		float fractJourney = distCovered/journeyLength;
		transform.position = Vector3.Lerp (startPoint.position, endPoint.position, fractJourney); 
		//Instantiate (snowFlake,transform.position,Quaternion.identity); 

		if(transform.position == endPoint.position)
		   Start(); 
	}

	IEnumerator spawn()
	{
		for (int i=0; i <20; i++)
		{
			Instantiate(snowFlake, transform.position, Quaternion.identity);
				yield return new WaitForSeconds(5f); 
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour{
	private float topBound = 30;
	private float lowerBound = -10;

    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update(){
		// Destroys Game Objects With This Script When They Reach The topBound Or lowerBound Also Prints Game Over When Object Reaches lowerBound
		if (transform.position.z > topBound){
			Destroy(gameObject);
		}
		else if (transform.position.z < lowerBound){
			Debug.Log("Game Over!");
			Destroy(gameObject);
		}
    }
}

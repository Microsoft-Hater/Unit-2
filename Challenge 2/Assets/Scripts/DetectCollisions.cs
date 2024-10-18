using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour{
    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update(){
    }

    // Calls When A Trigger Box Collides With Another And Then Destroys Both Objects
    void OnTriggerEnter(Collider other){
		Destroy(gameObject);
		Destroy(other.gameObject);
	}
}

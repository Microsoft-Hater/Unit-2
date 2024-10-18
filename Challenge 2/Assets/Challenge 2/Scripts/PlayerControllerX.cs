using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
	public float fireRate = 1;
	private float timeUntilShot = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timeUntilShot !< Time.time){
			Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
			timeUntilShot = Time.time + fireRate;
		}
	}
}

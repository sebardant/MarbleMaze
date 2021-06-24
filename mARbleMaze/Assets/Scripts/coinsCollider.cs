using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class coinsCollider : MonoBehaviour {

   
   
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Sphere"))
        {
            Camera.main.GetComponent<ScoreHandler>().score += 100;
            gameObject.SetActive(false);  
        }
    }

    private void OnDisable()
    {
        gameObject.GetComponentInParent<AudioSource>().Play();
    }
}

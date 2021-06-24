using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLost : MonoBehaviour {

    [SerializeField]
    private GameObject gameOverScreen;
    [SerializeField]
    private GameObject InGameUI;
    // Use this for initialization
    void Start () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        InGameUI.SetActive(false);
        gameOverScreen.SetActive(true);

        if (GameObject.Find("Sphere"))
        {
            Destroy(GameObject.Find("Sphere"));
        }
    }
}

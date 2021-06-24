using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryTrigger : MonoBehaviour {
    [SerializeField]
    private GameObject VictoryScreen;
    [SerializeField]
    private GameObject Fireworks;
    [SerializeField]
    private GameObject VictoryCamera;
    [SerializeField]
    private GameObject MainCamera;
    [SerializeField]
    private GameObject InGameUI;
    // Use this for initialization
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        InGameUI.SetActive(false);
        VictoryScreen.SetActive(true);
        Fireworks.SetActive(true);
        if (GameObject.Find("Sphere"))
        {
            Destroy(GameObject.Find("Sphere"));
        }
    }
}

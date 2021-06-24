using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickEvent : MonoBehaviour {
    [SerializeField]
    private GameObject sphere;
    [SerializeField]
    private GameObject startPosition;
    [SerializeField]
    private Transform maze;
    

    [SerializeField]
    private GameObject gameOverUI;

    [SerializeField]
    private GameObject victoryUI;

    [SerializeField]
    private GameObject InGameUI;

    [SerializeField]
    private GameObject VictoryCamera;
    [SerializeField]
    private GameObject MainCamera;

    [SerializeField]
    private GameObject Coins;

    [SerializeField]
    private GameObject StartUI;

    [SerializeField]
    private GameObject FireWorks;


    public void spawnBall()
    {
       
       
        foreach (Transform child in Coins.transform)
        {
            child.gameObject.SetActive(true);
            Debug.Log(child.name);
        }

        StartUI.SetActive(false);
        FireWorks.SetActive(false);
        MainCamera.GetComponent<ScoreHandler>().score = 0;
     
        gameOverUI.SetActive(false);
        victoryUI.SetActive(false);
        InGameUI.SetActive(true);
        
        GameObject ball = Instantiate(sphere);
        ball.name = "Sphere";
        ball.transform.SetParent(maze);
        ball.transform.position = startPosition.transform.position; 

    }

}

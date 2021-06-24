using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFireworks : MonoBehaviour {

    [SerializeField]
    GameObject fireworksBlue_Big;
    [SerializeField]
    GameObject fireworksBlue_Little;
    [SerializeField]
    GameObject fireworksGreen_Big;
    [SerializeField]
    GameObject fireworksGreen_Little;
    [SerializeField]
    GameObject fireworksYellow_Big;
    [SerializeField]
    GameObject fireworksYellow_Little;

    [SerializeField]
    Transform range;

    [SerializeField]
    Transform parent;

    public float maxTime = 5;
    public float minTime = 2;

    //current time
    private float time;

    //The time to spawn the object
    private float spawnTime;

    List<GameObject> fireworksList;
    // Use this for initialization
    void Start () {
        fireworksList = new List<GameObject>();
        fireworksList.Add(fireworksBlue_Big);
        fireworksList.Add(fireworksBlue_Little);
        fireworksList.Add(fireworksGreen_Big);
        fireworksList.Add(fireworksGreen_Little);
        fireworksList.Add(fireworksYellow_Big);
        fireworksList.Add(fireworksYellow_Little);

        SetRandomTime();
        time = minTime;
    }

     void FixedUpdate(){
 
         //Counts up
         time += Time.deltaTime;
 
         //Check if its the right time to spawn the object
         if(time >= spawnTime){
             SpawnObject();
             SetRandomTime();
         }
 
     }
 
 
     //Spawns the object and resets the time
     void SpawnObject(){
         time = minTime;
         Instantiate((GameObject)fireworksList[Random.Range(0, 5)], new Vector3(Random.Range(range.GetComponent<BoxCollider>().bounds.min.x, range.GetComponent<BoxCollider>().bounds.max.x), Random.Range(range.GetComponent<BoxCollider>().bounds.min.y, range.GetComponent<BoxCollider>().bounds.max.y), Random.Range(range.GetComponent<BoxCollider>().bounds.min.z, range.GetComponent<BoxCollider>().bounds.max.z)), Quaternion.identity, parent);
    }

    //Sets the random time between minTime and maxTime
    void SetRandomTime(){
         spawnTime = Random.Range(minTime, maxTime);
     }
}

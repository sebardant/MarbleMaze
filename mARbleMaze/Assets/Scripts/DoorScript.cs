using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {



    Animator animator;

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update()
    {
        Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        //Ray raycast = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit raycastHit;
        if (Physics.Raycast(raycast, out raycastHit))
        {
            if (raycastHit.collider.Equals(GetComponent<Collider>()))
            {
                animator.SetBool("Open", true);
                //animator.SetBool("Open", false);
            }
        }
    }
}

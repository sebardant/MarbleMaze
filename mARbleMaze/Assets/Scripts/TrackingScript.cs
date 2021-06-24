using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class TrackingScript : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;

    [SerializeField]
    private Transform canvas;

    [SerializeField]
    private GameObject startButton;

    [SerializeField]
    private GameObject gameOverUI;

    [SerializeField]
    private GameObject victoryUI;

    [SerializeField]
    private GameObject InGameGUI;

    bool starting;
    void Start()
    {
        starting = true;
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if (previousStatus == TrackableBehaviour.Status.NO_POSE)
        {
            if (newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED) {
                if (starting)
                {
                    startButton.SetActive(true);
                    starting = false;
                }
                startButton.SetActive(true);

            }
        }
        else if (previousStatus == TrackableBehaviour.Status.DETECTED || previousStatus == TrackableBehaviour.Status.TRACKED)
        {
            if (newStatus == TrackableBehaviour.Status.NO_POSE)
            {
                startButton.SetActive(false);
                gameOverUI.SetActive(false);
                victoryUI.SetActive(false);
                InGameGUI.SetActive(false);
            }
        }
    }
}
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class Orientation : MonoBehaviour {

    public static event UnityAction<ScreenOrientation> orientationChangedEvent;
    public static ScreenOrientation _orientation;
    public GameObject portraitPanel;
    public GameObject landscapePanel;
    public Text DebugText;

    void Start()
    {
        _orientation = Screen.orientation;
        InvokeRepeating("CheckForChange", 1, .1f);
    }

    private static void OnOrientationChanged(ScreenOrientation orientation)
    {
        if (orientationChangedEvent != null)
            orientationChangedEvent(orientation);
    }

    private void CheckForChange()
    {        
        if (_orientation != Screen.orientation)
        {
            _orientation = Screen.orientation;
            OnOrientationChanged(_orientation);

            if (Input.deviceOrientation == DeviceOrientation.Portrait ||
            Input.deviceOrientation == DeviceOrientation.PortraitUpsideDown)
            {
                portraitPanel.SetActive(true);
                landscapePanel.SetActive(false);
            }
            else if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft ||
            Input.deviceOrientation == DeviceOrientation.LandscapeRight)
            {
                portraitPanel.SetActive(false);
                landscapePanel.SetActive(true);
            }
        }
    }

    void Update()
    {
        DebugText.GetComponent<Text>().text = Input.deviceOrientation.ToString();
    }
}
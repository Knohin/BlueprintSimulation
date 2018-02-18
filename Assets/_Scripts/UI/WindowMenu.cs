﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowMenu : PopupMenu {

    public Button[] buttons;

    private Pickable PickedObject;
    private Animator animator;

    //private enum State
    //{
    //    AOpened = 0,
    //    Closed,
    //    BOpened
    //}
    //private State state;
    private void Awake()
    {
        PickedObject = Camera.main.GetComponent<ObjectPicker>().PickedObject;
    }

    private void OnEnable()
    {
        animator = PickedObject.GetComponent<Animator>();
        if (null == animator)
            Debug.LogError("No Animator!");

        for (int i = 0; i < buttons.Length; i++)
            buttons[i].interactable = true;

        int state = animator.GetInteger("WindowState");
        buttons[state].interactable = false;
    }
    
    public void OpenWIndowA()
    {
        animator.SetInteger("WindowState", 0);
        gameObject.SetActive(false);
    }
    public void OpenWIndowB()
    {
        animator.SetInteger("WindowState", 2);
        gameObject.SetActive(false);
    }
    public void CloseAll()
    {
        animator.SetInteger("WindowState", 1);
        gameObject.SetActive(false);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelChanger : MonoBehaviour
{
    enum Panel
    {
        Panel0,
        Panel1,
        Panel2,
        Panel3,
        Panel4,
        Panel5,
        Panel6,
        Panel7,
        Panel8,
    }

    Panel currentPanel;

    public void OnRightButton()
    {
        switch (currentPanel)
        {
            case Panel.Panel0:
                Show(Panel.Panel1);
                break;
            case Panel.Panel1:
                Show(Panel.Panel2);
                break;
            case Panel.Panel6:
                Show(Panel.Panel7);
                break;
            case Panel.Panel7:
                Show(Panel.Panel8);
                break;


        }
    }
    public void OnLeftButton()
    {
        switch (currentPanel)
        {
            case Panel.Panel1:
                Show(Panel.Panel0);
                break;
            case Panel.Panel2:
                Show(Panel.Panel1);
                break;
            case Panel.Panel7:
                Show(Panel.Panel6);
                break;
            case Panel.Panel8:
                Show(Panel.Panel7);
                break;
        }
    }
    public void OnBackButton()
    {
        // Panel3 -> 0
        // Panel4 -> 1
        // Panel5 -> 2
        switch (currentPanel)
        {
            case Panel.Panel3:
                Show(Panel.Panel0);
                break;
            case Panel.Panel4:
                Show(Panel.Panel1);
                break;
            case Panel.Panel5:
                Show(Panel.Panel2);
                break;

        }
    }

    public void OnLocker()
    {
        Show(Panel.Panel3);
    }

    public void OnPig()
    {
        Show(Panel.Panel4);
    }

    public void OnBucket()
    {
        Show(Panel.Panel5);
    }

    public void OnHall2()
    {
        Show(Panel.Panel6);
    }
    public void OnHall6()
    {
        Show(Panel.Panel2);
    }

    void Show(Panel panel)
    {
        currentPanel = panel;
        switch (panel)
        {
            case Panel.Panel0:
                transform.localPosition = new Vector2(0, 0);
                break;
            case Panel.Panel1:
                transform.localPosition = new Vector2(-1000, 0);
                break;
            case Panel.Panel2:
                transform.localPosition = new Vector2(-2000, 0);
                break;
            case Panel.Panel3:
                transform.localPosition = new Vector2(0, 1500);
                break;
            case Panel.Panel4:
                transform.localPosition = new Vector2(-1000, 1500);
                break;
            case Panel.Panel5:
                transform.localPosition = new Vector2(-2000, 1500);
                break;
            case Panel.Panel6:
                transform.localPosition = new Vector2(0, 3000);
                break;
            case Panel.Panel7:
                transform.localPosition = new Vector2(-1000, 3000);
                break;
            case Panel.Panel8:
                transform.localPosition = new Vector2(-2000, 3000);
                break;

        }
    }

}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject letterPanel;
    public ScrollRect letterScrollRect;

    public void CloseLetter()
    {
        letterPanel.SetActive(false);
    }

    public void OpenLetter()
    {
        letterPanel.SetActive(true);
        letterScrollRect.verticalNormalizedPosition = 1f; // scroll to top
    }
}
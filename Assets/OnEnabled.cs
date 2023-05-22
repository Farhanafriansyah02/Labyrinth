using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnabled : MonoBehaviour
{
    public GameObject panel;

    public void ButtonOnClick() {
        if (panel.activeInHierarchy == true)
            panel.SetActive(false);
        else
            panel.SetActive(true);
    }
}

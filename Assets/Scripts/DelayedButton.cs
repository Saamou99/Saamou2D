using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DelayedButton : MonoBehaviour
{
    public Button sceneButton;
    public float delayTime = 30f;
    public string sceneName = "Scene4";

    private void Start()
    {
        sceneButton.interactable = false;
        StartCoroutine(DelayButton());
    }

    IEnumerator DelayButton()
    {
        yield return new WaitForSeconds(delayTime);
        sceneButton.interactable = true;
    }

    public void ChangeScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Scene4");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JumpButton : MonoBehaviour
{
    public Button jumpButton;
    public float waitTime = 10f;

    private bool canSkipScene = false;

    void Start()
    {
        StartCoroutine(WaitToChangeText());
        jumpButton.onClick.AddListener(ChangeScene);
    }

    IEnumerator WaitToChangeText()
    {
        yield return new WaitForSeconds(waitTime);
        jumpButton.GetComponentInChildren<Text>().text = "Haha just kidding. Please wait...";
        canSkipScene = true;
    }

    void ChangeScene()
    {
        if (canSkipScene)
        {
            SceneManager.LoadScene("Scene6");
        }
    }
}

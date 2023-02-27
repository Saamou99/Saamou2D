using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SkipSceneButton : MonoBehaviour
{
    public Button GameObject;
    public float skipTime = 15.0f;

    void Start()
    {
        StartCoroutine(SkipScene());
    }

    IEnumerator SkipScene()
    {
        yield return new WaitForSeconds(skipTime);
        SceneManager.LoadScene("Scene6");
    }
}

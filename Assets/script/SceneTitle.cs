using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTitle : MonoBehaviour
{
    public void SwitchScene()
    {
        SceneManager.LoadScene("title", LoadSceneMode.Single);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteGame : MonoBehaviour
{
public void ToMainMenu()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    public Button button;
    void Start()
    {
        button.onClick.AddListener(Exit);
    }

    void Exit()
    {
        button.transform.parent.GetComponentInChildren<Text>().gameObject.SetActive(false);
        button.transform.parent.gameObject.SetActive(false);
    }
}

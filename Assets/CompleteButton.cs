using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompleteButton : MonoBehaviour
{

    public Button button;
    public GameObject playerCamera;
    void Start()
    {
    button.onClick.AddListener(CloseWindow);
    }
    void CloseWindow()
    {
        this.transform.parent.transform.parent.gameObject.SetActive(false);
        playerCamera.GetComponent<MouseLook>().enabled = true;
        playerCamera.transform.parent.GetComponent<PlayerMovement>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
    }

}

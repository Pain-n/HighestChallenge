using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseTerminalScript : MonoBehaviour
{
    public Button button;
    public GameObject playerCamera;
    void Start()
    {
     button.onClick.AddListener(CloseTab);
    }

    void CloseTab()
    {
        button.transform.parent.gameObject.SetActive(false);
        playerCamera.GetComponent<MouseLook>().enabled = true;
        playerCamera.transform.parent.GetComponent<PlayerMovement>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
    }
}

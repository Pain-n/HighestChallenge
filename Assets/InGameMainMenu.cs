using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMainMenu : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject PlayerCamera;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            for (int i = 0; i<MenuPanel.transform.parent.childCount; i++)
            {
                MenuPanel.transform.parent.GetChild(i).gameObject.SetActive(false);
            }
            MenuPanel.SetActive(true);
            PlayerCamera.GetComponent<MouseLook>().enabled = false;
            Cursor.lockState = CursorLockMode.Confined;
            PlayerCamera.transform.parent.GetComponent<PlayerMovement>().enabled = false;
        }
    }
}

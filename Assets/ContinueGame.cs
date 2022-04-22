using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueGame : MonoBehaviour
{
    public GameObject playerCamera;
public void ContinueTheGame()
    {
        this.transform.parent.gameObject.SetActive(false);
        playerCamera.GetComponent<MouseLook>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        playerCamera.transform.parent.GetComponent<PlayerMovement>().enabled = true;
    }
}

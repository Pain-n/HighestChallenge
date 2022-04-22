using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompleteServerTerminalButton : MonoBehaviour
{
    public Button button;
    public InputField inputField;
    public GameObject player;
    public GameObject completePanel;
    public GameObject failureMessage;
    void Start()
    {
        button.onClick.AddListener(CompleteServerTerminal);
    }

    void CompleteServerTerminal()
    {
        if (inputField.transform.Find("Text").GetComponent<Text>().text.ToLower() == "perfection")
        {
            player.GetComponent<DoorController>().TerminalServerComplete = true;
            completePanel.gameObject.SetActive(true);
        }
        else
        {
            failureMessage.gameObject.SetActive(true);
        }
    }
}

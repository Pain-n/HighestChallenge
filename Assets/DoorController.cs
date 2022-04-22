using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorController : MonoBehaviour
{
    public GameObject instructions;
    public GameObject terminal1;
    public GameObject terminal2;
    public GameObject terminal3;
    public GameObject terminal4;
    public GameObject terminal5;
    public GameObject terminal6;
    public GameObject terminalServer;
    public GameObject terminalMask;
    public GameObject drone;
    public GameObject playerCamera;
    public GameObject terminalItem;
    public GameObject terminal2Item;
    public GameObject terminal3Item;
    public GameObject terminal4Item;
    public GameObject terminal5Item;
    public GameObject terminal6Item;
    public bool Terminal1Complete = false;
    public bool Terminal2Complete = false;
    public bool Terminal3Complete = false;
    public bool Terminal4Complete = false;
    public bool Terminal5Complete = false;
    public bool Terminal6Complete = false;
    public bool TerminalServerComplete = false;
    public bool TerminalMaskComplete = false;

    public void SaveGame()
    {
        SaveSystem.SaveGame(this);
    }
    public void LoadGame()
    {
        PlayerData data = SaveSystem.LoadGame();
        Terminal1Complete = data.Terminal1Complete;
        Terminal2Complete = data.Terminal2Complete;
        Terminal3Complete = data.Terminal3Complete;
        Terminal4Complete = data.Terminal4Complete;
        Terminal5Complete = data.Terminal5Complete;
        Terminal6Complete = data.Terminal6Complete;
        TerminalServerComplete = data.TerminalServerComplete;
        TerminalMaskComplete = data.TerminalMaskComplete;
        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Door" && Terminal1Complete == true)
        {
            Animator anim = other.GetComponentInChildren<Animator>();
            anim.SetTrigger("OpenClose");
        }
        if (other.tag == "Door1" && Terminal2Complete == true)
        {
            Animator anim = other.GetComponentInChildren<Animator>();
            anim.SetTrigger("OpenClose");
        }
        if (other.tag == "Door2" && Terminal3Complete == true)
        {
            Animator anim = other.GetComponentInChildren<Animator>();
            anim.SetTrigger("OpenClose");
        }
        if (other.tag == "Door3" && Terminal4Complete == true && TerminalServerComplete == true)
        {
            Animator anim = other.GetComponentInChildren<Animator>();
            anim.SetTrigger("OpenClose");
        }
        if (other.tag == "Door4" && Terminal5Complete == true)
        {
            Animator anim = other.GetComponentInChildren<Animator>();
            anim.SetTrigger("OpenClose");
        }
        if (other.tag == "Door5" && TerminalMaskComplete == true)
        {
            Animator anim = other.GetComponentInChildren<Animator>();
            anim.SetTrigger("OpenClose");
        }
        if (other.tag == "Door6" && Terminal6Complete == true)
        {
            Animator anim = other.GetComponentInChildren<Animator>();
            anim.SetTrigger("OpenClose");
        }
        if (other.tag == "Terminal")
        {
            instructions.SetActive(true);
            instructions.GetComponentInChildren<Text>().text = "Нажмите E для взаимодействия";
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Terminal")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (other.name == "Terminal1")
                {
                    terminalItem.GetComponent<ItemController>().counterUp = 4;
                    terminalItem.GetComponent<ItemController>().counterRight = 2;
                    terminalItem.GetComponent<ItemController>().counterLeft = 5;
                    terminalItem.GetComponent<ItemController>().counterDestroy = 2;
                    terminal1.GetComponentInChildren<ExecuteAlgorythm>().currentCell = 1;
                    instructions.SetActive(false);
                    terminal1.SetActive(true);
                    playerCamera.GetComponent<MouseLook>().enabled = false;
                    Cursor.lockState = CursorLockMode.Confined;
                    playerCamera.transform.parent.GetComponent<PlayerMovement>().enabled = false;
                }
                if (other.name == "Terminal2")
                {
                        terminal2Item.GetComponent<ItemController>().counterUp = 4;
                        terminal2Item.GetComponent<ItemController>().counterRight = 1;
                        terminal2Item.GetComponent<ItemController>().counterLeft = 3;
                        terminal2Item.GetComponent<ItemController>().counterDestroy = 4;
                        terminal2.GetComponentInChildren<ExecuteAlgorythm>().currentCell = 3;
                        instructions.SetActive(false);
                        terminal2.SetActive(true);
                        playerCamera.GetComponent<MouseLook>().enabled = false;
                        Cursor.lockState = CursorLockMode.Confined;
                        playerCamera.transform.parent.GetComponent<PlayerMovement>().enabled = false;
                }
                if (other.name == "Terminal3")
                {
                   
                    terminal3Item.GetComponent<ItemController>().counterUp = 4;
                    terminal3Item.GetComponent<ItemController>().counterRight = 0;
                    terminal3Item.GetComponent<ItemController>().counterLeft = 4;
                    terminal3Item.GetComponent<ItemController>().counterDestroy = 6;
                    terminal3.GetComponentInChildren<ExecuteAlgorythm>().currentCell = 10;
                    instructions.SetActive(false);
                    terminal3.SetActive(true);
                    playerCamera.GetComponent<MouseLook>().enabled = false;
                    Cursor.lockState = CursorLockMode.Confined;
                    playerCamera.transform.parent.GetComponent<PlayerMovement>().enabled = false;
                }
                if (other.name == "Terminal4")
                {
                    if(TerminalServerComplete == true)
                    {
                        terminal4Item.GetComponent<ItemController>().counterUp = 2;
                        terminal4Item.GetComponent<ItemController>().counterRight = 3;
                        terminal4Item.GetComponent<ItemController>().counterLeft = 3;
                        terminal4Item.GetComponent<ItemController>().counterDestroy = 7;
                        terminal4.GetComponentInChildren<ExecuteAlgorythm>().currentCell = 0;
                        instructions.SetActive(false);
                        terminal4.SetActive(true);
                        playerCamera.GetComponent<MouseLook>().enabled = false;
                        Cursor.lockState = CursorLockMode.Confined;
                        playerCamera.transform.parent.GetComponent<PlayerMovement>().enabled = false;
                    }
                    instructions.GetComponentInChildren<Text>().text = "Требуется 2 уровень доступа";
                }
                if (other.name == "Terminal5")
                {
                        terminal5Item.GetComponent<ItemController>().counterUp = 4;
                        terminal5Item.GetComponent<ItemController>().counterRight = 2;
                        terminal5Item.GetComponent<ItemController>().counterLeft = 2;
                        terminal5Item.GetComponent<ItemController>().counterDestroy = 4;
                        terminal5.GetComponentInChildren<ExecuteAlgorythm>().currentCell = 3;
                        instructions.SetActive(false);
                        terminal5.SetActive(true);
                        playerCamera.GetComponent<MouseLook>().enabled = false;
                        Cursor.lockState = CursorLockMode.Confined;
                        playerCamera.transform.parent.GetComponent<PlayerMovement>().enabled = false;
                }
                if (other.name == "Terminal6")
                {
                    terminal6Item.GetComponent<ItemController>().counterUp = 1;
                    terminal6Item.GetComponent<ItemController>().counterRight = 1;
                    terminal6Item.GetComponent<ItemController>().counterLeft = 1;
                    terminal6Item.GetComponent<ItemController>().counterDestroy = 10;
                    terminal6.GetComponentInChildren<ExecuteAlgorythm>().currentCell = 21;
                    instructions.SetActive(false);
                    terminal6.SetActive(true);
                    playerCamera.GetComponent<MouseLook>().enabled = false;
                    Cursor.lockState = CursorLockMode.Confined;
                    playerCamera.transform.parent.GetComponent<PlayerMovement>().enabled = false;
                }
                if (other.name == "TerminalServer")
                {
                    instructions.SetActive(false);
                    terminalServer.SetActive(true);
                    playerCamera.GetComponent<MouseLook>().enabled = false;
                    Cursor.lockState = CursorLockMode.Confined;
                    playerCamera.transform.parent.GetComponent<PlayerMovement>().enabled = false;
                }
                if (other.name == "TerminalMask")
                {
                    instructions.SetActive(false);
                    terminalMask.SetActive(true);
                    playerCamera.GetComponent<MouseLook>().enabled = false;
                    Cursor.lockState = CursorLockMode.Confined;
                    playerCamera.transform.parent.GetComponent<PlayerMovement>().enabled = false;
                }
                if (other.name == "Drone")
                {
                    instructions.SetActive(false);
                    drone.SetActive(true);
                    playerCamera.GetComponent<MouseLook>().enabled = false;
                    Cursor.lockState = CursorLockMode.Confined;
                    playerCamera.transform.parent.GetComponent<PlayerMovement>().enabled = false;
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Door" && Terminal1Complete == true)
        {
            Animator anim = other.GetComponentInChildren<Animator>();
            anim.SetTrigger("OpenClose");
        }
        if (other.tag == "Door1" && Terminal2Complete == true)
        {
            Animator anim = other.GetComponentInChildren<Animator>();
            anim.SetTrigger("OpenClose");
        }
        if (other.tag == "Door2" && Terminal3Complete == true)
        {
            Animator anim = other.GetComponentInChildren<Animator>();
            anim.SetTrigger("OpenClose");
        }
        if (other.tag == "Door3" && Terminal4Complete == true && TerminalServerComplete == true)
        {
            Animator anim = other.GetComponentInChildren<Animator>();
            anim.SetTrigger("OpenClose");
        }
        if (other.tag == "Door4" && Terminal5Complete == true)
        {
            Animator anim = other.GetComponentInChildren<Animator>();
            anim.SetTrigger("OpenClose");
        }
        if (other.tag == "Door5" && TerminalMaskComplete == true)
        {
            Animator anim = other.GetComponentInChildren<Animator>();
            anim.SetTrigger("OpenClose");
        }
        if (other.tag == "Door6" && Terminal6Complete == true)
        {
            Animator anim = other.GetComponentInChildren<Animator>();
            anim.SetTrigger("OpenClose");
        }
        if (other.tag == "Terminal")
        {
            instructions.SetActive(false);
        }
    }
}

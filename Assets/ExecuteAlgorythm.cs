using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExecuteAlgorythm : MonoBehaviour
{
    public int currentCell;
    public Button button;
    public GameObject terminalPlayer;
    public GameObject cristall;
    public GameObject TerminalGrid;
    public GameObject TerminalAlgorytmPanel;
    public GameObject player;
    public GameObject CompleteMessage;
    public GameObject failureMessage;
    public Quaternion startRotation;
    bool IsTerminalDone = false;
    private int startPosition;
    void Start()
    {
        button.onClick.AddListener(Execute);
        startPosition = currentCell;
        startRotation = terminalPlayer.transform.rotation;
    }
    void Execute()
    {
        for (int i = 0; i<TerminalAlgorytmPanel.transform.childCount; i++)
        {
            GameObject sell = TerminalAlgorytmPanel.transform.GetChild(i).gameObject;
            if (sell.transform.childCount != 0)
            {
                if(sell.transform.GetChild(0).tag == "ItemDestroy")
                {
                    if (terminalPlayer.transform.rotation.eulerAngles.z == 0)
                    {
                        if (currentCell + 4 <= 23)
                        {
                            if (TerminalGrid.transform.GetChild(currentCell + 4).transform.childCount != 0)
                            {
                                if (TerminalGrid.transform.GetChild(currentCell + 4).transform.GetChild(0).tag == "Barrier")
                                {
                                    TerminalGrid.transform.GetChild(currentCell + 4).transform.GetChild(0).gameObject.SetActive(false);
                                    terminalPlayer.transform.SetParent(TerminalGrid.transform.GetChild(currentCell + 4));
                                    terminalPlayer.GetComponent<RectTransform>().position = terminalPlayer.transform.parent.GetComponent<RectTransform>().position;
                                    if (TerminalGrid.transform.GetChild(currentCell + 4).tag == "Barrier")
                                    {
                                        TerminalGrid.transform.GetChild(currentCell + 4).gameObject.tag = "BarrierDisabled";
                                    }
                                    currentCell = currentCell + 4;
                                }
                            }
                        }
                    }
                    if (terminalPlayer.transform.rotation.eulerAngles.z == 180)
                    {
                        if (currentCell - 4 >= 0)
                        {
                            if (TerminalGrid.transform.GetChild(currentCell - 4).transform.childCount != 0)
                            {
                                if (TerminalGrid.transform.GetChild(currentCell - 4).transform.GetChild(0).tag == "Barrier")
                                {
                                    TerminalGrid.transform.GetChild(currentCell - 4).transform.GetChild(0).gameObject.SetActive(false);
                                    terminalPlayer.transform.SetParent(TerminalGrid.transform.GetChild(currentCell - 4));
                                    terminalPlayer.GetComponent<RectTransform>().position = terminalPlayer.transform.parent.GetComponent<RectTransform>().position;

                                    if (TerminalGrid.transform.GetChild(currentCell - 4).tag == "Barrier")
                                    {
                                        TerminalGrid.transform.GetChild(currentCell - 4).gameObject.tag = "BarrierDisabled";
                                    }
                                    currentCell = currentCell - 4;
                                }
                            }
                        }
                    }
                    if (terminalPlayer.transform.rotation.eulerAngles.z == 90)
                    {
                        if (currentCell + 1 <= 23 || currentCell + 1 != 4 || currentCell + 1 != 8 || currentCell + 1 != 12 || currentCell + 1 != 16 || currentCell + 1 != 20) 
                        {
                            if (TerminalGrid.transform.GetChild(currentCell + 1).transform.childCount != 0)
                            {
                                if (TerminalGrid.transform.GetChild(currentCell + 1).transform.GetChild(0).tag == "Barrier")
                                {
                                    TerminalGrid.transform.GetChild(currentCell + 1).transform.GetChild(0).gameObject.SetActive(false);
                                    terminalPlayer.transform.SetParent(TerminalGrid.transform.GetChild(currentCell + 1));
                                    terminalPlayer.GetComponent<RectTransform>().position = terminalPlayer.transform.parent.GetComponent<RectTransform>().position;
                                    
                                    if (TerminalGrid.transform.GetChild(currentCell + 1).tag == "Barrier")
                                    {
                                        TerminalGrid.transform.GetChild(currentCell + 1).gameObject.tag = "BarrierDisabled";
                                    }
                                    currentCell = currentCell + 1;
                                }
                            }
                        }
                    }
                    if (terminalPlayer.transform.rotation.eulerAngles.z == 270)
                    {
                        if (currentCell - 1 <= 0 || currentCell - 1 != 3 || currentCell - 1 != 7 || currentCell - 1 != 11 || currentCell - 1 != 15 || currentCell - 1 != 19) 
                        {
                            if (TerminalGrid.transform.GetChild(currentCell - 1).transform.childCount != 0)
                            {
                                if (TerminalGrid.transform.GetChild(currentCell - 1).transform.GetChild(0).tag == "Barrier")
                                {
                                    TerminalGrid.transform.GetChild(currentCell - 1).transform.GetChild(0).gameObject.SetActive(false);
                                    terminalPlayer.transform.SetParent(TerminalGrid.transform.GetChild(currentCell - 1));
                                    terminalPlayer.GetComponent<RectTransform>().position = terminalPlayer.transform.parent.GetComponent<RectTransform>().position;
                                    
                                    if (TerminalGrid.transform.GetChild(currentCell - 1).tag == "Barrier")
                                    {
                                        TerminalGrid.transform.GetChild(currentCell - 1).gameObject.tag = "BarrierDisabled";
                                    }
                                    currentCell = currentCell - 1;
                                }
                            }
                        }
                    }
                }
                if (sell.transform.GetChild(0).tag == "ItemForward")
                {
                    int barrier = 0;
                    while (barrier == 0)
                    {
                        if (terminalPlayer.transform.rotation.eulerAngles.z == 0)
                        {
                            if (currentCell + 4 > 23 || TerminalGrid.transform.GetChild(currentCell + 4).tag == "BlackCell")
                            {
                               barrier = 1;
                            }
                            else if(TerminalGrid.transform.GetChild(currentCell + 4).transform.childCount != 0)
                            {
                               if(TerminalGrid.transform.GetChild(currentCell + 4).tag == "Barrier")
                                {
                                    barrier = 1;    
                                }
                               if(TerminalGrid.transform.GetChild(currentCell + 4).transform.GetChild(0).tag == "Cristall")
                                {
                                    terminalPlayer.transform.SetParent(TerminalGrid.transform.GetChild(currentCell + 4));
                                    terminalPlayer.GetComponent<RectTransform>().position = terminalPlayer.transform.parent.GetComponent<RectTransform>().position;
                                    currentCell = currentCell + 4;
                                    barrier = 1;
                                    IsTerminalDone = true;
                                }
                            }
                            else
                            {
                                terminalPlayer.transform.SetParent(TerminalGrid.transform.GetChild(currentCell + 4));
                                terminalPlayer.GetComponent<RectTransform>().position = terminalPlayer.transform.parent.GetComponent<RectTransform>().position;
                                currentCell = currentCell + 4;
                            }
                        }
                        else if (terminalPlayer.transform.rotation.eulerAngles.z == 180)
                        {
                            if (currentCell - 4 < 0 || TerminalGrid.transform.GetChild(currentCell - 4).tag == "BlackCell")
                            {
                                barrier = 1;
                            }
                            else if (TerminalGrid.transform.GetChild(currentCell - 4).transform.childCount != 0)
                            {
                                if (TerminalGrid.transform.GetChild(currentCell - 4).tag == "Barrier")
                                {
                                    barrier = 1;
                                }
                                if (TerminalGrid.transform.GetChild(currentCell - 4).transform.GetChild(0).tag == "Cristall")
                                {
                                    terminalPlayer.transform.SetParent(TerminalGrid.transform.GetChild(currentCell - 4));
                                    terminalPlayer.GetComponent<RectTransform>().position = terminalPlayer.transform.parent.GetComponent<RectTransform>().position;
                                    currentCell = currentCell - 4;
                                    barrier = 1;
                                    IsTerminalDone = true;
                                }
                            }
                            else
                            {
                                terminalPlayer.transform.SetParent(TerminalGrid.transform.GetChild(currentCell - 4));
                                terminalPlayer.GetComponent<RectTransform>().position = terminalPlayer.transform.parent.GetComponent<RectTransform>().position;
                                currentCell = currentCell - 4;
                            }

                        }
                        else if (terminalPlayer.transform.rotation.eulerAngles.z == 90)
                        {
                            if (currentCell + 1 > 23 || currentCell + 1 == 4 || currentCell + 1 == 8 || currentCell + 1 == 12 || currentCell + 1 == 16 || currentCell + 1 == 20 || TerminalGrid.transform.GetChild(currentCell + 1).tag == "BlackCell")
                            {
                                barrier = 1;
                            }
                            else if (TerminalGrid.transform.GetChild(currentCell + 1).transform.childCount != 0)
                            {
                                if (TerminalGrid.transform.GetChild(currentCell + 1).tag == "Barrier")
                                {
                                    barrier = 1;
                                }
                                if (TerminalGrid.transform.GetChild(currentCell + 1).transform.GetChild(0).tag == "Cristall")
                                {
                                    terminalPlayer.transform.SetParent(TerminalGrid.transform.GetChild(currentCell + 1));
                                    terminalPlayer.GetComponent<RectTransform>().position = terminalPlayer.transform.parent.GetComponent<RectTransform>().position;
                                    currentCell = currentCell + 1;
                                    barrier = 1;
                                    IsTerminalDone = true;
                                }
                            }
                            else
                            {
                                terminalPlayer.transform.SetParent(TerminalGrid.transform.GetChild(currentCell + 1));
                                terminalPlayer.GetComponent<RectTransform>().position = terminalPlayer.transform.parent.GetComponent<RectTransform>().position;
                                currentCell = currentCell + 1;
                            }

                        }
                        else if (terminalPlayer.transform.rotation.eulerAngles.z == 270)
                        {
                            if (currentCell - 1 < 0 || currentCell - 1 == 3 || currentCell - 1 == 7 || currentCell - 1 == 11 || currentCell - 1 == 15 || currentCell - 1 == 19 || TerminalGrid.transform.GetChild(currentCell - 1).tag == "BlackCell")
                            {
                                barrier = 1;
                            }
                            else if (TerminalGrid.transform.GetChild(currentCell - 1).transform.childCount != 0)
                            {
                                if (TerminalGrid.transform.GetChild(currentCell - 1).tag == "Barrier")
                                {
                                    barrier = 1;
                                }
                                if (TerminalGrid.transform.GetChild(currentCell - 1).transform.GetChild(0).tag == "Cristall")
                                {
                                    terminalPlayer.transform.SetParent(TerminalGrid.transform.GetChild(currentCell - 1));
                                    terminalPlayer.GetComponent<RectTransform>().position = terminalPlayer.transform.parent.GetComponent<RectTransform>().position;
                                    currentCell = currentCell - 1;
                                    barrier = 1;
                                    IsTerminalDone = true;
                                }
                            }
                            else 
                            {
                                terminalPlayer.transform.SetParent(TerminalGrid.transform.GetChild(currentCell - 1));
                                terminalPlayer.GetComponent<RectTransform>().position = terminalPlayer.transform.parent.GetComponent<RectTransform>().position;
                                currentCell = currentCell - 1;
                            }

                        }
                    }
                }
                if (sell.transform.GetChild(0).tag == "ItemLeft")
                {
                    if (terminalPlayer.transform.rotation.z == 180 || terminalPlayer.transform.rotation.z == -180) 
                    {
                    terminalPlayer.transform.Rotate(0f, 0f, -270f, Space.Self);
                    }
                    terminalPlayer.transform.Rotate(0f, 0f, 90f, Space.Self);
                }
                if (sell.transform.GetChild(0).tag == "ItemRight")
                {
                    if (terminalPlayer.transform.rotation.z == 180 || terminalPlayer.transform.rotation.z == -180)
                    {
                        terminalPlayer.transform.Rotate(0f, 0f, 270f, Space.Self);
                    }
                    terminalPlayer.transform.Rotate(0f, 0f, -90f, Space.Self);
                }
            }
            if(i == TerminalAlgorytmPanel.transform.childCount - 1 && IsTerminalDone == false)
            {
                failureMessage.SetActive(true);
                terminalPlayer.transform.SetParent(TerminalGrid.transform.GetChild(startPosition));
                terminalPlayer.transform.position = terminalPlayer.transform.parent.position;
                terminalPlayer.transform.rotation = startRotation;
                for(int n = 0; n < TerminalGrid.transform.childCount; n++)
                {
                    if (TerminalGrid.transform.GetChild(n).tag == "BarrierDisabled")
                    {
                        TerminalGrid.transform.GetChild(n).gameObject.tag = "Barrier";
                        TerminalGrid.transform.GetChild(n).transform.GetChild(0).gameObject.SetActive(true);
                    }
                    if (TerminalGrid.transform.GetChild(n).tag == "BarrierDisabled")
                    {
                        TerminalGrid.transform.GetChild(n).gameObject.tag = "Barrier";
                        TerminalGrid.transform.GetChild(n).transform.GetChild(0).gameObject.SetActive(true);
                    }
                    }
            }
            if(IsTerminalDone == true)
            {
                i = TerminalAlgorytmPanel.transform.childCount;
                CompleteMessage.SetActive(true);
                if(TerminalGrid.transform.parent.name == "Terminal1")
                {
                    player.GetComponent<DoorController>().Terminal1Complete = true;
                    IsTerminalDone = false;
                }
                if (TerminalGrid.transform.parent.name == "Terminal2")
                {
                    player.GetComponent<DoorController>().Terminal2Complete = true;
                    IsTerminalDone = false;
                }
                if (TerminalGrid.transform.parent.name == "Terminal3")
                {
                    player.GetComponent<DoorController>().Terminal3Complete = true;
                    IsTerminalDone = false;
                }
                if (TerminalGrid.transform.parent.name == "Terminal4")
                {
                    player.GetComponent<DoorController>().Terminal4Complete = true;
                    IsTerminalDone = false;
                }
                if (TerminalGrid.transform.parent.name == "Terminal5")
                {
                    player.GetComponent<DoorController>().Terminal5Complete = true;
                    IsTerminalDone = false;
                }
                if (TerminalGrid.transform.parent.name == "Terminal6")
                {
                    player.GetComponent<DoorController>().Terminal6Complete = true;
                    IsTerminalDone = false;
                }
                if (TerminalGrid.transform.parent.name == "TerminalServer")
                {
                    player.GetComponent<DoorController>().TerminalServerComplete = true;
                    IsTerminalDone = false;
                }
                if (TerminalGrid.transform.parent.name == "TerminalMask")
                {
                    player.GetComponent<DoorController>().TerminalMaskComplete = true;
                    IsTerminalDone = false;
                }
            }
        }
    }
}
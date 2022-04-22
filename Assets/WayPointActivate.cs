using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WayPointActivate : MonoBehaviour
{
    public Button button;
    public Text CountCharge;
    public GameObject WayPack;
    public GameObject CompletePanel;
    public GameObject player;
    void Start()
    {
        button.onClick.AddListener(WayPointActivation);
    }

    void WayPointActivation()
    {
        if (button.name == "StartWayButton1" || button.name == "StartWayButton2" || button.name == "StartWayButton3" || button.name == "StartWayButton4" || button.name == "StartWayButton5")
        {
            for (int p = 0; p < WayPack.transform.childCount; p++)
            {
                WayPack.transform.GetChild(p).GetComponent<Image>().color = new Color(0.4f,0,0);
                WayPack.transform.GetChild(p).transform.Find("Way").GetComponent<Image>().color = new Color(0.3f, 0, 0);
                if(WayPack.transform.GetChild(p).transform.Find("Way").childCount != 0) 
                {
                    for (int i = 0; i < WayPack.transform.GetChild(p).transform.Find("Way").childCount; i++)
                    {
                        WayPack.transform.GetChild(p).transform.Find("Way").transform.GetChild(i).GetComponent<Image>().color = new Color(0.3f, 0, 0);
                    }
                }
                if(WayPack.transform.GetChild(p).name == "StartWayButton1Activated")
                {
                    WayPack.transform.GetChild(p).name = "StartWayButton1";
                }
                if (WayPack.transform.GetChild(p).name == "StartWayButton2Activated")
                {
                    WayPack.transform.GetChild(p).name = "StartWayButton2";
                }
                if (WayPack.transform.GetChild(p).name == "StartWayButton3Activated")
                {
                    WayPack.transform.GetChild(p).name = "StartWayButton3";
                }
                if (WayPack.transform.GetChild(p).name == "StartWayButton4Activated")
                {
                    WayPack.transform.GetChild(p).name = "StartWayButton4";
                }
                if (WayPack.transform.GetChild(p).name == "StartWayButton5Activated")
                {
                    WayPack.transform.GetChild(p).name = "StartWayButton5";
                }
                if (WayPack.transform.GetChild(p).name == "WayButton1.1Activated")
                {
                    WayPack.transform.GetChild(p).name = "WayButton1.1";
                }
                if (WayPack.transform.GetChild(p).name == "WayButton1.2Activated")
                {
                    WayPack.transform.GetChild(p).name = "WayButton1.2";
                }
                if (WayPack.transform.GetChild(p).name == "WayButton1.3Activated")
                {
                    WayPack.transform.GetChild(p).name = "WayButton1.3";
                }
                if (WayPack.transform.GetChild(p).name == "WayButton2.1Activated")
                {
                    WayPack.transform.GetChild(p).name = "WayButton2.1";
                }
                if (WayPack.transform.GetChild(p).name == "WayButton2.2Activated")
                {
                    WayPack.transform.GetChild(p).name = "WayButton2.2";
                }
                if (WayPack.transform.GetChild(p).name == "WayButton2.3Activated")
                {
                    WayPack.transform.GetChild(p).name = "WayButton2.3";
                }
                if (WayPack.transform.GetChild(p).name == "WayButton3.1Activated")
                {
                    WayPack.transform.GetChild(p).name = "WayButton3.1";
                }
                if (WayPack.transform.GetChild(p).name == "WayButton3.2Activated")
                {
                    WayPack.transform.GetChild(p).name = "WayButton3.2";
                }
                if (WayPack.transform.GetChild(p).name == "WayButton3.3Activated")
                {
                    WayPack.transform.GetChild(p).name = "WayButton3.3";
                }
            }
            CountCharge.text = "12";
            if (int.Parse(CountCharge.text) - int.Parse(button.transform.Find("Text").GetComponent<Text>().text) >= 0)
            {
                CountCharge.text = (int.Parse(CountCharge.text) - int.Parse(button.transform.Find("Text").GetComponent<Text>().text)).ToString();
                button.GetComponent<Image>().color = new Color(1f, 0, 0);
                button.transform.Find("Way").GetComponent<Image>().color = new Color(0.7f, 0, 0);
                if(button.transform.Find("Way").childCount != 0)
                {
                    for (int i = 0; i < button.transform.Find("Way").childCount; i++)
                    {
                        button.transform.Find("Way").transform.GetChild(i).GetComponent<Image>().color = new Color(0.7f, 0, 0);
                    }
                }
                if (button.name == "StartWayButton1")
                {
                    button.name = "StartWayButton1Activated";
                    WayPack.GetComponent<PreviousWayButtonChecker>().previousButton = button.name;
                }
                if (button.name == "StartWayButton2")
                {
                    button.name = "StartWayButton2Activated";
                    WayPack.GetComponent<PreviousWayButtonChecker>().previousButton = button.name;
                }
                if (button.name == "StartWayButton3")
                {
                    button.name = "StartWayButton3Activated";
                    WayPack.GetComponent<PreviousWayButtonChecker>().previousButton = button.name;
                }
                if (button.name == "StartWayButton4")
                {
                    button.name = "StartWayButton4Activated";
                    WayPack.GetComponent<PreviousWayButtonChecker>().previousButton = button.name;
                }
                if (button.name == "StartWayButton5")
                {
                    button.name = "StartWayButton5Activated";
                    WayPack.GetComponent<PreviousWayButtonChecker>().previousButton = button.name;
                }
            }
        }
        if (button.name == "WayButton1.1")
        {
            if (WayPack.GetComponent<PreviousWayButtonChecker>().previousButton == "StartWayButton1Activated" || WayPack.GetComponent<PreviousWayButtonChecker>().previousButton == "StartWayButton2Activated")
            {
                if (int.Parse(CountCharge.text) - int.Parse(button.transform.Find("Text").GetComponent<Text>().text) >= 0)
                {
                    CountCharge.text = (int.Parse(CountCharge.text) - int.Parse(button.transform.Find("Text").GetComponent<Text>().text)).ToString();
                    button.GetComponent<Image>().color = new Color(1f, 0, 0);
                    button.transform.Find("Way").GetComponent<Image>().color = new Color(0.7f, 0, 0);
                    if(button.transform.Find("Way").childCount != 0)
                    {
                        for (int i = 0; i < button.transform.Find("Way").childCount; i++)
                        {
                            button.transform.Find("Way").transform.GetChild(i).GetComponent<Image>().color = new Color(0.7f, 0, 0);
                        }
                    }
                    button.name = "WayButton1.1Activated";
                    WayPack.GetComponent<PreviousWayButtonChecker>().previousButton = button.name;
                }
            }
        }
        if (button.name == "WayButton1.2")
        {
            if (WayPack.GetComponent<PreviousWayButtonChecker>().previousButton == "WayButton1.1Activated")
            {
                if (int.Parse(CountCharge.text) - int.Parse(button.transform.Find("Text").GetComponent<Text>().text) >= 0)
                {
                    CountCharge.text = (int.Parse(CountCharge.text) - int.Parse(button.transform.Find("Text").GetComponent<Text>().text)).ToString();
                    button.GetComponent<Image>().color = new Color(1f, 0, 0);
                    button.transform.Find("Way").GetComponent<Image>().color = new Color(0.7f, 0, 0);
                    if (button.transform.Find("Way").childCount != 0)
                    {
                        for (int i = 0; i < button.transform.Find("Way").childCount; i++)
                        {
                            button.transform.Find("Way").transform.GetChild(i).GetComponent<Image>().color = new Color(0.7f, 0, 0);
                        }
                    }
                    button.name = "WayButton1.2Activated";
                    WayPack.GetComponent<PreviousWayButtonChecker>().previousButton = button.name;
                }
            }
        }
        if (button.name == "WayButton1.3")
        {
            if (WayPack.GetComponent<PreviousWayButtonChecker>().previousButton == "WayButton1.2Activated")
            {
                if (int.Parse(CountCharge.text) - int.Parse(button.transform.Find("Text").GetComponent<Text>().text) >= 0)
                {
                    CountCharge.text = (int.Parse(CountCharge.text) - int.Parse(button.transform.Find("Text").GetComponent<Text>().text)).ToString();
                    button.GetComponent<Image>().color = new Color(1f, 0, 0);
                    button.transform.Find("Way").GetComponent<Image>().color = new Color(0.7f, 0, 0);
                    if (button.transform.Find("Way").childCount != 0)
                    {
                        for (int i = 0; i < button.transform.Find("Way").childCount; i++)
                        {
                            button.transform.Find("Way").transform.GetChild(i).GetComponent<Image>().color = new Color(0.7f, 0, 0);
                        }
                    }
                    button.name = "WayButton1.3Activated";
                    WayPack.GetComponent<PreviousWayButtonChecker>().previousButton = button.name;
                }
            }
        }
        if (button.name == "WayButton2.1")
        {
            if (WayPack.GetComponent<PreviousWayButtonChecker>().previousButton == "StartWayButton3Activated" || WayPack.GetComponent<PreviousWayButtonChecker>().previousButton == "StartWayButton4Activated")
            {
                if (int.Parse(CountCharge.text) - int.Parse(button.transform.Find("Text").GetComponent<Text>().text) >= 0)
                {
                    CountCharge.text = (int.Parse(CountCharge.text) - int.Parse(button.transform.Find("Text").GetComponent<Text>().text)).ToString();
                    button.GetComponent<Image>().color = new Color(1f, 0, 0);
                    button.transform.Find("Way").GetComponent<Image>().color = new Color(0.7f, 0, 0);
                    if (button.transform.Find("Way").childCount != 0)
                    {
                        for (int i = 0; i < button.transform.Find("Way").childCount; i++)
                        {
                            button.transform.Find("Way").transform.GetChild(i).GetComponent<Image>().color = new Color(0.7f, 0, 0);
                        }
                    }
                    button.name = "WayButton2.1Activated";
                    WayPack.GetComponent<PreviousWayButtonChecker>().previousButton = button.name;
                }
            }
        }
        if (button.name == "WayButton2.2")
        {
            if (WayPack.GetComponent<PreviousWayButtonChecker>().previousButton == "WayButton2.1Activated")
            {
                if (int.Parse(CountCharge.text) - int.Parse(button.transform.Find("Text").GetComponent<Text>().text) >= 0)
                {
                    CountCharge.text = (int.Parse(CountCharge.text) - int.Parse(button.transform.Find("Text").GetComponent<Text>().text)).ToString();
                    button.GetComponent<Image>().color = new Color(1f, 0, 0);
                    button.transform.Find("Way").GetComponent<Image>().color = new Color(0.7f, 0, 0);
                    if (button.transform.Find("Way").childCount != 0)
                    {
                        for (int i = 0; i < button.transform.Find("Way").childCount; i++)
                        {
                            button.transform.Find("Way").transform.GetChild(i).GetComponent<Image>().color = new Color(0.7f, 0, 0);
                        }
                    }
                    button.name = "WayButton2.2Activated";
                    WayPack.GetComponent<PreviousWayButtonChecker>().previousButton = button.name;
                }
            }
        }
        if (button.name == "WayButton2.3")
        {
            if (WayPack.GetComponent<PreviousWayButtonChecker>().previousButton == "WayButton2.2Activated")
            {
                if (int.Parse(CountCharge.text) - int.Parse(button.transform.Find("Text").GetComponent<Text>().text) >= 0)
                {
                    CountCharge.text = (int.Parse(CountCharge.text) - int.Parse(button.transform.Find("Text").GetComponent<Text>().text)).ToString();
                    button.GetComponent<Image>().color = new Color(1f, 0, 0);
                    button.transform.Find("Way").GetComponent<Image>().color = new Color(0.7f, 0, 0);
                    if (button.transform.Find("Way").childCount != 0)
                    {
                        for (int i = 0; i < button.transform.Find("Way").childCount; i++)
                        {
                            button.transform.Find("Way").transform.GetChild(i).GetComponent<Image>().color = new Color(0.7f, 0, 0);
                        }
                    }
                    button.name = "WayButton2.3Activated";
                    WayPack.GetComponent<PreviousWayButtonChecker>().previousButton = button.name;
                }
            }
        }
        if (button.name == "WayButton3.1")
        {
            if (WayPack.GetComponent<PreviousWayButtonChecker>().previousButton == "StartWayButton5Activated")
            {
                if (int.Parse(CountCharge.text) - int.Parse(button.transform.Find("Text").GetComponent<Text>().text) >= 0)
                {
                    CountCharge.text = (int.Parse(CountCharge.text) - int.Parse(button.transform.Find("Text").GetComponent<Text>().text)).ToString();
                    button.GetComponent<Image>().color = new Color(1f, 0, 0);
                    button.transform.Find("Way").GetComponent<Image>().color = new Color(0.7f, 0, 0);
                    if (button.transform.Find("Way").childCount != 0)
                    {
                        for (int i = 0; i < button.transform.Find("Way").childCount; i++)
                        {
                            button.transform.Find("Way").transform.GetChild(i).GetComponent<Image>().color = new Color(0.7f, 0, 0);
                        }
                    }
                    button.name = "WayButton3.1Activated";
                    WayPack.GetComponent<PreviousWayButtonChecker>().previousButton = button.name;
                }
            }
        }
        if (button.name == "WayButton3.2")
        {
            if (WayPack.GetComponent<PreviousWayButtonChecker>().previousButton == "WayButton3.1Activated")
            {
                if (int.Parse(CountCharge.text) - int.Parse(button.transform.Find("Text").GetComponent<Text>().text) >= 0)
                {
                    CountCharge.text = (int.Parse(CountCharge.text) - int.Parse(button.transform.Find("Text").GetComponent<Text>().text)).ToString();
                    button.GetComponent<Image>().color = new Color(1f, 0, 0);
                    button.transform.Find("Way").GetComponent<Image>().color = new Color(0.7f, 0, 0);
                    if (button.transform.Find("Way").childCount != 0)
                    {
                        for (int i = 0; i < button.transform.Find("Way").childCount; i++)
                        {
                            button.transform.Find("Way").transform.GetChild(i).GetComponent<Image>().color = new Color(0.7f, 0, 0);
                        }
                    }
                    button.name = "WayButton3.2Activated";
                    WayPack.GetComponent<PreviousWayButtonChecker>().previousButton = button.name;
                }
            }
        }
        if (button.name == "WayButton3.3")
        {
            if (WayPack.GetComponent<PreviousWayButtonChecker>().previousButton == "WayButton3.2Activated")
            {
                if (int.Parse(CountCharge.text) - int.Parse(button.transform.Find("Text").GetComponent<Text>().text) >= 0)
                {
                    CountCharge.text = (int.Parse(CountCharge.text) - int.Parse(button.transform.Find("Text").GetComponent<Text>().text)).ToString();
                    button.GetComponent<Image>().color = new Color(1f, 0, 0);
                    button.transform.Find("Way").GetComponent<Image>().color = new Color(0.7f, 0, 0);
                    if (button.transform.Find("Way").childCount != 0)
                    {
                        for (int i = 0; i < button.transform.Find("Way").childCount; i++)
                        {
                            button.transform.Find("Way").transform.GetChild(i).GetComponent<Image>().color = new Color(0.7f, 0, 0);
                        }
                    }
                    button.name = "WayButton3.3Activated";
                    WayPack.GetComponent<PreviousWayButtonChecker>().previousButton = button.name;
                }
            }
        }
        if(button.name == "Eye")
        {
            if (WayPack.GetComponent<PreviousWayButtonChecker>().previousButton == "WayButton1.3Activated" || WayPack.GetComponent<PreviousWayButtonChecker>().previousButton == "WayButton2.3Activated" || WayPack.GetComponent<PreviousWayButtonChecker>().previousButton == "WayButton3.3Activated")
            {
             button.transform.GetChild(0).GetComponent<Image>().color = new Color(1f, 0, 0);
             button.transform.GetChild(0).transform.GetChild(0).GetComponent<Image>().color = new Color(0.7f, 0, 0);
             player.GetComponent<DoorController>().TerminalMaskComplete = true;
             CompletePanel.SetActive(true);
            }
            }
    }
}

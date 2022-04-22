using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ServerInfo : MonoBehaviour
{
    public Button button;
    public GameObject serverInfo;
    void Start()
    {
        button.onClick.AddListener(ServerInfoLook);
    }
void ServerInfoLook()
    {
        serverInfo.gameObject.SetActive(true);
        if(button.name == "ButtonServer")
        {
            serverInfo.transform.Find("Text1").gameObject.SetActive(true);
        }
        if (button.name == "ButtonServer1")
        {
            serverInfo.transform.Find("Text2").gameObject.SetActive(true);
        }
        if (button.name == "ButtonServer2")
        {
            serverInfo.transform.Find("Text3").gameObject.SetActive(true);
        }
        if (button.name == "ButtonServer3")
        {
            serverInfo.transform.Find("Text4").gameObject.SetActive(true);
        }
        if (button.name == "ButtonServer4")
        {
            serverInfo.transform.Find("Text5").gameObject.SetActive(true);
        }
        if (button.name == "ButtonServer5")
        {
            serverInfo.transform.Find("Text6").gameObject.SetActive(true);
        }
        if (button.name == "ButtonServer6")
        {
            serverInfo.transform.Find("Text7").gameObject.SetActive(true);
        }
        if (button.name == "ButtonServer7")
        {
            serverInfo.transform.Find("Text8").gameObject.SetActive(true);
        }
        if (button.name == "ButtonServer8")
        {
            serverInfo.transform.Find("Text9").gameObject.SetActive(true);
        }
        if (button.name == "ButtonServer9")
        {
            serverInfo.transform.Find("Text10").gameObject.SetActive(true);
        }
        if (button.name == "ButtonServer10")
        {
            serverInfo.transform.Find("Text11").gameObject.SetActive(true);
        }
        if (button.name == "ButtonServer11")
        {
            serverInfo.transform.Find("Text12").gameObject.SetActive(true);
        }
        if (button.name == "ButtonServer12")
        {
            serverInfo.transform.Find("Text13").gameObject.SetActive(true);
        }
        if (button.name == "ButtonServer13")
        {
            serverInfo.transform.Find("Text14").gameObject.SetActive(true);
        }
        if (button.name == "ButtonServer14")
        {
            serverInfo.transform.Find("Text15").gameObject.SetActive(true);
        }
        if (button.name == "ButtonServer15")
        {
            serverInfo.transform.Find("Text16").gameObject.SetActive(true);
        }
    }
}

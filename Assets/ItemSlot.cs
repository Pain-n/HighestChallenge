using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
       if(eventData.pointerDrag != null)
        {
            if (this.transform.parent.name == "TerminalItems" && eventData.pointerDrag.GetComponent<ItemController>().parentObject.transform.parent.name != "TerminalItems")
            {
                int count = int.Parse(eventData.pointerDrag.transform.GetChild(1).GetComponent<Text>().text) + 1;
                eventData.pointerDrag.GetComponent<ItemController>().parentObjectForBack.transform.GetChild(0).transform.GetChild(1).GetComponent<Text>().text = count.ToString();
                Destroy(eventData.pointerDrag.gameObject);
            }
            if(eventData.pointerDrag.transform.GetChild(1).GetComponent<Text>().text == "0" && eventData.pointerDrag.GetComponent<ItemController>().parentObject.transform.parent.name != "TerminalAlgorytmPanel")
            {
                Destroy(eventData.pointerDrag.gameObject);
            }
            if(this.transform.parent.name == "TerminalItems" && eventData.pointerDrag.GetComponent<ItemController>().parentObject.transform.parent.name == "TerminalItems")
            {
                Destroy(eventData.pointerDrag.gameObject);
            }
            if (this.transform.parent.name == "TerminalAlgorytmPanel" && eventData.pointerDrag.GetComponent<ItemController>().parentObject.transform.parent.name != "TerminalAlgorytmPanel" && eventData.pointerDrag.transform.GetChild(1).GetComponent<Text>().text != "0")
            {
                
                int count = int.Parse(eventData.pointerDrag.transform.GetChild(1).GetComponent<Text>().text) - 1;
                eventData.pointerDrag.transform.GetChild(1).GetComponent<Text>().text = count.ToString();
                eventData.pointerDrag.GetComponent<ItemController>().parentObject.transform.GetChild(0).transform.GetChild(1).GetComponent<Text>().text = count.ToString();
            }


            eventData.pointerDrag.transform.SetParent(this.transform);
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemMissed : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.GetComponent<ItemController>().parentObjectForBack != null)
            {
                int count = int.Parse(eventData.pointerDrag.transform.GetChild(1).GetComponent<Text>().text) + 1;
                eventData.pointerDrag.GetComponent<ItemController>().parentObjectForBack.transform.GetChild(0).transform.GetChild(1).GetComponent<Text>().text = count.ToString();
            }
            Destroy(eventData.pointerDrag);
        }
    }
}

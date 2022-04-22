using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemController : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    public GameObject parentObject;
    public GameObject parentObjectForBack;
    public GameObject player;
    public int counterUp;
    public int counterRight;
    public int counterLeft;
    public int counterDestroy;
    bool TerminalBegin = false;
    bool parentBlock = false;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();        
    }

    private void Update()
    {
        if (player.GetComponent<DoorController>().terminal1.activeInHierarchy == true)
        {
            if (TerminalBegin == false)
            {
                if (this.name == "ItemForward")
                {
                    this.transform.GetChild(1).GetComponent<Text>().text = player.GetComponent<DoorController>().terminalItem.GetComponent<ItemController>().counterUp.ToString();
                }
                else if (this.name == "ItemLeft")
                {
                    this.transform.GetChild(1).GetComponent<Text>().text = player.GetComponent<DoorController>().terminalItem.GetComponent<ItemController>().counterLeft.ToString();
                }
                else if (this.name == "ItemRight")
                {
                    this.transform.GetChild(1).GetComponent<Text>().text = player.GetComponent<DoorController>().terminalItem.GetComponent<ItemController>().counterRight.ToString();
                }
                else if (this.name == "ItemDestroy")
                {
                    this.transform.GetChild(1).GetComponent<Text>().text = player.GetComponent<DoorController>().terminalItem.GetComponent<ItemController>().counterDestroy.ToString();
                }

                TerminalBegin = true;
            }
        }
        if (player.GetComponent<DoorController>().terminal2.activeInHierarchy == true)
        {
            if (TerminalBegin == false)
            {
                if (this.name == "ItemForward")
                {
                    this.transform.GetChild(1).GetComponent<Text>().text = player.GetComponent<DoorController>().terminal2Item.GetComponent<ItemController>().counterUp.ToString();
                }
                else if (this.name == "ItemLeft")
                {
                    this.transform.GetChild(1).GetComponent<Text>().text = player.GetComponent<DoorController>().terminal2Item.GetComponent<ItemController>().counterLeft.ToString();
                }
                else if (this.name == "ItemRight")
                {
                    this.transform.GetChild(1).GetComponent<Text>().text = player.GetComponent<DoorController>().terminal2Item.GetComponent<ItemController>().counterRight.ToString();
                }
                else if (this.name == "ItemDestroy")
                {
                    this.transform.GetChild(1).GetComponent<Text>().text = player.GetComponent<DoorController>().terminal2Item.GetComponent<ItemController>().counterDestroy.ToString();
                }

                TerminalBegin = true;
            }
        }
        if (player.GetComponent<DoorController>().terminal3.activeInHierarchy == true)
        {
            if (TerminalBegin == false)
            {
                if (this.name == "ItemForward")
                {
                    this.transform.GetChild(1).GetComponent<Text>().text = player.GetComponent<DoorController>().terminal3Item.GetComponent<ItemController>().counterUp.ToString();
                }
                else if (this.name == "ItemLeft")
                {
                    this.transform.GetChild(1).GetComponent<Text>().text = player.GetComponent<DoorController>().terminal3Item.GetComponent<ItemController>().counterLeft.ToString();
                }
                else if (this.name == "ItemRight")
                {
                    this.transform.GetChild(1).GetComponent<Text>().text = player.GetComponent<DoorController>().terminal3Item.GetComponent<ItemController>().counterRight.ToString();
                }
                else if (this.name == "ItemDestroy")
                {
                    this.transform.GetChild(1).GetComponent<Text>().text = player.GetComponent<DoorController>().terminal3Item.GetComponent<ItemController>().counterDestroy.ToString();
                }

                TerminalBegin = true;
            }
        }
        if (player.GetComponent<DoorController>().terminal4.activeInHierarchy == true)
        {
            if (TerminalBegin == false)
            {
                if (this.name == "ItemForward")
                {
                    this.transform.GetChild(1).GetComponent<Text>().text = player.GetComponent<DoorController>().terminal4Item.GetComponent<ItemController>().counterUp.ToString();
                }
                else if (this.name == "ItemLeft")
                {
                    this.transform.GetChild(1).GetComponent<Text>().text = player.GetComponent<DoorController>().terminal4Item.GetComponent<ItemController>().counterLeft.ToString();
                }
                else if (this.name == "ItemRight")
                {
                    this.transform.GetChild(1).GetComponent<Text>().text = player.GetComponent<DoorController>().terminal4Item.GetComponent<ItemController>().counterRight.ToString();
                }
                else if (this.name == "ItemDestroy")
                {
                    this.transform.GetChild(1).GetComponent<Text>().text = player.GetComponent<DoorController>().terminal4Item.GetComponent<ItemController>().counterDestroy.ToString();
                }

                TerminalBegin = true;
            }
        }
        if (player.GetComponent<DoorController>().terminal5.activeInHierarchy == true)
        {
            if (TerminalBegin == false)
            {
                if (this.name == "ItemForward")
                {
                    this.transform.GetChild(1).GetComponent<Text>().text = player.GetComponent<DoorController>().terminal5Item.GetComponent<ItemController>().counterUp.ToString();
                }
                else if (this.name == "ItemLeft")
                {
                    this.transform.GetChild(1).GetComponent<Text>().text = player.GetComponent<DoorController>().terminal5Item.GetComponent<ItemController>().counterLeft.ToString();
                }
                else if (this.name == "ItemRight")
                {
                    this.transform.GetChild(1).GetComponent<Text>().text = player.GetComponent<DoorController>().terminal5Item.GetComponent<ItemController>().counterRight.ToString();
                }
                else if (this.name == "ItemDestroy")
                {
                    this.transform.GetChild(1).GetComponent<Text>().text = player.GetComponent<DoorController>().terminal5Item.GetComponent<ItemController>().counterDestroy.ToString();
                }

                TerminalBegin = true;
            }
        }
        if (player.GetComponent<DoorController>().terminal6.activeInHierarchy == true)
        {
            if (TerminalBegin == false)
            {
                if (this.name == "ItemForward")
                {
                    this.transform.GetChild(1).GetComponent<Text>().text = player.GetComponent<DoorController>().terminal6Item.GetComponent<ItemController>().counterUp.ToString();
                }
                else if (this.name == "ItemLeft")
                {
                    this.transform.GetChild(1).GetComponent<Text>().text = player.GetComponent<DoorController>().terminal6Item.GetComponent<ItemController>().counterLeft.ToString();
                }
                else if (this.name == "ItemRight")
                {
                    this.transform.GetChild(1).GetComponent<Text>().text = player.GetComponent<DoorController>().terminal6Item.GetComponent<ItemController>().counterRight.ToString();
                }
                else if (this.name == "ItemDestroy")
                {
                    this.transform.GetChild(1).GetComponent<Text>().text = player.GetComponent<DoorController>().terminal6Item.GetComponent<ItemController>().counterDestroy.ToString();
                }

                TerminalBegin = true;
            }
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (eventData.pointerDrag.transform.parent.transform.parent.name != "TerminalAlgorytmPanel")
        {
            GameObject changer = Instantiate(eventData.pointerDrag, eventData.pointerDrag.transform.position, eventData.pointerDrag.transform.rotation);
            changer.transform.SetParent(eventData.pointerDrag.transform.parent.transform);
            changer.transform.localScale = eventData.pointerDrag.transform.localScale;
        }
        if (parentObject != null && parentBlock == false)
        {
            parentObjectForBack = parentObject;
            parentBlock = true;
        }
        parentObject = eventData.pointerDrag.transform.parent.gameObject;

        
        eventData.pointerDrag.transform.SetParent(canvas.transform);
        eventData.pointerDrag.transform.GetChild(1).gameObject.SetActive(false);
        canvasGroup.blocksRaycasts = false;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
     
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }
}

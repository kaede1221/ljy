using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemButton : MonoBehaviour
{

    public int buttonID;
    private Item thisItem;
    private void Awake()
    {
       
    }

    private Item GetThisItem()

    {
        Debug.Log("find" + thisItem);
        for (int i = 0; i < GameManager.instance.items.Count; i++)
        {
            if (buttonID == i)
            {
                thisItem = GameManager.instance.items[i];
                Debug.Log("find" + thisItem);
            }

          
        }
        return thisItem;

    }
    public void CloseButton()
    {
        Debug.Log("nofind" + thisItem);
        GameManager.instance.RemoveItem(GetThisItem());
    }
}

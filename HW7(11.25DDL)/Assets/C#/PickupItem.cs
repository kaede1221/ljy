using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ItemManager;


public class PickupItem : MonoBehaviour
{
    public ItemManager.ItemType item;
    /*   public GameObject pickupEffect;*/
    public Item itemData;

    private void Awake()
    {
        bool isCollected = ItemManager.Instance.IsItemCollected(item);

        // 根据拾取状态设置物品的激活状态
        gameObject.SetActive(!isCollected);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            ItemManager.Instance.SetItemCollected(item, true);

            Destroy(gameObject);
            /*Instantiate(pickupEffect, transform.position, Quaternion.identity);*/
            GameManager.instance.AddItem(itemData);
            
        }
    }
}



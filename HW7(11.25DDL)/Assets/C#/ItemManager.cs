using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    private static ItemManager _instance;
    public enum ItemType
    {
        Item1,
        Item2,
        Item3,
        Item4
        // 可以根据实际情况添加更多的道具类型
    }
    public static ItemManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<ItemManager>();

                if (_instance == null)
                {
                    GameObject go = new GameObject("ItemManager");
                    _instance = go.AddComponent<ItemManager>();
                    DontDestroyOnLoad(go);
                }
            }
            return _instance;
        }
    }

    // 使用字典存储道具拾取状态
    private Dictionary<ItemType, bool> itemCollected = new Dictionary<ItemType, bool>();

    // 获取道具拾取状态的方法
    public bool GetItemCollected(ItemType itemType)
    {
        // 如果字典中包含道具类型，则返回对应的拾取状态，否则返回false
        return itemCollected.TryGetValue(itemType, out bool collected) ? collected : false;
    }

    // 设置道具拾取状态的方法
    public void SetItemCollected(ItemType itemType, bool value)
    {
        // 如果字典中包含道具类型，则更新拾取状态，否则添加新的道具类型和状态
        if (itemCollected.ContainsKey(itemType))
        {
            itemCollected[itemType] = value;
        }
        else
        {
            itemCollected.Add(itemType, value);
        }
    }

    public bool IsItemCollected(ItemType itemType)
    {
        return GetItemCollected(itemType);
    }
}

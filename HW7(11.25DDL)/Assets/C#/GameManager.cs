using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public CharacterData_SO characterData; // 将CharacterData_SO实例拖拽到GameManager的Inspector中
    public static GameManager instance;
    public bool isPaused;
    public List<Item> items = new List<Item>();
    public List<int> itemNumbers = new List<int>();
    public GameObject[] slots;
    public Item addItem;
    public Item removeItem;

    public Dictionary<Item, int> itemDict = new Dictionary<Item, int>();


    //here for test

    private void Awake()
    {
        if (characterData != null)
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                if (instance != this)
                {
                    Destroy(gameObject);
                }
            }
           
            // 在游戏启动时将CrossingNum重置为0
            characterData.CrossingNum = 0;

        }
    }

    private void Update()
    {

        //here for test
        if (Input.GetKeyDown(KeyCode.M))
        {
            AddItem(addItem);
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            RemoveItem(removeItem);
        }
    }
    private void Start()
    {
        DisplayItems();
    }


    private void DisplayItems()
    {
      /*  for (int i = 0; i < items.Count; i++)
        {
            slots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
            slots[i].transform.GetChild(0).GetComponent<Image>().sprite = items[i].itemSprite;

            slots[i].transform.GetChild(1).GetComponent<Text>().color = new Color(1, 1, 1, 1);
            slots[i].transform.GetChild(1).GetComponent<Text>().text = itemNumbers[i].ToString();

            slots[i].transform.GetChild(2).gameObject.SetActive(true);
        }*/

        for (int i = 0; i < slots.Length; i++)
        {
            if (i < items.Count)
            {
                slots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
                slots[i].transform.GetChild(0).GetComponent<Image>().sprite = items[i].itemSprite;

                slots[i].transform.GetChild(1).GetComponent<Text>().color = new Color(1, 1, 1, 1);
                slots[i].transform.GetChild(1).GetComponent<Text>().text = itemNumbers[i].ToString();

                slots[i].transform.GetChild(2).gameObject.SetActive(true);
            }
            else {

                slots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(0, 0, 0, 0);
                slots[i].transform.GetChild(0).GetComponent<Image>().sprite = null;

                slots[i].transform.GetChild(1).GetComponent<Text>().color = new Color(0,0,0,0);
                slots[i].transform.GetChild(1).GetComponent<Text>().text = null;

                slots[i].transform.GetChild(2).gameObject.SetActive(false);
            }
        }
    }
    public void AddItem(Item _item)
    {
        if (!items.Contains(_item))
        {
            items.Add(_item);
            itemNumbers.Add(1);
        }
        else
        {
            Debug.Log("you have it");
            for (int i = 0; i < items.Count; i++)
            {
                if (_item == items[i])
                    itemNumbers[i]++;
            }
        }
        DisplayItems();
    }

    public void RemoveItem(Item _item)
    {
        Debug.Log("test removeitem");
        if (items.Contains(_item))
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (_item == items[i])
                {
                    itemNumbers[i]--;
                    if (itemNumbers[i] == 0)
                    {
                        items.Remove(_item);
                        itemNumbers.Remove(itemNumbers[i]);
                    }
                }
            }
        }
        else
        {
            Debug.Log("nothing here");
           
        }
        DisplayItems();
    }
}

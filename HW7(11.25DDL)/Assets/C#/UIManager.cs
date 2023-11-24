using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.U2D.Animation;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance; // µ¥ÀýÊµÀý
    public GameObject inventoryMenu;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }


    // Start is called before the first frame update
    private void Start()
    {

        inventoryMenu.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        InventoryControl();
        
    }
    private void InventoryControl()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameManager.instance.isPaused)
            {
                Resume();

            }
            else
            {
                Pause();
            }
        }
    }
    private void Resume()
    {
        inventoryMenu.gameObject.SetActive(false);
        Time.timeScale = 1.0f;
        GameManager.instance.isPaused = false;
    }
    private void Pause()
    {
        inventoryMenu.gameObject.SetActive(true);
        Time.timeScale = 0.0f;
        GameManager.instance.isPaused = true;
    }

}

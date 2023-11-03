using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    private void Start()
    {

    }
    public string targetSceneName = "First";
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
            {
            Destroy(other.gameObject);
            // 查找音乐管理器并标记为不在加载新场景时被销毁
            GameObject musicManager = GameObject.Find("Sound"); 
            if (musicManager != null)
            {
                DontDestroyOnLoad(musicManager);
            }
            UnityEngine.SceneManagement.SceneManager.LoadScene(targetSceneName);
            }
    
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CharacterStats : MonoBehaviour
{
    //用于获取角色数值

    public CharacterData_SO characterData;
   

    private void Start()
    {
        // 注册一个场景切换事件监听器
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // 每次切换场景时增加CrossingNum
        characterData.CrossingNum++;
    }

    //折叠管理
    #region Read for Data_SO
    public int MaxHealth
    {
        get { if (characterData != null) return characterData.CrossingNum; else return 0; }
        set { characterData.CrossingNum = value; }
    }
    /*    public int CurrentHealth
        {
            get { if (characterData != null) return characterData.currentHealth; else return 0; }
            set { characterData.currentHealth = value; }
        }
        public int BaseDefence
        {
            get { if (characterData != null) return characterData.baseDefence; else return 0; }
            set { characterData.baseDefence = value; }
        }
        public int CurrentDefence
        {
            get { if (characterData != null) return characterData.currentDefence; else return 0; }
            set { characterData.currentDefence = value; }
        }*/
    #endregion
}
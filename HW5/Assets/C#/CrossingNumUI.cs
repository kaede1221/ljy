using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using TMPro; // 导入TextMeshPro的命名空间

public class CrossingNumUI : MonoBehaviour
{
    public static CrossingNumUI instance; // 单例实例
    public Transform characterHead;
    public TextMeshProUGUI crossingNumText;
    public CharacterData_SO characterData;


    private void Awake()
    {
        Debug.Log("1");
        // 创建单例
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // 保持声音管理器在场景切换时不被销毁
        }

      
    }
    private void Update()
    {
        if (characterHead != null)
        {
            float characterCenterX = characterHead.position.x;

      // 获取角色的最高y坐标
        float characterTopY = characterHead.position.y + characterHead.localScale.y * 0.5f;

    // 设置UI Text的位置
    Vector3 uiPosition = new Vector3(characterCenterX, characterTopY +1f, 0f);
    Vector3 screenPosition = Camera.main.WorldToScreenPoint(uiPosition);
    crossingNumText.transform.position = screenPosition;
        

            // 更新UI Text的文本为CrossingNum
            crossingNumText.text = "CrossingNum: " + characterData.CrossingNum;
        }
    }
}

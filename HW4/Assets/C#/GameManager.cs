using UnityEngine;

public class GameManager : MonoBehaviour
{
    public CharacterData_SO characterData; // 将CharacterData_SO实例拖拽到GameManager的Inspector中

    private void Awake()
    {
        if (characterData != null)
        {
            // 在游戏启动时将CrossingNum重置为0
            characterData.CrossingNum = 0;
        }
    }
}

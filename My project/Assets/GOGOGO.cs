using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GOGOGO : MonoBehaviour
{
 
    [SerializeField] public string entrancePassword;
    private void Start()
    {
        if (PlayerMovement.instance.scenePassword == entrancePassword)
        {
            PlayerMovement.instance.transform.position = transform.position;
            Debug.Log("enter!");

        }
        else
        {
            Debug.Log("WRONG answer");
                }
    }
    
}

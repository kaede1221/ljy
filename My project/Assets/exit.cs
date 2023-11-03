using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exit : MonoBehaviour
{
    [SerializeField] public string sceneName;
    [SerializeField] private string newScenePassword;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            PlayerMovement.instance.scenePassword = newScenePassword;
            SceneManager.LoadScene(sceneName);
            Debug.Log("goto the next");
        }
    }
}

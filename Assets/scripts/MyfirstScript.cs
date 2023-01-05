using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MyfirstScript : MonoBehaviour
{
    public Button button;
    public string newScene;

    private void Start()
    {
        button.onClick.AddListener(OnButtonClick); 
    }
    private void OnButtonClick()
    {
        Debug.Log("BUtton clicked");
        SceneManager.LoadScene(newScene);
    }
}

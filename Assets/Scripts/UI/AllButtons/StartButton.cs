using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public GameObject _gamelifeScore;
    public GameObject _startPanelUI;
    public void Startbutton()
    {
        GameObject.FindWithTag("StartUI").SetActive(false);
        _gamelifeScore.SetActive(true);
        
    }
}

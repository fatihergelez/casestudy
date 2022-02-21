using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Collect;
using UnityEngine.UI;

public class GameFinish : MonoBehaviour
{
    //Collect Gem kodumuzdaki Score de�i�kenine ula�t�k ve e�er 100 puan�n� ge�ersek, son ekran�m�z olan biti� ekran�n� aktif ettik.
    private CollectGem _finishGamePoint;
    public GameObject _gameFinishPanel;
    public GameObject _gameLiveScorePanel;
    private void Awake()
    {
        _finishGamePoint = GameObject.FindWithTag("player").GetComponent<CollectGem>();
    }
    void Update()
    {
        if (_finishGamePoint.Score >= 100)
        {
            _gameFinishPanel.SetActive(true);
            _gameLiveScorePanel.SetActive(false);
        }
    }
}

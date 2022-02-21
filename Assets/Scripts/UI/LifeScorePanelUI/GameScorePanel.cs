using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Collect;

public class GameScorePanel : MonoBehaviour
{
    //Oyun ekran�ndaki �st k�s�mdaki canl� skor k�sm�n� e�er 100 puana ula��rsak kapat.
    private CollectGem _gameFinishScore;
    private GameObject _gameLiveScorePanel;

    void Start()
    {
        _gameFinishScore = GameObject.FindWithTag("player").GetComponent<CollectGem>();
        _gameLiveScorePanel = GameObject.FindWithTag("gamelivescore");
    }


    void Update()
    {
        if (_gameFinishScore.Score >= 100)
        {
            _gameLiveScorePanel.SetActive(false);
        }
    }
}

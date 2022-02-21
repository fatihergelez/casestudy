using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Collect;

public class GameScorePanel : MonoBehaviour
{
    //Oyun ekranýndaki üst kýsýmdaki canlý skor kýsmýný eðer 100 puana ulaþýrsak kapat.
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

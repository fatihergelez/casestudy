using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Collect;

    public class GameScore : MonoBehaviour
    {
    //CollectGem kodumuzdaki Score deðiþkenimize ulaþýyoruz ve canlý olarak ScoreUI kýsmýna anlýk puanýmýzý yazdýrýyoruz.
    private CollectGem _gameScoreCollected;
    public Text _gameScoreUI;

       void Awake()
        {
            _gameScoreCollected = GameObject.FindWithTag("player").GetComponent<CollectGem>();
             GameObject.FindWithTag("gamelivescore").SetActive(false);
        }
        void Update()
        {
           _gameScoreUI.text = _gameScoreCollected.Score.ToString();
        }
    }



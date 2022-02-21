using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Collect;

    public class GameScore : MonoBehaviour
    {
    //CollectGem kodumuzdaki Score de�i�kenimize ula��yoruz ve canl� olarak ScoreUI k�sm�na anl�k puan�m�z� yazd�r�yoruz.
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



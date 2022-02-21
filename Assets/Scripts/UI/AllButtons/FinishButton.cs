using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishButton : MonoBehaviour
{
    //Oyun bitiþ panelimizi bulup kapatýyoruz, ardýndan yeni oyun sahnemizi yüklüyoruz.
    
    public void FinishGame()
    {
        GameObject.FindWithTag("finishpanel").SetActive(false);
        SceneManager.LoadScene("GameScene");
        
     
    }

}

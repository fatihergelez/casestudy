using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishButton : MonoBehaviour
{
    //Oyun biti� panelimizi bulup kapat�yoruz, ard�ndan yeni oyun sahnemizi y�kl�yoruz.
    
    public void FinishGame()
    {
        GameObject.FindWithTag("finishpanel").SetActive(false);
        SceneManager.LoadScene("GameScene");
        
     
    }

}

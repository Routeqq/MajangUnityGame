using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Move : MonoBehaviour{

    public void startButton(){
      SceneManager.LoadScene("StartGame");
    }
    public void GameGuide(){
      SceneManager.LoadScene("GameGuide");
    }
    public void MainMove(){
      SceneManager.LoadScene("Main");
    }

}

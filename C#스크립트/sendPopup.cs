using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sendPopup : MonoBehaviour{
  public static sendPopup instance;
  public Text sendPopupText;

  void Awake(){
    if (!instance) //정적으로 자신을 체크합니다.
    instance = this; //정적으로 자신을 저장합니다.
  }

  public void sendMessage(string str){
    sendPopupText.text = str; //텍스트에 반영합니다.
  }

}

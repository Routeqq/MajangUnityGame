using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mystock : MonoBehaviour{
  public static Mystock instance;
  public Text MystockText;
  public int SharpsstockNNN = 0;//갯수
  public int BookstockNNN = 0;
  public int PensStockNNN = 0;

  void Awake(){
    if (!instance) //정적으로 자신을 체크합니다.
    instance = this; //정적으로 자신을 저장합니다.
  }

  public void setSharpsstockNNN(int num){
    SharpsstockNNN = num;
  }
  public void setBookstockNNN(int num){
    BookstockNNN = num;
  }
  public void setPensStockNNN(int num){
    PensStockNNN = num;
  }

  void Update(){
    MystockText.text = "[ 보유 주식 수량 ]\n연필 | "+PensStockNNN+"\n공책 | "+BookstockNNN+"\n샤프 | "+SharpsstockNNN ; //텍스트에 반영합니다.
  }

}

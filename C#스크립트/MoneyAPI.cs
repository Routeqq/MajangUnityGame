using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoneyAPI : MonoBehaviour{
  public static MoneyAPI instance; //어디서나 접근할 수 있도록 static(정적)으로 자기 자신을 저장할 변수를 만듭니다.
  public Text MoneyText; //점수를 표시하는 Text객체를 에디터에서 받아옵니다.
  public int Money = 0; //돈을 관리합니다.
  public float time;

  randStock randStockk;//클래스 가져오기
  Mystock Mystockk;

  void Awake(){
      if (!instance) //정적으로 자신을 체크합니다.
      instance = this; //정적으로 자신을 저장합니다.
  }
  void Start(){
    randStockk = FindObjectOfType<randStock>();
    Mystockk = FindObjectOfType<Mystock>();
    if(Money == 0){
      Money += 1000;
      MoneyText.text = "내 돈 | " + Money + "원"; //텍스트에 반영합니다.

    }
  }``

  public void addMoney(int num){ //점수를 추가해주는 함수를 만들어 줍니다.{
      Money += num; //점수를 더해줍니다.
      MoneyText.text = "내 돈 | " + Money + "원"; //텍스트에 반영합니다.
  }
  public void reduceMoney(int num) {//점수를 추가해주는 함수를 만들어 줍니다.{
      Money += num; //점수를 더해줍니다.
      MoneyText.text = "내 돈 | " + Money + "원"; //텍스트에 반영합니다.
  }
  /********************************************************************************************/
  public void P_GButton() {//연필 구매
    if(0 < randStockk.PensStock){
    if(Money >= randStockk.PensStock){
      Money -= randStockk.PensStock;
      MoneyText.text = "내 돈 | " + Money + "원"; //텍스트에 반영합니다.
      Mystockk.PensStockNNN += 1;
      Mystockk.MystockText.text = "[ 보유 주식 수량 ]\n연필 | "+Mystockk.PensStockNNN+"\n공책 | "+Mystockk.BookstockNNN+"\n샤프 | "+Mystockk.SharpsstockNNN ;
      sendPopup.instance.sendMessage("[알림] 연필 주식을 성공적으로 구매 했습니다!");
    }else{
      sendPopup.instance.sendMessage("[알림] 돈이 부족합니다!");
    }
    }else{
      sendPopup.instance.sendMessage("[알림] 아직 주식 시장이 열리지 않았습니다!");
    }
  }
  public void P_SButton() {//연필 판매
    if(Mystockk.PensStockNNN > 0){
      Money += randStockk.PensStock;
      MoneyText.text = "내 돈 | " + Money + "원"; //텍스트에 반영합니다.
      Mystockk.PensStockNNN -= 1;
      Mystockk.MystockText.text = "[ 보유 주식 수량 ]\n연필 | "+Mystockk.PensStockNNN+"\n공책 | "+Mystockk.BookstockNNN+"\n샤프 | "+Mystockk.SharpsstockNNN ;
      sendPopup.instance.sendMessage("[알림] 연필 주식을 성공적으로 판매 했습니다!");
    }else{
      sendPopup.instance.sendMessage("[알림] 연필 주식이 부족합니다!");
    }
  }
  /********************************************************************************************/
  public void G_GButton() {//공책 구매
    if(0 < randStockk.Bookstock){
    if(Money >= randStockk.Bookstock){
      Money -= randStockk.Bookstock;
      MoneyText.text = "내 돈 | " + Money + "원"; //텍스트에 반영합니다.
      Mystockk.BookstockNNN += 1;
      Mystockk.MystockText.text = "[ 보유 주식 수량 ]\n연필 | "+Mystockk.PensStockNNN+"\n공책 | "+Mystockk.BookstockNNN+"\n샤프 | "+Mystockk.SharpsstockNNN ;
      sendPopup.instance.sendMessage("[알림] 공책 주식을 성공적으로 구매 했습니다!");
    }else{
      sendPopup.instance.sendMessage("[알림] 돈이 부족합니다!");
    }
    }else{
      sendPopup.instance.sendMessage("[알림] 아직 주식 시장이 열리지 않았습니다!");
    }
  }
  public void G_SButton() {//공책 판매
    if(Mystockk.BookstockNNN > 0){
      Money += randStockk.Bookstock;
      MoneyText.text = "내 돈 | " + Money + "원"; //텍스트에 반영합니다.
      Mystockk.BookstockNNN -= 1;
      Mystockk.MystockText.text = "[ 보유 주식 수량 ]\n연필 | "+Mystockk.PensStockNNN+"\n공책 | "+Mystockk.BookstockNNN+"\n샤프 | "+Mystockk.SharpsstockNNN ;
      sendPopup.instance.sendMessage("[알림] 공책 주식을 성공적으로 판매 했습니다!");
    }else{
      sendPopup.instance.sendMessage("[알림] 공책 주식이 부족합니다!");
    }
  }
  /********************************************************************************************/
  public void S_GButton() {//공책 구매
    if(0 < randStockk.Sharpsstock){
    if(Money >= randStockk.Sharpsstock){
      Money -= randStockk.Sharpsstock;
      MoneyText.text = "내 돈 | " + Money + "원"; //텍스트에 반영합니다.
      Mystockk.SharpsstockNNN += 1;
      Mystockk.MystockText.text = "[ 보유 주식 수량 ]\n연필 | "+Mystockk.PensStockNNN+"\n공책 | "+Mystockk.BookstockNNN+"\n샤프 | "+Mystockk.SharpsstockNNN ;
      sendPopup.instance.sendMessage("[알림] 공책 주식을 성공적으로 구매 했습니다!");
    }else{
      sendPopup.instance.sendMessage("[알림] 돈이 부족합니다!");
    }
    }else{
      sendPopup.instance.sendMessage("[알림] 아직 주식 시장이 열리지 않았습니다!");
    }
  }
  public void S_SButton() {//공책 판매
    if(Mystockk.SharpsstockNNN > 0){
      Money += randStockk.Sharpsstock;
      MoneyText.text = "내 돈 | " + Money + "원"; //텍스트에 반영합니다.
      Mystockk.SharpsstockNNN -= 1;
      Mystockk.MystockText.text = "[ 보유 주식 수량 ]\n연필 | "+Mystockk.PensStockNNN+"\n공책 | "+Mystockk.BookstockNNN+"\n샤프 | "+Mystockk.SharpsstockNNN ;
      sendPopup.instance.sendMessage("[알림] 공책 주식을 성공적으로 판매 했습니다!");
    }else{
      sendPopup.instance.sendMessage("[알림] 공책 주식이 부족합니다!");
    }
  }
  /********************************************************************************************/
  void Update(){
    if(Money < randStockk.PensStock && Money < randStockk.Bookstock && Money < randStockk.Sharpsstock && Mystockk.PensStockNNN == 0 && Mystockk.BookstockNNN == 0 && Mystockk.SharpsstockNNN == 0 ){
      SceneManager.LoadScene("EndGame");
    }
  }
}

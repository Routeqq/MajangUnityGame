using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randStock : MonoBehaviour{

  public static randStock instance;
  public Text randStockText;
  public float time;
  public int PensStock = 0;//주식 가격
  public int Bookstock = 0;
  public int Sharpsstock = 0;



  void Awake(){
      if (!instance) //정적으로 자신을 체크합니다.
      instance = this; //정적으로 자신을 저장합니다.
  }


    void Update(){
      time += Time.deltaTime;

      if(time >= 10 && time <= 10.05){
        int NPensStockk = Random.Range(-100, 100);
        int NBookstockk = Random.Range(-100, 100);
        int NSharpsstockk = Random.Range(-100, 100);
        PensStock += NPensStockk;//연필
        Bookstock += NBookstockk;//책
        Sharpsstock += NSharpsstockk;//샤프
        time = 0;//다시주기
        randStockText.text = "[ 종목 ]\n연필 | "+PensStock+"원\n공책 | "+Bookstock+"원\n샤프 | "+Sharpsstock+"원" ; //텍스트에 반영합니다.
      }
      if(time >= 0 && time <= 0.5){
      if(Sharpsstock <= 0 ){//주식이 0밑으로 떨어졌을 때
        Mystock.instance.setSharpsstockNNN(0);//0으로 설정
        Sharpsstock = 0;
        randStockText.text = "[ 종목 ]\n연필 | "+PensStock+"원\n공책 | "+Bookstock+"원\n샤프 | "+Sharpsstock+"원" ; //텍스트에 반영합니다.

      }
      if(Bookstock <= 0){//주식이 0밑으로 떨어졌을 때
        Mystock.instance.setBookstockNNN(0);//0으로 설정
        Bookstock = 0;
        randStockText.text = "[ 종목 ]\n연필 | "+PensStock+"원\n공책 | "+Bookstock+"원\n샤프 | "+Sharpsstock+"원" ; //텍스트에 반영합니다.

      }
      if(PensStock <= 0){//주식이 0밑으로 떨어졌을 때
        Mystock.instance.setPensStockNNN(0);//0으로 설정
        PensStock = 0;
        randStockText.text = "[ 종목 ]\n연필 | "+PensStock+"원\n공책 | "+Bookstock+"원\n샤프 | "+Sharpsstock+"원" ; //텍스트에 반영합니다.
      }
      }
    }
   }

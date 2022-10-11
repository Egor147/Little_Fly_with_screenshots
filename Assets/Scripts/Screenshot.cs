using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screenshot : StartWork
{
    private int _number_of_current_scrinshot = 0;   //Счётчик скриншотов
    private bool _ready_for_new_screen = true;  //Флаг готовности к новому скриншоту
    private string[] Nulls = new string[]{"0","00","000","0000"};   //Массив возможного количества нулей в названии

    //Вызывается каждый кадр. Запускает корутину по мере готовности к новому скриншоту
    private void Update(){
        if (_go && _ready_for_new_screen){           
            StartCoroutine(DoScreen());
        }
    }

    //Метод возвращает количество разрядов счётчика скриншотов для нужного количества нулей в названии файла
    private int GetDischarge(int x){ return (int)Mathf.Log10(x)+1;}

    //Корутина обновляет счётчик кадров, даёт сиграл о готовности к новому скриншоту каждую секунду, а также запускает создание скриншота
    private IEnumerator DoScreen() 
    {
        _ready_for_new_screen = false;
        yield return new WaitForSeconds(1);
        _number_of_current_scrinshot++;
        StartCoroutine(TakePhoto());
        _ready_for_new_screen = true;
    }

    //Делает скриншот вида камеры и сохраняет в папку Screens с нужным названием
    private IEnumerator TakePhoto(){
        yield return new WaitForEndOfFrame();
        ScreenCapture.CaptureScreenshot("Assets/Screens/" + Nulls[4-GetDischarge(_number_of_current_scrinshot)] + _number_of_current_scrinshot.ToString() + ".png",1);
    }

}

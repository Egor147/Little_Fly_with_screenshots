using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFly : MonoBehaviour
{
    
    private Move _moveScript; //Скрипт для передачи сигнала о начале движения
    private Screenshot _screenshotScript;

    private void Start(){
        _moveScript = GetComponent<Move>();
        _screenshotScript = GetComponent<Screenshot>();
    }

    private void Update(){
        //Проверка нажатия клавиши начала движения
        if (Input.GetKeyDown(KeyCode.G)){
            _moveScript.SetGo(true); //Передача сигнала
            _screenshotScript.SetGo(true);
            Destroy(this); //Удаление экого скрипта с камеры из-за его дальнейшей ненужности
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : StartWork
{
    //Масштаб: 100 метров = 1 единица координат

    [SerializeField]private float _speed; //Скорость самолёта в км/ч

    private void Start(){
        _speed = (_speed*1000)/(60); //Перевод скорости из км/ч в м/с и подстраивание под взятый масштаб
    }
    
    private void Update(){
        CameraMove();
    }

    //Метод, реализующий движение камеры вперёд с заданной скоростью
    private void CameraMove(){
        if (transform.position.y > 0 && _go)
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
}

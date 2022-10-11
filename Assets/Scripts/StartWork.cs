using UnityEngine;

public class StartWork : MonoBehaviour
{
    protected bool _go = false;   //Флаг начала работы скрипта

    //Метод, принимающий из другого скрипта сигнал о необходимости начать работу
    public void SetGo(bool NewValue){
        _go = NewValue;
    }
}

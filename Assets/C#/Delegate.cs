using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegate : MonoBehaviour//ѧϰί�е�ʹ��
{
    delegate void Aws();
    Aws aws;
    void Start()//�����Ǵ���߼�������,ί���Ǵ�ŷ���������
    {
        aws = Run;
        aws += Run;
        aws += Run2;
        aws?.Invoke();//��������ж�ί���Ƿ�Ϊ���پ���ִ��Invoke
    }
    void Update()
    {
        
    }
    void Run()
    {
        Debug.Log("����1");
    }
    void Run2()
    {
        Debug.Log("����2");
    }
}

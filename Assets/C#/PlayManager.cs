using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayManager : MonoBehaviour
{
    public static PlayManager instance;//����
    int _gold;
    public int GoldSum { get { return _gold; } set { if ((_gold + value) > 0) { _gold = value; } } }
    public int EnemySum;
    void Start()
    {
        instance = this;
        GoldSum = 0;
        EnemySum = 0;
    }
    void Update()
    {

    }
    public void PlayGame()
    {
        //GameObject.Find(string ��������)���ҳ����ж�Ӧ�Ķ���
        //Transform.Find(string ��������)���ҵ�ǰ�����µĶ���

        UIManager.instance.UIPlayGameMenu.SetActive(false);//�ر���Ϸ��ʼ�˵�
        UIManager.instance.UIPlayMenu.SetActive(true);//������Ϸ�Ʒְ�˵�
        UIManager.instance.UIPlayMenu.transform.Find("EnemySum").GetComponent<Text>().text = $"��������: {EnemySum}";
        //ͨ��UIManager�ϵ�UIPlayMenu��transform�������Ӷ����ȡ���������ֵ����ͬ��
        UIManager.instance.UIPlayMenu.transform.Find("GoldSum").GetComponent<Text>().text = $"�������: {GoldSum}";
    }
}

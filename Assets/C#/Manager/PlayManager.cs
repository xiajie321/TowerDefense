using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayManager : MonoBehaviour
{
    public static PlayManager instance;//����
    [SerializeField]
    GameObject go1;
    void Start()
    {
        instance = this;
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
        UIManager.instance.UIPlayMenu.transform.Find("EnemySum").GetComponent<Text>().text = $"��������: {DataManager.instance.EnemySum}";
        //ͨ��UIManager�ϵ�UIPlayMenu��transform�������Ӷ����ȡ���������ֵ����ͬ��
        UIManager.instance.UIPlayMenu.transform.Find("GoldSum").GetComponent<Text>().text = $"�������: {DataManager.instance.GoldSum}";
        if(go1!=null) go1.SetActive(true);
    }
}

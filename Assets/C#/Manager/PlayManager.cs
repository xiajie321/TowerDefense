using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayManager : MonoBehaviour
{
    public static PlayManager instance;//����
    bool isPlay; //�ж���Ϸ�Ƿ�����
    [SerializeField]
    GameObject go1;
    Camera mainCamera;
    Ray ray;
    RaycastHit hit;
    void Start()
    {
        instance = this;
        mainCamera = Camera.main;
        
    }
    void Update()
    {
        if (!isPlay) return;
        ray = mainCamera.ScreenPointToRay(Input.mousePosition);//����Ļ������λ�÷���һ������ռ������
        if (Physics.Raycast(ray,out hit) && Input.GetMouseButtonDown(0))//Physics.Raycast(ray,out hit)������߼�⵽�������ķ���ֵ����true���ҽ���⵽�����崫��hit������
        {
            if (hit.transform.tag.Equals("FYT"))//�жϱ�ǩ�Ƿ�ΪFYT�ǵĻ���ִ������ķ���
            {
                UIManager.instance.UISelect.transform.position = mainCamera.WorldToScreenPoint(hit.transform.position);//����������תΪ��Ļ����󴫸�UI
                UIManager.instance.UISelect.SetActive(true);
            }
        }
        else if(Input.GetMouseButtonDown(0))
        {
            UIManager.instance.UISelect.SetActive(false);
        }
    }
    public void PlayGame()
    {
        //GameObject.Find(string ��������)���ҳ����ж�Ӧ�Ķ���
        //Transform.Find(string ��������)���ҵ�ǰ�����µĶ���
        isPlay = true;
        UIManager.instance.UIPlayGameMenu.SetActive(false);//�ر���Ϸ��ʼ�˵�
        UIManager.instance.UIPlayMenu.SetActive(true);//������Ϸ�Ʒְ�˵�
        UIManager.instance.UIPlayMenu.transform.Find("EnemySum").GetComponent<Text>().text = $"��������: {DataManager.instance.EnemySum}";
        //ͨ��UIManager�ϵ�UIPlayMenu��transform�������Ӷ����ȡ���������ֵ����ͬ��
        UIManager.instance.UIPlayMenu.transform.Find("GoldSum").GetComponent<Text>().text = $"�������: {DataManager.instance.GoldSum}";
        if(go1!=null) go1.SetActive(true);

    }
}

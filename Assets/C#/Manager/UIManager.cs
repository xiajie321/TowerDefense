using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    //--Ԥ����
    [SerializeField]
    GameObject PUIPlayGameMenu;//Ԥ����
    //--����
    GameObject LsGameObject;//��ʱ�洢����
    public GameObject UIPlayGameMenu;//��Ϸ��ʼ�˵�
    public GameObject UIPlayMenu;//��ʼ��Ĳ˵�
    void Start()
    {
        instance = this;
        if(PUIPlayGameMenu != null)
        {
            LsGameObject = Instantiate(PUIPlayGameMenu); //Instantiateͨ��Ԥ�������ɶ��󷵻ص�ֵ��Ԥ���������ڳ����еĶ���
            UIPlayGameMenu = LsGameObject.transform.Find("UIPlayGameMenu").gameObject; 
            //ͨ���洢��LsGameObject�еĶ���ȥ��ȡ���Ӷ��󲢸���UIPlayGameMenu����ͬ��
            UIPlayMenu = LsGameObject.transform.Find("UIPlayMenu").gameObject;
            UIPlayGameMenu.transform.Find("Play").GetComponent<Button>().onClick.AddListener(() =>
            {
                PlayManager.instance.PlayGame();
            });
        }
        }
    void Update()
    {
        
    }
}

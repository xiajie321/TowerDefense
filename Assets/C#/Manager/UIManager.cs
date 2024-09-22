using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    //--预制体
    [SerializeField]
    GameObject PUIPlayGameMenu;//预制体
    //--变量
    GameObject LsGameObject;//临时存储对象
    public GameObject UIPlayGameMenu;//游戏开始菜单
    public GameObject UIPlayMenu;//开始后的菜单
    void Start()
    {
        instance = this;
        if(PUIPlayGameMenu != null)
        {
            LsGameObject = Instantiate(PUIPlayGameMenu); //Instantiate通过预制体生成对象返回的值是预制体生成在场景中的对象
            UIPlayGameMenu = LsGameObject.transform.Find("UIPlayGameMenu").gameObject; 
            //通过存储在LsGameObject中的对象去获取其子对象并赋予UIPlayGameMenu以下同理
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

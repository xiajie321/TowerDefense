using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;
    int _gold;
    public int GoldSum { get { return _gold; } set { if ((_gold + value) > 0) { _gold = value; } } }
    public int EnemySum { get; set; }
    void Start()
    {
        instance = this;
    }
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameObject("GameManager").AddComponent<GameManager>();
            }
            return _instance;
        }
    }

    public Character Player { get; set; }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (_instance != null)
            {
                Destroy(gameObject);
            }
        }

        SetData();
    }


    public void SetData()
    {
        Player = new Character(
            "Chad", //name
            "�ڵ��� �뿹�� ���� 10��¥�� �Ǵ� �ӽ��Դϴ�. ���õ� ����ϸ� ���Ƽ� ġŲ�� ��ų���� �𸥴ٴ� ������ ����� Ű�� �ֳ׿�.", //des
            10, // lv
            12, // maxexp
            9, // exp
            35, // atk
            40, // def
            100, // hp
            25, // cri
            2000, // gold
            0, // modifier
            0,
            0,
            0,
            UIManager.Instance.UIInventory);
        Debug.Log(Player.Name);
    }
}

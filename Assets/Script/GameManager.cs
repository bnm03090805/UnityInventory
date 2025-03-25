using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    Button btn;

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
    public List<Item> Items { get; set; }

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

    private void Start()
    {
        btn = GameObject.Find("ItemBtn").GetComponent<Button>();
        Debug.Log(btn);
        btn.onClick.AddListener(Player.AddItem);
    }

    public void SetData()
    {
        Items = new List<Item>();

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
        

        Items.Add(new Item(
            "��", // name
            "���Դϴ�", // des
            Resources.Load<Sprite>("Icon/sword"), //icon
            ItemType.Weapon, // type
            10f, // atk
            0f, // def
            0f, // hp
            5f,// cri
            false)); // isequip 
        Items.Add(new Item(
            "�κ�",
            "�κ��Դϴ�",
            Resources.Load<Sprite>("Icon/cloaks"), //icon))
            ItemType.Armor,
            0f, 10f, 20f, 0f, false));
        Items.Add(new Item(
            "�����",
            "������Դϴ�",
            Resources.Load<Sprite>("Icon/necklace"),
            ItemType.Ac,
            3f, 2f, 10f, 5f, false));
        Items.Add(new Item(
            "����",
            "�����Դϴ�",
            Resources.Load<Sprite>("Icon/helmets"),
            ItemType.Helmet,
            0f, 20f, 30f, 0f, false));


    }
}

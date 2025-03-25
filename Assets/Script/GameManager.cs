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
            "코딩의 노예가 된지 10년짜리 되는 머슴입니다. 오늘도 밤샘일만 남아서 치킨을 시킬지도 모른다는 생각에 배민을 키고 있네요.", //des
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
            "검", // name
            "검입니다", // des
            Resources.Load<Sprite>("Icon/sword"), //icon
            ItemType.Weapon, // type
            10f, // atk
            0f, // def
            0f, // hp
            5f,// cri
            false)); // isequip 
        Items.Add(new Item(
            "로브",
            "로브입니다",
            Resources.Load<Sprite>("Icon/cloaks"), //icon))
            ItemType.Armor,
            0f, 10f, 20f, 0f, false));
        Items.Add(new Item(
            "목걸이",
            "목걸이입니다",
            Resources.Load<Sprite>("Icon/necklace"),
            ItemType.Ac,
            3f, 2f, 10f, 5f, false));
        Items.Add(new Item(
            "투구",
            "투구입니다",
            Resources.Load<Sprite>("Icon/helmets"),
            ItemType.Helmet,
            0f, 20f, 30f, 0f, false));


    }
}

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
        Debug.Log(Player.Name);
    }
}

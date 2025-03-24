using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int Level { get; private set; }
    public int MaxExp {  get; private set; }
    public int Exp { get; private set; }
    public float Atk { get; private set; }
    public float Def { get; private set; }
    public float HP { get; private set; }
    public float Critical { get; private set; }
    public float Gold { get; private set; }

    public float AtkModifier { get; private set; }
    public float DefModifier { get; private set; }
    public float HPModifier { get; private set; }
    public float CriticalModifier { get; private set; }

    public Character()
    {
        Debug.Log("캐릭터 생성됨");
        this.Name = "Chad";
        this.Description = "코딩의 노예가 된지 10년짜리 되는 머슴입니다. 오늘도 밤샘일만 남아서 치킨을 시킬지도 모른다는 생각에 배민을 키고 있네요.";
        this.Level = 10;
        this.MaxExp = 12;
        this.Exp = 9;
        this.Atk = 35f;
        this.Def = 40f;
        this.HP = 100f;
        this.Critical = 25f;
        this.Gold = 2000;
    }

    
}

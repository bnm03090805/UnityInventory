using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float Atk { get; set; } = 35f;
    public float Def { get; set; } = 40f;
    public float HP { get; set; } = 100f;
    public float Critical { get; set; } = 25f;
    public float Gold { get; set; } = 2000f;

    public float AtkModifier { get; set; }
    public float DefModifier { get; set; }
    public float HPModifier { get; set; }
    public float CriticalModifier {  get; set; }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

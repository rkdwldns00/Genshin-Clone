using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct AttackData
{
    public GameObject attackPrefab;
    public DamageData damage;
    public float delay;
}

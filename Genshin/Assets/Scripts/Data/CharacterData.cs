using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Character Data",menuName ="Scriptable Object/Character Data",order = int.MaxValue)]
public class CharacterData : ScriptableObject
{
    [SerializeField] string characterName;
    public string CharacterName { get { return characterName; }}


    [SerializeField] int hp;
    public int HP { get { return hp; }}


    [SerializeField] int atk;
    public int Atk { get { return atk; }}


    [SerializeField] DamageData[] attackDamages;
    public DamageData[] AttackDatas { get { return attackDamages; }}


    [SerializeField] DamageData[] skillValues;
    public DamageData[] SkillValues { get { return skillValues; }}


    [SerializeField] DamageData[] ultimateSkillValues;
    public DamageData[] UltimateSkillValues { get { return ultimateSkillValues; }}
}

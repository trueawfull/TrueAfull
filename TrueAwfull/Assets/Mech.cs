using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Mech", menuName = "Mechs/MechData", order = 1)]
public class Mech : ScriptableObject
{
    public string name;
    public Transform model;
    public string weightClass;
    public float health;
    public float fuel;
    public float fuelRate;
    public Gun[] primaryWeapons;
    public Gun[] secondaryWeapons;
    public float dodgeTime;
    public float flyTime;
}

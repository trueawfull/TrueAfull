using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Gun", menuName = "Mechs/GunData", order = 1)]
public class Gun : ScriptableObject
{
    public string name;
    public Transform model;
    public int magSize;
    public float damage;
}

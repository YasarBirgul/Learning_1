﻿using Data.ValueObject;
using UnityEngine;

namespace Data.UnityObject
{
    [CreateAssetMenu(fileName = "CD_Player", menuName = "Learning1/CD_Player", order = 0)]
    public class CD_Player : ScriptableObject
    {
        public PlayerData playerData;
    }
}
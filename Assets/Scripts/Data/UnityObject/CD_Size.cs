using System.Collections.Generic;
using UnityEngine;
using Data.ValueObject;

namespace Data.UnityObject
{
    [CreateAssetMenu(fileName = "CD_Size", menuName = "Learning1/CD_Size", order = 0)]
    public class CD_Size : ScriptableObject
    {
        public List<GameObject> cubes;
        public SizeList sizeList;
        public List<Vector3> PositionList;
    }
}
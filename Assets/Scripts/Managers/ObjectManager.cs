using System;
using System.Collections.Generic;
using Data.UnityObject;
using Unity.Mathematics;
using UnityEngine;

namespace Managers
{
   public class ObjectManager : MonoBehaviour
   { 
       private int CubeID;
       private CD_Size CdSize;
       private List<GameObject> cubes;
       private void Awake()
       {
           
       }
       void InstatiateCubes(int cubeID)
       {
          // Instantiate(CdSize.cubes[cubeID], CdSize.PositionList[cubeID], quaternion.identity);
       }

       private void OnEnable()
       {
           SubscribeEvent();
       }

       void SubscribeEvent()
       {
           
       } 
       void UnSubscribeEvent()
       {
           
       }

       private void OnDisable()
       {
           UnSubscribeEvent();
       }
   } 
}


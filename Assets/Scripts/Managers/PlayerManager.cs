using Data.ValueObject;
using UnityEngine;
using Controllers;

namespace Managers
{
    public class PlayerManager : MonoBehaviour
    {
        #region Public Variables
        [Header("Data")] public PlayerData PlayerData;
        
        #endregion
        
        #region Serialized Variables
     
        [Space] [SerializeField] private PlayerMovementController movementController;
        
        #endregion

        private Rigidbody _rigidbody;
    }
}


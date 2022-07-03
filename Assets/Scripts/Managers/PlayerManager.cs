using Data.ValueObject;
using UnityEngine;
using Controllers;
using Signals;

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


        #region EventSubscription
        
        private void OnEnable()
        {
            SubscribeEvents();
        }

        private void SubscribeEvents()
        {
            InputSignals.Instance.onInputTaken += ActivateMovement;
        }

        private void UnsubscribeEvents()
        {
            
            InputSignals.Instance.onInputTaken -= ActivateMovement;
        }

        private void OnDisable()
        {
            UnsubscribeEvents();
        }
        #endregion



        void ActivateMovement()
        {
            movementController.EnableMovement();
        }

    }
}


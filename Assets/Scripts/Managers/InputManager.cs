using System;
using Data.UnityObject;
using Data.ValueObject;
using Keys;
using Signals;
using UnityEngine;

namespace Managers
{
    public class InputManager : MonoBehaviour
    {
        [Header("Data")] public InputData Data;

        [SerializeField] private bool isReadyToMove, isFirstTimeTouchTaken;


        private void Awake()
        {
           Data.InputValues = GetInput();
        }
        private Vector2 GetInput() => new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        
        
        #region Event Subscriptions

        private void OnEnable()
        {
            SubscribeEvents();
        }

        private void SubscribeEvents()
        {
            InputSignals.Instance.onInputTaken += OnInputTaken;

        }

        private void UnsubscribeEvents()
        {
            
            InputSignals.Instance.onInputTaken -= OnInputTaken;
        }

        private void OnDisable()
        {
            UnsubscribeEvents();
        }

        #endregion


        private void Update()
        {

            if (isReadyToMove)
            {
                 InputSignals.Instance.onInputDragged?.Invoke(new InputParams()
                            {
                                values = GetInput()
                            }
                                );
            }
            
           

        }
        void OnInputTaken()
        {
            isReadyToMove = true;

        }

        void OnDisableInput()
        {
            isReadyToMove = false;
        }
        
    }
}
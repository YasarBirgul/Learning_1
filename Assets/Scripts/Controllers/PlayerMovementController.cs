using Data.ValueObject;
using Keys;
using Managers;
using Signals;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Controllers
{
    public class PlayerMovementController
    {

        [SerializeField] private PlayerManager manager;
        [SerializeField] private Rigidbody rigidbody;

        [Header("Data")] [ShowInInspector] private MovementData playerMovementData;
        [ShowInInspector] private bool _isReadyToMove;
        [ShowInInspector] private InputParams _inputValue;

        
        
        
        private void SubscribeEvents()
        {
            InputSignals.Instance.onInputDragged += UpdateInputValue;
        }
        
        private void UnSubscribeEvents()
        {
            InputSignals.Instance.onInputDragged -= UpdateInputValue;
        }

        private void OnEnable()
        {
            SubscribeEvents();
        }

        private void OnDisable()
        {
            UnSubscribeEvents();
        
        }
        

        public void SetMovementData(MovementData dataMovementData)
        {
            playerMovementData = dataMovementData;
        }

        public void EnableMovement()
        {
            _isReadyToMove = true;
        }

        public void DeactiveMovement()
        {
            _isReadyToMove = false;
        }


        private void FixedUpdate()
        {
            if (_isReadyToMove)
            {
                Move();
            }
            else
            {
                Stop();
            }
        }

        public void UpdateInputValue(InputParams inputParams)
        {
            _inputValue = inputParams;
        }

        void Move()
        {
            rigidbody.velocity = new Vector3(_inputValue.values.x*playerMovementData.speed,rigidbody.velocity.y,_inputValue.values.y*playerMovementData.speed);
        }
        
        private void Stop()
        {
            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;

        }
        
    }
}
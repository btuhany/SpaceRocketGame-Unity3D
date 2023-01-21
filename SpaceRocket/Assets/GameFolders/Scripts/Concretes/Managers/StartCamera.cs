using Cinemachine;
using Controllers;
using Inputs;
using Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

namespace Managers
{
    public class StartCamera : MonoBehaviour
    {
        [SerializeField] Transform _inGameCamera;
        [SerializeField] float _positionTransitionSpeed;
        [SerializeField] float _quaternionTransitionSpeed;
        [SerializeField] float _distanceLevel;
        [SerializeField] PlayerController _player;
        [SerializeField] GameObject WarningText;
        DefaultInput _input;
        bool _cameraTransition;
        bool _isCameraTransitionFinished;
        public static StartCamera Instance { get; private set; }
        public bool IsCameraTransitionFinished { get => _isCameraTransitionFinished; set => _isCameraTransitionFinished = value; }

        //private void Awake()
        //{
        //    SingletonThisGameObject();
        //}
        //private void SingletonThisGameObject()
        //{
        //    if (Instance == null)
        //    {
        //        Instance = this;

        //    }
        //    else
        //    {
        //        Destroy(this.gameObject);
        //    }
        //}
        private void Awake()
        {
            _input = new DefaultInput();
        }
        private void Update()
        {
            if (_isCameraTransitionFinished)
            {
                gameObject.GetComponent<CinemachineBrain>().enabled = true;
                Destroy(gameObject.GetComponent<StartCamera>());
            }
            if ( _input.IsEngineUp && !_isCameraTransitionFinished)
            {
                _cameraTransition = true;
                _player.CanMove = false;
                WarningText.SetActive(false);
            }
            if (_cameraTransition)
            {
                Vector3 startPosition = Vector3.Lerp(transform.position, _inGameCamera.position, _positionTransitionSpeed * Time.deltaTime);
                Quaternion startRotation = Quaternion.Lerp(transform.rotation, _inGameCamera.rotation, _quaternionTransitionSpeed * Time.deltaTime);
                transform.position = startPosition;
                transform.rotation = startRotation;
                if (Vector3.one.magnitude * _distanceLevel > (transform.position - _inGameCamera.position).magnitude)
                {
                    Debug.Log("Camera transition finished");
                    _isCameraTransitionFinished = true;
                    _cameraTransition = false;
                    _player.CanMove = true;
                }
            }
        }

    }
}


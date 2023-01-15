using Cinemachine;
using Controllers;
using Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Managers
{
    public class StartCamera : MonoBehaviour
    {
        [SerializeField] Transform _inGameCamera;
        [SerializeField] float _transitionSpeed;
        [SerializeField] float _distanceLevel;
        [SerializeField] PlayerController _player;
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
        private void Update()
        {
            if (_isCameraTransitionFinished)
            {
                gameObject.GetComponent<CinemachineBrain>().enabled = true;
                Destroy(gameObject.GetComponent<StartCamera>());
            }
            if (Input.anyKeyDown && !_isCameraTransitionFinished)
            {
                _cameraTransition = true;
                _player.CanMove = false;
            }
            if (_cameraTransition)
            {
                Vector3 startPosition = Vector3.Lerp(transform.position, _inGameCamera.position, _transitionSpeed * Time.deltaTime);
                transform.position = startPosition;
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


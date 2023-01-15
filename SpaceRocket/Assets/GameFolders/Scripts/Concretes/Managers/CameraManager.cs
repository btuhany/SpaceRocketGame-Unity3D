using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Managers
{
    public class CameraManager : MonoBehaviour
    {
        [SerializeField] Transform _playerTransform;
        [SerializeField] private float _lerpTime;
        [SerializeField] float _cameraLimitAtZ;
        private Vector3 _offset;

        private void Start()
        {
            _offset = transform.position - _playerTransform.position;
        }

        private void LateUpdate()
        {
            Vector3 playerPositionFreezingZ = _playerTransform.position;
            if (playerPositionFreezingZ.z >= _cameraLimitAtZ)
            {
                playerPositionFreezingZ.z = _cameraLimitAtZ;
            }



            Vector3 _newPosition = Vector3.Lerp(transform.position, playerPositionFreezingZ + _offset, _lerpTime * Time.deltaTime);
            transform.position = _newPosition;
        }
    }
}


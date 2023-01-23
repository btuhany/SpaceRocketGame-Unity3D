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
        [SerializeField] float _cameraChangeAtY;
        [SerializeField] float _cameraPosChangeForY;

        private Vector3 _offset;
        private bool _flag;
        
        private void Start()
        {
            _offset = transform.position - _playerTransform.position;
        }

        private void LateUpdate()
        {
            Vector3 playerPositionFreezingZ = _playerTransform.position;
            
            //Manuel sound fade control :( because audio clips in the same gameobject.
            if (_playerTransform.position.z >= _cameraLimitAtZ*1.3f)
            {
                SoundManager.Instance.SetVolume(0, 0.35f);
            }
            if (_playerTransform.position.z >= _cameraLimitAtZ * 1.6f)
            {
                SoundManager.Instance.SetVolume(0, 0.22f);
            }
            if (_playerTransform.position.z >= _cameraLimitAtZ * 2f)
            {
                SoundManager.Instance.SetVolume(0, 0.11f);
            }
            if (playerPositionFreezingZ.z >= _cameraLimitAtZ)
            {
                playerPositionFreezingZ.z = _cameraLimitAtZ;
            }
            else
            {
                SoundManager.Instance.SetVolume(0, 0.5f);
            }
            transform.position = Vector3.Lerp(transform.position, playerPositionFreezingZ + _offset, _lerpTime * Time.deltaTime);


            newPositionAtY(_cameraChangeAtY, _cameraPosChangeForY);
        }


        void newPositionAtY(float yLimit, float y)   //May not be the optimum way!!!!
        {
            if(yLimit>0)
            {
                if (_playerTransform.position.y > yLimit)
                {
                    if (!_flag)
                    {
                        _offset.y += y;
                        _flag = true;
                    }
                }
                else
                {
                    if (_flag)
                    {
                        _offset.y -= y;
                        _flag = false;
                    }
                }
            }


        }
    }
}


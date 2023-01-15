using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCamera : MonoBehaviour
{
    [SerializeField] Transform _inGameCamera;
    [SerializeField] float _transitionSpeed;
    bool _cameraTransition;
    bool _cameraTransitionFinished;

    private void Update()
    {
        if(Input.anyKeyDown && !_cameraTransitionFinished)
        {
            _cameraTransition = true;
        }
        if(_cameraTransition)
        {
            Vector3 startPosition = Vector3.Lerp(transform.position, _inGameCamera.position, _transitionSpeed * Time.deltaTime);
            transform.position = startPosition;
            if(Vector3.one.magnitude*0.5f > (transform.position-_inGameCamera.position).magnitude)
            {
                Debug.Log("tamamdir");
                _cameraTransitionFinished = true;
                _cameraTransition= false;
            }
        }
        if (_cameraTransitionFinished)
        {
            gameObject.GetComponent<CinemachineBrain>().enabled = true;
            Destroy(gameObject.GetComponent<StartCamera>());
        }


    }

}

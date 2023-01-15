using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Inputs
{
    public class DefaultInput
    {
        DefaultActions _input;

        public bool IsEngineUp { get; private set; }
        public float RotateLeftRight { get; private set; }
        public float RotateFrontBack { get; private set; }
        public bool Restart { get; private set; }
        public DefaultInput()
        {
            _input= new DefaultActions();

            _input.Rocket.EngineUp.performed += context => IsEngineUp = context.ReadValueAsButton();
            _input.Rocket.RotateZ.performed += context => RotateLeftRight = context.ReadValue<float>();
            _input.Rocket.RotateX.performed += context => RotateFrontBack = context.ReadValue<float>();
            _input.Rocket.Restart.performed += context => Restart = context.ReadValueAsButton();
            _input.Enable();
        }
    }

    //void EngineUpOnPerformed (InputAction.CallbackContext context)

}

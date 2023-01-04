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
        public DefaultInput()
        {
            _input= new DefaultActions();

            _input.Rocket.EngineUp.performed += context => IsEngineUp = context.ReadValueAsButton();

            _input.Enable();
        }
    }

    //void EngineUpOnPerformed (InputAction.CallbackContext context)

}

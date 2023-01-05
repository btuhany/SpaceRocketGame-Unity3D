//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/GameFolders/Scripts/Concretes/Inputs/DefaultActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Inputs
{
    public partial class @DefaultActions : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @DefaultActions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""DefaultActions"",
    ""maps"": [
        {
            ""name"": ""Rocket"",
            ""id"": ""e302a7ad-932a-49f5-9d08-e8a6e6a225e1"",
            ""actions"": [
                {
                    ""name"": ""EngineUp"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5b01930d-e7c2-4020-a5db-b825e54d1103"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RotateZ"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4bff1747-bbef-4b54-8928-0f9fa6590ff8"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RotateX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7a6c1a3f-5da5-4fee-9c6b-4814986cad33"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""131993fe-1ca1-4a93-9580-8cf8f641b7ce"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EngineUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Z Axis"",
                    ""id"": ""14cf3b94-d9d0-4e82-afa4-86fc942778aa"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateZ"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""49de1a94-4705-45bb-8604-d73fcd03f4bc"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""0f7f63ed-d5f2-4ad7-81fa-4ce42d767d5b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""e115fa76-4309-478d-a784-91d0cf79a74c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateX"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f0ff460d-c1e5-4376-be9f-802c79b9dac3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""dc9b5835-c568-48db-9ca2-73fc08512227"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Rocket
            m_Rocket = asset.FindActionMap("Rocket", throwIfNotFound: true);
            m_Rocket_EngineUp = m_Rocket.FindAction("EngineUp", throwIfNotFound: true);
            m_Rocket_RotateZ = m_Rocket.FindAction("RotateZ", throwIfNotFound: true);
            m_Rocket_RotateX = m_Rocket.FindAction("RotateX", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }
        public IEnumerable<InputBinding> bindings => asset.bindings;

        public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return asset.FindAction(actionNameOrId, throwIfNotFound);
        }
        public int FindBinding(InputBinding bindingMask, out InputAction action)
        {
            return asset.FindBinding(bindingMask, out action);
        }

        // Rocket
        private readonly InputActionMap m_Rocket;
        private IRocketActions m_RocketActionsCallbackInterface;
        private readonly InputAction m_Rocket_EngineUp;
        private readonly InputAction m_Rocket_RotateZ;
        private readonly InputAction m_Rocket_RotateX;
        public struct RocketActions
        {
            private @DefaultActions m_Wrapper;
            public RocketActions(@DefaultActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @EngineUp => m_Wrapper.m_Rocket_EngineUp;
            public InputAction @RotateZ => m_Wrapper.m_Rocket_RotateZ;
            public InputAction @RotateX => m_Wrapper.m_Rocket_RotateX;
            public InputActionMap Get() { return m_Wrapper.m_Rocket; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(RocketActions set) { return set.Get(); }
            public void SetCallbacks(IRocketActions instance)
            {
                if (m_Wrapper.m_RocketActionsCallbackInterface != null)
                {
                    @EngineUp.started -= m_Wrapper.m_RocketActionsCallbackInterface.OnEngineUp;
                    @EngineUp.performed -= m_Wrapper.m_RocketActionsCallbackInterface.OnEngineUp;
                    @EngineUp.canceled -= m_Wrapper.m_RocketActionsCallbackInterface.OnEngineUp;
                    @RotateZ.started -= m_Wrapper.m_RocketActionsCallbackInterface.OnRotateZ;
                    @RotateZ.performed -= m_Wrapper.m_RocketActionsCallbackInterface.OnRotateZ;
                    @RotateZ.canceled -= m_Wrapper.m_RocketActionsCallbackInterface.OnRotateZ;
                    @RotateX.started -= m_Wrapper.m_RocketActionsCallbackInterface.OnRotateX;
                    @RotateX.performed -= m_Wrapper.m_RocketActionsCallbackInterface.OnRotateX;
                    @RotateX.canceled -= m_Wrapper.m_RocketActionsCallbackInterface.OnRotateX;
                }
                m_Wrapper.m_RocketActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @EngineUp.started += instance.OnEngineUp;
                    @EngineUp.performed += instance.OnEngineUp;
                    @EngineUp.canceled += instance.OnEngineUp;
                    @RotateZ.started += instance.OnRotateZ;
                    @RotateZ.performed += instance.OnRotateZ;
                    @RotateZ.canceled += instance.OnRotateZ;
                    @RotateX.started += instance.OnRotateX;
                    @RotateX.performed += instance.OnRotateX;
                    @RotateX.canceled += instance.OnRotateX;
                }
            }
        }
        public RocketActions @Rocket => new RocketActions(this);
        public interface IRocketActions
        {
            void OnEngineUp(InputAction.CallbackContext context);
            void OnRotateZ(InputAction.CallbackContext context);
            void OnRotateX(InputAction.CallbackContext context);
        }
    }
}
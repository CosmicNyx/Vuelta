//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.2
//     from Assets/SCRIPTS/PlayerControls.inputactions
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

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Music"",
            ""id"": ""6363bd2b-5df2-4c8c-80b2-f2e66355785f"",
            ""actions"": [
                {
                    ""name"": ""sound1"",
                    ""type"": ""Button"",
                    ""id"": ""f1abfc0a-fa7d-4927-86f3-3f81ebed27e7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""sound2"",
                    ""type"": ""Button"",
                    ""id"": ""8127c74b-4389-4e2f-8587-e0e123893391"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""sound3"",
                    ""type"": ""Button"",
                    ""id"": ""f3520321-e658-460c-a1c6-d5b84fb934b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""sound4"",
                    ""type"": ""Button"",
                    ""id"": ""202a77d0-7b0a-448a-8ebd-8845511c0416"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""da4c1825-c9c7-48c6-ae51-da6623cdf32d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sound1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53cee1f1-62de-45fe-8fa9-a34207ebc891"",
                    ""path"": ""<XRController>{RightHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sound1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eca35c0d-e9ac-4d51-a0da-205f0493873f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sound2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97b31236-e819-4cb3-991d-e61e1bd031bb"",
                    ""path"": ""<XRController>{RightHand}/secondaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sound2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c4aa0831-22ec-4c3d-8a81-3c9d01440b6a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sound3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""36fbb3d3-b354-4554-a228-af1a7ee99912"",
                    ""path"": ""<XRController>{LeftHand}/primaryTouch"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sound3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e918f387-ed3f-4ad9-93e8-b3630cf00c1e"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sound4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""139762c0-2ee2-4454-912b-e780bfc55ec2"",
                    ""path"": ""<XRController>{LeftHand}/secondaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sound4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Music
        m_Music = asset.FindActionMap("Music", throwIfNotFound: true);
        m_Music_sound1 = m_Music.FindAction("sound1", throwIfNotFound: true);
        m_Music_sound2 = m_Music.FindAction("sound2", throwIfNotFound: true);
        m_Music_sound3 = m_Music.FindAction("sound3", throwIfNotFound: true);
        m_Music_sound4 = m_Music.FindAction("sound4", throwIfNotFound: true);
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

    // Music
    private readonly InputActionMap m_Music;
    private IMusicActions m_MusicActionsCallbackInterface;
    private readonly InputAction m_Music_sound1;
    private readonly InputAction m_Music_sound2;
    private readonly InputAction m_Music_sound3;
    private readonly InputAction m_Music_sound4;
    public struct MusicActions
    {
        private @PlayerControls m_Wrapper;
        public MusicActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @sound1 => m_Wrapper.m_Music_sound1;
        public InputAction @sound2 => m_Wrapper.m_Music_sound2;
        public InputAction @sound3 => m_Wrapper.m_Music_sound3;
        public InputAction @sound4 => m_Wrapper.m_Music_sound4;
        public InputActionMap Get() { return m_Wrapper.m_Music; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MusicActions set) { return set.Get(); }
        public void SetCallbacks(IMusicActions instance)
        {
            if (m_Wrapper.m_MusicActionsCallbackInterface != null)
            {
                @sound1.started -= m_Wrapper.m_MusicActionsCallbackInterface.OnSound1;
                @sound1.performed -= m_Wrapper.m_MusicActionsCallbackInterface.OnSound1;
                @sound1.canceled -= m_Wrapper.m_MusicActionsCallbackInterface.OnSound1;
                @sound2.started -= m_Wrapper.m_MusicActionsCallbackInterface.OnSound2;
                @sound2.performed -= m_Wrapper.m_MusicActionsCallbackInterface.OnSound2;
                @sound2.canceled -= m_Wrapper.m_MusicActionsCallbackInterface.OnSound2;
                @sound3.started -= m_Wrapper.m_MusicActionsCallbackInterface.OnSound3;
                @sound3.performed -= m_Wrapper.m_MusicActionsCallbackInterface.OnSound3;
                @sound3.canceled -= m_Wrapper.m_MusicActionsCallbackInterface.OnSound3;
                @sound4.started -= m_Wrapper.m_MusicActionsCallbackInterface.OnSound4;
                @sound4.performed -= m_Wrapper.m_MusicActionsCallbackInterface.OnSound4;
                @sound4.canceled -= m_Wrapper.m_MusicActionsCallbackInterface.OnSound4;
            }
            m_Wrapper.m_MusicActionsCallbackInterface = instance;
            if (instance != null)
            {
                @sound1.started += instance.OnSound1;
                @sound1.performed += instance.OnSound1;
                @sound1.canceled += instance.OnSound1;
                @sound2.started += instance.OnSound2;
                @sound2.performed += instance.OnSound2;
                @sound2.canceled += instance.OnSound2;
                @sound3.started += instance.OnSound3;
                @sound3.performed += instance.OnSound3;
                @sound3.canceled += instance.OnSound3;
                @sound4.started += instance.OnSound4;
                @sound4.performed += instance.OnSound4;
                @sound4.canceled += instance.OnSound4;
            }
        }
    }
    public MusicActions @Music => new MusicActions(this);
    public interface IMusicActions
    {
        void OnSound1(InputAction.CallbackContext context);
        void OnSound2(InputAction.CallbackContext context);
        void OnSound3(InputAction.CallbackContext context);
        void OnSound4(InputAction.CallbackContext context);
    }
}

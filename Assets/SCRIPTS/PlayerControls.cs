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
                    ""name"": ""play"",
                    ""type"": ""Button"",
                    ""id"": ""f1abfc0a-fa7d-4927-86f3-3f81ebed27e7"",
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
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""play"",
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
                    ""action"": ""play"",
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
        m_Music_play = m_Music.FindAction("play", throwIfNotFound: true);
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
    private readonly InputAction m_Music_play;
    public struct MusicActions
    {
        private @PlayerControls m_Wrapper;
        public MusicActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @play => m_Wrapper.m_Music_play;
        public InputActionMap Get() { return m_Wrapper.m_Music; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MusicActions set) { return set.Get(); }
        public void SetCallbacks(IMusicActions instance)
        {
            if (m_Wrapper.m_MusicActionsCallbackInterface != null)
            {
                @play.started -= m_Wrapper.m_MusicActionsCallbackInterface.OnPlay;
                @play.performed -= m_Wrapper.m_MusicActionsCallbackInterface.OnPlay;
                @play.canceled -= m_Wrapper.m_MusicActionsCallbackInterface.OnPlay;
            }
            m_Wrapper.m_MusicActionsCallbackInterface = instance;
            if (instance != null)
            {
                @play.started += instance.OnPlay;
                @play.performed += instance.OnPlay;
                @play.canceled += instance.OnPlay;
            }
        }
    }
    public MusicActions @Music => new MusicActions(this);
    public interface IMusicActions
    {
        void OnPlay(InputAction.CallbackContext context);
    }
}
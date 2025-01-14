//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Joicy/Controllers/UIActionMap.inputactions
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

public partial class @UIActionMap : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @UIActionMap()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""UIActionMap"",
    ""maps"": [
        {
            ""name"": ""In-Game"",
            ""id"": ""da1337d5-ead6-43fb-9ef4-c87c242d54c1"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""fb999455-1ca3-4b2c-bd92-0e9c92844136"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""OpenUpgradeTab"",
                    ""type"": ""Button"",
                    ""id"": ""5e77758c-0213-4791-9050-1baf04a09fa9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0783dc39-f4f8-4db1-93cc-23aa657ac34d"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0cd9acfc-9bd0-49b6-9a87-01d8cbf33fe8"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenUpgradeTab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // In-Game
        m_InGame = asset.FindActionMap("In-Game", throwIfNotFound: true);
        m_InGame_Pause = m_InGame.FindAction("Pause", throwIfNotFound: true);
        m_InGame_OpenUpgradeTab = m_InGame.FindAction("OpenUpgradeTab", throwIfNotFound: true);
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

    // In-Game
    private readonly InputActionMap m_InGame;
    private IInGameActions m_InGameActionsCallbackInterface;
    private readonly InputAction m_InGame_Pause;
    private readonly InputAction m_InGame_OpenUpgradeTab;
    public struct InGameActions
    {
        private @UIActionMap m_Wrapper;
        public InGameActions(@UIActionMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_InGame_Pause;
        public InputAction @OpenUpgradeTab => m_Wrapper.m_InGame_OpenUpgradeTab;
        public InputActionMap Get() { return m_Wrapper.m_InGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InGameActions set) { return set.Get(); }
        public void SetCallbacks(IInGameActions instance)
        {
            if (m_Wrapper.m_InGameActionsCallbackInterface != null)
            {
                @Pause.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnPause;
                @OpenUpgradeTab.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnOpenUpgradeTab;
                @OpenUpgradeTab.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnOpenUpgradeTab;
                @OpenUpgradeTab.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnOpenUpgradeTab;
            }
            m_Wrapper.m_InGameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @OpenUpgradeTab.started += instance.OnOpenUpgradeTab;
                @OpenUpgradeTab.performed += instance.OnOpenUpgradeTab;
                @OpenUpgradeTab.canceled += instance.OnOpenUpgradeTab;
            }
        }
    }
    public InGameActions @InGame => new InGameActions(this);
    public interface IInGameActions
    {
        void OnPause(InputAction.CallbackContext context);
        void OnOpenUpgradeTab(InputAction.CallbackContext context);
    }
}

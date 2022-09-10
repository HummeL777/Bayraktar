//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Joicy/Controllers/PlayerActionMap.inputactions
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

public partial class @PlayerActionMap : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActionMap()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActionMap"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""1a915606-dc40-4169-a393-79f41b8f9fc7"",
            ""actions"": [
                {
                    ""name"": ""Accelerating"",
                    ""type"": ""Value"",
                    ""id"": ""24e80ab1-0f7b-44f3-9223-50c47966fc43"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""b2f8bb3d-9fe8-40c8-8e06-5e93168b7c97"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerating"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ff3e56d3-897a-4172-a858-65c97922019a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerating"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9719bb95-a5c7-4cf1-9bf3-3ecab75d102e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerating"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Weapons"",
            ""id"": ""0b52b3fb-73db-4a12-af56-651c454d78a0"",
            ""actions"": [
                {
                    ""name"": ""ChooseNextWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""480a6d69-ec84-4723-b91e-5e07f3d5098e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ChoosePreviousWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""75105c75-dac1-4ccb-af09-8bcd9e4e967c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shooting"",
                    ""type"": ""Button"",
                    ""id"": ""aa9b5a5d-5209-406f-ac39-7e7a365e4a66"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""eaa666f9-a415-44da-83cf-602261c60a80"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChooseNextWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9804609d-d18b-4183-a79f-47cd11dacc12"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChoosePreviousWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc90bcc6-e3af-4691-9945-967c53eb21cb"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shooting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_Accelerating = m_Movement.FindAction("Accelerating", throwIfNotFound: true);
        // Weapons
        m_Weapons = asset.FindActionMap("Weapons", throwIfNotFound: true);
        m_Weapons_ChooseNextWeapon = m_Weapons.FindAction("ChooseNextWeapon", throwIfNotFound: true);
        m_Weapons_ChoosePreviousWeapon = m_Weapons.FindAction("ChoosePreviousWeapon", throwIfNotFound: true);
        m_Weapons_Shooting = m_Weapons.FindAction("Shooting", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_Accelerating;
    public struct MovementActions
    {
        private @PlayerActionMap m_Wrapper;
        public MovementActions(@PlayerActionMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Accelerating => m_Wrapper.m_Movement_Accelerating;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @Accelerating.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnAccelerating;
                @Accelerating.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnAccelerating;
                @Accelerating.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnAccelerating;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Accelerating.started += instance.OnAccelerating;
                @Accelerating.performed += instance.OnAccelerating;
                @Accelerating.canceled += instance.OnAccelerating;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Weapons
    private readonly InputActionMap m_Weapons;
    private IWeaponsActions m_WeaponsActionsCallbackInterface;
    private readonly InputAction m_Weapons_ChooseNextWeapon;
    private readonly InputAction m_Weapons_ChoosePreviousWeapon;
    private readonly InputAction m_Weapons_Shooting;
    public struct WeaponsActions
    {
        private @PlayerActionMap m_Wrapper;
        public WeaponsActions(@PlayerActionMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @ChooseNextWeapon => m_Wrapper.m_Weapons_ChooseNextWeapon;
        public InputAction @ChoosePreviousWeapon => m_Wrapper.m_Weapons_ChoosePreviousWeapon;
        public InputAction @Shooting => m_Wrapper.m_Weapons_Shooting;
        public InputActionMap Get() { return m_Wrapper.m_Weapons; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WeaponsActions set) { return set.Get(); }
        public void SetCallbacks(IWeaponsActions instance)
        {
            if (m_Wrapper.m_WeaponsActionsCallbackInterface != null)
            {
                @ChooseNextWeapon.started -= m_Wrapper.m_WeaponsActionsCallbackInterface.OnChooseNextWeapon;
                @ChooseNextWeapon.performed -= m_Wrapper.m_WeaponsActionsCallbackInterface.OnChooseNextWeapon;
                @ChooseNextWeapon.canceled -= m_Wrapper.m_WeaponsActionsCallbackInterface.OnChooseNextWeapon;
                @ChoosePreviousWeapon.started -= m_Wrapper.m_WeaponsActionsCallbackInterface.OnChoosePreviousWeapon;
                @ChoosePreviousWeapon.performed -= m_Wrapper.m_WeaponsActionsCallbackInterface.OnChoosePreviousWeapon;
                @ChoosePreviousWeapon.canceled -= m_Wrapper.m_WeaponsActionsCallbackInterface.OnChoosePreviousWeapon;
                @Shooting.started -= m_Wrapper.m_WeaponsActionsCallbackInterface.OnShooting;
                @Shooting.performed -= m_Wrapper.m_WeaponsActionsCallbackInterface.OnShooting;
                @Shooting.canceled -= m_Wrapper.m_WeaponsActionsCallbackInterface.OnShooting;
            }
            m_Wrapper.m_WeaponsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ChooseNextWeapon.started += instance.OnChooseNextWeapon;
                @ChooseNextWeapon.performed += instance.OnChooseNextWeapon;
                @ChooseNextWeapon.canceled += instance.OnChooseNextWeapon;
                @ChoosePreviousWeapon.started += instance.OnChoosePreviousWeapon;
                @ChoosePreviousWeapon.performed += instance.OnChoosePreviousWeapon;
                @ChoosePreviousWeapon.canceled += instance.OnChoosePreviousWeapon;
                @Shooting.started += instance.OnShooting;
                @Shooting.performed += instance.OnShooting;
                @Shooting.canceled += instance.OnShooting;
            }
        }
    }
    public WeaponsActions @Weapons => new WeaponsActions(this);
    public interface IMovementActions
    {
        void OnAccelerating(InputAction.CallbackContext context);
    }
    public interface IWeaponsActions
    {
        void OnChooseNextWeapon(InputAction.CallbackContext context);
        void OnChoosePreviousWeapon(InputAction.CallbackContext context);
        void OnShooting(InputAction.CallbackContext context);
    }
}
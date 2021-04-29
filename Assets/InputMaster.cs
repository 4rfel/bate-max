// GENERATED AUTOMATICALLY FROM 'Assets/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""e777b942-21d5-4a22-b44a-08dcbbd835a1"",
            ""actions"": [
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""Value"",
                    ""id"": ""7f987a4e-3fa2-490e-8a97-a6d0f359a3ac"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": ""Clamp(max=1)"",
                    ""interactions"": ""Hold(duration=0.1,pressPoint=0.1)""
                },
                {
                    ""name"": ""Break"",
                    ""type"": ""Value"",
                    ""id"": ""edcc0b89-157e-4037-83f6-998d7d4049dd"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeCam"",
                    ""type"": ""Button"",
                    ""id"": ""1015781b-1625-42bb-ba09-ac5af430c8b0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a586424e-5e99-4c24-adf2-aeb48909817b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""469186e7-9831-46d1-8f2c-65832288006d"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ControllerXBOX"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c309d9f4-6aa6-488a-afe4-9bdd07086e4b"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ControllerXBOX"",
                    ""action"": ""Break"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""10221f53-1b41-4af3-8a22-3772d1b13c74"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado"",
                    ""action"": ""Break"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ae495f9-d5f6-473e-b816-5d46f672f5d8"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado"",
                    ""action"": ""ChangeCam"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6226e193-8ef5-485c-8acc-8164dace3436"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ControllerXBOX"",
                    ""action"": ""ChangeCam"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""ControllerPS4"",
            ""bindingGroup"": ""ControllerPS4"",
            ""devices"": [
                {
                    ""devicePath"": ""<DualShockGamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""ControllerXBOX"",
            ""bindingGroup"": ""ControllerXBOX"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Teclado"",
            ""bindingGroup"": ""Teclado"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Accelerate = m_Player.FindAction("Accelerate", throwIfNotFound: true);
        m_Player_Break = m_Player.FindAction("Break", throwIfNotFound: true);
        m_Player_ChangeCam = m_Player.FindAction("ChangeCam", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Accelerate;
    private readonly InputAction m_Player_Break;
    private readonly InputAction m_Player_ChangeCam;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Accelerate => m_Wrapper.m_Player_Accelerate;
        public InputAction @Break => m_Wrapper.m_Player_Break;
        public InputAction @ChangeCam => m_Wrapper.m_Player_ChangeCam;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Accelerate.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAccelerate;
                @Accelerate.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAccelerate;
                @Accelerate.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAccelerate;
                @Break.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBreak;
                @Break.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBreak;
                @Break.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBreak;
                @ChangeCam.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeCam;
                @ChangeCam.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeCam;
                @ChangeCam.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeCam;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Accelerate.started += instance.OnAccelerate;
                @Accelerate.performed += instance.OnAccelerate;
                @Accelerate.canceled += instance.OnAccelerate;
                @Break.started += instance.OnBreak;
                @Break.performed += instance.OnBreak;
                @Break.canceled += instance.OnBreak;
                @ChangeCam.started += instance.OnChangeCam;
                @ChangeCam.performed += instance.OnChangeCam;
                @ChangeCam.canceled += instance.OnChangeCam;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_ControllerPS4SchemeIndex = -1;
    public InputControlScheme ControllerPS4Scheme
    {
        get
        {
            if (m_ControllerPS4SchemeIndex == -1) m_ControllerPS4SchemeIndex = asset.FindControlSchemeIndex("ControllerPS4");
            return asset.controlSchemes[m_ControllerPS4SchemeIndex];
        }
    }
    private int m_ControllerXBOXSchemeIndex = -1;
    public InputControlScheme ControllerXBOXScheme
    {
        get
        {
            if (m_ControllerXBOXSchemeIndex == -1) m_ControllerXBOXSchemeIndex = asset.FindControlSchemeIndex("ControllerXBOX");
            return asset.controlSchemes[m_ControllerXBOXSchemeIndex];
        }
    }
    private int m_TecladoSchemeIndex = -1;
    public InputControlScheme TecladoScheme
    {
        get
        {
            if (m_TecladoSchemeIndex == -1) m_TecladoSchemeIndex = asset.FindControlSchemeIndex("Teclado");
            return asset.controlSchemes[m_TecladoSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnAccelerate(InputAction.CallbackContext context);
        void OnBreak(InputAction.CallbackContext context);
        void OnChangeCam(InputAction.CallbackContext context);
    }
}

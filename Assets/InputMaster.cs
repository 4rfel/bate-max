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
                    ""expectedControlType"": """",
                    ""processors"": ""Clamp(max=1)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Break"",
                    ""type"": ""Value"",
                    ""id"": ""22e53ca6-c694-43d8-a8bb-a33bc71898f8"",
                    ""expectedControlType"": """",
                    ""processors"": ""Clamp(max=1)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeCam"",
                    ""type"": ""Button"",
                    ""id"": ""1015781b-1625-42bb-ba09-ac5af430c8b0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Turn"",
                    ""type"": ""Value"",
                    ""id"": ""7a2b81d0-82f8-4c90-b472-259fca0a57be"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Nitro"",
                    ""type"": ""Button"",
                    ""id"": ""5ab6a704-f1fd-4dd6-bf0d-c8afb3eea4b3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
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
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""ff5de195-b055-42cb-a33a-cccb3df5c082"",
                    ""path"": ""1DAxis(minValue=-100,maxValue=100)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ec1269e9-6541-49e4-96a3-1fa617fb81b7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ed66f130-a758-4457-ae26-b6e0ee7027a0"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ControllerXBOX"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""2ac16326-299b-4db1-8945-cc2be9209091"",
                    ""path"": ""1DAxis(minValue=-100,maxValue=100)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Break"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f834924e-10fd-4d64-9ecf-0f0b53b66cea"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado"",
                    ""action"": ""Break"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""242c241f-3444-466d-b779-2d1707342932"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ControllerXBOX"",
                    ""action"": ""Break"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""0ba1a52c-0279-4ac2-87d0-a470bbde1793"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""43eb2003-d558-42eb-a175-0cf505c039a1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8d4f6a29-e481-4d79-97cc-87d43bac4070"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""cb5c8e17-509f-47d1-86d1-ea3e63f8ebef"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ControllerXBOX"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""77fb4373-0ea6-42e0-9baf-2dbe089f0f81"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""082ba2ec-2cef-4b5e-bc51-8ddd4f09154f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado"",
                    ""action"": ""Nitro"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75523c9b-55cd-4349-bf59-e28cc8b95503"",
                    ""path"": ""<XInputController>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ControllerXBOX"",
                    ""action"": ""Nitro"",
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
        m_Player_Turn = m_Player.FindAction("Turn", throwIfNotFound: true);
        m_Player_Nitro = m_Player.FindAction("Nitro", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Turn;
    private readonly InputAction m_Player_Nitro;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Accelerate => m_Wrapper.m_Player_Accelerate;
        public InputAction @Break => m_Wrapper.m_Player_Break;
        public InputAction @ChangeCam => m_Wrapper.m_Player_ChangeCam;
        public InputAction @Turn => m_Wrapper.m_Player_Turn;
        public InputAction @Nitro => m_Wrapper.m_Player_Nitro;
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
                @Turn.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurn;
                @Turn.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurn;
                @Turn.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurn;
                @Nitro.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNitro;
                @Nitro.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNitro;
                @Nitro.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNitro;
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
                @Turn.started += instance.OnTurn;
                @Turn.performed += instance.OnTurn;
                @Turn.canceled += instance.OnTurn;
                @Nitro.started += instance.OnNitro;
                @Nitro.performed += instance.OnNitro;
                @Nitro.canceled += instance.OnNitro;
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
        void OnTurn(InputAction.CallbackContext context);
        void OnNitro(InputAction.CallbackContext context);
    }
}

using UnityEngine;
using Zenject;

public class CameraViewController : MonoBehaviour
{
    [SerializeField] private VoidEventChannel angleChanged = null;
    [SerializeField] private BoolEventChannel gameStateChanged = null;
    [SerializeField] private VoidEventChannel settingsChangedChannel = null;

    [SerializeField] private Camera mainCamera = null;
    [SerializeField] private float _zoomSensitivity = 1f;
    [SerializeField] private float _rotatingSensitivity = 1f;
    [SerializeField] private Vector3 _minAngles = Vector3.zero;
    [SerializeField] private Vector3 _maxAngles = Vector3.one;
    [SerializeField] private float _minZoom = 30;
    [SerializeField] private float _maxZoom = 60;

    [Inject] private SettingsData settingsData = null;

    private CameraActionMap _actionMap = null;

    public void SetStats(ZoomUpgrade stats)
    {
        _minZoom = stats.MinZoom;
        _maxZoom = stats.MaxZoom;
    }

    private void Awake()
    {
        gameStateChanged.ChannelEvent += OnGameStateChanged;
        settingsChangedChannel.ChannelEvent += OnSettingsChanged;

        Cursor.lockState = CursorLockMode.Locked;
        mainCamera = Camera.main;
        _actionMap = new CameraActionMap();

        ApplySettings();
    }

    private void OnEnable()
    {
        _actionMap?.Enable();
    }

    private void Update()
    {
        UpdateRotating(_actionMap.View.LookAround.ReadValue<Vector2>());
        UpdateZoom(_actionMap.View.Zoom.ReadValue<float>());
    }

    private void UpdateZoom(float delta)
    {
        float currentZoom = mainCamera.fieldOfView - delta * _zoomSensitivity;
        mainCamera.fieldOfView = Mathf.Clamp(currentZoom, _minZoom, _maxZoom);
    }

    private void UpdateRotating(Vector2 delta)
    {
        float sensitivity = _rotatingSensitivity * mainCamera.fieldOfView;
        Vector3 moving = new Vector3(delta.y * sensitivity, delta.x * sensitivity, 0f);
        Transform camera = mainCamera.transform;

        Vector3 currentAngles = camera.localEulerAngles + moving;
        currentAngles.x = Mathf.Clamp(currentAngles.x, _minAngles.x, _maxAngles.x);
        currentAngles.y = Mathf.Clamp(currentAngles.y, _minAngles.y, _maxAngles.y);

        camera.localEulerAngles = currentAngles;

        angleChanged.RaiseEvent();
    }

    private void ApplySettings()
    {
        _rotatingSensitivity = Mathf.Lerp(0.0005f, 0.005f, settingsData.Control.Sensitivity);
    }

    private void OnSettingsChanged()
    {
        ApplySettings();
    }

    private void OnGameStateChanged(bool resumed)
    {
        if (resumed)
        {
            _actionMap?.Enable();
        }
        else
        {
            _actionMap?.Disable();
        }
    }

    private void OnDisable()
    {
        _actionMap?.Disable();
    }
}

using Cinemachine;
using UnityEngine;

public class CinemachineCameraController : CinemachineExtension
{
    [SerializeField] private float horizontalSpeed = 10f;
    [SerializeField] private float verticalSpeed = 10f;
    [SerializeField] private float clampAngle = 80f;

    private PlayerController playerController;
    private Vector3 startingRotation;

    protected override void Awake()
    {
        playerController = FindObjectOfType<PlayerController>();

        base.Awake();
    }

    protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        if (Application.isPlaying)
        {
            if (vcam.Follow)
            {
                if (stage == CinemachineCore.Stage.Aim)
                {
                    Vector2 deltaInput = playerController.GetMouseDelta();

                    startingRotation.x += deltaInput.x * verticalSpeed * Time.deltaTime;
                    startingRotation.y -= deltaInput.y * horizontalSpeed * Time.deltaTime;
                    startingRotation.y = Mathf.Clamp(startingRotation.y, -clampAngle, clampAngle);

                    state.RawOrientation = Quaternion.Euler(startingRotation.y, startingRotation.x, 0f);
                }
            }
        }
    }
}

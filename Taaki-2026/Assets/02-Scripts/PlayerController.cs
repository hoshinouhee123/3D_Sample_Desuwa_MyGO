using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float movespeed = 5f;

    public float jumpPower = 5f;
    public float gravity = -20f;

    public float mouseSensitivity = 0.2f;

    private Vector2 lookInput;

    private bool isRunning;

    public Transform cameraPivot;

    public Transform cameraTransform;

    private float pitch = 20f;

    private float verticalVelocity;

    private Vector2 moveInput;
    private CharacterController controller;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        transform.Rotate(0f, lookInput.x * mouseSensitivity, 0f);

        pitch = pitch - lookInput.y * mouseSensitivity;
        pitch = Mathf.Clamp(pitch, -20f, 60f);
        cameraPivot.localEulerAngles = new Vector3(pitch, 0f, 0f);

        if (controller.isGrounded && verticalVelocity < 0f)
        {
            verticalVelocity = -2f;
        }

        verticalVelocity += gravity * Time.deltaTime;

        Vector3 move = transform.forward * moveInput.y + transform.right * moveInput.x;
        float speed = movespeed;
        float targetZ = -6f;
        if (isRunning)
        {
            speed = movespeed * 2f;
            targetZ = -8f;
        }
        move = move * speed;
        move.y = verticalVelocity;

        Vector3 camPos = cameraTransform.localPosition;
        camPos.z = Mathf.Lerp(camPos.z, targetZ, 5f * Time.deltaTime);
        cameraTransform.localPosition = camPos;

        controller.Move(move * movespeed * Time.deltaTime);
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    public void OnJump(InputValue value)
    {
        if (value.isPressed && controller.isGrounded)
        {
            verticalVelocity = jumpPower;
        }
    }

    public void OnSprint(InputValue value)
    {
        isRunning = value.isPressed;
    }

    public void OnLook(InputValue value)
    {
        lookInput = value.Get<Vector2>();
    }
}

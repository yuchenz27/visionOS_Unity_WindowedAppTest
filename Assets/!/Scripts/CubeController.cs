using UnityEngine;
using UnityEngine.EventSystems;

public enum InteractionMode
{
    Click = 0,
    Drag = 1
}

public class CubeController : MonoBehaviour
{
    [SerializeField] private float m_RotationSpeed = 50f;

    [SerializeField] private float m_ClickMovementSpeed = 5f;

    [SerializeField] private float m_DragMovementSpeed = 1f;

    [SerializeField] private InteractionMode m_CurrentMode = InteractionMode.Click;

    [SerializeField] private Joystick m_Joystick;

    public InteractionMode CurrentMode
    {
        set
        {
            m_CurrentMode = value;
            if (m_CurrentMode == InteractionMode.Click)
            {
                m_Joystick.gameObject.SetActive(false);
            }
            else if (m_CurrentMode == InteractionMode.Drag)
            {
                m_Joystick.gameObject.SetActive(true);
            }
        }
    }

    private void Start()
    {
        m_Joystick.gameObject.SetActive(false);
    }

    private void Update()
    {
        // Rotation
        transform.Rotate(0f, m_RotationSpeed * Time.deltaTime, 0f, Space.Self);

        if (m_CurrentMode == InteractionMode.Click)
        {
            // Tap movement
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Began)
                {
                    if (EventSystem.current.IsPointerOverGameObject(touch.fingerId))
                    {
                        // If the touch is over a UI element, return early and do nothing
                        return;
                    }

                    float zDistanceToTarget = transform.position.z - Camera.main.transform.position.z;
                    // Create a Vector3 with the correct z value
                    Vector3 touchPositionWithZ = new Vector3(touch.position.x, touch.position.y, zDistanceToTarget);
                    // Convert the screen position to world position
                    Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touchPositionWithZ);

                    float distance = Vector3.Distance(transform.position, touchPosition);
                    float duration = distance / m_ClickMovementSpeed;

                    LeanTween.cancel(gameObject);
                    LeanTween.move(gameObject, touchPosition, duration);
                }
            }
        }
        else if (m_CurrentMode == InteractionMode.Drag)
        {
            transform.position += m_DragMovementSpeed * Time.deltaTime * new Vector3(m_Joystick.Direction.x, m_Joystick.Direction.y, transform.position.z);
        }
    }

    public void OnDropdownValueChanged(int index)
    {
        if (index == 0)
            CurrentMode = InteractionMode.Click;
        else if (index == 1)
            CurrentMode = InteractionMode.Drag;
    }
}

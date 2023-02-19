using UnityEngine;
using UnityEngine.EventSystems;

public class StopButtonAnimation : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private Animator animator;
    private bool isHeldDown = false;
    private bool isAnimating = true;
    private float pauseDuration = 3f;
    private float pauseTimer = 2f;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isHeldDown = true;
        pauseTimer = 0f;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isHeldDown = false;
        isAnimating = true;
        animator.speed = 1f;
    }

    private void Update()
    {
        if (isHeldDown)
        {
            if (pauseTimer >= pauseDuration)
            {
                isAnimating = true;
                pauseTimer = 0f;
            }
            else
            {
                isAnimating = false;
                pauseTimer += Time.deltaTime;
            }
        }

        if (isAnimating)
        {
            animator.speed = 1f;
        }
        else
        {
            animator.speed = 0f;
        }
    }
}

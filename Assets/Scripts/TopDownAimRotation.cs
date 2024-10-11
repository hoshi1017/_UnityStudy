using Unity.Mathematics;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{   
    
    private TopDownController controller;
    [SerializeField]private SpriteRenderer characterRenderer;
    private void Awake()
    {
        controller = GetComponent<TopDownController>();
    }
    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }
    private void OnAim(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}
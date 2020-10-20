using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] static float paddleWidthInUnits = 2f;
    private float stopLeft = paddleWidthInUnits / 2;
    private float stopRight = 16f - (paddleWidthInUnits / 2);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalWidth = Camera.main.aspect * Camera.main.orthographicSize * 2;
        float mouseX = Mathf.Clamp((Input.mousePosition.x / Screen.width * horizontalWidth), stopLeft, stopRight);
        transform.position = new Vector2(mouseX, transform.position.y);
    }
}

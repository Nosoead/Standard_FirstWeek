using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FuelBarPosition : MonoBehaviour
{
    [SerializeField] private Transform rocketTransform;
    [SerializeField] private Transform ImageTransform;
    Vector2 rocketPosition = Vector2.zero;
    //public RectTransform ImageTransform;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        Time.timeScale = 1f;
    }
    private void Start()
    {
        ImageTransform.position = Vector2.zero;
        rocketPosition.x = rocketTransform.position.x;
        rocketPosition.y = rocketTransform.position.y +1.4f;
    }

    private void FixedUpdate()
    {
        SamePositon();
    }

    private void SamePositon()
    {
        ImageTransform.position = rocketTransform.position;
    }
}
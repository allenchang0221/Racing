using UnityEngine;
using System.Collections.Generic;

public class wheel: MonoBehaviour
{
    [Header("輪胎碰撞體")]
    public WheelCollider frontLeftWheel;
    public WheelCollider frontRightWheel;
    public WheelCollider rearLeftWheel;
    public WheelCollider rearRightWheel;

    [Header("輪胎外觀模型")]
    public Transform frontLeftTransform;
    public Transform frontRightTransform;
    public Transform rearLeftTransform;
    public Transform rearRightTransform;

    [Header("車輛參數")]
    public float motorForce = 1500f;
    public float brakeForce = 3000f;
    public float maxSteerAngle = 30f;

    private float currentSteerAngle;
    private float currentBreakForce;
    private void Start()
    {
        Application.targetFrameRate = 60;
    }
    // 每一幀偵測輸入
    private void Update()
    {
        // 取得鍵盤 W/S (或上下箭頭) 與 A/D (或左右箭頭) 的輸入
        float moveInput = Input.GetAxis("Vertical");
        float steerInput = Input.GetAxis("Horizontal");

        // 驅動後輪 (後輪驅動)
        rearLeftWheel.motorTorque = moveInput * motorForce;
        rearRightWheel.motorTorque = moveInput * motorForce;

        // 前輪轉向
        currentSteerAngle = maxSteerAngle * steerInput;
        frontLeftWheel.steerAngle = currentSteerAngle;
        frontRightWheel.steerAngle = currentSteerAngle;

        // 煞車控制 (空白鍵)
        if (Input.GetKey(KeyCode.Space))
        {
            currentBreakForce = brakeForce;
        }
        else
        {
            currentBreakForce = 0f;
        }
        ApplyBraking();

        // 更新輪胎外觀的位置與旋轉
        UpdateWheelVisuals(frontLeftWheel, frontLeftTransform);
        UpdateWheelVisuals(frontRightWheel, frontRightTransform);
        UpdateWheelVisuals(rearLeftWheel, rearLeftTransform);
        UpdateWheelVisuals(rearRightWheel, rearRightTransform);
    }

    private void ApplyBraking()
    {
        frontLeftWheel.brakeTorque = currentBreakForce;
        frontRightWheel.brakeTorque = currentBreakForce;
        rearLeftWheel.brakeTorque = currentBreakForce;
        rearRightWheel.brakeTorque = currentBreakForce;
    }

    // 讓外觀模型對齊 Wheel Collider 物理狀態的關鍵函式
    private void UpdateWheelVisuals(WheelCollider collider, Transform transform)
    {
        Vector3 pos;
        Quaternion rot;
        collider.GetWorldPose(out pos, out rot);
        transform.position = pos;
        transform.rotation = rot;
    }
}
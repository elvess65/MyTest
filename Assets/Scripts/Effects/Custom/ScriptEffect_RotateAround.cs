﻿using UnityEngine;

namespace mytest.Effects.Custom
{
    /// <summary>
    /// Вращение вокруг оси с определенной скоростью
    /// </summary>
    public class ScriptEffect_RotateAround : MonoBehaviour
    {
        public float RotationSpeed = 20;
        public Vector3 Axis = Vector3.forward;

        void Update()
        {
            transform.Rotate(Axis, Time.deltaTime * RotationSpeed);
        }
    }
}

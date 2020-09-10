﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IrohaChiyo.FiniteStateMachine
{
    [RequireComponent(typeof(BoolVariable))]
    public class IfButtonWasReleasedThisFrame : MonoBehaviour
    {
        public ButtonInputVariable variable;
        public bool reverse;

        private BoolVariable condition;

        private void Awake()
        {
            condition = GetComponent<BoolVariable>();
        }

        private void LateUpdate()
        {
            condition.Value = variable.WasReleasedThisFrame ^ reverse;
        }
    }
}
﻿using UnityEngine;

namespace Core
{
    public static class MovementUtils
    {
        public const float SpeedCharge = 42.0f;
        public const int SplineStepsPerSegment = 3;
        public const int SpellMovementInterruptThreshold = 200;

        public const float GridCellSwitchDifference = 1.0f;
        public const float MaxHeight = 100.0f;
        public const float MinHeight = -100.0f;

        public const float Gravity = 19.29110527038574f;
        public const float TerminalVelocity = 60.148003f;
        public const float TerminalSafefallVelocity = 7.0f;

        public const float TerminalLength = TerminalVelocity * TerminalVelocity / (2.0f * Gravity);
        public const float TerminalSafeFallLength = TerminalSafefallVelocity * TerminalSafefallVelocity / (2.0f * Gravity);
        public const float TerminalFallTime = TerminalVelocity / Gravity;
        public const float TerminalSafeFallFallTime = TerminalSafefallVelocity / Gravity;

        public const float SmoothPathStepSize = 4.0f;
        public const float SmoothPathSlop = 0.3f;

        public const int MaxPathLength = 74;
        public const int MaxPointPathLength = 74;
        public const int VertexSize = 3;
        public const int InvalidPolyref = 0;

        public static bool IsMoving(this MovementFlags movementFlags) => (movementFlags & MovementFlags.MaskMoving) != 0;

        public static float ComputeFallTime(float pathLength, bool isSafeFall)
        {
            if (pathLength < 0.0f)
                return 0.0f;

            float time;
            if (isSafeFall)
            {
                if (pathLength >= TerminalSafeFallLength)
                    time = (pathLength - TerminalSafeFallLength) / TerminalSafefallVelocity + TerminalSafeFallFallTime;
                else
                    time = Mathf.Sqrt(2.0f * pathLength / Gravity);
            }
            else
            {
                if (pathLength >= TerminalLength)
                    time = (pathLength - TerminalLength) / TerminalVelocity + TerminalFallTime;
                else
                    time = Mathf.Sqrt(2.0f * pathLength / Gravity);
            }

            return time;
        }

        public static float ComputeFallElevation(float tPassed, bool isSafeFall, float startVelocity = 0.0f)
        {
            float termVel;

            if (isSafeFall)
                termVel = TerminalSafefallVelocity;
            else
                termVel = TerminalVelocity;

            if (startVelocity > termVel)
                startVelocity = termVel;

            // the time that needed to reach TerminalVelocity
            float terminalTime = (isSafeFall ? TerminalSafeFallFallTime : TerminalFallTime) - startVelocity / Gravity;

            if (tPassed > terminalTime)
                return termVel * (tPassed - terminalTime) + startVelocity * terminalTime + Gravity * terminalTime * terminalTime * 0.5f;

            return tPassed * (startVelocity + tPassed * Gravity * 0.5f);
        }
    }
}
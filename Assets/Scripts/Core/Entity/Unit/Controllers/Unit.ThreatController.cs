﻿namespace Core
{
    public abstract partial class Unit
    {
        internal class ThreatController : IUnitBehaviour
        {
            public bool HasClientLogic => false;
            public bool HasServerLogic => true;

            void IUnitBehaviour.DoUpdate(int deltaTime)
            {
            }

            void IUnitBehaviour.HandleUnitAttach(Unit unit)
            {
            }

            void IUnitBehaviour.HandleUnitDetach()
            {
            }
        }
    }
}
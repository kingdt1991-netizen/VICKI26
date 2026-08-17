using System;
using UnityEngine;

namespace LuMarea.Core
{
    public enum VerticalSlicePhase
    {
        SunriseIntro = 0,
        GullsToTown = 10,
        MistArrival = 20,
        TitleReveal = 30,
        GimbleArrival = 40,
        HarborCleanup = 50,
        LighthouseRepair = 60,
        FirstLightIgnition = 70,
        MistRetreat = 80,
        HudAwake = 90,
        Complete = 100
    }

    /// <summary>
    /// Authoritative progression state for the LuMarea opening vertical slice.
    /// Other systems react to this state instead of advancing themselves independently.
    /// </summary>
    public sealed class VerticalSlicePhaseController : MonoBehaviour
    {
        [SerializeField] private VerticalSlicePhase currentPhase = VerticalSlicePhase.SunriseIntro;
        [SerializeField] private bool allowPhaseRegression;

        public VerticalSlicePhase CurrentPhase => currentPhase;
        public event Action<VerticalSlicePhase, VerticalSlicePhase> PhaseChanged;

        public bool SetPhase(VerticalSlicePhase nextPhase)
        {
            if (nextPhase == currentPhase)
                return false;

            if (!allowPhaseRegression && nextPhase < currentPhase)
            {
                Debug.LogWarning($"Ignored vertical-slice phase regression: {currentPhase} -> {nextPhase}.", this);
                return false;
            }

            VerticalSlicePhase previous = currentPhase;
            currentPhase = nextPhase;
            PhaseChanged?.Invoke(previous, currentPhase);
            return true;
        }

        public bool IsAtLeast(VerticalSlicePhase phase) => currentPhase >= phase;

        public void ResetToOpening()
        {
            VerticalSlicePhase previous = currentPhase;
            currentPhase = VerticalSlicePhase.SunriseIntro;
            PhaseChanged?.Invoke(previous, currentPhase);
        }
    }
}

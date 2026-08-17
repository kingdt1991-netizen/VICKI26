using System;
using LuMarea.Core;
using UnityEngine;

namespace LuMarea.Gameplay
{
    /// <summary>
    /// Tracks the two interactive restoration beats in the opening loop:
    /// clearing harbor debris, then repairing the lighthouse.
    /// </summary>
    public sealed class RestorationProgressController : MonoBehaviour
    {
        [SerializeField] private VerticalSlicePhaseController phaseController;
        [Min(1)] [SerializeField] private int requiredDebrisClears = 3;
        [Min(1)] [SerializeField] private int requiredRepairSteps = 3;

        private int debrisCleared;
        private int repairStepsCompleted;

        public int DebrisCleared => debrisCleared;
        public int RepairStepsCompleted => repairStepsCompleted;
        public float CleanupProgress => Mathf.Clamp01((float)debrisCleared / requiredDebrisClears);
        public float RepairProgress => Mathf.Clamp01((float)repairStepsCompleted / requiredRepairSteps);

        public event Action<float> CleanupProgressChanged;
        public event Action<float> RepairProgressChanged;

        public bool RegisterDebrisCleared()
        {
            if (phaseController == null || phaseController.CurrentPhase != VerticalSlicePhase.HarborCleanup)
                return false;

            if (debrisCleared >= requiredDebrisClears)
                return false;

            debrisCleared++;
            CleanupProgressChanged?.Invoke(CleanupProgress);

            if (debrisCleared >= requiredDebrisClears)
                phaseController.SetPhase(VerticalSlicePhase.LighthouseRepair);

            return true;
        }

        public bool RegisterRepairStepCompleted()
        {
            if (phaseController == null || phaseController.CurrentPhase != VerticalSlicePhase.LighthouseRepair)
                return false;

            if (repairStepsCompleted >= requiredRepairSteps)
                return false;

            repairStepsCompleted++;
            RepairProgressChanged?.Invoke(RepairProgress);

            if (repairStepsCompleted >= requiredRepairSteps)
                phaseController.SetPhase(VerticalSlicePhase.FirstLightIgnition);

            return true;
        }

        public void ResetProgress()
        {
            debrisCleared = 0;
            repairStepsCompleted = 0;
            CleanupProgressChanged?.Invoke(0f);
            RepairProgressChanged?.Invoke(0f);
        }
    }
}

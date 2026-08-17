using LuMarea.Core;
using LuMarea.Gameplay;
using UnityEngine;
using UnityEngine.UI;

namespace LuMarea.UI
{
    /// <summary>
    /// Minimal graybox HUD for the opening loop. It stays hidden until the
    /// First Light payoff and can display cleanup/repair progress with sliders.
    /// </summary>
    public sealed class SliceHudController : MonoBehaviour
    {
        [SerializeField] private VerticalSlicePhaseController phaseController;
        [SerializeField] private RestorationProgressController restorationProgress;
        [SerializeField] private CanvasGroup hudCanvasGroup;
        [SerializeField] private Slider cleanupSlider;
        [SerializeField] private Slider repairSlider;
        [SerializeField] private GameObject cleanupPanel;
        [SerializeField] private GameObject repairPanel;

        private void OnEnable()
        {
            if (phaseController != null)
                phaseController.PhaseChanged += HandlePhaseChanged;

            if (restorationProgress != null)
            {
                restorationProgress.CleanupProgressChanged += HandleCleanupProgress;
                restorationProgress.RepairProgressChanged += HandleRepairProgress;
            }

            Refresh();
        }

        private void OnDisable()
        {
            if (phaseController != null)
                phaseController.PhaseChanged -= HandlePhaseChanged;

            if (restorationProgress != null)
            {
                restorationProgress.CleanupProgressChanged -= HandleCleanupProgress;
                restorationProgress.RepairProgressChanged -= HandleRepairProgress;
            }
        }

        private void HandlePhaseChanged(VerticalSlicePhase previous, VerticalSlicePhase current) => Refresh();

        private void HandleCleanupProgress(float value)
        {
            if (cleanupSlider != null)
                cleanupSlider.value = value;
        }

        private void HandleRepairProgress(float value)
        {
            if (repairSlider != null)
                repairSlider.value = value;
        }

        private void Refresh()
        {
            if (phaseController == null)
                return;

            bool hudAwake = phaseController.IsAtLeast(VerticalSlicePhase.HudAwake);
            if (hudCanvasGroup != null)
            {
                hudCanvasGroup.alpha = hudAwake ? 1f : 0f;
                hudCanvasGroup.interactable = hudAwake;
                hudCanvasGroup.blocksRaycasts = hudAwake;
            }

            if (cleanupPanel != null)
                cleanupPanel.SetActive(phaseController.CurrentPhase == VerticalSlicePhase.HarborCleanup);

            if (repairPanel != null)
                repairPanel.SetActive(phaseController.CurrentPhase == VerticalSlicePhase.LighthouseRepair);

            if (cleanupSlider != null && restorationProgress != null)
                cleanupSlider.value = restorationProgress.CleanupProgress;

            if (repairSlider != null && restorationProgress != null)
                repairSlider.value = restorationProgress.RepairProgress;
        }
    }
}

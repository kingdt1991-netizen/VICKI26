using System.Collections;
using LuMarea.Core;
using UnityEngine;

namespace LuMarea.Gameplay
{
    /// <summary>
    /// Performs the First Light payoff by driving the shared world-state signal
    /// from its current value to full Light, then advancing the opening loop.
    /// </summary>
    public sealed class FirstLightIgnitionController : MonoBehaviour
    {
        [SerializeField] private VerticalSlicePhaseController phaseController;
        [SerializeField] private WorldStateController worldStateController;
        [Min(0.1f)] [SerializeField] private float ignitionSeconds = 4f;
        [SerializeField] private AnimationCurve ignitionCurve = AnimationCurve.EaseInOut(0f, 0f, 1f, 1f);

        private Coroutine ignitionRoutine;
        public bool IsIgniting => ignitionRoutine != null;

        public bool TryIgnite()
        {
            if (phaseController == null || worldStateController == null)
            {
                Debug.LogError("FirstLightIgnitionController is missing required references.", this);
                return false;
            }

            if (phaseController.CurrentPhase != VerticalSlicePhase.FirstLightIgnition || ignitionRoutine != null)
                return false;

            ignitionRoutine = StartCoroutine(IgniteRoutine());
            return true;
        }

        private IEnumerator IgniteRoutine()
        {
            float start = worldStateController.LightAmount;
            float elapsed = 0f;

            while (elapsed < ignitionSeconds)
            {
                elapsed += Time.deltaTime;
                float t = Mathf.Clamp01(elapsed / ignitionSeconds);
                float shaped = ignitionCurve != null ? ignitionCurve.Evaluate(t) : t;
                worldStateController.SetLightAmount(Mathf.Lerp(start, 1f, shaped));
                yield return null;
            }

            worldStateController.SetLightAmount(1f);
            phaseController.SetPhase(VerticalSlicePhase.MistRetreat);
            yield return new WaitForSeconds(1f);
            phaseController.SetPhase(VerticalSlicePhase.HudAwake);
            ignitionRoutine = null;
        }
    }
}

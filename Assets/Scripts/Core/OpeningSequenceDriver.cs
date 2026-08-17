using System.Collections;
using UnityEngine;

namespace LuMarea.Core
{
    /// <summary>
    /// Drives the non-interactive opening beats and hands control to gameplay
    /// at HarborCleanup. Visual/audio systems can subscribe to phase changes.
    /// </summary>
    public sealed class OpeningSequenceDriver : MonoBehaviour
    {
        [SerializeField] private VerticalSlicePhaseController phaseController;
        [SerializeField] private GameObject playerControlRoot;

        [Header("Graybox timing")]
        [Min(0f)] [SerializeField] private float sunriseSeconds = 2.5f;
        [Min(0f)] [SerializeField] private float gullsSeconds = 2f;
        [Min(0f)] [SerializeField] private float mistSeconds = 3f;
        [Min(0f)] [SerializeField] private float titleSeconds = 2f;
        [Min(0f)] [SerializeField] private float arrivalSeconds = 3f;

        private Coroutine sequenceRoutine;

        private void Start()
        {
            if (phaseController == null)
            {
                Debug.LogError("OpeningSequenceDriver requires a VerticalSlicePhaseController.", this);
                enabled = false;
                return;
            }

            if (playerControlRoot != null)
                playerControlRoot.SetActive(false);

            sequenceRoutine = StartCoroutine(RunOpening());
        }

        private IEnumerator RunOpening()
        {
            phaseController.ResetToOpening();
            yield return Wait(sunriseSeconds);

            phaseController.SetPhase(VerticalSlicePhase.GullsToTown);
            yield return Wait(gullsSeconds);

            phaseController.SetPhase(VerticalSlicePhase.MistArrival);
            yield return Wait(mistSeconds);

            phaseController.SetPhase(VerticalSlicePhase.TitleReveal);
            yield return Wait(titleSeconds);

            phaseController.SetPhase(VerticalSlicePhase.GimbleArrival);
            yield return Wait(arrivalSeconds);

            phaseController.SetPhase(VerticalSlicePhase.HarborCleanup);
            if (playerControlRoot != null)
                playerControlRoot.SetActive(true);

            sequenceRoutine = null;
        }

        private static IEnumerator Wait(float seconds)
        {
            if (seconds > 0f)
                yield return new WaitForSeconds(seconds);
        }

        public void SkipToGameplay()
        {
            if (sequenceRoutine != null)
            {
                StopCoroutine(sequenceRoutine);
                sequenceRoutine = null;
            }

            phaseController.SetPhase(VerticalSlicePhase.HarborCleanup);
            if (playerControlRoot != null)
                playerControlRoot.SetActive(true);
        }
    }
}

using System;
using UnityEngine;

namespace LuMarea.Core
{
    /// <summary>
    /// Central normalized world-state signal for the vertical slice.
    /// 0 = full Mist / cold world, 1 = restored Light / warm world.
    /// Visual, audio, UI and gameplay presentation systems subscribe to this
    /// instead of hard-coding independent transitions.
    /// </summary>
    public sealed class WorldStateController : MonoBehaviour
    {
        public static WorldStateController Instance { get; private set; }

        [Range(0f, 1f)]
        [SerializeField] private float lightAmount;

        public float LightAmount => lightAmount;
        public event Action<float> LightAmountChanged;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
        }

        public void SetLightAmount(float value)
        {
            float next = Mathf.Clamp01(value);
            if (Mathf.Approximately(next, lightAmount)) return;

            lightAmount = next;
            LightAmountChanged?.Invoke(lightAmount);
        }
    }
}

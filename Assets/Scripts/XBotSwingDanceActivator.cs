using UnityEngine;

namespace Practice1
{
    public class XBotSwingDanceActivator : MonoBehaviour
    {
        [Header("Animation settings")]
        [SerializeField] private string stateName = "Swing Dancing";
        [SerializeField] private bool playOnStart = true;

        private Animator animator;

        private void Awake()
        {
            animator = GetComponent<Animator>();
        }

        private void Start()
        {
            if (!playOnStart)
            {
                return;
            }

            if (animator == null)
            {
                Debug.LogError("XBotSwingDanceActivator requires an Animator component on the same GameObject.");
                return;
            }

            if (string.IsNullOrWhiteSpace(stateName))
            {
                Debug.LogWarning("Animation state name is empty. Using default animation state.");
                return;
            }

            animator.Play(stateName, 0, 0f);
            Debug.Log($"Playing animation state: {stateName}");
        }
    }
}

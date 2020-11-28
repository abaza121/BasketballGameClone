using UnityEngine;

namespace FiveHoops.Gameplay
{
    /// <summary>
    /// Handles the Swipe Event and controls the throwables by holding or throwing.
    /// </summary>
    public class Thrower : MonoBehaviour
    {
        [SerializeField]
        private Transform holdingPositionTransform;

        [HideInInspector]
        private Throwable currentThrowable;

        public void LoadThrowable(Throwable throwable)
        {
            throwable.Hold();
            throwable.transform.position = holdingPositionTransform.position;
            throwable.transform.rotation = this.transform.rotation;
            currentThrowable = throwable;
            SwipeDetector.OnSwipe += Throw;
        }

        public void Throw(SwipeData data)
        {
            var force = PowerForceCalculator.GetForceFromSwipeData(data);
            currentThrowable.Throw(force);
            currentThrowable = null;
            SwipeDetector.OnSwipe -= Throw;
        }
    }
}

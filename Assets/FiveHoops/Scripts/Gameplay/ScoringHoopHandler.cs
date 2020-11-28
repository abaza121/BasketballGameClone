using FiveHoops.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FiveHoops.Gameplay
{
    /// <summary>
    /// Detects the scoring and notifies the score manager.
    /// </summary>
    public class ScoringHoopHandler : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Trigger enter" + other.tag);
            if (other.tag == "Throwable")
            {
                GameManager.Instance.ScoreManager.ScoredPoint();
            }
        }
    }
}

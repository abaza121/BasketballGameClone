using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FiveHoops.Gameplay
{
    public class PositionPicker : MonoBehaviour
    {
        [SerializeField]
        private Transform[] availablePositions;

        public Transform PickRandomPosition()
        {
            var chosen = Random.Range(0, availablePositions.Length);
            return availablePositions[chosen];
        }
    }
}

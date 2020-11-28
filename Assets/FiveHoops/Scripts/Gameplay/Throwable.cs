using System;
using UnityEngine;

namespace FiveHoops.Gameplay
{
    /// <summary>
    /// Controls the rigidbody and round gameplay loop.
    /// </summary>
    public class Throwable : MonoBehaviour
    {
        public event Action TouchedGround;

        [SerializeField]
        private Rigidbody rb;

        public void Hold()
        {
            rb.isKinematic = true;
        }

        public void Throw(Vector3 Force)
        {
            rb.isKinematic = false;
            rb.AddForce(Force, ForceMode.Impulse);
        }

        public void OnCollisionEnter(Collision collision)
        {
            if(collision.collider.tag == "Ground")
            {
                TouchedGround.Invoke();
            }
        }
    }
}

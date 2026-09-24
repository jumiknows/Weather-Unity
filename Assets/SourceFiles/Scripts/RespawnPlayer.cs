using Unity.Cinemachine;
using UnityEngine;

namespace StarterAssets
{
    [RequireComponent(typeof(CharacterController))]
    public class RespawnPlayer : MonoBehaviour
    {
        [Tooltip("The Y position threshold at which the player will respawn.")]
        public float yThreshold = -5f;

        public CinemachineCamera vCam;
        public AudioClip respawnSound;

        private Vector3 _startingPosition;
        private Quaternion _startingRotation;
        private CharacterController _characterController;
        private ThirdPersonController _thirdPersonController;

        private void Start()
        {
            _startingPosition = transform.position;
            _startingRotation = transform.rotation;

            _characterController = GetComponent<CharacterController>();
            _thirdPersonController = GetComponent<ThirdPersonController>();

            if (_thirdPersonController == null)
            {
                Debug.LogError("ThirdPersonController component is required for RespawnPlayer.");
            }
        }

        private void Update()
        {
            if (transform.position.y < yThreshold)
            {
                Respawn();
            }
        }

        private void Respawn()
        {
            _characterController.enabled = false;

            transform.position = _startingPosition;
            transform.rotation = _startingRotation;

            _characterController.enabled = true;

            if (_thirdPersonController != null)
            {
                _thirdPersonController.ResetVerticalVelocity();
                _thirdPersonController.ResetCameraRotation(_startingRotation.eulerAngles.y);
            }

            if (respawnSound != null)
            {
                AudioSource.PlayClipAtPoint(respawnSound, transform.position);
            }
        }
    }
}

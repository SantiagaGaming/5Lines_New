using AosSdk.Core.Utils;
using UnityEngine;

namespace AosSdk.Core.Player.VRPlayer
{
    [RequireComponent(typeof(LineRenderer))]
    public class TeleportArcManager : MonoBehaviour
    {
        [SerializeField] private AosSDKSettings sdkSettings;
        [SerializeField] private LayerMask excludeLayers;
        [SerializeField] private Gradient validTeleportGradient;
        [SerializeField] private Gradient invalidTeleportGradient;

        public float MaxTeleportRadius { get; set; } = 8f;
        private const int MaxArcPointCount = 30;
        private const float VertexDelta = 0.08f;

        private LineRenderer _arcRenderer; 

        private Vector3 _currentArcPointVelocity;
        private Vector3 _arcHighestPoint;
        private Vector3 _arcLastPoint;
        private Vector3 _previousPointPosition;

        private int _arcPointsCalculated;
        
        private Transform _thisTransform;

        private bool _groundDetected;
        private bool _teleportIsActive;
    
        public TeleportRaycastData RaycastData;
   
        public void ToggleDisplay(bool active)
        {
            _arcRenderer.enabled = active;
            _teleportIsActive = active;
        }
    
        private void OnEnable()
        {
            _arcRenderer = GetComponent<LineRenderer>();
            _arcRenderer.enabled = false;
            _thisTransform = transform;
        }

        private void LateUpdate()
        {
            if (!_teleportIsActive)
            {
                return;
            }
            
            UpdateArc();
        }

        private void UpdateArc()
        {
            _arcHighestPoint = Vector3.zero;
            _arcLastPoint = Vector3.zero;
            _groundDetected = false;
            _previousPointPosition = _thisTransform.position;
            _arcPointsCalculated = 0;
            
            _currentArcPointVelocity = _thisTransform.forward * MaxTeleportRadius;

            while (!_groundDetected && _arcPointsCalculated <= MaxArcPointCount)
            {
                var newPosition = _previousPointPosition + _currentArcPointVelocity * VertexDelta + Physics.gravity * (0.5f * Mathf.Pow(VertexDelta, 2));

                if (newPosition.y < _previousPointPosition.y && _arcHighestPoint == Vector3.zero)
                {
                    _arcHighestPoint = newPosition;
                }

                _currentArcPointVelocity += Physics.gravity * VertexDelta;
                
                _arcPointsCalculated++;

                if (Physics.Linecast(_previousPointPosition, newPosition, out var hit, ~excludeLayers))
                {
                    _groundDetected = true;
                    _arcLastPoint = hit.point;

                    if (hit.collider.CompareTag(sdkSettings.walkableTag))
                    {
                        RaycastData.TeleportPosition = hit.point;
                        RaycastData.TeleportNormal = hit.normal;
                        RaycastData.IsTeleportValid = true;
                        _arcRenderer.colorGradient = validTeleportGradient;
                        break;
                    }
                
                    RaycastData.IsTeleportValid = false;
                    _arcRenderer.colorGradient = invalidTeleportGradient;
                    break;
                }
                _previousPointPosition = newPosition;
            }
            
            _arcRenderer.positionCount = MaxArcPointCount;

            if (!_groundDetected)
            {
                RaycastData.IsTeleportValid = false;
                _arcRenderer.colorGradient = invalidTeleportGradient;
                _arcLastPoint = _thisTransform.position + _thisTransform.forward;
                _arcRenderer.positionCount = 2;
            }
            
            var t = 0f;
            for (var i = 0; i < _arcRenderer.positionCount; i++)
            {
                _arcRenderer.SetPosition(i, (1 - t) * (1 - t) * _thisTransform.position + 2 * (1 - t) * t * _arcHighestPoint + t * t * _arcLastPoint);
                t += 1 / (float)_arcRenderer.positionCount;
            }
        }
    
        public struct TeleportRaycastData
        {
            public Vector3 TeleportPosition;
            public Vector3 TeleportNormal;
            public bool IsTeleportValid;
        }
    }
}
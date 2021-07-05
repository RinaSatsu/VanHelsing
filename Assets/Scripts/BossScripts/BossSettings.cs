﻿using UnityEngine;
using System;


namespace BeastHunter
{
    [Serializable]
    public struct BossSettings
    {
        #region Fields

        [Header("Scene information fields")]

        [Tooltip("Boss prefab.")]
        [SerializeField] private GameObject _prefab;    

        [Tooltip("Ruler.")]
        [SerializeField] private GameObject _ruler;

        [Tooltip("StompFuf prefab.")]
        [SerializeField] private GameObject _stompPuf;

        [Tooltip("StompFuf prefab.")]
        [SerializeField] private GameObject _healAura;

        [Tooltip("StompFuf prefab.")]
        [SerializeField] private GameObject _BarkBuffEffect;

        [Tooltip("StompFuf prefab.")]
        [SerializeField] private GameObject _callOfForestEffect;

        [Tooltip("Boss instance name.")]
        [SerializeField] private string _instanceName;

        [Tooltip("Left hand object path")]
        [SerializeField] private string _leftHandObjectPath;

        [Tooltip("Right hand object path")]
        [SerializeField] private string _rightHandObjectPath;

        [Tooltip("Boss right finger path")]
        [SerializeField] private string _rightFingerPath;

        [Tooltip("Left foot object path")]
        [SerializeField] private string _leftFootObjectPath;

        [Tooltip("Right foot object path")]
        [SerializeField] private string _rightFootObjectPath;

        [Tooltip("Boss instance tag.")]
        [SerializeField] private string _instanceTag;

        [Tooltip("Boss instance layer.")]
        [SerializeField] private int _instanceLayer;

        [Tooltip("Boss default movement runtime animator controller.")]
        [SerializeField] private RuntimeAnimatorController _bossAnimator;

        [Tooltip("Prefab direction on the scene")]
        [SerializeField] private float _instantiateDirection;

        [Tooltip("Active Rage value between 0 and 100.")]
        [Range(0.0f, 100.0f)]
        [SerializeField] private float _activateRage;

        [Tooltip("Duration Rage value(sec) between 0 and 100.")]
        [Range(0.0f, 100.0f)]
        [SerializeField] private float _durationRage;

        [Tooltip("Left Eye Path")]
        [SerializeField] public string _leftEye;

        [Tooltip("Right Eye Path")]
        [SerializeField] public string _rightEye;

        [Header("Prefab rigitbody information fields")]

        [Tooltip("Boss rigitbody mass between 0 and 10.")]
        [Range(0.0f, 10.0f)]
        [SerializeField] private float _rigitbodyMass;

        [Tooltip("Boss rigitbody drag between 0 and 10.")]
        [Range(0.0f, 10.0f)]
        [SerializeField] private float _rigitbodyDrag;

        [Tooltip("Boss rigitbody angular drag between 0 and 10.")]
        [Range(0.0f, 10.0f)]
        [SerializeField] private float _rigitbodyAngularDrag;

        [Tooltip("Is boss rigitbody kinematic")]
        [SerializeField] private bool _isRigitbodyKinematic;

        [Header("Prefab capsule collider information fields")]

        [Tooltip("Capsule collider center position")]
        [SerializeField] private Vector3 _capsuleColliderCenter;

        [Tooltip("Capsule collider radius between 0 and 2.")]
        [Range(0.0f, 2.0f)]
        [SerializeField] private float _capsuleColliderRadius;

        [Tooltip("Capsule collider height between 0 and 5.")]
        [Range(0.0f, 5.0f)]
        [SerializeField] private float _capsuleColliderHeight;

        [Header("Prefab sphere trigger information fields")]

        [Tooltip("Sphere trigger center position")]
        [SerializeField] private Vector3 _sphereColliderCenter;

        [Tooltip("Sphere trigger radius between 0 and 100.")]
        [Range(0.0f, 100.0f)]
        [SerializeField] private float _sphereColliderRadius;

        [Tooltip("Sphere trigger radius increace in battle between 1 and 2.")]
        [Range(1f, 2f)]
        [SerializeField] private float _sphereColliderRadiusIncrease;

        [Tooltip("Sphere trigger radius decreace when player sneaking between 1 and 2.")]
        [Range(1f, 2f)]
        [SerializeField] private float _sphereColliderRadiusDecrease;

        [Header("Prefab nav mesh settings")]

        [Tooltip("Acceleration between 0 and 20.")]
        [Range(0.0f, 20.0f)]
        [SerializeField] private float _navMeshAcceleration;

        [Header("Movement settings")]

        [Tooltip("Walk speed value between 0 and 20.")]
        [Range(0.0f, 20.0f)]
        [SerializeField] private float _walkSpeed;

        [Tooltip("Run speed value between 0 and 20.")]
        [Range(0.0f, 20.0f)]
        [SerializeField] private float _runSpeed;

        [Tooltip("Rotate speed value between 0 and 20.")]
        [Range(0.0f, 20.0f)]
        [SerializeField] private float _rotateSpeed;

        [Tooltip("Ground check height under boss between 0 and 2.")]
        [Range(0.0f, 2.0f)]
        [SerializeField] private float _groundCheckHeight;

        [Tooltip("Boss direction change lag between 0 and 1.")]
        [Range(0.0f, 1.0f)]
        [SerializeField] private float _directionChangeLag;

        [Tooltip("Base animator speed between 0 and 2.")]
        [Range(0.0f, 2.0f)]
        [SerializeField] private float _animatorBaseSpeed;

        [Header("Boss battle settings")]

        [Tooltip("Left hand hit box radius between 0 and 50.")]
        [Range(0.0f, 50.0f)]
        [SerializeField] private float _leftHandHitBoxRadius;

        [Tooltip("Left hand hit box canter")]
        [SerializeField] private Vector3 _leftHandHitBoxCenter;

        [Tooltip("Right hand hit box radius between 0 and 50.")]
        [Range(0.0f, 50.0f)]
        [SerializeField] private float _rightHandHitBoxRadius;

        [Tooltip("Right hand hit box canter")]
        [SerializeField] private Vector3 _rightHandHitBoxCenter;

        #endregion


        #region Properties

        public GameObject Prefab => _prefab;
        public GameObject Ruler => _ruler;
        public GameObject StompPuf => _stompPuf;

        public GameObject HealAura => _healAura;
        public GameObject BarkBuffEffect => _BarkBuffEffect;
        public GameObject CallOfForestEffect => _callOfForestEffect;

        public RuntimeAnimatorController BossAnimator => _bossAnimator;

        public Vector3 CapsuleColliderCenter => _capsuleColliderCenter;
        public Vector3 SphereColliderCenter => _sphereColliderCenter;
        public Vector3 LeftHandHitBoxCenter => _leftHandHitBoxCenter;
        public Vector3 RightHandHitBoxCenter => _rightHandHitBoxCenter;

        public string InstanceName => _instanceName;
        public string LeftHandObjectPath => _leftHandObjectPath;
        public string RightHandObjectPath => _rightHandObjectPath;
        public string RightFingerPath => _rightFingerPath;
        public string LeftFootObjectPath => _leftFootObjectPath;
        public string RightFootObjectPath => _rightFootObjectPath;

        public string InstanceTag => _instanceTag;

        public int InstanceLayer => _instanceLayer;

        public bool IsRigitbodyKinematic => _isRigitbodyKinematic;

        public float InstantiateDirection => _instantiateDirection;
        public float RigitbodyMass => _rigitbodyMass;
        public float RigitbodyDrag => _rigitbodyDrag;
        public float RigitbodyAngularDrag => _rigitbodyAngularDrag;

        public float CapsuleColliderRadius => _capsuleColliderRadius;
        public float CapsuleColliderHeight => _capsuleColliderHeight;
        public float SphereColliderRadius => _sphereColliderRadius;
        public float SphereColliderRadiusIncrease => _sphereColliderRadiusIncrease;
        public float SphereColliderRadiusDecreace => _sphereColliderRadiusDecrease;

        public float NavMeshAcceleration => _navMeshAcceleration;

        public float WalkSpeed => _walkSpeed;
        public float RunSpeed => _runSpeed;
        public float RotateSpeed => _rotateSpeed;
        public float GroundCheckHeight => _groundCheckHeight;
        public float DirectionChangeLag => _directionChangeLag;
        public float AnimatorBaseSpeed => _animatorBaseSpeed;

        public float LeftHandHitBoxRadius => _leftHandHitBoxRadius;
        public float RightHandHitBoxRadius => _rightHandHitBoxRadius;
        public float ActivateRage => _activateRage;
        public float DurationRage =>_durationRage;
        public string LeftEyePath => _leftEye;
        public string RightEyePath => _rightEye;

        #endregion
    }
}


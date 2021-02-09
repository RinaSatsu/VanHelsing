﻿using System;
using UnityEngine;


namespace BeastHunter
{

    [Serializable]
    public struct NonStateSkillsSettings
    {
        #region Fields

        [Header("[Test Attack]")]

        [Tooltip("Skill ID")]
        [SerializeField] private int _testSkillId;
        [Tooltip("Skill Range Min")]
        [Range(-1.0f, 30.0f)]
        [SerializeField] private float _testSkillRangeMin;
        [Tooltip("Skill Range Max")]
        [Range(-1.0f, 30.0f)]
        [SerializeField] private float _testSkillRangeMax;
        [Tooltip("Skill Cooldown")]
        [Range(0.0f, 200.0f)]
        [SerializeField] private float _testSkillCooldown;
        [Tooltip("Skill Ready")]
        [SerializeField] private bool _testSkillReady;

        [Header("[Throw Attack]")]

        [Tooltip("Skill ID")]
        [SerializeField] private int _throwSkillId;
        [Tooltip("Skill Range Min")]
        [Range(-1.0f, 30.0f)]
        [SerializeField] private float _throwSkillRangeMin;
        [Tooltip("Skill Range Max")]
        [Range(-1.0f, 30.0f)]
        [SerializeField] private float _throwSkillRangeMax;
        [Tooltip("Skill Cooldown")]
        [Range(0.0f, 200.0f)]
        [SerializeField] private float _throwSkillCooldown;
        [Tooltip("Skill Ready")]
        [SerializeField] private bool _throwSkillReady;

        [Header("[Self Heal]")]

        [Tooltip("Skill ID")]
        [SerializeField] private int _selfHealSkillId;
        [Tooltip("Skill Range Min")]
        [Range(-1.0f, 30.0f)]
        [SerializeField] private float _selfHealSkillRangeMin;
        [Tooltip("Skill Range Max")]
        [Range(-1.0f, 30.0f)]
        [SerializeField] private float _selfHealSkillRangeMax;
        [Tooltip("Skill Cooldown")]
        [Range(0.0f, 200.0f)]
        [SerializeField] private float _selfHealSkillCooldown;
        [Tooltip("Skill Ready")]
        [SerializeField] private bool _selfHealSkillReady;
        [Tooltip("Skill can Interrupt")]
        [SerializeField] private bool _selfHealSkillCanInterrupt;

        #endregion


        #region Properties

        public int TestSkillId => _testSkillId;
        public float TestSkillRangeMin => _testSkillRangeMin;
        public float TestSkillRangeMax => _testSkillRangeMax;
        public float TestSkillCooldown => _testSkillCooldown;
        public bool TestSkillReady => _testSkillReady;

        public int ThrowSkillId => _throwSkillId;
        public float ThrowSkillRangeMin => _throwSkillRangeMin;
        public float ThrowSkillRangeMax => _throwSkillRangeMax;
        public float ThrowSkillCooldown => _throwSkillCooldown;
        public bool ThrowSkillReady => _throwSkillReady;

        public int SelfHealSkillId => _selfHealSkillId;
        public float SelfHealSkillRangeMin => _selfHealSkillRangeMin;
        public float SelfHealSkillRangeMax => _selfHealSkillRangeMax;
        public float SelfHealSkillCooldown => _selfHealSkillCooldown;
        public bool SelfHealSkillReady => _selfHealSkillReady;
        public bool SelfHealSkillCanInterrupt => _selfHealSkillCanInterrupt;

        #endregion


        #region Methods

        public (int, float, float, float, bool, bool) GetTestSkillInfo()
        {
            var tuple = (TestSkillId, TestSkillRangeMin, TestSkillRangeMax, TestSkillCooldown, TestSkillReady, false);
            return tuple;
        }

        public (int, float, float, float, bool, bool) GetThrowSkillInfo()
        {
            var tuple = (ThrowSkillId, ThrowSkillRangeMin, ThrowSkillRangeMax, ThrowSkillCooldown, ThrowSkillReady, false);
            return tuple;
        }

        public (int, float, float, float, bool, bool) GetSelfHealSkillInfo()
        {
            var tuple = (SelfHealSkillId, SelfHealSkillRangeMin, SelfHealSkillRangeMax, SelfHealSkillCooldown, SelfHealSkillReady, SelfHealSkillCanInterrupt);
            return tuple;
        }

        #endregion
    }
}
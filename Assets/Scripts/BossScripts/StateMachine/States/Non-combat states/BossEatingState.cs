﻿using UnityEngine;


namespace BeastHunter
{
    public class BossEatingState : BossBaseState
    {

        #region Constants

        private const float EATING_TIME = 5f;
        private const float EATING_TAKE_TIME = 4f;
        private const float DISTANCE_TO_START_EATING = 2.3f;
        private const float FOOD_POINT = 50f;
        private const float ANGLE_SPEED = 100f;
        private const float ANGLE_RANGE = 5f;


        #endregion


        #region Fields

        private float _eatingCountTime = EATING_TIME;
        private Vector3 _target;
        private GameObject _targetFood;
        private bool _canEat;
        private bool _startEating;
        private bool _setParent;
        private Quaternion TargetRotation;

        #endregion


        #region ClassLifeCycle

        public BossEatingState(BossStateMachine stateMachine) : base(stateMachine)
        {
            
        }

        #endregion


        #region Methods 

        public override void OnAwake()
        {
            CanExit = true;
            CanBeOverriden = true;
            IsBattleState = false;
            
        }

        public override void Initialise()
        {
            _stateMachine._model.BossNavAgent.speed = _stateMachine._model.BossData._bossSettings.WalkSpeed;
            _stateMachine._model.BossNavAgent.stoppingDistance = DISTANCE_TO_START_EATING;
            _stateMachine._model.BossAnimator.Play("MovingState");
            _canEat = false;
            _startEating = false;

            if (_bossModel.BossCurrentTarget != null)
            {
                _target = _bossModel.BossCurrentTarget.transform.position;
            }
        }

        public override void Execute()
        {
            CheckTarget();
            CheckDistance();
            Eating();
        }

        public override void OnExit()
        {

        }

        public override void OnTearDown()
        {
        }


        private void CheckTarget()
        {
            if(!_startEating)
            {
                if (_stateMachine._model.FoodList.Count != 0)
                {
                    _targetFood = _stateMachine._model.FoodList[0];
                    _stateMachine._model.BossCurrentTarget = _targetFood;
                }
                else
                {
                    _stateMachine.SetCurrentState(_stateMachine.LastStateType);
                }
            }
        }


        private void CheckDistance()
        {
            if (!_startEating)
            {
                if (_stateMachine._model.BossData.CheckIsNearTarget(_stateMachine._model.BossTransform.position, _target, DISTANCE_TO_START_EATING))
                {
                    _canEat = true;
                }
                else
                {
                    _canEat = false;
                    _stateMachine.SetCurrentState(BossStatesEnum.Moving);

                }
            }
        }

        private void Eating()
        {
            if (_canEat)
            {
                Debug.Log("Eating");
                _startEating = true;
                _stateMachine._model.BossAnimator.Play("EatingState");
                _eatingCountTime -= Time.deltaTime;

                if(_eatingCountTime<= EATING_TAKE_TIME)
                {
                    if (!_setParent)
                    {
                        _targetFood.transform.SetParent(_stateMachine._model.RightHand);
                        _setParent = true;
                    }

                }
                if(_eatingCountTime <= 0)
                {
                    _eatingCountTime = EATING_TIME;
                    _targetFood.SetActive(false);
                    _stateMachine._model.FoodList.Remove(_targetFood);
                    _stateMachine._model.CurrentStamina += FOOD_POINT;
                    _startEating = false;
                    _setParent = false;
                    _stateMachine._model.BossCurrentTarget = null;
                    _stateMachine.SetCurrentState(BossStatesEnum.Idle);
                    
                }
            }
        }

        #endregion
    }
}
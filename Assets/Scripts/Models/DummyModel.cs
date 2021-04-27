using UnityEngine;
using DG.Tweening;
using TMPro;


namespace BeastHunter
{
    public sealed class DummyModel : EnemyModel, IAwake
    {

        #region Properties

        public Sequence DamageTextSequence { get; private set; }
        public Sequence DummyPushSequence { get; private set; }
        public Transform DamageTextObject { get; }
        public TextMeshPro DamageText { get; }
        public Color DamageTextColor { get; }
        public VisualEffectController VisualEffectController { get; }
        public EffectReactionController EffectReactionController { get; }

        #endregion


        #region ClassLifeCycle

        public DummyModel(GameObject objectOnScene, EnemyData data) : base(objectOnScene, data)
        {
            DamageTextSequence = DOTween.Sequence();
            DummyPushSequence = DOTween.Sequence();
            DamageTextObject = GameObject.Instantiate(((DummyData)ThisEnemyData).DamageTextObject,
                ObjectOnScene.transform.position + Vector3.up * ((DummyData)ThisEnemyData).DummyHeight,
                    Quaternion.identity).transform;
            DamageText = DamageTextObject.GetComponent<TextMeshPro>();
            DamageTextColor = DamageText.color;
            DamageText.text = string.Empty;
            DamageText.color = Color.clear;
            BuffEffectPrefab = objectOnScene.transform.Find("Effects").gameObject;

            VisualEffectController = new VisualEffectController(Services.SharedInstance.Context, this);
            EffectReactionController = new EffectReactionController(Services.SharedInstance.Context, this);
        }

        #endregion


        #region Methods

        public override void TakeDamage(Damage damage)
        {
            ((DummyData)ThisEnemyData).CreateDamageObject(damage, this);
        }

        public void RefreshDamageTextSequence(bool doComplete)
        {
            if (doComplete && !DamageTextSequence.IsComplete()) DamageTextSequence.Complete();
            DamageTextSequence = DOTween.Sequence();
        }

        public void RefreshDummyPushSeqnece(bool doComplete)
        {
            if (doComplete && !DummyPushSequence.IsComplete()) DummyPushSequence.Complete();
            DummyPushSequence = DOTween.Sequence();
        }

        public void OnAwake()
        {
            VisualEffectController.OnAwake();
            EffectReactionController.OnAwake();
        }


        #endregion
    }
}


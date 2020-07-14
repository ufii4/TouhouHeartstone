﻿using System;
using UnityEngine.EventSystems;
using UnityEngine;
using TouhouHeartstone;
using System.Linq;
using TouhouCardEngine;
using UnityEngine.Events;
namespace UI
{
    partial class Skill : IBeginDragHandler, IDragHandler, IEndDragHandler
    {
        [Obsolete]
        public TouhouCardEngine.Card card { get; private set; } = null;
        [Obsolete]
        public void update(Table table, THHPlayer self, THHPlayer player, TouhouCardEngine.Card card, CardSkinData skin)
        {
            this.card = card;

            Image.sprite = skin.image;
            CostPropNumber.asText.text = card.getCost().ToString();
            if (card.isUsed())
            {
                // IsUsedController = IsUsed.True;
                onIsUsedControllerTrue?.Invoke();
            }
            else
            {
                // IsUsedController = IsUsed.False;
                onIsUsedControllerFalse?.Invoke();
            }
            if (player == self
                && card.isUsable(table.game, player, out _)//技能是可用的
                && table.selectableTargets == null//没有在选择目标
                && table.canControl//是自己的回合
                )
            {
                // IsUsableController = IsUsable.True;
                onIsUsableTrue?.Invoke();
                asButton.interactable = true;
            }
            else
            {
                // IsUsableController = IsUsable.False;
                onIsUsableFalse?.Invoke();
                asButton.interactable = false;
            }
        }
        public void OnBeginDrag(PointerEventData eventData)
        {
            throw new NotImplementedException();
        }

        public void OnDrag(PointerEventData eventData)
        {
            onDrag.invoke(this, eventData);
        }
        public ActionEvent<Skill, PointerEventData> onDrag { get; } = new ActionEvent<Skill, PointerEventData>();
        public void OnEndDrag(PointerEventData eventData)
        {
            onDragEnd.invoke(this, eventData);
        }
        public ActionEvent<Skill, PointerEventData> onDragEnd { get; } = new ActionEvent<Skill, PointerEventData>();
        [SerializeField]
        UnityEvent _onIsUsableTrue = new UnityEvent();
        public UnityEvent onIsUsableTrue => _onIsUsableTrue;

        [SerializeField]
        UnityEvent _onIsUsableFalse = new UnityEvent();
        public UnityEvent onIsUsableFalse => _onIsUsableFalse;

        [SerializeField]
        private UnityEvent _onIsUsedControllerFalse;
        public UnityEvent onIsUsedControllerFalse => _onIsUsedControllerFalse;

        [SerializeField]
        private UnityEvent _onIsUsedControllerTrue;
        public UnityEvent onIsUsedControllerTrue => _onIsUsedControllerTrue;

    }
}

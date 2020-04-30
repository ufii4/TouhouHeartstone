﻿using TouhouHeartstone;
using TouhouCardEngine;
namespace UI
{
    partial class Card
    {
        public TouhouCardEngine.Card card { get; private set; }
        public void update(TouhouCardEngine.Card card, CardSkinData skin)
        {
            this.card = card;

            CostText.text = card.getCost().ToString();
            if (card.define.type == CardDefineType.SERVANT)
            {
                TypeController = Type.Servant;
                AttackText.text = card.getAttack().ToString();
                LifeText.text = card.getLife().ToString();
            }
            else
            {
                TypeController = Type.Spell;
            }

            if (skin != null)
            {
                Image.sprite = skin.image;
                NameText.text = skin.name;
                DescText.text = skin.desc;
                IsFaceupController = IsFaceup.True;
            }
            else
                IsFaceupController = IsFaceup.False;
        }
        public void update(CardDefine card, CardSkinData skin)
        {
            CostText.text = card.getCost().ToString();
            AttackText.text = card.getAttack().ToString();
            LifeText.text = card.getLife().ToString();

            Image.sprite = skin.image;
            NameText.text = skin.name;
            DescText.text = skin.desc;
            IsFaceupController = IsFaceup.True;
        }
    }
}
﻿using System.Linq;

namespace TouhouHeartstone
{
    class InitReplaceEvent : VisibleEvent
    {
        public InitReplaceEvent(Player player, Card[] cards) : base("onInitReplace")
        {
            this.player = player;
            originCards = cards;
        }
        Card[] originCards { get; set; }
        public Player player
        {
            get { return getProp<Player>("player"); }
            private set { setProp("player", value); }
        }
        public override void execute(CardEngine engine)
        {
            //先把卡牌放回牌库
            int[] cardsIndex = originCards.Select(c => { return player["Init"].indexOf(c); }).ToArray();
            foreach (Card card in originCards)
            {
                card.pile = null;
                player["Deck"].insert(card, player["Deck"].count);
            }
            //然后洗牌
            player["Deck"].shuffle(engine);
            //最后再抽相同数量的卡并替换
            replacedCards = player["Deck"][player["Deck"].count - originCards.Length, player["Deck"].count - 1];
            for (int i = 0; i < replacedCards.Length; i++)
            {
                player["Deck"].remove(replacedCards[i]);
                replacedCards[i].pile = player["Init"];
                player["Init"][cardsIndex[i]] = replacedCards[i];
            }
            engine.registerCards(replacedCards);
        }
        Card[] replacedCards { get; set; }
        public override EventWitness getWitness(CardEngine engine, Player player)
        {
            EventWitness witness = new InitReplaceWitness();
            witness.setVar("playerIndex", engine.getPlayerIndex(this.player));
            witness.setVar("originCardsRID", originCards.Select(c => { return c.id; }).ToArray());
            if (player == this.player)
            {
                //自己
                witness.setVar("replacedCardsDID", replacedCards.Select(c => { return c.define.id; }).ToArray());
            }
            //其他玩家
            witness.setVar("replacedCardsRID", replacedCards.Select(c => { return c.id; }).ToArray());
            return witness;
        }
    }
    /// <summary>
    /// 替换初始手牌事件
    /// </summary>
    public class InitReplaceWitness : EventWitness
    {
        /// <summary>
        /// 替换初始手牌的玩家索引
        /// </summary>
        public int playerIndex
        {
            get { return getVar<int>("playerIndex"); }
        }
        /// <summary>
        /// 被替换的所有初始手牌RID
        /// </summary>
        public int[] originCardsRID
        {
            get { return getVar<int[]>("originCardsRID"); }
        }
        /// <summary>
        /// 替换后的所有初始手牌DID
        /// </summary>
        public int[] replacedCardsDID
        {
            get { return getVar<int[]>("replacedCardsDID"); }
        }
        /// <summary>
        /// 替换后的所有初始手牌RID
        /// </summary>
        public int[] replacedCardsRID
        {
            get { return getVar<int[]>("replacedCardsRID"); }
        }
        public InitReplaceWitness() : base("onInitReplace")
        {
        }
    }
    public partial class HeartstoneCardEngine
    {
        public void initReplace(Player player, Card[] cards)
        {
            doEvent(new InitReplaceEvent(player, cards));
        }
    }
}
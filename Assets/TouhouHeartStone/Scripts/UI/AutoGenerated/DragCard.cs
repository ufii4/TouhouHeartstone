//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UI
{
    using System;
    using UnityEngine;
    using UnityEngine.UI;
    using BJSYGameCore.UI;
    
    public partial class DragCard : UIObject
    {
        protected override void Awake()
        {
            base.Awake();
            this.autoBind();
            this.onAwake();
        }
        public void autoBind()
        {
            this._BuildDeckListItem = this.transform.Find("BuildDeckListItem").GetComponent<BuildDeckListItem>();
            this._Card = this.transform.Find("Card").GetComponent<Card>();
        }
        private Main _parent;
        public Main parent
        {
            get
            {
                return this.transform.parent.parent.GetComponent<Main>();
            }
        }
        [SerializeField()]
        private BuildDeckListItem _BuildDeckListItem;
        public BuildDeckListItem BuildDeckListItem
        {
            get
            {
                if ((this._BuildDeckListItem == null))
                {
                    this._BuildDeckListItem = this.transform.Find("BuildDeckListItem").GetComponent<BuildDeckListItem>();
                }
                return this._BuildDeckListItem;
            }
        }
        [SerializeField()]
        private Card _Card;
        public Card Card
        {
            get
            {
                if ((this._Card == null))
                {
                    this._Card = this.transform.Find("Card").GetComponent<Card>();
                }
                return this._Card;
            }
        }
        partial void onAwake();
    }
}

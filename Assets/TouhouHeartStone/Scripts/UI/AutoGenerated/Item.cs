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
    
    public partial class Item : UIObject
    {
        protected override void Awake()
        {
            base.Awake();
            this.autoBind();
            this.onAwake();
        }
        public void autoBind()
        {
            this._Mask = this.transform.Find("Mask").GetComponent<Mask>();
            this._Image = this.transform.Find("Mask").Find("Image").GetComponent<Image>();
            this._FrameImage = this.transform.Find("Frame").GetComponent<Image>();
            this._AttackImage = this.transform.Find("Attack").GetComponent<Image>();
            this._AttackPropNumber = this.transform.Find("Attack").Find("Attack").GetComponent<PropNumber>();
            this._DurabilityImage = this.transform.Find("Durability").GetComponent<Image>();
            this._DurabilityPropNumber = this.transform.Find("Durability").Find("Durability").GetComponent<PropNumber>();
        }
        [SerializeField()]
        private Mask _Mask;
        public Mask Mask
        {
            get
            {
                if ((this._Mask == null))
                {
                    this._Mask = this.transform.Find("Mask").GetComponent<Mask>();
                }
                return this._Mask;
            }
        }
        [SerializeField()]
        private Image _Image;
        public Image Image
        {
            get
            {
                if ((this._Image == null))
                {
                    this._Image = this.transform.Find("Mask").Find("Image").GetComponent<Image>();
                }
                return this._Image;
            }
        }
        [SerializeField()]
        private Image _FrameImage;
        public Image FrameImage
        {
            get
            {
                if ((this._FrameImage == null))
                {
                    this._FrameImage = this.transform.Find("Frame").GetComponent<Image>();
                }
                return this._FrameImage;
            }
        }
        [SerializeField()]
        private Image _AttackImage;
        public Image AttackImage
        {
            get
            {
                if ((this._AttackImage == null))
                {
                    this._AttackImage = this.transform.Find("Attack").GetComponent<Image>();
                }
                return this._AttackImage;
            }
        }
        [SerializeField()]
        private PropNumber _AttackPropNumber;
        public PropNumber AttackPropNumber
        {
            get
            {
                if ((this._AttackPropNumber == null))
                {
                    this._AttackPropNumber = this.transform.Find("Attack").Find("Attack").GetComponent<PropNumber>();
                }
                return this._AttackPropNumber;
            }
        }
        [SerializeField()]
        private Image _DurabilityImage;
        public Image DurabilityImage
        {
            get
            {
                if ((this._DurabilityImage == null))
                {
                    this._DurabilityImage = this.transform.Find("Durability").GetComponent<Image>();
                }
                return this._DurabilityImage;
            }
        }
        [SerializeField()]
        private PropNumber _DurabilityPropNumber;
        public PropNumber DurabilityPropNumber
        {
            get
            {
                if ((this._DurabilityPropNumber == null))
                {
                    this._DurabilityPropNumber = this.transform.Find("Durability").Find("Durability").GetComponent<PropNumber>();
                }
                return this._DurabilityPropNumber;
            }
        }
        partial void onAwake();
    }
}

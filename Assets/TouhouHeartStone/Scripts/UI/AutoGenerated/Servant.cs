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
    
    public partial class Servant : UIObject
    {
        protected override void Awake()
        {
            base.Awake();
            this.autoBind();
            this.onAwake();
        }
        public void autoBind()
        {
            this._Image_1 = this.transform.Find("Root").Find("Taunt").Find("GameObject").Find("Image (1)").GetComponent<Image>();
            this._Image_2 = this.transform.Find("Root").Find("Taunt").Find("GameObject (1)").Find("Image (2)").GetComponent<Image>();
            this._Image_3 = this.transform.Find("Root").Find("Taunt").Find("GameObject (2)").Find("Image (3)").GetComponent<Image>();
            this._HighlightImage = this.transform.Find("Root").Find("Highlight").GetComponent<Image>();
            this._BackgroundImage = this.transform.Find("Root").Find("Background").GetComponent<Image>();
            this._Mask = this.transform.Find("Root").Find("Mask").GetComponent<Mask>();
            this._Image = this.transform.Find("Root").Find("Mask").Find("Image").GetComponent<Image>();
            this._HpImage = this.transform.Find("Root").Find("Hp").GetComponent<Image>();
            this._HpText = this.transform.Find("Root").Find("Hp").Find("HpText").GetComponent<Text>();
            this._AtkImage = this.transform.Find("Root").Find("Atk").GetComponent<Image>();
            this._AttackText = this.transform.Find("Root").Find("Atk").Find("AttackText").GetComponent<Text>();
            this._DamageImage = this.transform.Find("Root").Find("DamageImage").GetComponent<Image>();
            this._DamageText = this.transform.Find("Root").Find("DamageImage").Find("DamageText").GetComponent<Text>();
            this._HealImage = this.transform.Find("Root").Find("HealImage").GetComponent<Image>();
            this._HealText = this.transform.Find("Root").Find("HealImage").Find("HealText").GetComponent<Text>();
        }
        [SerializeField()]
        private Image _Image_1;
        public Image Image_1
        {
            get
            {
                if ((this._Image_1 == null))
                {
                    this._Image_1 = this.transform.Find("Root").Find("Taunt").Find("GameObject").Find("Image (1)").GetComponent<Image>();
                }
                return this._Image_1;
            }
        }
        [SerializeField()]
        private Image _Image_2;
        public Image Image_2
        {
            get
            {
                if ((this._Image_2 == null))
                {
                    this._Image_2 = this.transform.Find("Root").Find("Taunt").Find("GameObject (1)").Find("Image (2)").GetComponent<Image>();
                }
                return this._Image_2;
            }
        }
        [SerializeField()]
        private Image _Image_3;
        public Image Image_3
        {
            get
            {
                if ((this._Image_3 == null))
                {
                    this._Image_3 = this.transform.Find("Root").Find("Taunt").Find("GameObject (2)").Find("Image (3)").GetComponent<Image>();
                }
                return this._Image_3;
            }
        }
        [SerializeField()]
        private Image _HighlightImage;
        public Image HighlightImage
        {
            get
            {
                if ((this._HighlightImage == null))
                {
                    this._HighlightImage = this.transform.Find("Root").Find("Highlight").GetComponent<Image>();
                }
                return this._HighlightImage;
            }
        }
        [SerializeField()]
        private Image _BackgroundImage;
        public Image BackgroundImage
        {
            get
            {
                if ((this._BackgroundImage == null))
                {
                    this._BackgroundImage = this.transform.Find("Root").Find("Background").GetComponent<Image>();
                }
                return this._BackgroundImage;
            }
        }
        [SerializeField()]
        private Mask _Mask;
        public Mask Mask
        {
            get
            {
                if ((this._Mask == null))
                {
                    this._Mask = this.transform.Find("Root").Find("Mask").GetComponent<Mask>();
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
                    this._Image = this.transform.Find("Root").Find("Mask").Find("Image").GetComponent<Image>();
                }
                return this._Image;
            }
        }
        [SerializeField()]
        private Image _HpImage;
        public Image HpImage
        {
            get
            {
                if ((this._HpImage == null))
                {
                    this._HpImage = this.transform.Find("Root").Find("Hp").GetComponent<Image>();
                }
                return this._HpImage;
            }
        }
        [SerializeField()]
        private Text _HpText;
        public Text HpText
        {
            get
            {
                if ((this._HpText == null))
                {
                    this._HpText = this.transform.Find("Root").Find("Hp").Find("HpText").GetComponent<Text>();
                }
                return this._HpText;
            }
        }
        [SerializeField()]
        private Image _AtkImage;
        public Image AtkImage
        {
            get
            {
                if ((this._AtkImage == null))
                {
                    this._AtkImage = this.transform.Find("Root").Find("Atk").GetComponent<Image>();
                }
                return this._AtkImage;
            }
        }
        [SerializeField()]
        private Text _AttackText;
        public Text AttackText
        {
            get
            {
                if ((this._AttackText == null))
                {
                    this._AttackText = this.transform.Find("Root").Find("Atk").Find("AttackText").GetComponent<Text>();
                }
                return this._AttackText;
            }
        }
        [SerializeField()]
        private Image _DamageImage;
        public Image DamageImage
        {
            get
            {
                if ((this._DamageImage == null))
                {
                    this._DamageImage = this.transform.Find("Root").Find("DamageImage").GetComponent<Image>();
                }
                return this._DamageImage;
            }
        }
        [SerializeField()]
        private Text _DamageText;
        public Text DamageText
        {
            get
            {
                if ((this._DamageText == null))
                {
                    this._DamageText = this.transform.Find("Root").Find("DamageImage").Find("DamageText").GetComponent<Text>();
                }
                return this._DamageText;
            }
        }
        [SerializeField()]
        private Image _HealImage;
        public Image HealImage
        {
            get
            {
                if ((this._HealImage == null))
                {
                    this._HealImage = this.transform.Find("Root").Find("HealImage").GetComponent<Image>();
                }
                return this._HealImage;
            }
        }
        [SerializeField()]
        private Text _HealText;
        public Text HealText
        {
            get
            {
                if ((this._HealText == null))
                {
                    this._HealText = this.transform.Find("Root").Find("HealImage").Find("HealText").GetComponent<Text>();
                }
                return this._HealText;
            }
        }
        partial void onAwake();
        public enum Highlight
        {
            None,
            Green,
            Yellow,
        }
        public Highlight HighlightController
        {
            get
            {
                return ((Highlight)(Enum.Parse(typeof(Highlight), this.getController("Highlight", Enum.GetNames(typeof(Highlight))))));
            }
            set
            {
                this.setController("Highlight", Enum.GetName(typeof(Highlight), value));
            }
        }
    }
}

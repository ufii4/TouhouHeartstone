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
    
    public partial class GameResultDialog : UIObject
    {
        protected override void Awake()
        {
            base.Awake();
            this.autoBind();
            this.onAwake();
        }
        public void autoBind()
        {
            this.m_as_Image = this.GetComponent<Image>();
            this._Image = this.transform.Find("Image").GetComponent<Image>();
            this._WinImage = this.transform.Find("Image").Find("Win").GetComponent<Image>();
            this._Text = this.transform.Find("Image").Find("Win").Find("Text").GetComponent<Text>();
            this._FailImage = this.transform.Find("Image").Find("Fail").GetComponent<Image>();
            this._Fail_Text = this.transform.Find("Image").Find("Fail").Find("Text").GetComponent<Text>();
            this._ButtonGlassButtonBlack = this.transform.Find("Image").Find("ButtonGlass").GetComponent<ButtonBlack>();
            this._Image_Text = this.transform.Find("Image").Find("Text").GetComponent<Text>();
        }
        [SerializeField()]
        private Image m_as_Image;
        public Image asImage
        {
            get
            {
                if ((this.m_as_Image == null))
                {
                    this.m_as_Image = this.GetComponent<Image>();
                }
                return this.m_as_Image;
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
                    this._Image = this.transform.Find("Image").GetComponent<Image>();
                }
                return this._Image;
            }
        }
        [SerializeField()]
        private Image _WinImage;
        public Image WinImage
        {
            get
            {
                if ((this._WinImage == null))
                {
                    this._WinImage = this.transform.Find("Image").Find("Win").GetComponent<Image>();
                }
                return this._WinImage;
            }
        }
        [SerializeField()]
        private Text _Text;
        public Text Text
        {
            get
            {
                if ((this._Text == null))
                {
                    this._Text = this.transform.Find("Image").Find("Win").Find("Text").GetComponent<Text>();
                }
                return this._Text;
            }
        }
        [SerializeField()]
        private Image _FailImage;
        public Image FailImage
        {
            get
            {
                if ((this._FailImage == null))
                {
                    this._FailImage = this.transform.Find("Image").Find("Fail").GetComponent<Image>();
                }
                return this._FailImage;
            }
        }
        [SerializeField()]
        private Text _Fail_Text;
        public Text Fail_Text
        {
            get
            {
                if ((this._Fail_Text == null))
                {
                    this._Fail_Text = this.transform.Find("Image").Find("Fail").Find("Text").GetComponent<Text>();
                }
                return this._Fail_Text;
            }
        }
        [SerializeField()]
        private ButtonBlack _ButtonGlassButtonBlack;
        public ButtonBlack ButtonGlassButtonBlack
        {
            get
            {
                if ((this._ButtonGlassButtonBlack == null))
                {
                    this._ButtonGlassButtonBlack = this.transform.Find("Image").Find("ButtonGlass").GetComponent<ButtonBlack>();
                }
                return this._ButtonGlassButtonBlack;
            }
        }
        [SerializeField()]
        private Text _Image_Text;
        public Text Image_Text
        {
            get
            {
                if ((this._Image_Text == null))
                {
                    this._Image_Text = this.transform.Find("Image").Find("Text").GetComponent<Text>();
                }
                return this._Image_Text;
            }
        }
        partial void onAwake();
    }
}

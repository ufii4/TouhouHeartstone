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
    
    public partial class Main : UIPageGroup
    {
        protected override void Awake()
        {
            base.Awake();
            this.autoBind();
            this.onAwake();
        }
        public void autoBind()
        {
            this._Game = this.transform.Find("Game").GetComponent<Game>();
            this._Build = this.transform.Find("Build").GetComponent<Build>();
            this._MainMenu = this.transform.Find("MainMenu").GetComponent<MainMenu>();
            this._NetworkingPage = this.transform.Find("NetworkingPage").GetComponent<NetworkingPage>();
            this._Dialog = this.transform.Find("Dialog").GetComponent<Dialog>();
        }
        [SerializeField()]
        private Game _Game;
        public Game Game
        {
            get
            {
                if ((this._Game == null))
                {
                    this._Game = this.transform.Find("Game").GetComponent<Game>();
                }
                return this._Game;
            }
        }
        [SerializeField()]
        private Build _Build;
        public Build Build
        {
            get
            {
                if ((this._Build == null))
                {
                    this._Build = this.transform.Find("Build").GetComponent<Build>();
                }
                return this._Build;
            }
        }
        [SerializeField()]
        private MainMenu _MainMenu;
        public MainMenu MainMenu
        {
            get
            {
                if ((this._MainMenu == null))
                {
                    this._MainMenu = this.transform.Find("MainMenu").GetComponent<MainMenu>();
                }
                return this._MainMenu;
            }
        }
        [SerializeField()]
        private NetworkingPage _NetworkingPage;
        public NetworkingPage NetworkingPage
        {
            get
            {
                if ((this._NetworkingPage == null))
                {
                    this._NetworkingPage = this.transform.Find("NetworkingPage").GetComponent<NetworkingPage>();
                }
                return this._NetworkingPage;
            }
        }
        [SerializeField()]
        private Dialog _Dialog;
        public Dialog Dialog
        {
            get
            {
                if ((this._Dialog == null))
                {
                    this._Dialog = this.transform.Find("Dialog").GetComponent<Dialog>();
                }
                return this._Dialog;
            }
        }
        public override UIObject[] getPages()
        {
            return new UIObject[] {
                    this.Game,
                    this.Build,
                    this.MainMenu,
                    this.NetworkingPage,
                    this.Dialog};
        }
        partial void onAwake();
    }
}

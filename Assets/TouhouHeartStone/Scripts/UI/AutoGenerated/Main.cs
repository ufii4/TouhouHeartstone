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
            this._Table = this.transform.Find("Table").GetComponent<Table>();
            this._Build = this.transform.Find("Build").GetComponent<Build>();
            this._MainMenu = this.transform.Find("MainMenu").GetComponent<MainMenu>();
        }
        [SerializeField()]
        private Table _Table;
        public Table Table
        {
            get
            {
                if ((this._Table == null))
                {
                    this._Table = this.transform.Find("Table").GetComponent<Table>();
                }
                return this._Table;
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
        public override UIObject[] getPages()
        {
            return new UIObject[] {
                    this.Table,
                    this.Build,
                    this.MainMenu};
        }
        partial void onAwake();
    }
}

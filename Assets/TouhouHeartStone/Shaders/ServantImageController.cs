//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Animations
{
    
    public partial class ServantImageController : BJSYGameCore.Animations.GraphMatPropCtrl
    {
        protected override void Update()
        {
            base.material.SetTexture("_MainTex", this._MainTex);
            base.material.SetColor("_Color", this._Color);
            base.material.SetFloat("_StencilComp", this._StencilComp);
            base.material.SetFloat("_Stencil", this._Stencil);
            base.material.SetFloat("_StencilOp", this._StencilOp);
            base.material.SetFloat("_StencilWriteMask", this._StencilWriteMask);
            base.material.SetFloat("_StencilReadMask", this._StencilReadMask);
            base.material.SetFloat("_ColorMask", this._ColorMask);
            base.material.SetFloat("_UseUIAlphaClip", this._UseUIAlphaClip);
            base.material.SetTexture("_texcoord", this._texcoord);
        }
        protected override void Reset()
        {
            base.Reset();
            this._MainTex = base.material.GetTexture("_MainTex");
            this._Color = base.material.GetColor("_Color");
            this._StencilComp = base.material.GetFloat("_StencilComp");
            this._Stencil = base.material.GetFloat("_Stencil");
            this._StencilOp = base.material.GetFloat("_StencilOp");
            this._StencilWriteMask = base.material.GetFloat("_StencilWriteMask");
            this._StencilReadMask = base.material.GetFloat("_StencilReadMask");
            this._ColorMask = base.material.GetFloat("_ColorMask");
            this._UseUIAlphaClip = base.material.GetFloat("_UseUIAlphaClip");
            this._texcoord = base.material.GetTexture("_texcoord");
        }
        [UnityEngine.SerializeField()]
        public UnityEngine.Texture _MainTex;
        [UnityEngine.SerializeField()]
        public UnityEngine.Color _Color;
        [UnityEngine.SerializeField()]
        public float _StencilComp;
        [UnityEngine.SerializeField()]
        public float _Stencil;
        [UnityEngine.SerializeField()]
        public float _StencilOp;
        [UnityEngine.SerializeField()]
        public float _StencilWriteMask;
        [UnityEngine.SerializeField()]
        public float _StencilReadMask;
        [UnityEngine.SerializeField()]
        public float _ColorMask;
        [UnityEngine.SerializeField()]
        public float _UseUIAlphaClip;
        [UnityEngine.SerializeField()]
        public UnityEngine.Texture _texcoord;
        public const int SHADER_ID = 183072;
    }
}

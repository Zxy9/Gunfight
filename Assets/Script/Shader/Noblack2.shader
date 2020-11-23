Shader "Unlit/Noblack2"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _Diffuse("Diffuse",Color) = (1,1,1,1)
        _MaskColor("MaskColor",Color) = (1,1,1,1)
        _Cutoff("Alpha Cutoff",Range(0,1)) = 0.5
    }
        SubShader
        {
            Tags { "Queue" = "AlphaTest" "IgnoreProjector" = "True"}
            LOD 100

            Pass
            {
                CGPROGRAM
                #pragma vertex vert
                #pragma fragment frag
                #include "UnityCG.cginc"
                #include "Lighting.cginc"

                sampler2D _MainTex;
                float4 _MainTex_ST;
                fixed4 _Diffuse;
                fixed4 _MaskColor;
                float _Cutoff;

         

            struct v2f
            {
                float4 vertex : SV_POSITION;
                fixed3 worldNormal : TEXCOORD0;
                float3 worldPos: TEXCOORD1;
                float2 uv :TEXCOORD2;
            };

          

            v2f vert (appdata_base v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                fixed3 worldNormal = UnityObjectToWorldNormal(v.normal);
                o.worldNormal = worldNormal;
                o.worldPos = mul(unity_ObjectToWorld, v.vertex);
                o.uv = TRANSFORM_TEX(v.texcoord, _MainTex);
                return o;
            }

            fixed4 frag(v2f i) : SV_Target
            {
               fixed3 ambient = UNITY_LIGHTMODEL_AMBIENT.xyz;
            fixed4 texColor = tex2D(_MainTex, i.uv);
            if ((texColor.r <= _MaskColor.r) && (texColor.g <= _MaskColor.g) && (texColor.b <= _MaskColor.b))
            {
                discard;
            }
            //fixed3 worldLightDir = UnityWorldSpaceLightDir(i.worldPos);
            //fixed3 diffuse = _LightColor0.rgb * texColor.rgb * _Diffuse.rgb * (dot(worldLightDir, i.worldNormal) * 0.5 + 0.5);

            //fixed3 color = ambient + diffuse;

            return texColor;
            }
            ENDCG
        }
    }
            FallBack "Transparent/Cutout/VertexLit"
}

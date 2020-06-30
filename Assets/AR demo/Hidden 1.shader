Shader "Custom/Transparent"
{
	Properties
	{
		_Color("Color", Color) = (1,1,1,1)
		_MainTex("Albedo (RGB)", 2D) = "white" {}
		_Glossiness("Smoothness", Range(0,1)) = 0.5
		_Metallic("Metallic", Range(0,1)) = 0.0
	}
		SubShader
		{
			Tags {"Queue" = "Transparent" "RenderType" = "Transparent" }
			LOD 200

			Stencil {
			 Ref 1
			 Comp Equal
			 }

			CGPROGRAM

			#pragma surface surf Standard fullforwardshadows alpha:blend
			#pragma target 3.0

			sampler2D _MainTex;

			struct Input {
				float2 uv_MainTex;
			};

			half _Glossiness;
			half _Metallic;
			fixed4 _Color;

			void surf(Input IN, inout SurfaceOutputStandard o)
			{
				fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
			
				o.Albedo.r = c.r;
				o.Albedo.g = c.r;
				o.Albedo.b = c.r;

				o.Metallic = _Metallic;
				o.Smoothness = _Glossiness;
				//c.rgb = 1 - c;

				o.Alpha = c.r;
			}
			ENDCG
		}
			FallBack "Standard"
}

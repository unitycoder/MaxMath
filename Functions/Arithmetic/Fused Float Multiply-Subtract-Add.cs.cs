﻿using System.Runtime.CompilerServices;
using Unity.Mathematics;
using Unity.Burst.Intrinsics;

using static Unity.Burst.Intrinsics.X86;

namespace MaxMath
{
    unsafe public static partial class maxmath
    {
        /// <summary>       Returns the result of a componentwise multiply-subtract/add operation (a * b -/+ c) on 3 float2 vectors.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 msubadd(float2 a, float2 b, float2 c)
        {
            v128 temp = Fma.fmaddsub_ps(*(v128*)&a, *(v128*)&b, *(v128*)&c);

            return *(float2*)&temp;
        }

        /// <summary>       Returns the result of a componentwise multiply-subtract/add operation (a * b -/+ c) on 3 float3 vectors.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 msubadd(float3 a, float3 b, float3 c)
        {
            v128 temp = Fma.fmaddsub_ps(*(v128*)&a, *(v128*)&b, *(v128*)&c);

            return *(float3*)&temp;
        }

        /// <summary>       Returns the result of a componentwise multiply-subtract/add operation (a * b -/+ c) on 3 float4 vectors.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 msubadd(float4 a, float4 b, float4 c)
        {
            v128 temp = Fma.fmaddsub_ps(*(v128*)&a, *(v128*)&b, *(v128*)&c);

            return *(float4*)&temp;
        }

        /// <summary>       Returns the result of a componentwise multiply-subtract/add operation (a * b -/+ c) on 3 float8 vectors.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float8 msubadd(float8 a, float8 b, float8 c)
        {
            return Fma.mm256_fmsubadd_ps(a, b, c);
        }


        /// <summary>       Returns the result of a componentwise multiply-subtract/add operation (a * b -/+ c) on 3 double2 vectors.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 msubadd(double2 a, double2 b, double2 c)
        {
            v128 temp = Fma.fmaddsub_pd(*(v128*)&a, *(v128*)&b, *(v128*)&c);

            return *(double2*)&temp;
        }

        /// <summary>       Returns the result of a componentwise multiply-subtract/add operation (a * b -/+ c) on 3 double3 vectors.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 msubadd(double3 a, double3 b, double3 c)
        {
            v256 temp = Fma.mm256_fmaddsub_pd(*(v256*)&a, *(v256*)&b, *(v256*)&c);

            return *(double3*)&temp;
        }

        /// <summary>       Returns the result of a componentwise multiply-subtract/add operation (a * b -/+ c) on 3 double4 vectors.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 msubadd(double4 a, double4 b, double4 c)
        {
            v256 temp = Fma.mm256_fmaddsub_pd(*(v256*)&a, *(v256*)&b, *(v256*)&c);

            return *(double4*)&temp;
        }
    }
}
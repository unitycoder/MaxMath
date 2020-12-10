﻿using DevTools;
using Unity.Mathematics;

namespace MaxMath.Tests
{
    /// Float/Double implicitly tested by testing Int/Long
    unsafe public static class all_dif
    {
        [UnitTest("Functions", "Comparison", "AllDifferent")]
        public static bool Byte3()
        {
            bool result = true;

            for (int i = 0; i < 3; i++)
            {
                byte3 a = 0;

                for (int j = 0; j < 3; j++)
                {
                    a[j] = (byte)j;
                }

                result &= (maxmath.all_dif(a) == true);
                a[i] = (byte)((i == 1) ? 2 : 1);
                result &= (maxmath.all_dif(a) == false);
            }

            return result;
        }

        [UnitTest("Functions", "Comparison", "AllDifferent")]
        public static bool Byte4()
        {
            bool result = true;

            for (int i = 0; i < 4; i++)
            {
                byte4 a = 0;

                for (int j = 0; j < 4; j++)
                {
                    a[j] = (byte)j;
                }

                result &= (maxmath.all_dif(a) == true);
                a[i] = (byte)((i == 1) ? 2 : 1);
                result &= (maxmath.all_dif(a) == false);
            }

            return result;
        }

        [UnitTest("Functions", "Comparison", "AllDifferent")]
        public static bool Byte8()
        {
            bool result = true;

            for (int i = 0; i < 8; i++)
            {
                byte8 a = 0;

                for (int j = 0; j < 8; j++)
                {
                    a[j] = (byte)j;
                }

                result &= (maxmath.all_dif(a) == true);
                a[i] = (byte)((i == 1) ? 2 : 1);
                result &= (maxmath.all_dif(a) == false);
            }

            return result;
        }

        [UnitTest("Functions", "Comparison", "AllDifferent")]
        public static bool Byte16()
        {
            bool result = true;

            for (int i = 0; i < 16; i++)
            {
                byte16 a = 0;

                for (int j = 0; j < 16; j++)
                {
                    a[j] = (byte)j;
                }

                result &= (maxmath.all_dif(a) == true);
                a[i] = (byte)((i == 1) ? 2 : 1);
                result &= (maxmath.all_dif(a) == false);
            }

            return result;
        }


        [UnitTest("Functions", "Comparison", "AllDifferent")]
        public static bool Short3()
        {
            bool result = true;

            for (int i = 0; i < 3; i++)
            {
                short3 a = 0;

                for (int j = 0; j < 3; j++)
                {
                    a[j] = (short)j;
                }

                result &= (maxmath.all_dif(a) == true);
                a[i] = (byte)((i == 1) ? 2 : 1);
                result &= (maxmath.all_dif(a) == false);
            }

            return result;
        }

        [UnitTest("Functions", "Comparison", "AllDifferent")]
        public static bool Short4()
        {
            bool result = true;

            for (int i = 0; i < 4; i++)
            {
                short4 a = 0;

                for (int j = 0; j < 4; j++)
                {
                    a[j] = (short)j;
                }

                result &= (maxmath.all_dif(a) == true);
                a[i] = (byte)((i == 1) ? 2 : 1);
                result &= (maxmath.all_dif(a) == false);
            }

            return result;
        }

        [UnitTest("Functions", "Comparison", "AllDifferent")]
        public static bool Short8()
        {
            bool result = true;

            for (int i = 0; i < 8; i++)
            {
                short8 a = 0;

                for (int j = 0; j < 8; j++)
                {
                    a[j] = (short)j;
                }

                result &= (maxmath.all_dif(a) == true);
                a[i] = (byte)((i == 1) ? 2 : 1);
                result &= (maxmath.all_dif(a) == false);
            }

            return result;
        }

        [UnitTest("Functions", "Comparison", "AllDifferent")]
        public static bool Short16()
        {
            bool result = true;

            for (int i = 0; i < 16; i++)
            {
                short16 a = 0;

                for (int j = 0; j < 16; j++)
                {
                    a[j] = (short)j;
                }

                result &= (maxmath.all_dif(a) == true);
                a[i] = (byte)((i == 1) ? 2 : 1);
                result &= (maxmath.all_dif(a) == false);
            }

            return result;
        }


        [UnitTest("Functions", "Comparison", "AllDifferent")]
        public static bool Int3()
        {
            bool result = true;

            for (int i = 0; i < 3; i++)
            {
                int3 a = 0;

                for (int j = 0; j < 3; j++)
                {
                    a[j] = (int)j;
                }

                result &= (maxmath.all_dif(a) == true);
                a[i] = (int)((i == 1) ? 2 : 1);
                result &= (maxmath.all_dif(a) == false);
            }

            return result;
        }

        [UnitTest("Functions", "Comparison", "AllDifferent")]
        public static bool Int4()
        {
            bool result = true;

            for (int i = 0; i < 4; i++)
            {
                int4 a = 0;

                for (int j = 0; j < 4; j++)
                {
                    a[j] = (int)j;
                }

                result &= (maxmath.all_dif(a) == true);
                a[i] = (int)((i == 1) ? 2 : 1);
                result &= (maxmath.all_dif(a) == false);
            }

            return result;
        }

        [UnitTest("Functions", "Comparison", "AllDifferent")]
        public static bool Int8()
        {
            bool result = true;

            for (int i = 0; i < 8; i++)
            {
                int8 a = 0;

                for (int j = 0; j < 8; j++)
                {
                    a[j] = (int)j;
                }

                result &= (maxmath.all_dif(a) == true);
                a[i] = (int)((i == 1) ? 2 : 1);
                result &= (maxmath.all_dif(a) == false);
            }

            return result;
        }
    }
}
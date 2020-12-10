﻿using DevTools;
using Unity.Mathematics;
using Unity.Burst.Intrinsics;

namespace MaxMath.Tests
{
    unsafe public static class Byte2
    {
        internal const int NUM_TESTS = 4;


        internal static byte2[] TestData_LHS => new byte2[]
        {
            new byte2{ x = 143,
                       y = 55},

            new byte2{ x = 22,
                       y = 12 },
      // EQUAL
            new byte2{ x = 47,
                       y = byte.MaxValue },

            new byte2{ x = byte.MinValue,
                       y = 13 }
        };

        internal static byte2[] TestData_RHS => new byte2[]
        {
            new byte2{ x = 12,
                       y = 4},

            new byte2{ x = 22,
                       y = 12},
      // EQUAL
            new byte2{ x = 17,
                       y = 47},

            new byte2{ x = 2,
                       y = 9}
        };

        internal static int[] TestData_int32 => new int[]
        {
            7,
            3,
            4,
            0
        };


        [UnitTest("Types", "byte2")]
        public static bool Constructor_Byte_Byte()
        {
            byte2 x = new byte2(TestData_LHS[0].x, TestData_LHS[0].y);

            return x.x == TestData_LHS[0].x & 
                   x.y == TestData_LHS[0].y;
        }

        [UnitTest("Types", "byte2")]
        public static bool Constructor_Byte()
        {
            byte2 x = new byte2(TestData_LHS[0].x);

            return x.x == TestData_LHS[0].x & 
                   x.y == TestData_LHS[0].x;
        }

        [UnitTest("Types", "byte2")]
        public static bool Indexer()
        {
            return TestData_LHS[0][0] == TestData_LHS[0].x &
                   TestData_LHS[0][1] == TestData_LHS[0].y;
        }


        [UnitTest("Types", "byte2")]
        public static bool Add()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                byte2 x = TestData_LHS[i] + TestData_RHS[i];

                result &= x.x == (byte)(TestData_LHS[i].x + TestData_RHS[i].x) & 
                          x.y == (byte)(TestData_LHS[i].y + TestData_RHS[i].y);
            }

            return result;
        }

        [UnitTest("Types", "byte2")]
        public static bool Subtract()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                byte2 x = TestData_LHS[i] - TestData_RHS[i];

                result &= x.x == (byte)(TestData_LHS[i].x - TestData_RHS[i].x) & 
                          x.y == (byte)(TestData_LHS[i].y - TestData_RHS[i].y);
            }

            return result;
        }

        [UnitTest("Types", "byte2")]
        public static bool Multiply()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                byte2 x = TestData_LHS[i] * TestData_RHS[i];

                result &= x.x == (byte)(TestData_LHS[i].x * TestData_RHS[i].x) & 
                          x.y == (byte)(TestData_LHS[i].y * TestData_RHS[i].y);
            }

            return result;
        }

        [UnitTest("Types", "byte2")]
        public static bool Divide()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                byte2 x = TestData_LHS[i] / TestData_RHS[i];

                result &= x.x == (byte)(TestData_LHS[i].x / TestData_RHS[i].x) &
                          x.y == (byte)(TestData_LHS[i].y / TestData_RHS[i].y);
            }

            return result;
        }

        [UnitTest("Types", "byte2")]
        public static bool Remainder()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                byte2 x = TestData_LHS[i] % TestData_RHS[i];

                result &= x.x == (byte)(TestData_LHS[i].x % TestData_RHS[i].x) & 
                          x.y == (byte)(TestData_LHS[i].y % TestData_RHS[i].y);
            }

            return result;
        }

        [UnitTest("Types", "byte2")]
        public static bool AND()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                byte2 x = TestData_LHS[i] & TestData_RHS[i];

                result &= x.x == (byte)(TestData_LHS[i].x & TestData_RHS[i].x) &
                          x.y == (byte)(TestData_LHS[i].y & TestData_RHS[i].y);
            }

            return result;
        }

        [UnitTest("Types", "byte2")]
        public static bool OR()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                byte2 x = TestData_LHS[i] | TestData_RHS[i];

                result &= x.x == (byte)(TestData_LHS[i].x | TestData_RHS[i].x) & 
                          x.y == (byte)(TestData_LHS[i].y | TestData_RHS[i].y);
            }

            return result;
        }

        [UnitTest("Types", "byte2")]
        public static bool XOR()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                byte2 x = TestData_LHS[i] ^ TestData_RHS[i];

                result &= x.x == (byte)(TestData_LHS[i].x ^ TestData_RHS[i].x) & 
                          x.y == (byte)(TestData_LHS[i].y ^ TestData_RHS[i].y);
            }

            return result;
        }

        [UnitTest("Types", "byte2")]
        public static bool NOT()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                byte2 x = ~TestData_LHS[i];

                result &= x.x == (byte)(~TestData_LHS[i].x) & 
                          x.y == (byte)(~TestData_LHS[i].y);
            }

            return result;
        }

        [UnitTest("Types", "byte2")]
        public static bool ShiftLeft()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                for (int j = 0; j  < NUM_TESTS; j++)
                {
                    byte2 x = TestData_LHS[i] << TestData_int32[j];

                    result &= x.x == (byte)(TestData_LHS[i].x << TestData_int32[j]) & 
                              x.y == (byte)(TestData_LHS[i].y << TestData_int32[j]);
                }
            }

            return result;
        }

        [UnitTest("Types", "byte2")]
        public static bool ShiftRight()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                for (int j = 0; j  < NUM_TESTS; j++)
                {
                    byte2 x = TestData_LHS[i] >> TestData_int32[j];

                    result &= x.x == (byte)(TestData_LHS[i].x >> TestData_int32[j]) &
                              x.y == (byte)(TestData_LHS[i].y >> TestData_int32[j]);
                }
            }

            return result;
        }


        [UnitTest("Types", "byte2")]
        public static bool Equal()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                bool2 x = TestData_LHS[i] == TestData_RHS[i];

                result &= x.Equals(new bool2(TestData_LHS[i].x == TestData_RHS[i].x,
                                             TestData_LHS[i].y == TestData_RHS[i].y));
            }

            return result;
        }

        [UnitTest("Types", "byte2")]
        public static bool LessThan()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                bool2 x = TestData_LHS[i] < TestData_RHS[i];

                result &= x.Equals(new bool2(TestData_LHS[i].x < TestData_RHS[i].x,
                                             TestData_LHS[i].y < TestData_RHS[i].y));
            }

            return result;
        }

        [UnitTest("Types", "byte2")]
        public static bool GreaterThan()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                bool2 x = TestData_LHS[i] > TestData_RHS[i];

                result &= x.Equals(new bool2(TestData_LHS[i].x > TestData_RHS[i].x,
                                             TestData_LHS[i].y > TestData_RHS[i].y));
            }

            return result;
        }

        [UnitTest("Types", "byte2")]
        public static bool NotEqual()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                bool2 x = TestData_LHS[i] != TestData_RHS[i];

                result &= x.Equals(new bool2(TestData_LHS[i].x != TestData_RHS[i].x,
                                             TestData_LHS[i].y != TestData_RHS[i].y));
            }

            return result;
        }

        [UnitTest("Types", "byte2")]
        public static bool LessThanOrEqual()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                bool2 x = TestData_LHS[i] <= TestData_RHS[i];

                result &= x.Equals(new bool2(TestData_LHS[i].x <= TestData_RHS[i].x,
                                             TestData_LHS[i].y <= TestData_RHS[i].y));
            }

            return result;
        }

        [UnitTest("Types", "byte2")]
        public static bool GreaterThanOrEqual()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                bool2 x = TestData_LHS[i] >= TestData_RHS[i];

                result &= x.Equals(new bool2(TestData_LHS[i].x >= TestData_RHS[i].x,
                                             TestData_LHS[i].y >= TestData_RHS[i].y));
            }

            return result;
        }


        [UnitTest("Types", "byte2")]
        public static bool AllEqual()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                bool x = TestData_LHS[i].Equals(TestData_RHS[i]);

                result &= x == math.all(new bool2(TestData_LHS[i].x == TestData_RHS[i].x,
                                                  TestData_LHS[i].y == TestData_RHS[i].y));
            }

            return result;
        }


        [UnitTest("Types", "byte2")]
        public static bool Shuffle()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                byte4 xxxx = TestData_LHS[i].xxxx;
                result &= xxxx.x == TestData_LHS[i].x &
                          xxxx.y == TestData_LHS[i].x &
                          xxxx.z == TestData_LHS[i].x &
                          xxxx.w == TestData_LHS[i].x;

                byte4 yxxx = TestData_LHS[i].yxxx;
                result &= yxxx.x == TestData_LHS[i].y &
                          yxxx.y == TestData_LHS[i].x &
                          yxxx.z == TestData_LHS[i].x &
                          yxxx.w == TestData_LHS[i].x;

                byte4 xyxx = TestData_LHS[i].xyxx;
                result &= xyxx.x == TestData_LHS[i].x &
                          xyxx.y == TestData_LHS[i].y &
                          xyxx.z == TestData_LHS[i].x &
                          xyxx.w == TestData_LHS[i].x;

                byte4 xxyx = TestData_LHS[i].xxyx;
                result &= xxyx.x == TestData_LHS[i].x &
                          xxyx.y == TestData_LHS[i].x &
                          xxyx.z == TestData_LHS[i].y &
                          xxyx.w == TestData_LHS[i].x;

                byte4 xxxy = TestData_LHS[i].xxxy;
                result &= xxxy.x == TestData_LHS[i].x &
                          xxxy.y == TestData_LHS[i].x &
                          xxxy.z == TestData_LHS[i].x &
                          xxxy.w == TestData_LHS[i].y;

                byte4 yyxx = TestData_LHS[i].yyxx;
                result &= yyxx.x == TestData_LHS[i].y &
                          yyxx.y == TestData_LHS[i].y &
                          yyxx.z == TestData_LHS[i].x &
                          yyxx.w == TestData_LHS[i].x;

                byte4 yxyx = TestData_LHS[i].yxyx;
                result &= yxyx.x == TestData_LHS[i].y &
                          yxyx.y == TestData_LHS[i].x &
                          yxyx.z == TestData_LHS[i].y &
                          yxyx.w == TestData_LHS[i].x;

                byte4 yxxy = TestData_LHS[i].yxxy;
                result &= yxxy.x == TestData_LHS[i].y &
                          yxxy.y == TestData_LHS[i].x &
                          yxxy.z == TestData_LHS[i].x &
                          yxxy.w == TestData_LHS[i].y;

                byte4 xyyx = TestData_LHS[i].xyyx;
                result &= xyyx.x == TestData_LHS[i].x &
                          xyyx.y == TestData_LHS[i].y &
                          xyyx.z == TestData_LHS[i].y &
                          xyyx.w == TestData_LHS[i].x;

                byte4 xyxy = TestData_LHS[i].xyxy;
                result &= xyxy.x == TestData_LHS[i].x &
                          xyxy.y == TestData_LHS[i].y &
                          xyxy.z == TestData_LHS[i].x &
                          xyxy.w == TestData_LHS[i].y;

                byte4 xxyy = TestData_LHS[i].xxyy;
                result &= xxyy.x == TestData_LHS[i].x &
                          xxyy.y == TestData_LHS[i].x &
                          xxyy.z == TestData_LHS[i].y &
                          xxyy.w == TestData_LHS[i].y;

                byte4 yyyx = TestData_LHS[i].yyyx;
                result &= yyyx.x == TestData_LHS[i].y &
                          yyyx.y == TestData_LHS[i].y &
                          yyyx.z == TestData_LHS[i].y &
                          yyyx.w == TestData_LHS[i].x;

                byte4 yyxy = TestData_LHS[i].yyxy;
                result &= yyxy.x == TestData_LHS[i].y &
                          yyxy.y == TestData_LHS[i].y &
                          yyxy.z == TestData_LHS[i].x &
                          yyxy.w == TestData_LHS[i].y;

                byte4 yxyy = TestData_LHS[i].yxyy;
                result &= yxyy.x == TestData_LHS[i].y &
                          yxyy.y == TestData_LHS[i].x &
                          yxyy.z == TestData_LHS[i].y &
                          yxyy.w == TestData_LHS[i].y;

                byte4 xyyy = TestData_LHS[i].xyyy;
                result &= xyyy.x == TestData_LHS[i].x &
                          xyyy.y == TestData_LHS[i].y &
                          xyyy.z == TestData_LHS[i].y &
                          xyyy.w == TestData_LHS[i].y;

                byte4 yyyy = TestData_LHS[i].yyyy;
                result &= yyyy.x == TestData_LHS[i].y &
                          yyyy.y == TestData_LHS[i].y &
                          yyyy.z == TestData_LHS[i].y &
                          yyyy.w == TestData_LHS[i].y;


                byte3 xxx = TestData_LHS[i].xxx;
                result &= xxx.x == TestData_LHS[i].x &
                          xxx.y == TestData_LHS[i].x &
                          xxx.z == TestData_LHS[i].x;

                byte3 yxx = TestData_LHS[i].yxx;
                result &= yxx.x == TestData_LHS[i].y &
                          yxx.y == TestData_LHS[i].x &
                          yxx.z == TestData_LHS[i].x;

                byte3 xyx = TestData_LHS[i].xyx;
                result &= xyx.x == TestData_LHS[i].x &
                          xyx.y == TestData_LHS[i].y &
                          xyx.z == TestData_LHS[i].x;

                byte3 xxy = TestData_LHS[i].xxy;
                result &= xxy.x == TestData_LHS[i].x &
                          xxy.y == TestData_LHS[i].x &
                          xxy.z == TestData_LHS[i].y;

                byte3 yyx = TestData_LHS[i].yyx;
                result &= yyx.x == TestData_LHS[i].y &
                          yyx.y == TestData_LHS[i].y &
                          yyx.z == TestData_LHS[i].x;

                byte3 yxy = TestData_LHS[i].yxy;
                result &= yxy.x == TestData_LHS[i].y &
                          yxy.y == TestData_LHS[i].x &
                          yxy.z == TestData_LHS[i].y;

                byte3 xyy = TestData_LHS[i].xyy;
                result &= xyy.x == TestData_LHS[i].x &
                          xyy.y == TestData_LHS[i].y &
                          xyy.z == TestData_LHS[i].y;

                byte3 yyy = TestData_LHS[i].yyy;
                result &= yyy.x == TestData_LHS[i].y &
                          yyy.y == TestData_LHS[i].y &
                          yyy.z == TestData_LHS[i].y;

                byte2 xx = TestData_LHS[i].xx;
                result &= xx.x == TestData_LHS[i].x &
                          xx.y == TestData_LHS[i].x;

                byte2 yx = TestData_LHS[i].yx;
                result &= yx.x == TestData_LHS[i].y &
                          yx.y == TestData_LHS[i].x;

                byte2 yy = TestData_LHS[i].yy;
                result &= yy.x == TestData_LHS[i].y &
                          yy.y == TestData_LHS[i].y;
            }

            return result;
        }


        [UnitTest("Types", "byte2")]
        public static bool Cast_ToV128()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                v128 x = TestData_LHS[i];

                result &= x.Byte0 == TestData_LHS[i].x &
                          x.Byte1 == TestData_LHS[i].y;
            }

            return result;
        }

        [UnitTest("Types", "byte2")]
        public static bool Cast_FromV128()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                byte2 x = TestData_LHS[i];
                v128 c = x;
                x = c;

                result &= x.x == TestData_LHS[i].x &
                          x.y == TestData_LHS[i].y;
            }

            return result;
        }


        [UnitTest("Types", "byte2")]
        public static bool Cast_ToShort()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                short2 x = TestData_LHS[i];

                result &= x.x == TestData_LHS[i].x &
                          x.y == TestData_LHS[i].y;
            }

            return result;
        }

        [UnitTest("Types", "byte2")]
        public static bool Cast_ToUShort()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                ushort2 x = TestData_LHS[i];

                result &= x.x == TestData_LHS[i].x &
                          x.y == TestData_LHS[i].y;
            }

            return result;
        }

        [UnitTest("Types", "byte2")]
        public static bool Cast_ToInt()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                int2 x = TestData_LHS[i];

                result &= x.x == TestData_LHS[i].x &
                          x.y == TestData_LHS[i].y;
            }

            return result;
        }

        [UnitTest("Types", "byte2")]
        public static bool Cast_ToUInt()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                uint2 x = TestData_LHS[i];

                result &= x.x == TestData_LHS[i].x &
                          x.y == TestData_LHS[i].y;
            }

            return result;
        }

        [UnitTest("Types", "byte2")]
        public static bool Cast_ToLong()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                long2 x = TestData_LHS[i];

                result &= x.x == (long)TestData_LHS[i].x &
                          x.y == (long)TestData_LHS[i].y;
            }

            return result;
        }

        [UnitTest("Types", "byte2")]
        public static bool Cast_ToULong()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                ulong2 x = TestData_LHS[i];

                result &= x.x == (ulong)TestData_LHS[i].x &
                          x.y == (ulong)TestData_LHS[i].y;
            }

            return result;
        }

        [UnitTest("Types", "byte2")]
        public static bool Cast_ToFloat()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                float2 x =TestData_LHS[i];

                result &= maxmath.approx(x.x, (float)TestData_LHS[i].x) &
                          maxmath.approx(x.y, (float)TestData_LHS[i].y);
            }

            return result;
        }

        [UnitTest("Types", "byte2")]
        public static bool Cast_ToDouble()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                double2 x = TestData_LHS[i];

                result &= maxmath.approx(x.x, (double)TestData_LHS[i].x) &
                          maxmath.approx(x.y, (double)TestData_LHS[i].y);
            }

            return result;
        }
    }
}
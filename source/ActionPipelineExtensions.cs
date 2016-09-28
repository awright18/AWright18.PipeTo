
using System;
namespace AWright18.Extensions
{
	public static class ActionPipeToExtensions
	{

		public static void PipeTo<T>(this T val1,Action<T> action)
		{
			action(val1);
		}

		public static void PipeTo<T1,T2> (this T1 val1, Action<T1,T2> action ,T2 val2 )
		{
			action(val1 , val2);
		}

		public static void PipeTo<T1,T2,T3> (this T1 val1, Action<T1,T2,T3> action ,T2 val2,T3 val3 )
		{
			action(val1 , val2, val3);
		}

		public static void PipeTo<T1,T2,T3,T4> (this T1 val1, Action<T1,T2,T3,T4> action ,T2 val2,T3 val3,T4 val4 )
		{
			action(val1 , val2, val3, val4);
		}

		public static void PipeTo<T1,T2,T3,T4,T5> (this T1 val1, Action<T1,T2,T3,T4,T5> action ,T2 val2,T3 val3,T4 val4,T5 val5 )
		{
			action(val1 , val2, val3, val4, val5);
		}

		public static void PipeTo<T1,T2,T3,T4,T5,T6> (this T1 val1, Action<T1,T2,T3,T4,T5,T6> action ,T2 val2,T3 val3,T4 val4,T5 val5,T6 val6 )
		{
			action(val1 , val2, val3, val4, val5, val6);
		}

		public static void PipeTo<T1,T2,T3,T4,T5,T6,T7> (this T1 val1, Action<T1,T2,T3,T4,T5,T6,T7> action ,T2 val2,T3 val3,T4 val4,T5 val5,T6 val6,T7 val7 )
		{
			action(val1 , val2, val3, val4, val5, val6, val7);
		}

		public static void PipeTo<T1,T2,T3,T4,T5,T6,T7,T8> (this T1 val1, Action<T1,T2,T3,T4,T5,T6,T7,T8> action ,T2 val2,T3 val3,T4 val4,T5 val5,T6 val6,T7 val7,T8 val8 )
		{
			action(val1 , val2, val3, val4, val5, val6, val7, val8);
		}

		public static void PipeTo<T1,T2,T3,T4,T5,T6,T7,T8,T9> (this T1 val1, Action<T1,T2,T3,T4,T5,T6,T7,T8,T9> action ,T2 val2,T3 val3,T4 val4,T5 val5,T6 val6,T7 val7,T8 val8,T9 val9 )
		{
			action(val1 , val2, val3, val4, val5, val6, val7, val8, val9);
		}

		public static void PipeTo<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> (this T1 val1, Action<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> action ,T2 val2,T3 val3,T4 val4,T5 val5,T6 val6,T7 val7,T8 val8,T9 val9,T10 val10 )
		{
			action(val1 , val2, val3, val4, val5, val6, val7, val8, val9, val10);
		}

		public static void PipeTo<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> (this T1 val1, Action<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> action ,T2 val2,T3 val3,T4 val4,T5 val5,T6 val6,T7 val7,T8 val8,T9 val9,T10 val10,T11 val11 )
		{
			action(val1 , val2, val3, val4, val5, val6, val7, val8, val9, val10, val11);
		}

		public static void PipeTo<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> (this T1 val1, Action<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> action ,T2 val2,T3 val3,T4 val4,T5 val5,T6 val6,T7 val7,T8 val8,T9 val9,T10 val10,T11 val11,T12 val12 )
		{
			action(val1 , val2, val3, val4, val5, val6, val7, val8, val9, val10, val11, val12);
		}

		public static void PipeTo<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> (this T1 val1, Action<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> action ,T2 val2,T3 val3,T4 val4,T5 val5,T6 val6,T7 val7,T8 val8,T9 val9,T10 val10,T11 val11,T12 val12,T13 val13 )
		{
			action(val1 , val2, val3, val4, val5, val6, val7, val8, val9, val10, val11, val12, val13);
		}

		public static void PipeTo<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> (this T1 val1, Action<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> action ,T2 val2,T3 val3,T4 val4,T5 val5,T6 val6,T7 val7,T8 val8,T9 val9,T10 val10,T11 val11,T12 val12,T13 val13,T14 val14 )
		{
			action(val1 , val2, val3, val4, val5, val6, val7, val8, val9, val10, val11, val12, val13, val14);
		}

		public static void PipeTo<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> (this T1 val1, Action<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> action ,T2 val2,T3 val3,T4 val4,T5 val5,T6 val6,T7 val7,T8 val8,T9 val9,T10 val10,T11 val11,T12 val12,T13 val13,T14 val14,T15 val15 )
		{
			action(val1 , val2, val3, val4, val5, val6, val7, val8, val9, val10, val11, val12, val13, val14, val15);
		}

	}
}
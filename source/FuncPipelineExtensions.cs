
using System;

namespace AWright18.Extensions
{

	public static class FuncThenExtensions
	{
	
		public static T Then<T> (Func<T> func)
		{
			return func();
		}

		public static T2 Then<T1,T2> (this T1 val1, Func<T1,T2> func  )
		{
			return func(val1 );
		}

		public static T3 Then<T1,T2,T3> (this T1 val1, Func<T1,T2,T3> func ,T2 val2 )
		{
			return func(val1 , val2);
		}

		public static T4 Then<T1,T2,T3,T4> (this T1 val1, Func<T1,T2,T3,T4> func ,T2 val2,T3 val3 )
		{
			return func(val1 , val2, val3);
		}

		public static T5 Then<T1,T2,T3,T4,T5> (this T1 val1, Func<T1,T2,T3,T4,T5> func ,T2 val2,T3 val3,T4 val4 )
		{
			return func(val1 , val2, val3, val4);
		}

		public static T6 Then<T1,T2,T3,T4,T5,T6> (this T1 val1, Func<T1,T2,T3,T4,T5,T6> func ,T2 val2,T3 val3,T4 val4,T5 val5 )
		{
			return func(val1 , val2, val3, val4, val5);
		}

		public static T7 Then<T1,T2,T3,T4,T5,T6,T7> (this T1 val1, Func<T1,T2,T3,T4,T5,T6,T7> func ,T2 val2,T3 val3,T4 val4,T5 val5,T6 val6 )
		{
			return func(val1 , val2, val3, val4, val5, val6);
		}

		public static T8 Then<T1,T2,T3,T4,T5,T6,T7,T8> (this T1 val1, Func<T1,T2,T3,T4,T5,T6,T7,T8> func ,T2 val2,T3 val3,T4 val4,T5 val5,T6 val6,T7 val7 )
		{
			return func(val1 , val2, val3, val4, val5, val6, val7);
		}

		public static T9 Then<T1,T2,T3,T4,T5,T6,T7,T8,T9> (this T1 val1, Func<T1,T2,T3,T4,T5,T6,T7,T8,T9> func ,T2 val2,T3 val3,T4 val4,T5 val5,T6 val6,T7 val7,T8 val8 )
		{
			return func(val1 , val2, val3, val4, val5, val6, val7, val8);
		}

		public static T10 Then<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> (this T1 val1, Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> func ,T2 val2,T3 val3,T4 val4,T5 val5,T6 val6,T7 val7,T8 val8,T9 val9 )
		{
			return func(val1 , val2, val3, val4, val5, val6, val7, val8, val9);
		}

		public static T11 Then<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> (this T1 val1, Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> func ,T2 val2,T3 val3,T4 val4,T5 val5,T6 val6,T7 val7,T8 val8,T9 val9,T10 val10 )
		{
			return func(val1 , val2, val3, val4, val5, val6, val7, val8, val9, val10);
		}

		public static T12 Then<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> (this T1 val1, Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> func ,T2 val2,T3 val3,T4 val4,T5 val5,T6 val6,T7 val7,T8 val8,T9 val9,T10 val10,T11 val11 )
		{
			return func(val1 , val2, val3, val4, val5, val6, val7, val8, val9, val10, val11);
		}

		public static T13 Then<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> (this T1 val1, Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> func ,T2 val2,T3 val3,T4 val4,T5 val5,T6 val6,T7 val7,T8 val8,T9 val9,T10 val10,T11 val11,T12 val12 )
		{
			return func(val1 , val2, val3, val4, val5, val6, val7, val8, val9, val10, val11, val12);
		}

		public static T14 Then<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> (this T1 val1, Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> func ,T2 val2,T3 val3,T4 val4,T5 val5,T6 val6,T7 val7,T8 val8,T9 val9,T10 val10,T11 val11,T12 val12,T13 val13 )
		{
			return func(val1 , val2, val3, val4, val5, val6, val7, val8, val9, val10, val11, val12, val13);
		}

		public static T15 Then<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> (this T1 val1, Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> func ,T2 val2,T3 val3,T4 val4,T5 val5,T6 val6,T7 val7,T8 val8,T9 val9,T10 val10,T11 val11,T12 val12,T13 val13,T14 val14 )
		{
			return func(val1 , val2, val3, val4, val5, val6, val7, val8, val9, val10, val11, val12, val13, val14);
		}

	} 
}
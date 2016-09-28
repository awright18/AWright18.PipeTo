
using System;

namespace AWright18.Extensions
{
	public static class TupleFuncThenExtensions
	{
		public static T2 Then<T1,T2> (this Tuple<T1> tuple, Func<T1,T2> func)
		{
			return func(tuple.Item1);
		}

		public static T3 Then<T1,T2,T3> (this Tuple<T1,T2> tuple, Func<T1,T2,T3> func)
		{
			return func(tuple.Item1, tuple.Item2);
		}

		public static T4 Then<T1,T2,T3,T4> (this Tuple<T1,T2,T3> tuple, Func<T1,T2,T3,T4> func)
		{
			return func(tuple.Item1, tuple.Item2, tuple.Item3);
		}

		public static T5 Then<T1,T2,T3,T4,T5> (this Tuple<T1,T2,T3,T4> tuple, Func<T1,T2,T3,T4,T5> func)
		{
			return func(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4);
		}

		public static T6 Then<T1,T2,T3,T4,T5,T6> (this Tuple<T1,T2,T3,T4,T5> tuple, Func<T1,T2,T3,T4,T5,T6> func)
		{
			return func(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5);
		}

		public static T7 Then<T1,T2,T3,T4,T5,T6,T7> (this Tuple<T1,T2,T3,T4,T5,T6> tuple, Func<T1,T2,T3,T4,T5,T6,T7> func)
		{
			return func(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6);
		}

		public static T8 Then<T1,T2,T3,T4,T5,T6,T7,T8> (this Tuple<T1,T2,T3,T4,T5,T6,T7> tuple, Func<T1,T2,T3,T4,T5,T6,T7,T8> func)
		{
			return func(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7);
		}

	} 
}
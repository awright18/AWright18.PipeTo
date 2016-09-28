
using System;

namespace AWright18.Extensions
{
	public static class TupleActionPipeToExtensions
	{
		public static void PipeTo<T> (this Tuple<T> tuple, Action<T> action)
		{
			action(tuple.Item1);
		}

		public static void PipeTo<T1,T2> (this Tuple<T1,T2> tuple, Action<T1,T2> action)
		{
			action(tuple.Item1, tuple.Item2);
		}

		public static void PipeTo<T1,T2,T3> (this Tuple<T1,T2,T3> tuple, Action<T1,T2,T3> action)
		{
			action(tuple.Item1, tuple.Item2, tuple.Item3);
		}

		public static void PipeTo<T1,T2,T3,T4> (this Tuple<T1,T2,T3,T4> tuple, Action<T1,T2,T3,T4> action)
		{
			action(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4);
		}

		public static void PipeTo<T1,T2,T3,T4,T5> (this Tuple<T1,T2,T3,T4,T5> tuple, Action<T1,T2,T3,T4,T5> action)
		{
			action(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5);
		}

		public static void PipeTo<T1,T2,T3,T4,T5,T6> (this Tuple<T1,T2,T3,T4,T5,T6> tuple, Action<T1,T2,T3,T4,T5,T6> action)
		{
			action(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6);
		}

		public static void PipeTo<T1,T2,T3,T4,T5,T6,T7> (this Tuple<T1,T2,T3,T4,T5,T6,T7> tuple, Action<T1,T2,T3,T4,T5,T6,T7> action)
		{
			action(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7);
		}

	} 
}
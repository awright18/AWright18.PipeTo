         
using System;
namespace AWright18.Extensions
{
    public static class PipeToActionExtensions
    {      
        public static void PipeTo<T>(this T val1, Action<T> action)
        {
            action(val1);
        }
        public static  void PipeTo<T1,T2> (this T1 val1, Action<T1,T2> action, T2 value2)
        {
            action(val1, value2);
        }
        public static  void PipeTo<T1,T2,T3> (this T1 val1, Action<T1,T2,T3> action, T2 value2, T3 value3)
        {
            action(val1, value2, value3);
        }
        public static  void PipeTo<T1,T2,T3,T4> (this T1 val1, Action<T1,T2,T3,T4> action, T2 value2, T3 value3, T4 value4)
        {
            action(val1, value2, value3, value4);
        }
        public static  void PipeTo<T1,T2,T3,T4,T5> (this T1 val1, Action<T1,T2,T3,T4,T5> action, T2 value2, T3 value3, T4 value4, T5 value5)
        {
            action(val1, value2, value3, value4, value5);
        }
        public static  void PipeTo<T1,T2,T3,T4,T5,T6> (this T1 val1, Action<T1,T2,T3,T4,T5,T6> action, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6)
        {
            action(val1, value2, value3, value4, value5, value6);
        }
        public static  void PipeTo<T1,T2,T3,T4,T5,T6,T7> (this T1 val1, Action<T1,T2,T3,T4,T5,T6,T7> action, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7)
        {
            action(val1, value2, value3, value4, value5, value6, value7);
        }
        public static  void PipeTo<T1,T2,T3,T4,T5,T6,T7,T8> (this T1 val1, Action<T1,T2,T3,T4,T5,T6,T7,T8> action, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8)
        {
            action(val1, value2, value3, value4, value5, value6, value7, value8);
        }
        public static  void PipeTo<T1,T2,T3,T4,T5,T6,T7,T8,T9> (this T1 val1, Action<T1,T2,T3,T4,T5,T6,T7,T8,T9> action, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9)
        {
            action(val1, value2, value3, value4, value5, value6, value7, value8, value9);
        }
        public static  void PipeTo<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> (this T1 val1, Action<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> action, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10)
        {
            action(val1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
        }
        public static  void PipeTo<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> (this T1 val1, Action<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> action, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11)
        {
            action(val1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
        }
        public static  void PipeTo<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> (this T1 val1, Action<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> action, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12)
        {
            action(val1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        }
        public static  void PipeTo<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> (this T1 val1, Action<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> action, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13)
        {
            action(val1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        }
        public static  void PipeTo<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> (this T1 val1, Action<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> action, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14)
        {
            action(val1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        }
        public static  void PipeTo<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> (this T1 val1, Action<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> action, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15)
        {
            action(val1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        }
        public static  void PipeTo<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> (this T1 val1, Action<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> action, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15, T16 value16)
        {
            action(val1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
        }
    }
}
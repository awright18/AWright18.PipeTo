
            
using System;
namespace AWright18.Extensions
{
    public static class PipeToFuncExtensions
    {                  

        public static T2 PipeTo<T1,T2> (this T1 val1, Func<T1,T2> func  )
        {
            return func(val1 );
        }
                
        public static T3 PipeTo<T1,T2,T3> (this T1 val1, Func<T1,T2,T3> func ,T2 value2 )
        {
            return func(val1 , value2);
        }
                
        public static T4 PipeTo<T1,T2,T3,T4> (this T1 val1, Func<T1,T2,T3,T4> func ,T2 value2,T3 value3 )
        {
            return func(val1 , value2, value3);
        }
                
        public static T5 PipeTo<T1,T2,T3,T4,T5> (this T1 val1, Func<T1,T2,T3,T4,T5> func ,T2 value2,T3 value3,T4 value4 )
        {
            return func(val1 , value2, value3, value4);
        }
                
        public static T6 PipeTo<T1,T2,T3,T4,T5,T6> (this T1 val1, Func<T1,T2,T3,T4,T5,T6> func ,T2 value2,T3 value3,T4 value4,T5 value5 )
        {
            return func(val1 , value2, value3, value4, value5);
        }
                
        public static T7 PipeTo<T1,T2,T3,T4,T5,T6,T7> (this T1 val1, Func<T1,T2,T3,T4,T5,T6,T7> func ,T2 value2,T3 value3,T4 value4,T5 value5,T6 value6 )
        {
            return func(val1 , value2, value3, value4, value5, value6);
        }
                
        public static T8 PipeTo<T1,T2,T3,T4,T5,T6,T7,T8> (this T1 val1, Func<T1,T2,T3,T4,T5,T6,T7,T8> func ,T2 value2,T3 value3,T4 value4,T5 value5,T6 value6,T7 value7 )
        {
            return func(val1 , value2, value3, value4, value5, value6, value7);
        }
                
        public static T9 PipeTo<T1,T2,T3,T4,T5,T6,T7,T8,T9> (this T1 val1, Func<T1,T2,T3,T4,T5,T6,T7,T8,T9> func ,T2 value2,T3 value3,T4 value4,T5 value5,T6 value6,T7 value7,T8 value8 )
        {
            return func(val1 , value2, value3, value4, value5, value6, value7, value8);
        }
                
        public static T10 PipeTo<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> (this T1 val1, Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> func ,T2 value2,T3 value3,T4 value4,T5 value5,T6 value6,T7 value7,T8 value8,T9 value9 )
        {
            return func(val1 , value2, value3, value4, value5, value6, value7, value8, value9);
        }
                
        public static T11 PipeTo<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> (this T1 val1, Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> func ,T2 value2,T3 value3,T4 value4,T5 value5,T6 value6,T7 value7,T8 value8,T9 value9,T10 value10 )
        {
            return func(val1 , value2, value3, value4, value5, value6, value7, value8, value9, value10);
        }
                
        public static T12 PipeTo<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> (this T1 val1, Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> func ,T2 value2,T3 value3,T4 value4,T5 value5,T6 value6,T7 value7,T8 value8,T9 value9,T10 value10,T11 value11 )
        {
            return func(val1 , value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
        }
                
        public static T13 PipeTo<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> (this T1 val1, Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> func ,T2 value2,T3 value3,T4 value4,T5 value5,T6 value6,T7 value7,T8 value8,T9 value9,T10 value10,T11 value11,T12 value12 )
        {
            return func(val1 , value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        }
                
        public static T14 PipeTo<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> (this T1 val1, Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> func ,T2 value2,T3 value3,T4 value4,T5 value5,T6 value6,T7 value7,T8 value8,T9 value9,T10 value10,T11 value11,T12 value12,T13 value13 )
        {
            return func(val1 , value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        }
                
        public static T15 PipeTo<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> (this T1 val1, Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> func ,T2 value2,T3 value3,T4 value4,T5 value5,T6 value6,T7 value7,T8 value8,T9 value9,T10 value10,T11 value11,T12 value12,T13 value13,T14 value14 )
        {
            return func(val1 , value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        }
                
    }
}             
            
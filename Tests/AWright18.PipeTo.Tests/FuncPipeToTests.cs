using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace AWright18.Extensions.Tests
{
    public class FuncPipeToTests
    {
        [Fact]
        public void CanPipeToFuncWithOneArg()
        {
            var someValue = "some value";

            var result = someValue.PipeTo((value) => value);

            Assert.Equal(someValue, result);
        }

        [Fact]
        public void CanPipeToFuncWithTwoArgs()
        {
            var value1 = "value1";
            var value2 = "value2";
            var expected = "value1,value2";

            Func<string, string, string> func = (v1, v2) => string.Join(",", value1, value2);

            var result = value1.PipeTo(func, value2);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void CanPipeToFuncWith14Args()
        {
            var value1 = "value1";
            var value2 = "value2";
            var value3 = "value3";
            var value4 = "value4";
            var value5 = "value5";
            var value6 = "value6";
            var value7 = "value7";
            var value8 = "value8";
            var value9 = "value9";
            var value10 = "value10";
            var value11 = "value11";
            var value12 = "value12";
            var value13 = "value13";
            var value14 = "value14";

            var expected = "value1,value2,value3,value4,value5,value6,value7,value8,value9,value10,value11,value12,value13,value14";

            Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> func =
                (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14) =>
            string.Join(",", value1, value2, value3, value4, value5,
            value6, value7, value8, value9, value10
               , value11, value12, value13, value14);

            var result = value1.PipeTo(func,
                value2, value3, value4, value5,
                value6, value7, value8, value9,
                value10, value11, value12, value13, value14);

            Assert.Equal(expected, result);
        }

        [Theory, ClassData(typeof(FuncPipeToTestData))]
        public void CanPipeToFuncWithValidValues(string expected, string firstValue, dynamic func,
            params string[] parameters)
        {
            object result = null;

            if (parameters != null && parameters.Any())
            {
                var repeat = parameters.Length + 2;

                var method = typeof(PipeToFuncExtensions).GetMethods()
                    .First(m => m.Name == "PipeTo"
                                && m.GetParameters().Length == repeat);

                var genericTypes = Enumerable.Repeat(typeof(string), repeat).ToArray();

                var genericMethod = method.MakeGenericMethod(genericTypes);

                var updatedParameters = new List<object>() { firstValue, func };

                updatedParameters.AddRange(parameters);

                result = genericMethod.Invoke(null, updatedParameters.ToArray());
            }
            else
            {
                var method = typeof(PipeToFuncExtensions).GetMethods()
                   .First(m => m.Name == "PipeTo"
                               && m.GetParameters().Length == 2);

                var genericTypes = Enumerable.Repeat(typeof(string), 2).ToArray();

                var genericMethod = method.MakeGenericMethod(genericTypes);

                result = genericMethod.Invoke(null, new object[] { "value1", func });
            }

            Assert.Equal(expected, result);
        }
    }
}

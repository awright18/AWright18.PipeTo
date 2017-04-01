using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace AWright18.Extensions.Tests
{
    public class ActionPipeToTests
    {
        [Fact]
        public void CanPipeToActionWithOneArg()
        {
            var someValue = "some value";

            var expectedValue = "some value,some value";

            string result = null;

            someValue.PipeTo((value) => result = string.Join(",",value,value) );

            Assert.Equal(expectedValue, result);
        }

        [Fact]
        public void CanPipeToFuncWithTwoArgs()
        {
            var value1 = "value1";
            var value2 = "value2";
            var value3 = "value3";

            var expected = "value1,value2,value3";
            
            string result = null;

            Action<string, string, string> action = (v1, v2,v3) => result = string.Join(",", value1, value2,value3);

            value1.PipeTo(action, value2,value3);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void CanPipeToActionWith15Args()
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
            var value15 = "value15";

            string result = null;

            var expected = "value1,value2,value3,value4,value5,value6,value7,value8,value9,value10,value11,value12,value13,value14,value15";

            Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string,string> action =
                (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14,v15) =>
                 result = string.Join(",", value1, value2, value3, value4, value5,
                                           value6, value7, value8, value9, value10
                                           , value11, value12, value13, value14, value15);
            value1.PipeTo(action,
                value2, value3, value4, value5,
                value6, value7, value8, value9,
                value10, value11, value12, value13, value14,value15);

            Assert.Equal(expected, result);
        }

        [Theory, ClassData(typeof(ActionPipeToTestData))]
        public void CanPipeToFuncWithValidValues(string firstValue, dynamic action,
            params string[] parameters)
        {
          
            if (parameters != null && parameters.Any())
            {
                var numberOfParamters = parameters.Length + 2;

                var numberOfGenericParameters = parameters.Length + 1;

                var method = typeof(PipeToActionExtensions).GetMethods()
                    .First(m => m.Name == "PipeTo"
                                && m.GetParameters().Length == numberOfParamters);

                var genericTypes = Enumerable.Repeat(typeof(string), numberOfGenericParameters).ToArray();

                var genericMethod = method.MakeGenericMethod(genericTypes);

                var updatedParameters = new List<object>() { firstValue, action };

                updatedParameters.AddRange(parameters);

                genericMethod.Invoke(null, updatedParameters.ToArray());
                
            }
            else
            {
                var method = typeof(PipeToActionExtensions).GetMethods()
                   .First(m => m.Name == "PipeTo"
                               && m.GetParameters().Length == 2);

                var genericTypes = Enumerable.Repeat(typeof(string), 1).ToArray();

                var genericMethod = method.MakeGenericMethod(genericTypes);

                genericMethod.Invoke(null, new object[] { "value1", action });
            }

           //Doesn't Throw means it passed! So nothing to assert
        }
    }
}

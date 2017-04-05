using System;
using System.Collections;
using System.Collections.Generic;

namespace AWright18.PipeTo.Tests
{
    public class ActionPipeToTestData : IEnumerable<object[]>
    {

        public IEnumerator<object[]> GetEnumerator()
        {
            for (int i = 16; i <= 16; i++)
            {
                if (i == 1)
                {
                    yield return new object[]
                    {
                         "value1", GetAction(i), null
                    };
                }
                else
                {
                    var action = GetAction(i);
                    var parameters = GetParameters(i);
                    yield return new object[]
                    {
                        "value1", action, parameters
                    };
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()

        { return GetEnumerator(); }

        public string GetExpectedValue(int numberOfValues)
        {
            var values = new List<string>();

            for (int i = 1; i <= numberOfValues; i++)
            {
                values.Add($"value{i}");
            }

            var expectedValue = string.Join(",", values);

            return expectedValue;
        }

        public dynamic GetAction(int numberOfGenericParameters)
        {
            var funcs = new Dictionary<int, dynamic>
            {
                { 1, (Action<string>)(v1 => string.Join(",",v1,v1))},

                { 2, (Action<string,string>)((v1,v2) => string.Join(",",v1,v2))  },

                { 3, (Action<string,string,string>)((v1,v2,v3) => string.Join(",",v1,v2,v3))},

                { 4, (Action<string,string,string,string>)((v1,v2,v3,v4) => string.Join(",",v1,v2,v3,v4))},

                { 5, (Action<string,string,string,string,string>)((v1,v2,v3,v4,v5) => string.Join(",",v1,v2,v3,v4,v5))},

                { 6, (Action<string,string,string,string,string,string>)((v1,v2,v3,v4,v5,v6) => string.Join(",",v1,v2,v3,v4,v5,v6))},

                { 7, (Action<string,string,string,string,string,string,string>)((v1,v2,v3,v4,v5,v6,v7) => string.Join(",",v1,v2,v3,v4,v5,v6,v7))},

                { 8, (Action<string,string,string,string,string,string,string,string>)((v1,v2,v3,v4,v5,v6,v7,v8) => string.Join(",",v1,v2,v3,v4,v5,v6,v7,v8))  },

                { 9, (Action<string,string,string,string,string,string,string,string,string>)((v1,v2,v3,v4,v5,v6,v7,v8,v9) => string.Join(",",v1,v2,v3,v4,v5,v6,v7,v8,v9))  },

                { 10, (Action<string,string,string,string,string,string,string,string,string,string>)((v1,v2,v3,v4,v5,v6,v7,v8,v9,v10) => string.Join(",",v1,v2,v3,v4,v5,v6,v7,v8,v9,v10))  },

                { 11,(Action<string,string,string,string,string,string,string,string,string,string,string>)((v1,v2,v3,v4,v5,v6,v7,v8,v9,v10,v11) => string.Join(",",v1,v2,v3,v4,v5,v6,v7,v8,v9,v10,v11))  },

                { 12,(Action<string,string,string,string,string,string,string,string,string,string,string,string>)((v1,v2,v3,v4,v5,v6,v7,v8,v9,v10,v11,v12) => string.Join(",",v1,v2,v3,v4,v5,v6,v7,v8,v9,v10,v11,v12))  },

                { 13,(Action<string,string,string,string,string,string,string,string,string,string,string,string,string>)((v1,v2,v3,v4,v5,v6,v7,v8,v9,v10,v11,v12,v13) => string.Join(",",v1,v2,v3,v4,v5,v6,v7,v8,v9,v10,v11,v12,v13))  },

                { 14,(Action<string,string,string,string,string,string,string,string,string,string,string,string,string,string>)((v1,v2,v3,v4,v5,v6,v7,v8,v9,v10,v11,v12,v13,v14) => string.Join(",",v1,v2,v3,v4,v5,v6,v7,v8,v9,v10,v11,v12,v13,v14))  },

                { 15,(Action<string,string,string,string,string,string,string,string,string,string,string,string,string,string,string>)((v1,v2,v3,v4,v5,v6,v7,v8,v9,v10,v11,v12,v13,v14,v15) => string.Join(",",v1,v2,v3,v4,v5,v6,v7,v8,v9,v10,v11,v12,v13,v14,v15 ))  },

                { 16,(Action<string,string,string,string,string,string,string,string,string,string,string,string,string,string,string,string>)((v1,v2,v3,v4,v5,v6,v7,v8,v9,v10,v11,v12,v13,v14,v15,v16) => string.Join(",",v1,v2,v3,v4,v5,v6,v7,v8,v9,v10,v11,v12,v13,v14,v15,v16 ))  }
            };

            return funcs[numberOfGenericParameters];
        }

        public string[] GetParameters(int numberOfParameters)
        {
            var parameters = new List<string>();

            for (uint i = 1; i < numberOfParameters; i++)
            {
                var parameterNumber = i + 1;

                parameters.Add($"value{parameterNumber}");
            }

            return parameters.ToArray();
        }
    }
}

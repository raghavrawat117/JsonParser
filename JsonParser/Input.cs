namespace JsonParser
{
    public static class Input
    {
        public static string json =@"[
    {
        ""propertyA"": ""000000000"",
        ""propertyA"": 123,
        ""id"": 1137,
        
        ""nested0"": {
            ""id"": 1,
            ""name"": ""string""
        },
        ""nested1"": {
            ""code"": ""ABC"",
            ""id"": 5,
            ""name"": ""NVBCNA""
        },
        ""nested3"": {
            ""code"": ""4564"",
            ""someOtherProperty"": ""028088050"",
            ""AnotherNestedProperty"": {
                ""id"": 5,
                ""name"": ""zdsfsdfdsfdsfds"",
                ""code"": ""ASADASAD""
            }
        },
        ""nested2"": {
            ""nested1"": ""test"",
            ""nested11"": {
                ""nested"": ""sdfsdfdsfsdf"",
                ""id"": 4,
                ""name"": ""adadsdasds""
            }
        }
    },
    {
        ""propertyA"": ""000000000"",
        ""propertyA"": 678,
        ""id"": 501,
        
        ""nested0"": {
            ""id"": 1,
            ""name"": ""string""
        },
        ""nested1"": {
            ""code"": ""ABC"",
            ""id"": 5,
            ""name"": ""NVBCNA""
        },
        ""nested3"": {
            ""code"": ""046"",
            ""someOtherProperty"": ""028088050"",
            ""AnotherNestedProperty"": {
                ""id"": 5,
                ""name"": ""asdasdasdsa"",
                ""code"": ""ASADASAD""
            }
        },
        ""nested2"": {
            ""nested1"": ""test"",
            ""nested11"": {
                ""nested"": ""sdfsdfdsfsdf"",
                ""id"": 4,
                ""name"": ""adadsdasds""
            }
        }
    }
]";
    }
}
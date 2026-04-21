### 0. download/git clone and run
`cd JsonParser\JsonParser`
`dotnet build`
`dotnet run`

### 1. Paste large json file as
``` c#
public static class Input
    {
        public static string json =@"[{...}]";
    {
```

For changing it collapse the `string json` and remove/delete the entore property.

### 2. Parsing to dynamic using NewtonSoft Json
From any Nested Structure it can read the desired path, currently uses `.id`

### 3. multi line edit CTRL + Shift + L 
Output has prefix of `,` select that and key combination to edit multiline.
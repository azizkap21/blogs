1. Global using
Some frequently used namespaces have been added implicitly. It can be enabled or disabled in project file

```
<PropertyGroup>
  <ImplicitUsings>enable</ImplicitUsings>
</PropertyGroup>
```

We can add more usings which are not added by default or remove it if it conflics with our namespaces in the `ItemGroup` section of the project file

```
<ItemGroup>
  <Using Include="System.Linq.Expressions" />
  <Using Include="System.Reflection" />
  <Using Remove="System.Linq" />
</ItemGroup>

```

We can add global using in a file 
```
global using System.Linq.Expressions;
global using System.Reflection;
```
for this we can use `Program.cs` file or create `GlobalUsin.cs` file in each project. 

2. Namespace improvements

Now we can declare file level namespace without {} curly braces, if we don't have nested namespace in the same file. 

for example

```
namespace Xe.Api.Launchpad.Services;

public class RecipientService
{
  ...
  ...  
}

```

3. Top-level statements: Programs withoug main methods:



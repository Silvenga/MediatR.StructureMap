# MediatR.StructureMap
StructureMap configuration helper for MediatR. 

[![Build status](https://img.shields.io/appveyor/ci/Silvenga/mediatr-StructureMap.svg?maxAge=86400&style=flat-square)](https://ci.appveyor.com/project/Silvenga/mediatr-StructureMap)
[![Nuget Package](https://img.shields.io/nuget/v/MediatR.StructureMap.svg?maxAge=86400&style=flat-square)](https://www.nuget.org/packages/MediatR.StructureMap/)
[![License](https://img.shields.io/github/license/silvenga/MediatR.StructureMap.svg?maxAge=86400&style=flat-square)](https://github.com/Silvenga/MediatR.StructureMap/blob/master/LICENSE)
 
```
Install-Package MediatR.StructureMap
```

Example usage:

```csharp
// using MediatR;
// using MediatR.StructureMap;
// using StructureMap;
// ...

// Bind required services.
IContainer container = new Container();
container.BindMediatR();

// That's it! Make sure to bind the handlers as needed.
// TODO Write
```

## TODO
- [ ] Write docs
- [ ] Publish Nuget package
- [ ] CI Server
- [ ] Tests
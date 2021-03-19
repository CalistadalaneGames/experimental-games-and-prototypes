## /ApplicationData/Runtime/Embedded/

This is where all *embedded* application audio assets should be stored.

**/ApplicationData/Runtime/Embedded/** *is not* created at application runtime.

### Building these files as a project resource
##### Visual Studio 2019
To build runtime in `/ApplicationData/Runtime/Embedded/` as project resources, set the file properties as such:
```
Build Action: Resource
```

> This file is a placeholder to ensure that **/ApplicationData/Runtime/Embedded/** is included in the GitHub repository.
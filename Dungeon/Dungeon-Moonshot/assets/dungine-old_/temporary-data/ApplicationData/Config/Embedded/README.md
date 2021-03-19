## /ApplicationData/Config/Embedded/

This is where all *embedded* configurations should be stored.

**/ApplicationData/Config/Embedded/** *is not* created locally at application runtime.

### Building these files as a project resource
##### Visual Studio 2019
To build configurations in `/ApplicationData/Config/Embedded/` as project resources, set the file properties as such:
```
Build Action: Resource
```

> This file is a placeholder to ensure that **/ApplicationData/Config/Embedded/** is included in the GitHub repository.
## /ApplicationData/Asset/Image/Embedded/

This is where all *embedded* application image assets should be stored.

**/ApplicationData/Asset/Image/Embedded/** *is not* created locally at application runtime.

### Building these files as a project resource
##### Visual Studio 2019
To build image files in `/ApplicationData/Asset/Image/Embedded/` as project resources, set the file properties as such:
```
Build Action: Resource
```

> This file is a placeholder to ensure that **/ApplicationData/Asset/Image/Embedded/** is included in the GitHub repository.
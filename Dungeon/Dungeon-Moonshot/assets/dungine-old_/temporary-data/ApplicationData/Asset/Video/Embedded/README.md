## /ApplicationData/Asset/Video/Embedded/

This is where all *embedded* application video assets should be stored.

**/ApplicationData/Asset/Video/Embedded/** *is not* created locally at application runtime.

### Building these files as a project resource
##### Visual Studio 2019
To build video files in `/ApplicationData/Asset/Video/Embedded/` as project resources, set the file properties as such:
```
Build Action: Resource
```

> This file is a placeholder to ensure that **/ApplicationData/Asset/Video/Embedded/** is included in the GitHub repository.
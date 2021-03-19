## /ApplicationData/ThirdParty/

This is where all *embedded* third-party data should be stored.

By default, this folder is *not* created at application runtime.

### Building these files as a project resource
##### Visual Studio 2019
To build third-party data in `/ApplicationData/ThirdParty/Embedded/` as project resources, set the file properties as such:
```
Build Action: Resource
```

> This file is a placeholder to ensure that **/ApplicationData/ThirdParty/Embedded/** is included in the GitHub repository.
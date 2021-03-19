## /ApplicationData/Database/Embedded/

This is where all *embedded* application databases should be stored.

**/ApplicationData/Database/Embedded/** *is not* created locally at application runtime.

### Building these files as a project resource
##### Visual Studio 2019
To build databases in `/ApplicationData/Database/Embedded/` as project resources, set the file properties as such:
```
Build Action: Resource
```

> This file is a placeholder to ensure that **/ApplicationData/Database/Embedded/** is included in the GitHub repository.
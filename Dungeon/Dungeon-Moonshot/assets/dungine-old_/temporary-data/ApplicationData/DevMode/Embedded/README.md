## /ApplicationData/DevMode/Embedded/

This is where all *embedded* development data should be stored.

**/ApplicationData/DevMode/Embedded/** *is not* created locally at application runtime.

### Building these files as a project resource
##### Visual Studio 2019
To build development data in `/Audio/Embedded/` as project resources, set the file properties as such:
```
Build Action: Resource
```

> This file is a placeholder to ensure that **/ApplicationData/DevMode/Embedded/** is included in the GitHub repository.
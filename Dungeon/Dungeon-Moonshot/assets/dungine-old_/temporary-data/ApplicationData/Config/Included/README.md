## /ApplicationData/Config/Included/

This is where all audio assets that will be copied locally at runtime are stored.

### Copying data locally at runtime
##### Visual Studio 2019
To copy configurations located in `/ApplicationData/Config/Included/` locally at runtime, set the file properties as such:
```
Build Action: None
Copy to Output Directory: Copy always
```

> This file is a placeholder to ensure that **/ApplicationData/Config/Included/** is included in the GitHub repository, and created at application runtime.
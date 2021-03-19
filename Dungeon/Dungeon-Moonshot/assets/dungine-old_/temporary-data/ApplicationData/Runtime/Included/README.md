## /ApplicationData/Runtime/Included/

This is where all data that will be copied locally at runtime is stored.

### Copying data locally at runtime
##### Visual Studio 2019
To copy runtime data located in `/ApplicationData/Runtime/Included/` locally at runtime, set the file properties as such:
```
Build Action: None
Copy to Output Directory: Copy always
```

> This file is a placeholder to ensure that **/ApplicationData/Runtime/Included/** is included in the GitHub repository, and created at application runtime.
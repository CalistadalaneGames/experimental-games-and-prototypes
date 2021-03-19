## /ApplicationData/Help/Included/

This is where all help data and documentation that will be copied locally at runtime are stored.

### Copying data locally at runtime
##### Visual Studio 2019
To copy help data located in `/ApplicationData/Help/Included/` locally at runtime, set the file properties as such:
```
Build Action: None
Copy to Output Directory: Copy always
```

> This file is a placeholder to ensure that **/ApplicationData/Help/Included/** is included in the GitHub repository, and created at application runtime.
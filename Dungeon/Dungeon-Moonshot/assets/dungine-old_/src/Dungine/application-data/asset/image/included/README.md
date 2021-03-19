## /ApplicationData/Asset/Image/Included/

This is where all image assets that will be copied locally at runtime are stored.

### Copying data locally at runtime
##### Visual Studio 2019
To copy image files located in `/ApplicationData/Asset/Image/Included/` locally at runtime, set the file properties as such:
```
Build Action: None
Copy to Output Directory: Copy always
```

> This file is a placeholder to ensure that **/ApplicationData/Asset/Image/Included/** is included in the GitHub repository, and created at application runtime.
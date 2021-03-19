## /ApplicationData/Asset/Audio/Included/

This is where all audio assets that will be copied locally at runtime are stored.

### Copying data locally at runtime
##### Visual Studio 2019
To copy audio files located in `/ApplicationData/Asset/Audio/Included/` locally at runtime, set the file properties as such:
```
Build Action: None
Copy to Output Directory: Copy always
```

> This file is a placeholder to ensure that **/ApplicationData/Asset/Audio/Included/** is included in the GitHub repository, and created at application runtime.
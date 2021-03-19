## application-data/asset/

The `application-data/asset/` folder contains:

| Folder name         | Folder description                                     |
|--------------------:|:-------------------------------------------------------|
|`audio/`             | Audio files                                            |
|`font/`              | Font files                                             |
|`image/`             | Image files                                            |
|`video/`             | Video files                                            |

Each `application-data/asset/` folder also contains:

| Folder name         | Folder description                                     |
|--------------------:|:-------------------------------------------------------|
|`embedded/`          | Assets that not made available locally                 |
|`included/`          | Assets that are made available locally at runtime      |
|`custom/`            | User-created or custom assets                          |


### Copying data locally at runtime
##### Visual Studio 2019
To copy data located in `application-data/asset/*/included/` locally at runtime, set the file properties as such:
```
Build Action: None
Copy to Output Directory: Copy always
```

### Embedding data as a project resource
##### Visual Studio 2019
To build data located in `application-data/asset/*/embedded/` as a project resource, set the file properties as such:
```
Build Action: Resource
```
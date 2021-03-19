## /ApplicationData/DevMode/

This is where data and documentation related to application development should be stored.

By default, **/ApplicationData/DevMode/** *is* copied locally at runtime, but you should probably leave this folder empty when deploying.

Examples of development data:
* Online data that is cached when developing an application
* Code snippits

### Folder structure

| Folder               | Contents                                              |
|---------------------:|:------------------------------------------------------|
| `/DevMode/`          | Custom development data                               |
| `/DevMode/Included/` | Development data copied locally at runtime            |

> This file is a placeholder to ensure that **/ApplicationData/DevMode/** is included in the GitHub repository, and created at application runtime.
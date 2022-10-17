# BlUp

## Installation

Go to BlUp project folder and run:

```
dotnet pack
dotnet tool install --global --add-source ./nupkg blup
```

## Todo
* [ ] Tests
* [ ] Build
* [ ] Publish

## Docs

Usage: blup COMMAND [ARGUMENTS]

Commands:
  ups       Add or update blob storage settings
            Usage: blup ups %name% %container name% %blob account connection string%
  rem       Remove blob storage settings
            Usage: blup rem %name%
  list      List all registered blob storage settings
            Usage: blup list
  sync      Sync local directory with blob storage
            Usage: blup sync %name% %src path%
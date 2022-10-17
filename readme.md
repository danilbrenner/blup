# BlUp

Usage:  dotnet blup COMMAND [ARGUMENTS]

Commands:
  ups       Add or update blob storage settings
            Usage: dotnet blup ups %name% %container name% %blob account connection string%
  rem       Remove blob storage settings
            Usage: dotnet blup rem %name%
  list      List all registered blob storage settings
            Usage: dotnet blup list
  sync      Sync local directory with blob storage
            Usage: dotnet blup sync %name% %src path%
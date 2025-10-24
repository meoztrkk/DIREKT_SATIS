./build-image.ps1 -ProjectPath "../../src/DIREKT_SATIS.DbMigrator/DIREKT_SATIS.DbMigrator.csproj" -ImageName direkt_satis/dbmigrator
./build-image.ps1 -ProjectPath "../../src/DIREKT_SATIS.Web.Public/DIREKT_SATIS.Web.Public.csproj" -ImageName direkt_satis/webpublic
./build-image.ps1 -ProjectPath "../../src/DIREKT_SATIS.HttpApi.Host/DIREKT_SATIS.HttpApi.Host.csproj" -ImageName direkt_satis/httpapihost
./build-image.ps1 -ProjectPath "../../angular" -ImageName direkt_satis/angular -ProjectType "angular"
./build-image.ps1 -ProjectPath "../../src/DIREKT_SATIS.AuthServer/DIREKT_SATIS.AuthServer.csproj" -ImageName direkt_satis/authserver

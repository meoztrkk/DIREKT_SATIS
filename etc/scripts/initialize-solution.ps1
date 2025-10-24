abp install-libs

cd src/DIREKT_SATIS.DbMigrator && dotnet run && cd -


cd src/DIREKT_SATIS.HttpApi.Host && dotnet dev-certs https -v -ep openiddict.pfx -p config.auth_server_default_pass_phrase 


./etc/helm/create-tls-secrets.ps1

exit 0
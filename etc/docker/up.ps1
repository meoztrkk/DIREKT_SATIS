docker network create direkt_satis --label=direkt_satis
docker-compose -f containers/rabbitmq.yml up -d
docker-compose -f containers/redis.yml up -d
exit $LASTEXITCODE
docker build --no-cache -f SQL\Dockerfile.PostgreSql -t ghconnect/postgre-sql ../SQL

docker build --no-cache -f Dockerfile -t ghconnect/app ../..

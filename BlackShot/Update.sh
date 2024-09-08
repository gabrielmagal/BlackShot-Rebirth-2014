echo Stop WebSite
docker stop blackshot-blackshot-website-1
docker rm blackshot-blackshot-website-1
docker rmi -f blackshot-website-image

echo Stop LobbyCore
docker stop blackshot-lobby-core-1
docker rm blackshot-lobby-core-1
docker rmi -f lobby-core-image

echo Stop AuthCore
docker stop blackshot-auth-core-1
docker rm blackshot-auth-core-1
docker rmi -f auth-core-image

echo Core
cd Core
rm -R bin/
rm -R obj/
dotnet build -c Release
dotnet publish -c Release

echo BlackShotWebSite
cd ../BlackShotWebSite
rm -R bin/
rm -R obj/
dotnet build -c Release
dotnet publish -c Release

echo AuthCore
cd ../AuthCore
rm -R bin/
rm -R obj/
dotnet build -c Release
dotnet publish -c Release

echo LobbyCore
cd ../LobbyCore
rm -R bin/
rm -R obj/
dotnet build -c Release
dotnet publish -c Release

echo ComposeUp
docker compose up -d
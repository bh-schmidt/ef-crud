set -e
cat << eof

Updating Sonnar

eof

PROJECT_KEY="EfCrud.net"
SONAR_SCANNER_LOCATION="sonarscanner"
OPENCOVER_LOCATION="Tests\coverage.opencover.xml"
TOKEN="9bff2cb9cbdb20ca1409e75f7a783a34288e2e45"
COVERAGE_EXCLUSIONS="Tests/**/*.cs,Data/Migrations/*,**/EfCrudContext.cs,**/ConfigureContext.cs"


dotnet test //p:CollectCoverage=true //p:CoverletOutputFormat=opencover
dotnet build-server shutdown
dotnet sonarscanner begin //k:$PROJECT_KEY //d:sonar.login=$TOKEN //d:sonar.cs.opencover.reportsPaths=$OPENCOVER_LOCATION /d:sonar.coverage.exclusions=$COVERAGE_EXCLUSIONS
dotnet build
dotnet sonarscanner end //d:sonar.login=$TOKEN

cat << eof

Sonar update succeeded

eof

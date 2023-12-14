function global:build {
    cd Packing.Models;
    dotnet build --configuration Release;
    cd ..;
}

build;
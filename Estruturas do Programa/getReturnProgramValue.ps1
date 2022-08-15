dotnet build
dotnet run 

if($LastExitCode -eq 0){
    Write-Host "Execução realizada com sucesso"
}else{
    Write-Host "A execução do programa não pôde ser realizada com sucesso"
}

Write-Host "Valor retornado = " $LastExitCode
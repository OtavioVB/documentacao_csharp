dotnet build
dotnet run -- 1

if($LastExitCode -eq 0){
    Write-Host "Execução realizada com sucesso"
}else{
    Write-Host "A execução do programa não pôde ser realizada com sucesso"
}

Write-Host "Valor retornado = " $LastExitCode

Wait-Event Timer.Elapsed
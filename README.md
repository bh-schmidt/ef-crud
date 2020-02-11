# ef-crud

## Requisitos

1. DotNet SDK 3.1

## Como Executar

1. Clonar a aplicação.
2. Abrir o console na pasta do projeto ```~/ef-crud/src```.
3. Executar o comando ```dotnet run --project Api/Api.csproj```.
3.1. Por padrão o sistema será executado na porta ```5000```, por exemplo: ```http://localhost:5000```.
4. Realizar chamadas rest para as rotas da api.

### Rotas

1. Obter Todos os Caminhões

Método: GET

Rota: ```api/caminhoes```

Exemplo: ```http://localhost:5000/api/caminhoes```

****

2. Obter Caminhão por Id

Método: GET

Rota: ```api/caminhoes/{id}```

Exemplo: ```http://localhost:5000/api/caminhoes/3```

****

3. Inserir Caminhão

Método: POST

Rota: ```api/caminhoes```

Tipo do parâmetro: JSON

Parâmetros:

```
{
	"modelo": short,
	"anoFabricacao": int,
	"anoModelo": int
}
```

Exemplo: ```http://localhost:5000/api/caminhoes```
```
{
	"modelo": 1,
	"anoFabricacao": 2020,
	"anoModelo": 2021
}
```

****

4. Atualizar Caminhão

Método: PUT

Rota: ```api/caminhoes```

Tipo do parâmetro: JSON

Parâmetros:

```
{
  "id": long,
	"modelo": short,
	"anoFabricacao": int,
	"anoModelo": int
}
```

Exemplo: ```http://localhost:5000/api/caminhoes```
```
{
  "id": 3,
	"modelo": 2,
	"anoFabricacao": 2020,
	"anoModelo": 2021
}
```

****

5. Excluir Caminhão

Método: DELETE

Rota: ```api/caminhoes/{id}```

Exemplo: ```http://localhost:5000/api/caminhoes/{3}```

### Modelos Disponíveis

```FH = 1```
```FM = 2```

## Cobertura de Testes

<img src="https://i.ibb.co/SrVB5Rj/Sonar-Qube.png" >

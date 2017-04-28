# e-Municipal

[![Build status](https://ci.appveyor.com/api/projects/status/0cmj9nlj9bc8js4a?svg=true)](https://ci.appveyor.com/project/cleytonferrari/e-municipal)

Site oficial do município de Alto Paraíso-RO. 

O **e-Municipal** esta sendo desenvolvido e mantido pelo departamento de informática do município de Alto Paraíso-RO, para uso no próprio site oficial do município <a href='http://www.altoparaiso.ro.gov.br'>www.altoparaiso.ro.gov.br</a>.

> ### Aviso Legal
> **IMPORTANTE:** O estado atual desse site é **ALPHA**, considere-o como uma versão de base 0.1. Portanto, as áreas mudarão significativamente enquanto refatorar o código atual e implementar novos recursos. **Feedback com melhorias e pedidos de pull da comunidade são altamente apreciados e aceitos.**


## Funcionalidades

- Página Inicial
- Equipe de Governo

## Para testar o e-Municipal

Requisitos:
- <a href='https://www.microsoft.com/net/download/core'>.Net Core</a>

Para testar:
1. Clonar o repositório: 
```sh
git clone https://github.com/pmap-ro/e-municipal.git
```

2. Rodar o projeto:
```sh
cd e-municipal\src\web

dotnet restore && dotnet build && dotnet run
```
O site vai rodar por padrão em <a href="http://localhost:5000">http://localhost:5000</a>

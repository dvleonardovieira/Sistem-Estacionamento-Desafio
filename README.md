# 🅿️ Sistema de Estacionamento - JOE Parking

Projeto desenvolvido como parte do bootcamp de C# e .NET, implementando um sistema completo de controle de estacionamento com cadastro, remoção e listagem de veículos.

## 📋 Sobre o Projeto

Sistema de gerenciamento de estacionamento que permite:
- Cadastrar veículos ao entrar no estacionamento
- Remover veículos e calcular o valor a pagar baseado no tempo de permanência
- Listar todos os veículos estacionados
- Interface de console interativa e intuitiva

## 🚀 Tecnologias Utilizadas

- **C# 10.0**
- **.NET 10.0**
- **Visual Studio Code / Visual Studio**

## 💡 Funcionalidades

### 1. Cadastrar Veículo (Entrada)
- Solicita a placa do veículo
- Adiciona o veículo à lista de estacionados
- Confirma o cadastro com mensagem de sucesso

### 2. Remover Veículo (Saída)
- Solicita a placa do veículo
- Verifica se o veículo está realmente estacionado
- Calcula o valor total baseado nas horas de permanência
- Remove o veículo da lista
- Exibe o valor total a pagar

### 3. Listar Veículos
- Exibe todos os veículos estacionados
- Mostra numeração para melhor visualização
- Informa quando não há veículos no estacionamento

### 4. Encerrar
- Finaliza o sistema

## 🎯 Conceitos Aplicados

### Programação Orientada a Objetos
- **Classes e Objetos**: Criação da classe `Estacionamento` com encapsulamento de dados
- **Construtores**: Inicialização do objeto com preço por hora
- **Modificadores de Acesso**: Uso de `private` para proteger dados sensíveis

### Estruturas de Dados
- **List<T>**: Utilização de listas genéricas para armazenar placas dos veículos
- **Operações com Listas**: 
  - `Add()` - adicionar elementos
  - `Remove()` - remover elementos
  - `Any()` - verificar existência de elementos

### LINQ (Language Integrated Query)
- **`.Any()`**: Verificar se a lista contém elementos
- **Expressões Lambda**: `x => x.ToUpper() == placa.ToUpper()`
- **Comparações Case-Insensitive**: Uso de `.ToUpper()` para ignorar maiúsculas/minúsculas

### Estruturas de Controle
- **While Loop**: Menu principal com repetição
- **Switch-Case**: Navegação entre opções do menu
- **Foreach**: Iteração sobre lista de veículos
- **If-Else**: Validações e lógica condicional

### Manipulação de Dados
- **Console.ReadLine()**: Captura de entrada do usuário
- **Console.WriteLine()**: Exibição de informações
- **Convert.ToInt32()**: Conversão de string para inteiro
- **String Interpolation**: Formatação de strings com `$"...{variavel}..."`

## 🛠️ Como Executar o Projeto

### Pré-requisitos
- .NET 8.0 ou superior instalado
- Editor de código (VS Code, Visual Studio, etc.)

### Passos para execução

1. Clone o repositório
```bash
git clone https://github.com/dvleonardovieira/Sistem-Estacionamento-Desafio```

2. Navegue até a pasta do projeto
```bash
cd DesafioFundamentos
```

3. Execute o projeto
```bash
dotnet run
```

## 📖 Estrutura do Código

```
DesafioFundamentos/
│
├── Models/
│   └── Estacionamento.cs      # Classe principal com lógica do sistema
│
├── Program.cs                  # Ponto de entrada da aplicação
└── DesafioFundamentos.csproj  # Configurações do projeto
```

## 🎓 Aprendizados

Durante o desenvolvimento deste projeto, aprendi:

1. **Resolução de Problemas de Compatibilidade**: 
   - Como atualizar projetos de versões antigas do .NET (6.0) para versões mais recentes (10.0)
   - Modificação do arquivo `.csproj` para alterar o `TargetFramework`

2. **Trabalho com Listas Genéricas**:
   - Diferença entre `ArrayList` (legado) e `List<T>` (moderno)
   - Operações CRUD em listas (Create, Read, Update, Delete)

3. **LINQ e Expressões Lambda**:
   - Uso de consultas LINQ para filtrar e buscar dados
   - Sintaxe de expressões lambda: `x => condição`

4. **Boas Práticas**:
   - Encapsulamento de dados com modificadores de acesso
   - Nomenclatura clara e descritiva de variáveis
   - Separação de responsabilidades (Model e Program)

5. **Lógica de Negócio**:
   - Cálculo de valores baseado em tempo de permanência
   - Validação de dados de entrada
   - Tratamento de casos de uso (veículo não encontrado, lista vazia, etc.)

6. **Experiência do Usuário**:
   - Criação de menu interativo e intuitivo
   - Pausas estratégicas para leitura de informações
   - Mensagens claras e feedback ao usuário

## 🔄 Melhorias Implementadas

- **Simplificação do modelo de negócio**: Mudança de "preço inicial + preço por hora" para apenas "preço por hora fixo", tornando o sistema mais realista
- **Comparação case-insensitive**: Placas podem ser digitadas em maiúsculas ou minúsculas
- **Listagem numerada**: Melhor visualização dos veículos estacionados
- **Pausas no fluxo**: Melhor experiência do usuário com tempo para ler informações

## 📝 Exemplo de Uso

```
===================================
Seja bem vindo ao Sistemas:
>>>>>>>>JOE Parking<<<<<<<
Valor: $5.00 por hora
===================================

Pressione ENTER para continuar...

Digite a sua opção:
1 - Cadastrar veículo (Entrada)
2 - Remover veículo (Saida)
3 - Listar veículos
4 - Encerrar

> 1
Digite a placa do veículo para estacionar:
> ABC-1234
Veículo adicionado com sucesso!

> 3
Os veículos estacionados são:
1 - ABC-1234

> 2
Digite a placa do veículo para remover:
> ABC-1234
Digite a quantidade de horas que o veículo permaneceu estacionado:
> 3
O veículo ABC-1234 foi removido e o preço total foi de: $15
```

## 👨‍💻 Autor
jose leonardo vieira
Desenvolvido como parte do bootcamp de C# e .NET

## 📄 Licença

Este projeto é parte de um desafio educacional e está disponível para fins de aprendizado.

---

⭐ Se este projeto te ajudou de alguma forma, considere deixar uma estrela!

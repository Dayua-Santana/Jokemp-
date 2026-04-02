# 🎮 Jokempô - Pedra, Papel e Tesoura

![.NET](https://img.shields.io/badge/.NET%206-Console-512BD4?style=flat&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-Latest-239120?style=flat&logo=csharp&logoColor=white)
![License](https://img.shields.io/badge/license-MIT-green?style=flat)

> Um clássico jogo de Pedra, Papel e Tesoura implementado em C# com interface console colorida e dinâmica! 🎲

---

## 📖 Sobre o Projeto

**Jokempô** é uma aplicação console interativa que implementa o famoso jogo de Pedra, Papel e Tesoura. O jogador compete contra o computador em partidas contínuas, com feedbacks visuais e coloridos a cada rodada.

Desenvolvido com **C# .NET 6+**, o projeto demonstra boas práticas de código modular, separação de responsabilidades e interação com o usuário em aplicações console.

---

## ✨ Funcionalidades

- 🎮 **Modo Jogador vs Computador** - Desafie a IA em partidas infinitas
- 🎲 **Jogadas Aleatórias** - Computador escolhe de forma aleatória usando `Random`
- 🏆 **Avaliação Automática** - Sistema inteligente para determinar o vencedor
- 🔄 **Loop de Jogo** - Continue jogando quantas vezes quiser (S/N)
- 🎨 **Interface Colorida** - Feedback visual com cores diferentes para resultado
  - 🟢 Verde: Escolha do jogador
  - 🔵 Azul: Seu resultado
  - 🟣 Magenta: Jogada do PC
  - 🟢 Verde: Vitória
  - 🔴 Vermelho: Derrota
  - 🟡 Amarelo: Empate
- 🏗️ **Código Modular e Limpo** - Separação clara de responsabilidades

---

## 🚀 Como Rodar

### Pré-requisitos
- [.NET 6 SDK](https://dotnet.microsoft.com/download) ou superior instalado
- Terminal/Command Prompt

### Instalação e Execução

```bash
# 1. Clone ou acesse o diretório do projeto
cd Desktop/Jokempô

# 2. Execute o projeto
dotnet run

# OU no Visual Studio
# Abra Jokempô.sln e pressione F5
```

---

## 📝 Como Jogar

1. **Inicie o programa** - Você verá uma mensagem de boas-vindas
2. **Escolha sua jogada**:
   - Digite `1` para **Pedra** 🪨
   - Digite `2` para **Papel** 📄
   - Digite `3` para **Tesoura** ✂️
3. **Veja o resultado** - O programa mostra sua jogada, a do PC e quem venceu
4. **Continue ou saia**:
   - Digite `S` para jogar novamente
   - Digite `N` para sair

```
## 💡 Exemplo de Uso

```
🎮 JOKENPÔ - Bem-vindo!

1. Pedra | 2. Papel | 3. Tesoura
2
Papel vs Tesoura → PC venceu!
👋 Fim de jogo!

Deseja Continuar?(S/N): 
S

1. Pedra | 2. Papel | 3. Tesoura
1
Papel vs Pedra → Jogador venceu!
```

---

## 🔧 Tecnologias Utilizadas

- **C# 11+** - Linguagem de programação
- **.NET 6+** - Framework
- **Console I/O** - Interação com usuário
- **Switch Expressions** - Padrão matching moderno

---

## 📚 Conceitos Demonstrados

- ✅ **Estrutura de Classes** - Separação de responsabilidades
- ✅ **Métodos Estáticos** - Funções utilitárias
- ✅ **Pattern Matching** - Switch expressions do C#
- ✅ **Random Number Generation** - Aleatoriedade
- ✅ **Console Styling** - Cores e formatação
- ✅ **Validação de Input** - Tratamento de entrada do usuário

---

## 👨‍💻 Autor

**Dayuã Santana** - Desenvolvido como projeto da Academia do Progamador.

---

## 🤝 Contribuições

Contribuições são bem-vindas! Sinta-se livre para:
- Reportar bugs
- Sugerir melhorias
- Fazer pull requests

---

**Divirta-se jogando! 🎮✨**

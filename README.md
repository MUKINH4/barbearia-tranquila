---

# ✂️ **Barbearia Tranquila**

Bem-vindo ao projeto **Barbearia Tranquila**, um sistema de agendamento online para barbearias. Este projeto foi desenvolvido utilizando **ASP.NET Core Razor Pages** e tem como objetivo facilitar o gerenciamento de agendamentos, oferecendo uma interface simples e intuitiva para os usuários.

---

# 👥 **Integrantes**
* Samuel Heitor - RM 556731
* Renato David - RM 555627
* Lucas Nicolini - RIM 557613
* Gustavo Lopes - RM 556859
* Gabriel Jablonski - RM 555452
* Matheus Munuera - RM 557812

## 🌟 **Características do Projeto**

- **Tecnologias Utilizadas**:
  - **ASP.NET Core Razor Pages** (com .NET 8)
  - **C# 12.0**
  - **Tag Helpers** personalizados para componentes reutilizáveis

- **Funcionalidades Principais**:
  - **Listagem de Agendamentos**: Exibe todos os agendamentos cadastrados.
  - **Cadastro de Agendamentos**: Permite criar novos agendamentos com validações de formulário.
  - **Edição de Agendamentos**: Modal para editar os dados de um agendamento existente.
  - **Remoção de Agendamentos**: Modal de confirmação para excluir agendamentos.
  - **Mensagens Dinâmicas**: Exibição de mensagens de sucesso ou erro utilizando `TempData`.
  - **Validações de Formulário**: Validações de campos obrigatórios e formatos específicos (ex.: telefone).
  - **Tag Helpers Personalizados**:
    - `MensagemTagHelper`: Exibe mensagens de alerta.
    - `BotaoTagHelper`: Gera botões estilizados.
    - `DisplayTagHelper`: Formata exibições de dados.

---

## 🗂️ **Estrutura do Projeto**

### 📁 **Pastas e Arquivos Principais**

- **Controllers**:
  - `AgendamentoController.cs`: Controlador responsável por gerenciar as ações de agendamentos (listar, criar, editar e excluir).
  - `HomeController.cs`: Controlador para a página inicial.

- **Models**:
  - `AgendarModel.cs`: Modelo que representa os dados de um agendamento, incluindo propriedades como `Nome`, `Telefone`, `Data`, `Hora`, `Serviço`, `Profissional` e `Status`.

- **Views**:
  - **Agendamento**:
    - `Agendamentos.cshtml`: Página que lista todos os agendamentos.
    - `Agendar.cshtml`: Página para criar novos agendamentos.
    - `Edit.cshtml`: Página/modal para editar agendamentos.
    - `_Form.cshtml`: Formulário reutilizável para cadastro e edição.
  - **Shared**:
    - `_Layout.cshtml`: Layout principal do projeto.
  - **Home**:
    - `Index.cshtml`: Página inicial do sistema.

- **TagHelpers**:
  - `MensagemTagHelper.cs`: Exibe mensagens de alerta dinâmicas.
  - `BotaoTagHelper.cs`: Gera botões estilizados.
  - `DisplayTagHelper.cs`: Formata exibições de dados.

---

## ⚙️ **Configuração do Projeto**

### 🛠️ **Pré-requisitos**
- **.NET SDK 8.0** ou superior
- **Visual Studio 2022** (ou outro editor compatível com .NET)
- **Banco de Dados**: Este projeto utiliza uma lista em memória para armazenar os agendamentos. Não é necessário configurar um banco de dados.

## 🚀 **Como Usar**

### 🏠 **1. Página Inicial**
Acesse a página inicial para visualizar as opções disponíveis.

### 📋 **2. Listagem de Agendamentos**
Na página de agendamentos, você pode:
- Visualizar todos os agendamentos cadastrados.
- Clicar em **Editar** para modificar um agendamento.
- Clicar em **Remover** para excluir um agendamento.

### ➕ **3. Cadastro de Agendamentos**
Clique no botão **+ Agendar Horário** para acessar o formulário de cadastro. Preencha os campos obrigatórios e clique em **Salvar**.

### ✏️ **4. Edição de Agendamentos**
Clique no botão **Editar** ao lado de um agendamento. Altere os dados e clique em **Salvar**.

### ❌ **5. Remoção de Agendamentos**
Clique no botão **Remover** ao lado de um agendamento para abrir o modal de confirmação. Confirme a exclusão clicando em **Apagar**.

---

## ✅ **Validações**

- **Telefone**: Deve seguir o formato `(XX) XXXXX-XXXX`.
- **Data e Hora**: Devem ser válidas e no futuro.
- **Campos Obrigatórios**: Nome, Telefone, Data, Hora, Serviço e Profissional.

---

## 🧩 **Tag Helpers Personalizados**

### 🔔 **MensagemTagHelper**
Exibe mensagens de alerta dinâmicas com base no conteúdo de `TempData`.

### 🖱️ **BotaoTagHelper**
Gera botões estilizados com classes do Bootstrap.

### 📅 **DisplayTagHelper**
Formata exibições de dados, como datas e horas.

---

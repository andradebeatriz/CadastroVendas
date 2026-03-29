# 🛒 Sistema de Vendas - Windows Forms

Sistema completo de gerenciamento de vendas desenvolvido em **C# com Windows Forms**, com foco em organização, controle e visualização de dados.

---

## 📋 Funcionalidades

* ✅ Cadastro de Produtos
* ✅ Cadastro de Clientes
* ✅ Cadastro de Animais
* ✅ Cadastro de Vendas
* ✅ Gestão de Itens de Venda
* ✅ **Relatórios de:** Produtos, Clientes, Animais e Vendas


## 🛠️ Tecnologias Utilizadas

* C# (.NET Framework)
* Windows Forms
* SQL Server
* RDLC (Relatórios locais)



## 📦 Estrutura do Projeto

```bash
WfaPrjVendas/
├── FrmCadAnimais.cs        # Cadastro de animais
├── FrmCadClientes.cs       # Cadastro de clientes
├── FrmCadProduto.cs        # Cadastro de produtos
├── FrmCadVendas.cs         # Cadastro de vendas
├── FrmMenu.cs              # Menu principal
├── FrmSobre.cs             # Informações do projeto
├── FrmSplash.cs            # Tela inicial

├── FrmRptAnimais.cs        # Relatório de animais
├── FrmRptClientes.cs       # Relatório de clientes
├── FrmRptProdutos.cs       # Relatório de produtos
├── FrmRptVendas.cs         # Relatório de vendas

├── RptAnimais.rdlc         # Template relatório animais
├── RptClientes.rdlc        # Template relatório clientes
├── RptProdutos.rdlc        # Template relatório produtos
├── RptVendas.rdlc          # Template relatório vendas

├── DataSetVendas.xsd       # Dataset principal
├── Resources/              # Imagens e ícones
└── Properties/             # Configurações do projeto
```



## 🚀 Como Executar

1. Clone o repositório:

```bash
git clone https://github.com/andradebeatriz/CadastroVendas.git
```

2. Abra o projeto no **Visual Studio**

3. Configure a *string de conexão* no arquivo:

```bash
App.config
```

4. Execute o projeto:

```bash
F5
```

---

## ⚙️ Observações

* Certifique-se de que o **SQL Server** esteja instalado e configurado corretamente
* Os relatórios utilizam arquivos `.rdlc`, podendo ser visualizados diretamente no sistema
* Projeto desenvolvido com *fins educacionais*



## 👥 Desenvolvido por
Beatriz de Andrade Leite e Sophia Rosa da Silva Machado



## 🎓 Sobre o Projeto

Projeto acadêmico desenvolvido para o curso de **Desenvolvimento de Sistemas** da
**Etec Fernando Prestes - Extensão Fatec**


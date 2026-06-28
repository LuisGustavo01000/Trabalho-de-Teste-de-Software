# Template padrão da aplicação

<span style="color:red">Pré-requisitos: <a href="02-Especificacao.md"> Especificação do projeto</a></span>, <a href="03-Metodologia.md"> Metodologia</a>, <a href="05-Projeto-interface.md"> Projeto de interface</a>

## Arquitetura de Software e Tecnologias Utilizadas 
O sistema foi desenvolvido em plataforma Web, adotando a arquitetura MVC (Model-View-Controller), com separação clara entre as responsabilidades das camadas: <br>

1. Camada de Apresentação (View - Front-End): <br>
- Responsável pela interface com o usuário (professores, gestores e alunos), oferecendo uma navegação intuitiva e responsiva. <br>
- Tecnologias utilizadas: <br>
o HTML5, CSS3 e Bootstrap (para design responsivo e componentes de interface) <br>

2. Camada de Lógica de Negócio (Controller - Back-End): <br>
- Gerencia a lógica do sistema, processamento das regras de negócio, autenticação, e validação de dados. <br>
- Tecnologias utilizadas: <br>
o Linguagem: C# (plataforma .NET) <br> 
o Frameworks: ASP.NET MVC (para controle das requisições, rotas e lógica de aplicação) <br>

3. Camada de Dados (Model - Banco de Dados): <br>
- Responsável pelo armazenamento seguro e consistente das informações de frequência e desempenho dos alunos. <br>
- Tecnologias utilizadas: <br>
o Banco de Dados Relacional: SQL Server <br>

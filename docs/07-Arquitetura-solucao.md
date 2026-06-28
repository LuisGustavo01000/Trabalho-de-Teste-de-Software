# Arquitetura da solução

<span style="color:red">Pré-requisitos: <a href="05-Projeto-interface.md"> Projeto de interface</a></span>

A solução proposta foi estruturada utilizando a arquitetura MVC (Model-View-Controller), garantindo separação clara de responsabilidades e melhor organização do código para manutenção futura. O sistema será desenvolvido como uma aplicação web, acessível por diferentes dispositivos (desktop, tablet e smartphone).

### Componentes da Solução 
1. Front-end (View – Camada de Apresentação) <br>
Descrição: <br>
Responsável pela interface com o usuário (gestores, instrutores e secretários), permitindo a interação direta com as funcionalidades do sistema de forma intuitiva e responsiva.

Tecnologias Utilizadas: <br>

HTML5 <br>
CSS3 <br>
Bootstrap <br>

2. Back-end (Controller – Camada de Lógica de Negócio) <br>
Descrição: <br>
Gerencia a lógica do sistema, processamento de regras de negócio, autenticação de usuários e validação de dados, conectando a interface ao banco de dados. <br>

Tecnologias Utilizadas: <br>

Linguagem: C# <br>
Framework: ASP.NET MVC (Model-View-Controller) <br>
Plataforma: .NET <br>

3. Banco de Dados (Model – Camada de Dados)
Descrição:<br>
Responsável pelo armazenamento seguro e consistente de todas as informações, incluindo cadastros, registros de frequência e dados técnicos dos alunos. <br>

Tecnologia Utilizada:
Banco de Dados Relacional: SQL Server <br>

## Ambiente de Hospedagem
O ambiente de hospedagem previsto para a aplicação é composto por: <br>

Servidor Web:<br>
Hospedagem do sistema ASP.NET MVC em ambiente compatível com .NET, podendo ser um servidor IIS (Internet Information Services) local ou cloud.

Servidor de Banco de Dados: <br>
Hospedado em instância SQL Server, localmente ou em nuvem, garantindo acesso seguro às tabelas do sistema. <br>

Acesso ao Sistema: <br>
Realizado por meio de navegador web em dispositivos desktop ou mobile, com autenticação de usuário e controle de permissões por perfil (gestor, instrutor, secretária). <br>

![image](https://github.com/user-attachments/assets/8935696c-479c-414d-bafe-04dccebbd5b0)


### Benefícios da Arquitetura <br>
- Manutenção facilitada (separação clara de responsabilidades) <br>
- Escalabilidade (possibilidade de integração futura com outras modalidades e funcionalidades) <br>
- Segurança e desempenho adequados ao ambiente acadêmico e de gestão da academia <br>

## Diagrama de classes


![image](https://github.com/user-attachments/assets/72891e1e-2471-4527-854a-9dc022ef1b72)


##  Modelo de dados

![image](https://github.com/user-attachments/assets/ada56f3b-d165-4c95-81bf-b0de38b8c236)


### Modelo físico

A criação das tabelas do banco de dados foi realizada utilizando o Entity Framework, pois essa ferramenta oferece maior produtividade e integração com o projeto, permitindo o desenvolvimento orientado a objetos de forma prática e eficiente. <br>

Por meio do Entity Framework, foi possível gerar as tabelas diretamente a partir das classes de modelo criadas no código (Code First), garantindo: <br>

- Facilidade de manutenção e alteração no modelo de dados conforme as mudanças nos requisitos do sistema.<br>
- Redução de erros manuais, pois o mapeamento é feito automaticamente pelo framework, evitando inconsistências entre a aplicação e o banco. <br>
- Agilidade no desenvolvimento, eliminando a necessidade de criação manual de cada tabela e relação diretamente no SQL Server. <br>

Essa abordagem foi escolhida por se adequar às boas práticas de desenvolvimento .NET e por estar alinhada aos recursos aprendidos nas disciplinas do curso. <br>

﻿---using BlackBelt.Models; <br>
using Microsoft.EntityFrameworkCore; <br>

namespace BlackBelt.Context <br>
{<br>
    public class AppDbContext : DbContext <br>
    {<br>
        public AppDbContext(DbContextOptions options) : base(options) <br>
        {<br>
        }<br>

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Aluno> Alunos  { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Presenca> Presencas { get; set; }
        public DbSet<Habilidade> Habilidades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Turma>()
                .HasOne(t => t.Instrutor)
                .WithMany(i => i.Turmas)
                .HasForeignKey(t => t.Id_Instrutor)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Aluno>()
                .HasOne(a => a.Turma)
                .WithMany(t => t.Alunos)
                .HasForeignKey(a => a.Id_Turma)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Presenca>()
                .HasOne(p => p.Turma)
                .WithMany(t => t.Presencas)
                .HasForeignKey(p => p.Id_Turma)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Presenca>()
                .HasOne(p => p.Aluno)
                .WithMany(a => a.Presencas)
                .HasForeignKey(p => p.Id_Aluno)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Habilidade>()
                .HasOne(h => h.Aluno)
                .WithMany(a => a.Habilidades)
                .HasForeignKey(h => h.Id_Aluno)
                .OnDelete(DeleteBehavior.Cascade);

        }

    }
}


## Hospedagem

A hospedagem da plataforma foi realizada utilizando a plataforma Render, que oferece ambiente de deploy automatizado, escalável e com fácil integração aos repositórios Git. Para garantir portabilidade, consistência e facilidade no processo de publicação, foi utilizada também a ferramenta Docker, permitindo empacotar a aplicação com todas as suas dependências em containers.

Essa abordagem possibilitou: <br>

- Deploy mais rápido e seguro, reduzindo problemas de incompatibilidade entre ambientes de desenvolvimento e produção.<br>
- Escalabilidade, pois a Render gerencia a infraestrutura conforme a demanda de acesso.<br>
- Facilidade de manutenção, pois o uso de containers Docker simplifica atualizações futuras do sistema.<br>


## Qualidade de software

A demanda por um sistema de gestão de desempenho dos alunos para a academia está diretamente relacionada ao Objetivo de Desenvolvimento Sustentável (ODS) 9 - Indústria, Inovação e Infraestrutura, proposto pela ONU. Esse objetivo incentiva a inovação e a modernização dos processos para tornar as empresas mais eficientes e sustentáveis.   

Ao implementar um sistema automatizado para gestão de desempenho dos alunos, a academia promoverá o uso da tecnologia para melhorar sua infraestrutura e otimizar a gestão de recursos. Isso pode contribuir para um ambiente mais organizado, melhor planejamento dos horários e alocação de profissionais, além de reduzir desperdícios operacionais.   

Além disso, esse projeto também dialoga com o ODS 3 - Saúde e Bem-Estar, pois a análise dos dados de frequência pode ajudar a academia a incentivar hábitos mais saudáveis entre os alunos e possibilitar um maior desenvolvimento dentro da arte marcial. Permitindo os mestres orientadores serem mais precisos em suas aulas, identificando padrões de comparecimento e criando estratégias para reduzir a evasão e aumentar o engajamento na prática de atividades físicas. 

# Especificação do Projeto
<span style="color:red">Pré-requisitos</a></span><br>
Especificação do Problema<br>
Nesta seção, é apresentada a definição do problema e a ideia de solução a partir da perspectiva do usuário, contemplando:<br>

Definição do problema: A prática do Jiu-jitsu exige acompanhamento contínuo da evolução técnica e física dos praticantes. Atualmente, a Academia Sigma enfrenta dificuldades no controle manual de frequência e na ausência de um sistema estruturado para registro do desempenho individual dos alunos, tornando o acompanhamento e a personalização das aulas limitados.

Ideia de solução: Desenvolver um sistema automatizado de gerenciamento de frequência e desempenho dos alunos de Jiu-jitsu, permitindo registro de presenças, cadastro de alunos, acompanhamento técnico individualizado, geração de relatórios e gerenciamento de turmas e instrutores. Dessa forma, professores, gestores e secretários poderão organizar melhor as aulas, planejar treinos personalizados e tomar decisões baseadas em dados.

## Visão Geral
Nesta parte do documento, serão abordados:

- Diagrama de personas: descrição dos perfis de usuários que utilizarão o sistema<br>
- Histórias de usuários: necessidades e motivações de cada persona<br>
- Requisitos funcionais: funcionalidades que o sistema deverá oferecer<br>
- Requisitos não funcionais: características técnicas relacionadas a desempenho, usabilidade e segurança<br>
- Restrições do projeto: limitações identificadas para o desenvolvimento<br>

Técnicas e Ferramentas Utilizadas<br>
Para realizar esta especificação do projeto, foram utilizadas:<br>
Técnicas: análise de stakeholders, criação de personas, elicitação de requisitos, definição de histórias de usuários e priorização de requisitos<br>
Ferramentas: Microsoft Word para documentação, Diagrams.net para modelagem de casos de uso, Lucidchart para diagramas complementares e GitHub para versionamento e publicação do projeto

## Personas

Persona 1 – Gabriela Paes (Gestora Administrativa)
Idade: 35 anos
Profissão: Gerente Administrativa
Tecnologia: Intermediária (usa sistemas de gestão financeira, WhatsApp Business e planilhas Excel)
Características: Organizada, liderança firme, busca dados claros para decisões rápidas
Motivação: Acompanhar o desempenho geral dos alunos para melhorar retenção e faturamento

Persona 2 – Larissa Souza (Secretária/Recepcionista)
Idade: 23 anos
Profissão: Recepcionista/Secretária
Tecnologia: Básica a intermediária (domina aplicativos de gestão de matrícula, controle de pagamentos e redes sociais)
Características: Comunicativa, ágil no atendimento, realiza cadastros e confirma presença dos alunos
Motivação: Realizar cadastros e consultas de frequência com rapidez, evitando erros no atendimento diário

Persona 3 – Paulo Mendes (Instrutor de Jiu-jitsu)
Idade: 29 anos
Profissão: Professor de Jiu-jitsu faixa-preta
Tecnologia: Básica (usa smartphone para redes sociais e consulta de vídeos técnicos)
Características: Didático, atento à evolução individual, mas prefere métodos rápidos e práticos de registro
Motivação: Registrar presença e evolução técnica sem precisar usar planilhas manuais demoradas

Mapa de Stakeholders (Resumo)<br>
|Stakeholder|	Interesse	Influência |<br>
|Gestores|	Resultados e relatórios para decisões estratégicas	|Alta| <br>
|Secretários|	Agilidade no cadastro e consulta de dados	|Média|<br>
|Instrutores|	Facilidade de registro e acompanhamento técnico	|Alta|<br>
|Alunos|	Receber acompanhamento individualizado	|Baixa (usuários indiretos)|<br>


## Histórias de Usuários

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`            |<br>
|Gestor|	Visualizar relatórios de frequência e desempenho|	Tomar decisões sobre treinos e retenção |<br>
|Secretário|	Cadastrar novos alunos|	Controlar matrículas com rapidez e segurança|<br>
|Secretário|	Editar dados dos alunos|	Corrigir informações sem precisar de apoio técnico|<br>
|Instrutor|	Registrar presença dos alunos em aula|	Controlar frequência e planejar treinos|<br>
|Instrutor|	Inserir comentários sobre evolução técnica|	Acompanhar pontos fortes e dificuldades dos alunos|<br>
|Gestor|	Cadastrar e gerenciar instrutores|	Manter a equipe atualizada no sistema|<br>
|Instrutor|	Consultar histórico técnico do aluno|	Avaliar evolução e planejar graduações|<br>

## Requisitos

### Requisitos Funcionais<br>

|ID|	Descrição |	Prioridade |<br>
|RF-001|	Login de usuários (gerente, secretária, instrutor)	| Essencial |<br>
|RF-002|	Cadastro de alunos |	Essencial |<br>
|RF-003|	Edição de dados dos alunos	| Essencial |<br>
|RF-004|	Exclusão de alunos |	Essencial |<br>
|RF-005|	Registro de frequência |	Essencial |<br>
|RF-006|	Cadastro de turmas	| Essencial |<br>
|RF-007|	Cadastro de instrutores |	Essencial |<br>
|RF-008|	Edição e exclusão de turmas e instrutores |	Essencial |<br>
|RF-009|	Registro de comentários técnicos no perfil do aluno	| Importante |<br>
|RF-010|	Emissão de relatórios de frequência |	Desejável |<br>


### Requisitos Não Funcionais<br>

|ID|	Descrição |	Prioridade |<br>
|RNF-001| Sistema responsivo para mobile e desktop |	Essencial |<br>
|RNF-002| Autenticação segura de usuários |	Essencial |<br>
|RNF-003| Armazenamento de dados em banco relacional |	Essencial |<br>
|RNF-004| Interface amigável para usuários com diferentes níveis de experiência |	Essencial |<br>


### Restrições<br>

|ID|	Restrição |<br>
|001|	O projeto deverá ser entregue até o final do semestre (Julho de 2025) |<br>
|002|	Deverá utilizar arquitetura MVC com .NET e SQL Server, conforme definido no projeto |<br>
|003|	Não há custo previsto pois é projeto acadêmico |<br>


## Diagrama de Casos de Uso<br>

![image](https://github.com/user-attachments/assets/29fbe25d-6416-4b4b-9c47-e6cefb5facb1)


## Principais casos:<br>

Login<br>
Cadastrar/editar/excluir alunos<br>
Registrar frequência<br>
Registrar comentários técnicos<br>
Emitir relatórios<br>
Cadastrar/editar/excluir turmas<br>
Cadastrar/editar/excluir instrutores<br>

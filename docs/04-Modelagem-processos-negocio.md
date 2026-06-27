# Modelagem dos processos de negócio<br>

<span style="color:red">Pré-requisitos: <a href="02-Especificacao.md"> Especificação do projeto</a></span>

## Modelagem da situação atual (Modelagem AS IS)<br>

Atualmente, o controle de frequência e acompanhamento técnico dos alunos de Jiu-jitsu na Academia Sigma é realizado manualmente, com utilização de: <br>
- Planilhas impressas para registro de presença, preenchidas em cada aula pelo instrutor. <br>
- Cadernos ou fichas físicas onde os instrutores anotam observações sobre o desempenho técnico de cada aluno, como golpes aprendidos ou dificuldades específicas.<br>
- Comunicação verbal ou via WhatsApp entre instrutores e gestão para compartilhar informações sobre evolução ou faltas recorrentes dos alunos.<br>
- Controle de matrículas e turmas realizado pela secretária por meio de planilhas digitais simples no computador da recepção, sem integração com relatórios de frequência ou evolução. <br>

### Problemas identificados no processo atual
- Alto risco de perda ou extravio de informações registradas em papel. <br>
- Falta de integração entre frequência, matrícula e evolução técnica dos alunos. <br>
- Retrabalho constante, pois dados registrados em papel precisam ser transcritos para planilhas digitais posteriormente. <br>
- Dificuldade de acesso rápido a informações estratégicas pelos gestores, como alunos com baixa frequência ou evolução estagnada.<br>
- Dependência de múltiplos arquivos e cadernos, gerando desorganização e falhas de comunicação.<br>

## Descrição geral da proposta (Modelagem TO BE)

A solução proposta consiste na implantação de um sistema web integrado que automatiza o registro de frequência, cadastro de alunos, turmas e acompanhamento técnico individual, permitindo acesso simultâneo por gestores, instrutores e secretários. Com isso, os dados passam a ser armazenados em banco de dados relacional, garantindo segurança, integridade e facilidade de consulta.

### Principais mudanças e oportunidades de melhoria
- Eliminação do registro manual em papel, substituindo por registro direto no sistema via notebook, tablet ou smartphone. <br>
- Integração dos cadastros de alunos, frequência, turmas e evolução técnica, possibilitando emissão de relatórios automáticos.<br>
- Acesso rápido a indicadores de desempenho e frequência, apoiando a gestão pedagógica e administrativa.<br>
- Comunicação facilitada entre secretários, gestores e instrutores por meio do sistema centralizado.<br>

## Modelagem dos processos

### PROCESSO 1 – Registro de Frequência <br>
AS-IS <br>
Instrutor preenche lista impressa de presença.<br>
Secretária recolhe lista e lança manualmente na planilha digital.<br>
Gestor solicita planilha quando precisa de relatórios.<br>

TO-BE <br>
Instrutor realiza login no sistema e registra presença dos alunos online. <br>
Frequência é atualizada em tempo real no banco de dados. <br>
Gestor acessa relatórios a qualquer momento. <br>

### PROCESSO 2 – Acompanhamento Técnico dos Alunos
AS-IS <br>
Instrutor anota observações em fichas de papel. <br>
Fichas são arquivadas fisicamente. <br>
Gestor não tem acesso prático às anotações. <br>

TO-BE <br>
Instrutor registra comentários técnicos diretamente no perfil do aluno no sistema. <br>
Dados ficam salvos no banco de dados e disponíveis para consulta por gestores. <br>
Relatórios podem ser gerados com evolução técnica de cada aluno. <br>


## Indicadores de desempenho

Os indicadores de desempenho apresentados podem ser gerados a partir dos dados adquiridos pelo sistema atual, uma vez que todas as informações necessárias – como frequência, evolução técnica, cadastro de turmas e alunos – já são armazenadas de forma estruturada no banco de dados.

Como proposta futura, recomenda-se o investimento na criação de uma tela específica de relatórios dentro do sistema, que apresente esses indicadores de forma organizada e visualmente trabalhada, por meio de gráficos e dashboards. Essa funcionalidade agregaria valor à plataforma, permitindo que gestores e instrutores tomem decisões mais rápidas e assertivas, sem a necessidade de exportação manual e análise externa dos dados.

![image](https://github.com/user-attachments/assets/a29443f8-7653-4b8b-93a0-a256a6728ece)


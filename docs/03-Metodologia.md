# Metodologia <br>

<span style="color:red">Pré-requisitos: <a href="02-Especificacao.md"> Especificação do projeto</a></span>

Para abordar o desenvolvimento do sistema de gerenciamento da Academia Sigma, a equipe adotou metodologias ágeis, com foco no framework Scrum para organizar as entregas e promover a colaboração contínua entre os membros. A escolha por Scrum se deu por sua flexibilidade, capacidade de adaptação e ciclos curtos de entrega (Sprints), o que favoreceu a organização incremental do projeto.<br>


## Controle de versão <br>

A ferramenta de controle de versão adotada no projeto foi o [Git](https://git-scm.com/), sendo que o [GitHub](https://github.com) foi utilizado para hospedagem do repositório. <br>

O projeto segue a seguinte convenção para o nome de branches: <br>

- `main`: Versão principal e estável do sistema. Reúne as entregas consolidadas. <br>
- `Integracao_FrontEnd_Alunos`: Branch focada na integração entre as telas do front-end e os dados de alunos. <br>
- `Integracao_Telas_Frontend	`: Responsável pela construção e conexão das interfaces gráficas do sistema. <br>
- `Lista_e_Cadastro_Turmas`: Implementa funcionalidades de listagem e cadastro de turmas. <br>
- `Listagem_De_Frequencia	`: Contém a lógica de exibição das frequências dos alunos. <br>
- `Lucas-H	`: Branch onde o front-end foi inicialmente estruturado e publicado. Contém a base visual e os componentes principais da interface. <br>
- `Pedro	`: Branch do integrante Pedro, onde foram implementados: Plano de Testes de Software e Plano de Testes de Usabilidade. <br>
- `Versao-1.0 `: Primeira versão completa do sistema funcionando. Inclui funcionalidades principais, correções de layout e integração inicial. <br>
- `Versao-1.1	`: Segunda versão estável, com melhorias adicionais de usabilidade, ajustes visuais e refinamentos nas funcionalidades implementadas. <br>

## Planejamento do projeto<br>

###  Divisão de papéis <br>


#### Sprint 1<br>
- _Scrum master_: Vinicius<br>
- Protótipos: Lucas e Vinicius<br>
- Testes: Pedro e Rafael<br>
- Documentação: Sandy e Bruna<br>

#### Sprint 2<br>
- _Scrum master_: Vinicius<br>
- Desenvolvedor _front-end_: Lucas, Carolina e Bruna<br>
- Desenvolvedor _back-end_: Carolina e Vinicius<br>
- Testes: Pedro e Rafael<br>

###  Quadro de tarefas<br>

#### Sprint 1 <br>

| Responsável   | Tarefa/Requisito  | Iniciado em    | Prazo      | Status | Terminado em |<br>
| :----         |    :----          |      :----:    | :----:     | :----: | :----:       |<br>
| Vinicius| Login  | 12/05/2025      | 30/06/2025                 | ✔️ | 27/06/2025      |<br>
| Vinicius e Lucas | CRUD de Usuários  | 01/06/2025  | 30/06/2025  | ✔️ | 01/06/2025     |br>
| Lucas e Vinicius | CRUD de Turmas	  |28/05/2025 | 30/06/2025   | ✔️ |  01/06/2025      |<br>
| Pedro e Vinicius | CRUD de Alunos	  | 28/05/2025 | 30/06/2025  | ✔️ | 16/06/2025       |<br>
| Lucas e Pedro | Menu Principal	    | 12/05/2025| 30/06/2025     | ✔️  |   27/06/2025  |<br>
| Caolina, Vinicius e Lucas   | Perfil do Aluno	 |30/06/2025 | 12/02/2005 | ✔️  |28/06/2025 |<br>
| Bruna e Vinicius| Registrar Presença| 28/05/2025| 30/06/2025   | ✔️  | 20/06/2025      |<br>
| Vinicus | Modificar estrutura do banco | 29/05/2025| 30/06/2025 | ✔️  |  27/06/2025    |<br>

#### Sprint 2 <br>

| Responsável   | Tarefa/Requisito | Iniciado em    | Prazo      | Status | Terminado em    | <br>
| :----         |    :----         |      :----:    | :----:     | :----: | :----:          | <br>
| Carolina e Lucas| 	Login     | 29/05/2025      |30/06/2025 | ✔️    | 24/06/2025     |<br>
| Lucas         |   Home	    | 29/05/2025    | 30/06/2025 | ✔️    |  21/06/2025    | <br>
| Lucas         |   Turmas	  | 29/05/2025    | 30/06/2025 | ✔️    |  21/06/2025    |<br>
| Lucas         |   Usuários	|  29/05/2025   | 30/06/2025 | ✔️  |   21/06/2025     |<br>
| Carolina e Lucas|   Alunos		|  29/05/2025 | 30/06/2025 | ✔️  |   24/06/2025    |<br>
| Bruna         |    Aula	    |  16/06/2025   | 30/06/2025 | ✔️  |  16/06/2025      |<br>
| Vinicius      | Banco de Dados  |13/05/2025 | 30/06/2025 | ✔️  |16/06/2025    |<br>
| Pedro e Rafael|	Documentação de teste |  28/06/2025   | 30/06/2025 | ✔️  |28/06/2025  |<br>
| Carolina      |Pop-ups (opcional)	 |  27/06/2025 | 30/06/2025 | ✔️ | 28/06/2025  |<br>

Legenda:<br>
- ✔️: terminado <br>
- 📝: em execução <br>
- ⌛: atrasado <br>
- ❌: não iniciado <br>


### Processo <br>

O grupo seguiu a metodologia ágil Scrum para organizar e acompanhar o desenvolvimento do projeto. As tarefas foram divididas em sprints, com prazos definidos para cada entrega parcial e reuniões periódicas para alinhamento da equipe, revisão do progresso e replanejamento quando necessário. 
Para o gerenciamento do projeto, utilizamos a ferramenta Trello, onde as tarefas foram organizadas em quadros com colunas que indicavam o status de cada atividade, como "A Fazer", "Em andamento" e "Concluído". Essa organização visual permitiu à equipe acompanhar o progresso das entregas, facilitar a comunicação e garantir que todos estivessem cientes de suas responsabilidades. <br>

## Relação de ambientes de trabalho<br>
### Ferramentas<br>

| Ambiente                            | Plataforma                         | Link de acesso                         |<br>
|-------------------------------------|------------------------------------|----------------------------------------|<br>
| Repositório de código fonte         | GitHub                             | https://github.com/ICEI-PUC-Minas-PCO-SI/2025-1-p5-tias-grupo3.git|<br>
| Documentos do projeto               | Google Docs                        | https://docs.google.com/document/d/1iHhh2hjOmBgQGTWVt_aO8kXqRS3qxbHHrhcOum2YHgo/edit?usp=sharing |<br>
| Link Figma                          | Figma                              | https://www.figma.com/design/YLEuOfqvxmMry87SxlO8mm/Black-Belt?node-id=0-1&p=f&t=VtBiJCURuEpvY7Ud-0| <br>
| Link Caso de Teste                  | Word                               | https://sgapucminasbr my.sharepoint.com/personal/1452976_sga_pucminas_br/_layouts/15/guestaccess.aspx?share=EbYkJV8cdrpCg2ftZamBx1MBr_ypgZHEQDfnDPPJxNpvbg&e=ofIhjb  | <br>
| Hospedagem                          | Render                             | https://blackbeltprod.onrender.com | <br>

 

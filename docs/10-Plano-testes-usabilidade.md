# Plano de testes de usabilidade

<span style="color:red">Pré-requisitos: <a href="05-Projeto-interface.md"> Projeto de interface</a></span>, <a href="08-Plano-testes-software.md"> Plano de testes de software</a>

O teste de usabilidade permite avaliar a qualidade da interface com o usuário da aplicação interativa. Um plano de teste de usabilidade deverá conter: o detalhamento dos objetivos (ou cenários) em função dos requisitos levantados/implementados, os critérios que serão utilizados para a seleção dos participantes, os procedimentos a serem adotados pelos condutores de teste (por exemplo: os testes serão presenciais ou remotos? O método será observação direta, medição ou avaliação?), os dados a serem coletados (quantidade de cliques, número de erros, tempo, etc.), a ordem de execução das tarefas e das etapas da sessão de teste, os recursos demandados, as métricas coletadas, entre outros.

Para cada voluntário do teste, é fundamental coletar e apresentar todos os dados/métricas previamente definidos. No entanto, atendendo à LGPD (Lei Geral de Proteção de Dados), nenhum dado sensível que permita identificar o voluntário deverá ser apresentado.

O objetivo do plano de testes de usabilidade é obter informações quanto à expectativa dos usuários em relação à funcionalidade da aplicação de forma geral.

Para tanto, foram elaborados quatro cenários, cada um baseado na definição apresentada sobre as histórias dos usuários, definido na etapa das especificações do projeto.

Foram convidadas quatro pessoas que os perfis se encaixassem nas definições das histórias apresentadas na documentação, visando averiguar os seguintes indicadores:

Taxa de sucesso: responde se o usuário conseguiu ou não executar a tarefa proposta;

Satisfação subjetiva: responde como o usuário avalia o sistema com relação à execução da tarefa proposta, conforme a seguinte escala:

1. Péssimo; 
2. Ruim; 
3. Regular; 
4. Bom; 
5. Ótimo.

Tempo para conclusão da tarefa: em segundos, e em comparação com o tempo utilizado quando um especialista (um desenvolvedor) realiza a mesma tarefa.

Objetivando respeitar as diretrizes da Lei Geral de Proteção de Dados, as informações pessoais dos usuários que participaram do teste não foram coletadas, tendo em vista a ausência de Termo de Consentimento Livre e Esclarecido.


## Cenários de teste de usabilidade

| Nº do cenário | Descrição do cenário |
|---------------|----------------------|
| **1** | Você é um instrutor que deseja criar um usuário com nome de “Mica Galvão”. Encontre onde possui a parte de alunos e cadastre esse novo aluno preenchendo todos os campos. |
| **2** | Você é um instrutor e deseja visualizar todos os alunos que possuam “Rafael” no nome. Encontre a parte de alunos no sistema e filtre por nome. |
| **3** | Você é um administrador que precisa excluir um instrutor demitido recentemente. Encontre onde possui a lista de instrutores e exclua o último. |
| **4** | Você é um instrutor que deseja adicionar uma nova habilidade a um aluno da turma **Dragão Negro**. Encontre a lista de usuários e adicione uma nova habilidade ao perfil de um usuário desta turma. |
| **5** | Você é um instrutor que precisa editar o perfil de um aluno, pois seu telefone está incorreto. Encontre a lista de usuários e edite seu número. |
| **6** | Você é um administrador que precisa cadastrar um novo auxiliar para ajudar nas demandas do dia a dia. Encontre a lista de usuários e crie um usuário do tipo **Auxiliar**, preenchendo todos os campos necessários. |
| **7** | Você é um administrador e deseja visualizar quais instrutores estão cadastrados atualmente no sistema. Encontre a lista de usuários e verifique o tipo de usuário de cada um. |
| **8** | Você é um administrador e deseja cadastrar uma nova turma com nome de **“Treino Kids”** para às **07:00**. Encontre a parte de turmas e realize o cadastro para qualquer instrutor. |
| **9** | Você é um administrador e deseja visualizar qual foi a data de cadastro da turma **“Cobra Kai”**. Encontre a parte de turmas e verifique a data de cadastro para esta turma. |
| **10** | Você é um administrador e deseja excluir a turma **“Treino Kids”**. Encontre a parte de turmas e realize a exclusão. |
| **11** | Você é um instrutor e deseja realizar a chamada dos alunos da turma **Cobra Kai**. Encontre a realização de frequência e faça a chamada para os alunos presentes. |
| **12** | Você é um instrutor e deseja realizar a chamada somente para o aluno **“Rafael Romagnoli”** da turma **“Dragão Negro”**. Encontre a realização de frequência e registre presença somente para este usuário. |


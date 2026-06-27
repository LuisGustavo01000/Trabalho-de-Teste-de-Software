# Plano de testes de software

<span style="color:red">Pré-requisitos: <a href="02-Especificacao.md"> Especificação do projeto</a></span>, <a href="05-Projeto-interface.md"> Projeto de interface</a>

O plano de testes de software é gerado a partir da especificação do sistema e consiste em casos de teste que deverão ser executados quando a implementação estiver parcial ou totalmente pronta.



---

| **Caso de teste**  | **CT-001 – Cadastrar aluno**  |
|:---:|:---:|
| **Requisito associado** | RF-002 - O sistema deve permitir o cadastro de alunos <br> RF-008 - O sistema deve permitir cadastro de aluno em uma turma |
| **Objetivo do teste** | Verificar se um usuário consegue cadastrar um aluno. |
| **Passos** | - Acessar o navegador <br> - Acessar o sistema (LINK DO SISTEMA) <br> - Realizar login como Administrador ou Instrutor <br> - Clicar na guia de alunos <br> - Clicar em cadastrar aluno <br> - Preencher os campos obrigatórios (nome, CPF, e-mail, telefone, data de nascimento e turma) <br> - Clicar em "Cadastrar" |
| **Critério de êxito** | O cadastro foi realizado com sucesso. |
| **Responsável pela elaboração do caso de teste** | Pedro Arley |

---

| **Caso de teste**  | **CT-002 – Editar aluno**  |
|:---:|:---:|
| **Requisito associado** | RF-004 - O sistema deve permitir a edição dos dados dos alunos |
| **Objetivo do teste** | Verificar se um instrutor ou administrador consegue editar os dados do aluno. |
| **Passos** | - Acessar o navegador <br> - Acessar o sistema (LINK DO SISTEMA) <br> - Realizar login como Administrador ou Instrutor <br> - Clicar na guia de alunos <br> - Clicar em editar aluno <br> - Editar o telefone cadastrado |
| **Critério de êxito** | A alteração foi realizada com sucesso. |
| **Responsável pela elaboração do caso de teste** | Rafael Romagnoli |

---

| **Caso de teste**  | **CT-003 – Excluir aluno**  |
|:---:|:---:|
| **Requisito associado** | RF-003 - O sistema deve permitir a exclusão de alunos |
| **Objetivo do teste** | Verificar se um instrutor ou administrador consegue excluir um aluno. |
| **Passos** | - Acessar o navegador <br> - Acessar o sistema (LINK DO SISTEMA) <br> - Realizar login como Administrador ou Instrutor <br> - Clicar na guia de alunos <br> - Clicar em excluir aluno |
| **Critério de êxito** | A exclusão do usuário foi realizada com sucesso. |
| **Responsável pela elaboração do caso de teste** | Rafael Romagnoli |

---

| **Caso de teste**  | **CT-004 – Exibir todos os alunos cadastrados**  |
|:---:|:---:|
| **Requisito associado** | RF-016 - O sistema deve exibir todos os alunos por turma |
| **Objetivo do teste** | Verificar se um instrutor ou administrador consegue visualizar os alunos cadastrados na turma. |
| **Passos** | - Acessar o navegador <br> - Acessar o sistema (LINK DO SISTEMA) <br> - Realizar login como Administrador ou Instrutor <br> - Clicar na guia de alunos |
| **Critério de êxito** | Foi exibido uma lista com os alunos em suas respectivas turmas. |
| **Responsável pela elaboração do caso de teste** | Pedro Arley |

---

| **Caso de teste**  | **CT-005 – Realizar login como instrutor e administrador**  |
|:---:|:---:|
| **Requisito associado** | RF-001 - O sistema deve permitir realizar login com dados pessoais |
| **Objetivo do teste** | Verificar se um instrutor ou administrador consegue realizar login com seus dados no sistema. |
| **Passos** | - Acessar o navegador <br> - Acessar o sistema (LINK DO SISTEMA) <br> - Realizar login como Administrador ou Instrutor |
| **Critério de êxito** | Login foi realizado com êxito. |
| **Responsável pela elaboração do caso de teste** | Pedro Arley |

---

| **Caso de teste**  | **CT-006 – Realizar cadastro de uma nova turma**  |
|:---:|:---:|
| **Requisito associado** | RF-012 - O sistema deve permitir o cadastro de turmas |
| **Objetivo do teste** | Verificar se um instrutor ou administrador consegue realizar cadastro de uma nova turma. |
| **Passos** | - Acessar o navegador <br> - Acessar o sistema (LINK DO SISTEMA) <br> - Realizar login como Administrador ou Instrutor <br> - Clicar em “Turma” <br> - Clicar em “Cadastrar Turma” <br> - Preencher dados obrigatórios (Nome da turma, Instrutor responsável e horário) |
| **Critério de êxito** | Uma nova turma foi cadastrada no sistema. |
| **Responsável pela elaboração do caso de teste** | Rafael Romagnoli |

---

| **Caso de teste**  | **CT-007 – Realizar edição de uma turma**  |
|:---:|:---:|
| **Requisito associado** | RF-014 - O sistema deve permitir a edição dos dados da turma |
| **Objetivo do teste** | Verificar se um instrutor ou administrador consegue realizar edição de uma turma. |
| **Passos** | - Acessar o navegador <br> - Acessar o sistema (LINK DO SISTEMA) <br> - Realizar login como Administrador ou Instrutor <br> - Clicar em “Turma” <br> - Clicar em “Editar” na turma desejada <br> - Editar o nome da “turma” |
| **Critério de êxito** | O nome da turma foi alterado. |
| **Responsável pela elaboração do caso de teste** | Pedro Arley |

---

| **Caso de teste**  | **CT-008 – Realizar exclusão de uma turma**  |
|:---:|:---:|
| **Requisito associado** | RF-013 - O sistema deve permitir a exclusão de turmas |
| **Objetivo do teste** | Verificar se um instrutor ou administrador consegue realizar exclusão de uma turma. |
| **Passos** | - Acessar o navegador <br> - Acessar o sistema (LINK DO SISTEMA) <br> - Realizar login como Administrador ou Instrutor <br> - Clicar em “Turma” <br> - Clicar em “Excluir” na turma desejada |
| **Critério de êxito** | A turma desejada foi excluída. |
| **Responsável pela elaboração do caso de teste** | Rafael Romagnoli |

---

| **Caso de teste**  | **CT-009 – Exibir todas as turmas cadastradas**  |
|:---:|:---:|
| **Requisito associado** | RF-015 - O sistema deve exibir todas as turmas cadastradas |
| **Objetivo do teste** | Verificar se um instrutor ou administrador consegue visualizar todas as turmas cadastradas no sistema. |
| **Passos** | - Acessar o navegador <br> - Acessar o sistema (LINK DO SISTEMA) <br> - Realizar login como Administrador ou Instrutor <br> - Clicar em “Turma” |
| **Critério de êxito** | A lista de turmas cadastradas foi exibida. |
| **Responsável pela elaboração do caso de teste** | Pedro Arley |

---

| **Caso de teste**  | **CT-010 – Cadastrar uma habilidade no aluno**  |
|:---:|:---:|
| **Requisito associado** | RF-005 - O sistema deve permitir a alteração dos atributos técnicos de cada aluno <br> RF-007 - O sistema deve permitir realizar comentários no perfil de cada aluno |
| **Objetivo do teste** | Verificar se um instrutor ou administrador consegue adicionar habilidades e realizar comentários no perfil do aluno. |
| **Passos** | - Acessar o navegador <br> - Acessar o sistema (LINK DO SISTEMA) <br> - Realizar login como Administrador ou Instrutor <br> - Clicar na guia de alunos <br> - Clicar em editar aluno <br> - Cadastrar uma nova habilidade <br> - Preencher campos obrigatórios (Habilidade e comentário) |
| **Critério de êxito** | Uma nova habilidade com comentário foi cadastrada |
| **Responsável pela elaboração do caso de teste** | Pedro Arley |

---

| **Caso de teste**  | **CT-011 – Realizar frequência dos alunos**  |
|:---:|:---:|
| **Requisito associado** | RF-006 - O sistema deve permitir o registro de frequência dos alunos |
| **Objetivo do teste** | Verificar se um instrutor consegue realizar chamada de frequência dos alunos de uma turma. |
| **Passos** | - Acessar o navegador <br> - Acessar o sistema (LINK DO SISTEMA) <br> - Realizar login como ou instrutor <br> - Clicar na guia de registrar frequência <br> - Clicar em “Lançar presença” na turma desejada <br> - Selecionar alunos desejados <br> - Clicar em registrar |
| **Critério de êxito** | Os alunos receberam presença para a aula registrada |
| **Responsável pela elaboração do caso de teste** | Rafael Romagnoli |

---

| **Caso de teste**  | **CT-012 – Cadastrar instrutor**  |
|:---:|:---:|
| **Requisito associado** | RF-018 - O sistema deve permitir o cadastro de instrutores. |
| **Objetivo do teste** | Verificar se um administrador consegue realizar o cadastro de um novo instrutor. |
| **Passos** | - Acessar o navegador <br> - Acessar o sistema (LINK DO SISTEMA) <br> - Realizar login como Administrador <br> - Clicar na guia de usuários <br> - Clicar em cadastrar usuário <br> - Preencher campos obrigatórios (Nome, e-mail, CPF, telefone e data de nascimento, tipo de usuário e senha) <br> - Clicar em salvar |
| **Critério de êxito** | Um novo instrutor foi cadastrado no sistema e exibido na lista de instrutores |
| **Responsável pela elaboração do caso de teste** | Rafael Romagnoli |

---

| **Caso de teste**  | **CT-013 – Editar instrutor**  |
|:---:|:---:|
| **Requisito associado** | RF-020 - O sistema deve permitir a edição nos dados dos instrutores |
| **Objetivo do teste** | Verificar se um administrador consegue realizar a edição dos dados de um instrutor. |
| **Passos** | - Acessar o navegador <br> - Acessar o sistema (LINK DO SISTEMA) <br> - Realizar login como Administrador <br> - Clicar na guia de usuário <br> - Clicar em editar no instrutor desejado <br> - Editar o campo de data de nascimento <br> - Clicar em salvar |
| **Critério de êxito** | Os dados do instrutor foram salvos com a nova alteração |
| **Responsável pela elaboração do caso de teste** | Rafael Romagnoli |

---

| **Caso de teste**  | **CT-014 – Excluir instrutor**  |
|:---:|:---:|
| **Requisito associado** | RF-019 - O sistema deve permitir a exclusão de instrutores |
| **Objetivo do teste** | Verificar se um administrador consegue realizar a exclusão de um instrutor. |
| **Passos** | - Acessar o navegador <br> - Acessar o sistema (LINK DO SISTEMA) <br> - Realizar login como Administrador <br> - Clicar na guia de usuário <br> - Clicar em excluir no instrutor desejado |
| **Critério de êxito** | O instrutor desejado foi excluído da lista de instrutores |
| **Responsável pela elaboração do caso de teste** | Pedro Arley |

---

| **Caso de teste**  | **CT-015 – Alterar turma do aluno**  |
|:---:|:---:|
| **Requisito associado** | RF-009 - O sistema deve permitir a exclusão do aluno de uma turma |
| **Objetivo do teste** | Alterar a turma do aluno cadastrado |
| **Passos** | - Acessar o navegador <br> - Acessar o sistema (LINK DO SISTEMA) <br> - Realizar login como instrutor <br> - Clicar na guia de aluno <br> - Clicar em “Editar” no aluno desejado <br> - Selecionar a nova turma desejada em “Turma” <br> - Clicar em "Salvar” |
| **Critério de êxito** | A turma que o aluno pertence foi alterada |
| **Responsável pela elaboração do caso de teste** | Rafael Romagnoli |

---

| **Caso de teste**  | **CT-016 – Visualizar desempenho do aluno**  |
|:---:|:---:|
| **Requisito associado** | RF-011 - O sistema deve exibir o desempenho ao acessar o perfil do aluno |
| **Objetivo do teste** | Visualizar todas as habilidades e comentários feitos no perfil do aluno |
| **Passos** | - Acessar o navegador <br> - Acessar o sistema (LINK DO SISTEMA) <br> - Realizar login como instrutor <br> - Clicar na guia de aluno <br> - Clicar em “Perfil” no aluno desejado |
| **Critério de êxito** | A lista de habilidades e comentários do aluno foi exibida. |
| **Responsável pela elaboração do caso de teste** | Rafael Romagnoli |



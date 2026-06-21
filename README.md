# Trabalho-Teste-de-Software

Breve descrição do sistema.

## Pré-requisitos

Antes de começar, certifique-se de ter instalado em sua máquina:

- [Node.js](https://nodejs.org/) (v18 ou superior)
- [pnpm](https://pnpm.io/) (gerenciador de pacotes utilizado no projeto)
- [VS Code](https://code.visualstudio.com/) (Editor de código)
- Conta no [Turso](https://turso.tech/) (banco de dados SQLite distribuído)

## Instalação

### 1. Clonar o Repositório

```bash
git clone https://github.com/MatheusCanuto07/GastroFlow.git
cd Trabalho-Teste-de-Software
```

### 2. Instalar Dependências

Na raiz do projeto, execute:

```bash
pnpm install
```

> Caso prefira, também é possível usar `npm install`, mas o projeto utiliza `pnpm-lock.yaml` como referência de versões.

### 3. Configurar Variáveis de Ambiente

Crie um arquivo `.env` na raiz do projeto com as seguintes variáveis:

```
DATABASE_URL=
DATABASE_AUTH_TOKEN=
PORT=3000
```

- `DATABASE_URL`: URL de conexão do banco de dados Turso (ex: `libsql://seu-banco.turso.io`)
- `DATABASE_AUTH_TOKEN`: Token de autenticação gerado no Turso
- `PORT`: Porta em que a aplicação será executada (padrão: 3000)

## Configuração do Banco de Dados

O projeto utiliza [Turso](https://turso.tech/) (banco de dados SQLite distribuído) em conjunto com o [Drizzle ORM](https://orm.drizzle.team/) para modelagem e migrações.

### 1. Criar o Banco no Turso

Crie uma conta na [Turso](https://turso.tech/), instale a CLI e crie um novo banco de dados:

```bash
turso db create nome-do-banco
turso db tokens create nome-do-banco
```

Copie a URL e o token gerados para as variáveis `DATABASE_URL` e `DATABASE_AUTH_TOKEN` no arquivo `.env`.

### 2. Aplicar o Schema ao Banco

Com as variáveis de ambiente configuradas, sincronize o schema definido em `src/lib/server/schema/` com o banco:

```bash
pnpm db:push
```

Outros comandos úteis do Drizzle disponíveis no projeto:

```bash
pnpm generate   # Gera arquivos de migração a partir do schema
pnpm db:migrate # Executa as migrações geradas
pnpm db:studio  # Abre o Drizzle Studio para visualizar o banco
```

## Como Rodar o Backend

O backend é integrado ao próprio SvelteKit (rotas server-side em `src/routes` e lógica de acesso a dados em `src/lib/server`), não havendo um servidor separado.

Para iniciar o servidor de desenvolvimento (frontend + backend juntos):

```bash
pnpm dev
```

Se tudo estiver correto, o terminal exibirá uma mensagem semelhante a:

```
  VITE v5.x.x  ready in xxx ms

  ➜  Local:   http://localhost:5173/
```

A aplicação ficará disponível em: [http://localhost:5173](http://localhost:5173)

## Como Rodar o Frontend

O frontend é construído com **SvelteKit** e não requer configuração separada — ele é servido junto ao backend pelo mesmo comando `pnpm dev`.

Para visualizar as telas do projeto:

1. Certifique-se de que o servidor está rodando (`pnpm dev`).
2. Abra o navegador no endereço indicado no terminal (geralmente `http://localhost:5173`).
3. As páginas estão organizadas em `src/routes`, seguindo o sistema de roteamento por pastas do SvelteKit.

Para gerar uma build de produção:

```bash
pnpm build
pnpm preview
```

## Testes Automatizados

> ⚠️ Este projeto ainda não possui testes automatizados implementados.

Futuramente, esta seção será atualizada com instruções de execução (comando, framework utilizado e exemplo de saída esperada) assim que a suíte de testes for adicionada ao projeto.

## Tecnologias Utilizadas

- [SvelteKit](https://kit.svelte.dev/) — Framework principal (frontend + backend)
- [Svelte 5](https://svelte.dev/) — Biblioteca de componentes reativos
- [TypeScript](https://www.typescriptlang.org/) — Tipagem estática
- [Drizzle ORM](https://orm.drizzle.team/) — ORM para modelagem e migrações
- [Turso](https://turso.tech/) (LibSQL/SQLite) — Banco de dados
- [Tailwind CSS](https://tailwindcss.com/) + [DaisyUI](https://daisyui.com/) — Estilização
- [Vite](https://vitejs.dev/) — Build tool
- [better-auth](https://www.better-auth.com/) — Autenticação
- [Font Awesome](https://fontawesome.com/) — Ícones

## Estrutura do Projeto

```
Trabalho-Teste-de-Software/
├── src/
│   ├── lib/
│   │   ├── components/        # Componentes reutilizáveis da interface
│   │   └── server/
│   │       ├── DAO/           # Camada de acesso a dados
│   │       └── schema/        # Definição das tabelas (Drizzle)
│   └── routes/                 # Rotas e páginas (SvelteKit)
│       ├── (auth)/             # Autenticação (login, cadastro, etc.)
│       └── home/                # Páginas principais da aplicação
├── static/                     # Arquivos estáticos (imagens, ícones)
├── drizzle/                    # Migrações geradas pelo Drizzle
├── drizzle.config.ts           # Configuração do Drizzle ORM
├── svelte.config.js            # Configuração do SvelteKit
├── tailwind.config.ts          # Configuração do Tailwind CSS
├── vite.config.ts              # Configuração do Vite
├── package.json
└── README.md
```

## Observações

- O projeto utiliza **pnpm** como gerenciador de pacotes padrão; recomenda-se mantê-lo para evitar inconsistências no lockfile.
- É necessário ter uma conta e um banco configurado no **Turso** antes de rodar o projeto pela primeira vez — sem isso, as rotas que dependem do banco não funcionarão.
- O arquivo `.env` **não deve** ser versionado; certifique-se de adicioná-lo ao `.gitignore`.
- Em caso de dúvidas sobre o schema do banco, consulte os arquivos em `src/lib/server/schema/`.

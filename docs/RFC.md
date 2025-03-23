# Request for Comments (RFC)

## Capa
* **Título do Projeto**: MapShare - Plataforma de Compartilhamento e Visualização de Mapas em Tempo Real
* **Nome do Estudante**: Ryan Gabriel Mazzei Bromati
* **Curso**: Engenharia de Software
* **Data de Entrega**: 25/03/2025

## Resumo

Este documento apresenta uma proposta para o desenvolvimento de uma plataforma de compartilhamento e visualização de mapas em tempo real. O projeto visa criar um sistema baseado em microserviços com .NET Aspire, que permitirá aos usuários criar e compartilhar mapas, adicionar pontos de interesse, definir níveis de privacidade (público, protegido por link, privado), e interagir com as marcações de outros usuários através de curtidas e favoritos. O sistema utilizará tecnologias modernas de desenvolvimento web, incluindo C# .NET 8+, Angular 18+ para o frontend, e uma arquitetura híbrida de banco de dados com PostgreSQL e MongoDB. Este RFC busca a aprovação inicial para o desenvolvimento do projeto de portfólio, apresentando detalhadamente o escopo, requisitos, arquitetura proposta e as tecnologias a serem utilizadas.

## 1. Introdução

### Contexto

A visualização e compartilhamento de informações geográficas têm se tornado cada vez mais importantes nas aplicações modernas. Desde aplicativos de navegação até plataformas de compartilhamento de experiências, a capacidade de interagir com mapas de forma colaborativa representa um avanço significativo na forma como consumimos e produzimos informações geoespaciais. Em um mundo cada vez mais conectado, a necessidade de compartilhar experiências localizadas geograficamente cresce exponencialmente, criando oportunidades para inovação no campo das tecnologias geoespaciais.

### Justificativa

Apesar da existência de diversas soluções para visualização de mapas, há uma lacuna no mercado para plataformas que permitam o compartilhamento e a colaboração em tempo real de forma intuitiva e escalável. Este projeto visa preencher essa lacuna, oferecendo uma solução moderna que demonstre as capacidades das tecnologias emergentes como .NET Aspire e arquiteturas de microserviços.

O desenvolvimento desta plataforma proporciona uma oportunidade significativa para explorar e aplicar conceitos avançados de engenharia de software, incluindo arquitetura distribuída, comunicação entre serviços, persistência poliglota e desenvolvimento de interfaces interativas. A implementação de uma solução que integra essas tecnologias avançadas representa um desafio técnico relevante que contribuirá para a formação profissional em engenharia de software.

### Objetivos

**Objetivo Principal:**
Desenvolver uma plataforma de compartilhamento e visualização de mapas em tempo real que permita a colaboração entre usuários através de um mapa global interativo e mapas personalizados com diferentes níveis de privacidade.

**Objetivos Secundários:**
- Implementar uma arquitetura de microserviços usando .NET Aspire
- Demonstrar comunicação entre serviços utilizando diferentes protocolos (REST, gRPC, mensageria)
- Implementar funcionalidades de tempo real usando SignalR
- Aplicar uma abordagem híbrida de armazenamento de dados com PostgreSQL e MongoDB
- Criar uma interface responsiva e intuitiva utilizando Angular 18+
- Explorar padrões de design e arquitetura modernos como CQRS e Event Sourcing
- Implementar práticas de DevOps com CI/CD através do GitHub Actions

## 2. Descrição do Projeto

### Tema do Projeto

O projeto consiste no desenvolvimento de uma plataforma web que permite aos usuários criar mapas personalizados, compartilhá-los com diferentes níveis de privacidade (público, protegido por link, privado), e colaborar em um mapa global onde cada usuário pode adicionar apenas uma marcação. A plataforma permitirá interações como curtidas em marcações individuais e favoritar mapas públicos para acesso facilitado. A plataforma será desenvolvida utilizando uma arquitetura de microserviços com .NET Aspire, explorando diferentes formas de comunicação entre serviços e proporcionando uma experiência em tempo real.

O produto final será uma aplicação web completa, com backend distribuído e frontend responsivo, que demonstrará a aplicação prática de conhecimentos avançados em engenharia de software.

### Problemas a Resolver

1. **Criação e compartilhamento de mapas personalizados**: Desenvolver uma interface intuitiva que permita aos usuários criar mapas personalizados e compartilhá-los com diferentes níveis de privacidade.
2. **Gerenciamento eficiente de dados geoespaciais**: Desenvolver uma estratégia de armazenamento híbrido que otimize consultas geoespaciais.
3. **Limitação e controle de marcações no mapa global**: Implementar um sistema que permita apenas uma marcação por usuário no mapa global colaborativo.
4. **Sistema de privacidade de mapas**: Implementar controles de privacidade que permitam mapas públicos, protegidos por link e privados.
5. **Interação social através de curtidas e favoritos**: Implementar um sistema que permita usuários curtirem marcações e favoritarem mapas públicos.
6. **Organização e exibição de mapas favoritos**: Implementar um sistema que organize e priorize a exibição de mapas favoritos.
7. **Limitação de mapas públicos por usuário**: Implementar um sistema que limite cada usuário a no máximo 3 mapas públicos.
8. **Notificações em tempo real**: Criar um sistema de notificações que mantenha os usuários informados sobre atividades relevantes.
9. **Implementação de uma arquitetura escalável**: Projetar uma arquitetura que possa crescer organicamente com o aumento da base de usuários.
10. **Otimização de performance**: Garantir tempos de resposta aceitáveis mesmo com grande volume de dados geoespaciais.

### Limitações

- O projeto não abordará navegação guiada ou cálculo de rotas
- Não incluirá funcionalidades de análise espacial avançada
- Não implementará visualização 3D de mapas
- Não oferecerá funcionalidades de mapas offline
- Não tratará da criação de camadas de dados geoespaciais complexas
- Não integrará com sistemas externos de geolocalização em tempo real
- Não incluirá análise de dados baseada em machine learning
- Não implementará funcionalidades de realidade aumentada

## 3. Especificação Técnica

### 3.1. Requisitos de Software

#### Lista de Requisitos

**Requisitos Funcionais (RF):**

1. RF01: O sistema deve permitir que usuários se cadastrem e façam login
2. RF02: O sistema deve permitir que usuários criem mapas personalizados
3. RF03: O sistema deve permitir que usuários adicionem múltiplos marcadores em seus mapas personalizados
4. RF04: O sistema deve permitir que usuários definam o nível de privacidade de seus mapas (público, protegido por link, privado)
5. RF05: O sistema deve limitar cada usuário a ter até 3 mapas públicos simultaneamente
6. RF06: O sistema deve disponibilizar um mapa global onde cada usuário pode adicionar apenas uma marcação
7. RF07: O sistema deve permitir que usuários curtam marcações no mapa global
8. RF08: O sistema deve permitir que usuários curtam mapas públicos de outros usuários
9. RF09: O sistema deve permitir que usuários favoritem mapas públicos de outros usuários
10. RF10: O sistema deve exibir mapas favoritados com prioridade na listagem de mapas públicos
11. RF11: O sistema deve exibir atualizações em tempo real quando novos pontos são adicionados
12. RF12: O sistema deve permitir o compartilhamento de mapas através de links, respeitando as configurações de privacidade
13. RF13: O sistema deve ter três telas principais: mapa global, mapas pessoais e mapas públicos
14. RF14: O sistema deve permitir que usuários editem seus mapas personalizados após a criação

**Requisitos Não-Funcionais (RNF):**

1. RNF01: O sistema deve ser desenvolvido como uma arquitetura de microserviços usando .NET Aspire
2. RNF02: O frontend deve ser implementado utilizando Angular 18+
3. RNF03: O sistema deve utilizar PostgreSQL para dados relacionais e MongoDB para dados geoespaciais
4. RNF04: O sistema deve utilizar Redis para cache e funcionalidades de tempo real
5. RNF05: O sistema deve implementar comunicação assíncrona entre serviços utilizando RabbitMQ
6. RNF06: O sistema deve implementar comunicação em tempo real com o frontend utilizando SignalR
7. RNF07: O sistema deve ser responsivo e funcionar em dispositivos móveis e desktop
8. RNF08: O sistema deve ser escalável horizontalmente
9. RNF09: O sistema deve ter um tempo de resposta inferior a 2 segundos para operações comuns
10. RNF10: O sistema deve suportar um mínimo de 1000 usuários simultâneos
11. RNF11: O sistema deve implementar práticas de observabilidade com logs centralizados e métricas
12. RNF12: O sistema deve implementar testes automatizados com cobertura mínima de 80%
13. RNF13: O sistema deve utilizar Docker para containerização dos serviços
14. RNF14: O sistema deve utilizar GitHub Actions para CI/CD

#### Representação dos Requisitos

``` mermaid
stateDiagram-v2
    state "Usuário Não Registrado" as NR
    state "Usuário Registrado" as UR
    
    state "Sistema MapShare" as Sistema {
        state "Gerenciamento de Usuários" as GU {
            [*] --> Cadastro
            Cadastro --> Login
            Login --> [*]
        }
        
        state "Mapas Personalizados" as MP {
            [*] --> Criar
            Criar --> Editar
            Criar --> Definir_Privacidade
            Definir_Privacidade --> Público
            Definir_Privacidade --> Protegido_por_Link
            Definir_Privacidade --> Privado
            Editar --> Adicionar_Marcador
            Editar --> [*]
        }
        
        state "Mapa Global" as MG {
            [*] --> Visualizar
            Visualizar --> Adicionar_Marcacao
            Visualizar --> Curtir_Marcacao
            Adicionar_Marcacao --> [*]
            Curtir_Marcacao --> [*]
        }
        
        state "Mapas Públicos" as MPB {
            [*] --> Listar
            Listar --> Visualizar_Mapa
            Visualizar_Mapa --> Curtir_Mapa
            Visualizar_Mapa --> Favoritar_Mapa
            Curtir_Mapa --> [*]
            Favoritar_Mapa --> [*]
        }
        
        state "Compartilhamento" as SC {
            [*] --> Gerar_Link
            Gerar_Link --> Compartilhar
            Compartilhar --> [*]
        }
    }
    
    NR --> GU: Acessar
    NR --> MPB: Visualizar mapas públicos
    UR --> MP: Gerenciar mapas
    UR --> MG: Interagir
    UR --> MPB: Interagir
    UR --> SC: Compartilhar mapas
```


O diagrama acima representa os principais casos de uso do sistema, incluindo a interação dos usuários com mapas personalizados e o mapa global colaborativo. Os atores principais são os usuários registrados e não registrados, com diferentes níveis de permissão e acesso às funcionalidades do sistema.

### 3.2. Considerações de Design

#### Visão Inicial da Arquitetura

A arquitetura do sistema será baseada em microserviços, com cada serviço responsável por uma funcionalidade específica. Os serviços se comunicarão através de um barramento de mensagens (RabbitMQ) para operações assíncronas e APIs RESTful para operações síncronas. Um API Gateway gerenciará as requisições do frontend e encaminhará para os serviços apropriados.

Os principais componentes da arquitetura são:

1. **API Gateway**: Gerencia a comunicação entre o frontend e os microserviços, implementando roteamento, autenticação, rate limiting e cache.
2. **Serviço de Autenticação**: Gerencia usuários, autenticação e autorização usando JWT e OAuth 2.0.
3. **Serviço de Mapas Pessoais**: Gerencia mapas criados pelos usuários, incluindo criação, edição e configurações de privacidade.
4. **Serviço de Mapa Global**: Gerencia o mapa colaborativo compartilhado, incluindo visualização e interação.
5. **Serviço de Marcadores**: Gerencia pontos de interesse, incluindo criação, edição e categorização.
6. **Serviço de Interações**: Gerencia curtidas, favoritos e interações entre usuários e mapas/marcações.
7. **Serviço de Compartilhamento**: Gerencia os diferentes níveis de privacidade e compartilhamento de mapas.
8. **Serviço de Notificações**: Gerencia o envio de notificações em tempo real para usuários.
9. **SignalR Hub**: Gerencia comunicação em tempo real com o frontend para atualizações instantâneas.
10. **Serviço de Análise**: Coleta e processa métricas de uso para análise e monitoramento.

#### Padrões de Arquitetura

- **Arquitetura de Microserviços**: Cada componente do sistema será implementado como um serviço independente, promovendo autonomia, escalabilidade e isolamento.
- **API Gateway**: Padrão para centralizar a comunicação com o frontend, simplificando a experiência do cliente.
- **Event-Driven Architecture**: Comunicação entre serviços baseada em eventos, promovendo baixo acoplamento.
- **Publish-Subscribe**: Para notificações e atualizações em tempo real, permitindo comunicação assíncrona.
- **CQRS (Command Query Responsibility Segregation)**: Para separação de operações de leitura e escrita, otimizando cada fluxo independentemente.
- **Repository Pattern**: Para abstração do acesso aos dados, isolando a lógica de domínio da infraestrutura.
- **Domain-Driven Design**: Para modelagem de domínios complexos, especialmente no contexto de mapas e interações.
- **Circuit Breaker**: Para aumentar a resiliência na comunicação entre serviços.
- **Retry Pattern**: Para lidar com falhas transitórias nas comunicações.
- **Bulkhead Pattern**: Para isolar falhas e evitar efeitos cascata.

#### Modelos C4

**Nível 1: Contexto**
O sistema MapShare interage com usuários através de uma interface web e móvel, permitindo a criação, compartilhamento e interação com mapas e pontos de interesse. O sistema se integra com provedores de mapas para fornecer dados cartográficos base.

**Nível 2: Contêineres**
- Frontend Angular: Interface de usuário responsiva que interage com o backend através do API Gateway
- API Gateway: Ponto único de entrada para requisições do frontend, gerenciando roteamento e autenticação
- Microserviços .NET Aspire: Conjunto de serviços especializados que implementam a lógica de negócio
- Banco de dados PostgreSQL: Armazenamento de dados relacionais (usuários, interações, permissões)
- Banco de dados MongoDB: Armazenamento de dados geoespaciais (mapas, marcadores)
- Cache Redis: Cache distribuído para otimização de performance e suporte a sessões
- Barramento de mensagens RabbitMQ: Comunicação assíncrona entre serviços
- Hub SignalR: Suporte a comunicação em tempo real com o frontend

**Nível 3: Componentes**
Cada microserviço será composto pelos seguintes componentes:
- Controllers API: Endpoints REST para comunicação externa
- Services: Implementação da lógica de negócio
- Repositories: Abstração do acesso a dados
- Domain Models: Representação das entidades de domínio
- Event Handlers: Processamento de eventos do barramento de mensagens
- Validators: Validação de entrada de dados
- Mappers: Conversão entre DTOs e modelos de domínio

**Nível 4: Código**
Detalhamento das classes e interfaces para cada componente será desenvolvido durante a implementação, seguindo princípios SOLID e Clean Code. Serão definidas estruturas específicas para:
- Definição de comandos e consultas (CQRS)
- Implementação de handlers
- Definição de eventos de domínio
- Implementação de políticas de resiliência

### 3.3. Stack Tecnológica

#### Linguagens de Programação

- **C# 10**: Linguagem principal para desenvolvimento do backend, escolhida pela sua robustez, performance e integração com o ecossistema .NET. A versão 10 traz recursos avançados como expressões lambda aprimoradas, tipos de registro estruturados e melhorias em tipos nulos.
- **TypeScript 5.2+**: Para desenvolvimento do frontend, oferecendo tipagem estática e melhor suporte a IDEs, aumentando a produtividade e reduzindo erros em tempo de execução.

#### Frameworks e Bibliotecas

- **Backend**:
  - **.NET 8+**: Framework principal para desenvolvimento do backend, oferecendo alto desempenho e recursos modernos.
  - **.NET Aspire**: Para orquestração de microserviços, proporcionando uma experiência de desenvolvimento integrada.
  - **Entity Framework Core 10**: ORM para acesso ao PostgreSQL, com suporte a migrações e modelagem avançada.
  - **MongoDB Driver**: Para acesso ao MongoDB, otimizado para consultas geoespaciais.
  - **StackExchange.Redis**: Cliente Redis para .NET, permitindo operações de cache distribuído.
  - **MassTransit 8**: Abstração para RabbitMQ facilitando a implementação de padrões de mensageria (status: em análise).
  - **ASP.NET Core SignalR**: Para comunicação em tempo real bidirecional.
  - **IdentityServer4**: Para autenticação e autorização com suporte a OAuth 2.0 e OpenID Connect (status: em análise).
  - **FluentValidation**: Para validação de modelos e entrada de dados.
  - **AutoMapper**: Para mapeamento entre DTOs e modelos de domínio.
  - **Polly**: Para implementação de políticas de resiliência.
  - **Serilog**: Para logging estruturado e centralizado.
  - **MediatR**: Para implementação do padrão Mediator e CQRS.
  - **Scalar**: Para documentação de API com Scalar/OpenAPI.

- **Frontend**:
  - **Angular 18+**: Framework principal para desenvolvimento do frontend, escolhido por sua arquitetura robusta e escalável.
  - **Leaflet.js**: Biblioteca de mapas interativos, com amplo suporte a personalização.
  - **NgRx**: Implementação do padrão Redux para gerenciamento de estado no frontend.
  - **Angular Material**: Componentes UI com design material.
  - **RxJS**: Para programação reativa no frontend.
  - **Chart.js**: Para visualização de dados e métricas.
  - **Microsoft SignalR Client**: Para comunicação em tempo real com o backend.

#### Ferramentas de Desenvolvimento e Gestão de Projeto

- **JetBrains Rider**: IDE principal para desenvolvimento backend, com suporte avançado a C# e .NET.
- **Visual Studio Code**: IDE para desenvolvimento frontend, com extensões para TypeScript e Angular.
- **Docker**: Containerização de serviços, garantindo consistência entre ambientes.
- **Docker Compose**: Orquestração local de contêineres para desenvolvimento.
- **GitHub**: Versionamento de código com estratégia de branching GitFlow.
- **GitHub Actions**: CI/CD automatizado para build, teste e deploy.
- **GitHub Projects**: Gestão ágil do projeto com quadros Kanban.
- **Bruno**: Testes de API e documentação interativa.
- **DBeaver**: Gerenciamento de bancos de dados relacionais.
- **MongoDB Compass**: Gerenciamento visual do MongoDB.
- **Jest**: Framework de testes para frontend.
- **xUnit**: Framework de testes para backend.
<!-- - **SonarQube**: Análise estática de código e qualidade. -->
<!-- - **Grafana**: Visualização de métricas e monitoramento. -->
<!-- - **Prometheus**: Coleta de métricas em tempo real. -->

### 3.4. Considerações de Segurança

- **Autenticação e Autorização**: Implementação de JWT e OAuth 2.0 para autenticação segura, com suporte a múltiplos fatores.
- **HTTPS**: Toda comunicação com o servidor será criptografada com TLS 1.3, incluindo comunicação entre serviços.
- **Validação de Entrada**: Todas as entradas do usuário serão validadas para prevenir ataques como SQL Injection e XSS, utilizando técnicas de sanitização e validação.
- **Rate Limiting**: Implementação de limites de requisições para prevenir ataques de DDoS e abuso de API.
- **Auditoria**: Registro de todas as alterações sensíveis no sistema, com trilhas de auditoria imutáveis.
- **Segurança de Dados**: Implementação de medidas para proteger dados sensíveis dos usuários, incluindo pseudonimização quando necessário.
- **Controle de Acesso**: Implementação de políticas de acesso baseadas em papéis (RBAC) e recursos (ABAC).
- **Secrets Management**: Utilização de gestão segura de segredos com Azure Key Vault ou equivalente.
- **Segurança em DevOps**: Implementação de práticas de DevSecOps, incluindo análise de dependências e vulnerabilidades.
- **Conformidade com LGPD**: Garantia de que o sistema esteja em conformidade com a Lei Geral de Proteção de Dados.
- **Proteção contra ataques comuns**: Implementação de proteções contra CSRF, clickjacking e outros vetores de ataque conhecidos.

## 4. Próximos Passos

Após a aprovação deste RFC, os próximos passos para o desenvolvimento do projeto são:

**Portfólio I (Curto Prazo - próximos 3 meses):**
1. Refinamento dos requisitos baseado no feedback dos professores
2. Definição detalhada da arquitetura e diagrama de componentes
3. Criação do projeto base com estrutura de microserviços
4. Implementação do serviço de autenticação
5. Desenvolvimento do MVP para funcionalidades básicas de mapa
6. Implementação da comunicação entre serviços
7. Desenvolvimento da interface básica do usuário

**Portfólio II (Médio Prazo - 3 a 6 meses):**
1. Implementação completa de todos os microserviços
2. Desenvolvimento da interface de usuário completa
3. Integração de funcionalidades de tempo real
4. Implementação de testes automatizados
5. Configuração da pipeline de CI/CD
6. Otimização de performance e escalabilidade
7. Documentação completa do sistema
8. Apresentação final do projeto

## 5. Referências

- **Documentações Oficiais**:
  - [.NET Documentation](https://docs.microsoft.com/en-us/dotnet/)
  - [.NET Aspire Documentation](https://docs.microsoft.com/en-us/dotnet/aspire/)
  - [Angular Documentation](https://angular.io/docs)
  - [MongoDB Documentation](https://docs.mongodb.com/)
  - [PostgreSQL Documentation](https://www.postgresql.org/docs/)
  - [RabbitMQ Documentation](https://www.rabbitmq.com/documentation.html)
  - [Leaflet.js Documentation](https://leafletjs.com/reference.html)

- **Frameworks e Ferramentas**:
  - [Entity Framework Core](https://github.com/dotnet/efcore)
  - [IdentityServer4](https://github.com/IdentityServer/IdentityServer4)
  - [SignalR](https://github.com/dotnet/aspnetcore/tree/main/src/SignalR)
  - [MassTransit](https://masstransit-project.com/)
  - [Polly](https://github.com/App-vNext/Polly)
  - [Serilog](https://serilog.net/)
  - [AutoMapper](https://automapper.org/)
  - [FluentValidation](https://fluentvalidation.net/)

## 6. Apêndices

### Apêndice A: Glossário de Termos

- **Microserviços**: Arquitetura de software onde a aplicação é composta por pequenos serviços independentes.
- **API Gateway**: Componente que atua como ponto único de entrada para os clientes, encaminhando requisições para os serviços apropriados.
- **Event-Driven Architecture**: Padrão de arquitetura em que os componentes se comunicam através de eventos.
- **CQRS**: Command Query Responsibility Segregation, padrão que separa operações de leitura e escrita.
- **JWT**: JSON Web Token, método para representar claims entre duas partes.
- **OAuth 2.0**: Protocolo de autorização para acesso delegado.
- **SignalR**: Biblioteca para comunicação em tempo real entre cliente e servidor.
- **Mapa Global**: Espaço compartilhado onde cada usuário pode adicionar apenas uma marcação.
- **Mapas Pessoais**: Mapas criados e gerenciados pelo próprio usuário.
- **Mapas Públicos**: Mapas compartilhados que podem ser visualizados por qualquer usuário autenticado.
- **Marcador/Marcação**: Ponto de interesse adicionado a um mapa.
- **Favoritar**: Ação de marcar um mapa público para acesso facilitado.

### Apêndice B: Estimativas Iniciais de Esforço

| Componente | Estimativa (horas) |
|------------|-------------------|
| Configuração da Infraestrutura | 40 |
| Serviço de Autenticação | 60 |
| Serviço de Mapas Pessoais | 80 |
| Serviço de Mapa Global | 100 |
| Serviço de Marcadores | 60 |
| Serviço de Interações | 40 |
| Serviço de Compartilhamento | 50 |
| Serviço de Notificações | 30 |
| Frontend Angular | 120 |
| Testes e QA | 80 |
| DevOps e CI/CD | 40 |
| **Total** | **700** |

## 7. Avaliações de Professores

### Considerações Professor/a:
(Espaço reservado para avaliação)

Assinatura: _____________________________ Data: ______________

### Considerações Professor/a:
(Espaço reservado para avaliação)

Assinatura: _____________________________ Data: ______________

### Considerações Professor/a:
(Espaço reservado para avaliação)

Assinatura: _____________________________ Data: ______________

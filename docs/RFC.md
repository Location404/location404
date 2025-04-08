# RFC - CacheHunt: Aplicativo de Geocaching com Gamificação em .NET Aspire e Angular

* **Título do Projeto**: CacheHunt - Plataforma de Geocaching com Elementos de Gamificação
* **Nome do Estudante**: Ryan Gabriel Mazzei Bromati
* **Curso**: Engenharia de Software
* **Data de Entrega**: [Data]

## Resumo

Este documento apresenta a proposta de desenvolvimento do CacheHunt, uma plataforma de geocaching com elementos de gamificação desenvolvida em .NET Aspire e Angular. O projeto visa criar uma solução completa para entusiastas de geocaching, implementando as principais regras e conceitos do jogo, além de incorporar um sistema de conquistas, níveis e recompensas para aumentar o engajamento dos usuários. O documento detalha a arquitetura, requisitos, stack tecnológica e considerações de design para este trabalho de conclusão de curso em Engenharia de Software.

## 1. Introdução

### **Contexto**

Geocaching é uma atividade recreativa outdoor que combina elementos de caça ao tesouro e exploração, onde participantes usam dispositivos com GPS para esconder e encontrar recipientes chamados "geocaches" ou "caches" em locais ao redor do mundo. O CacheHunt surge como uma solução moderna para esta prática, trazendo elementos de gamificação para enriquecer a experiência dos usuários.

### **Justificativa**

O desenvolvimento do CacheHunt é relevante para o campo da Engenharia de Software por diversos motivos:

1. Integra tecnologias modernas (.NET Aspire e Angular) para resolver problemas reais de geolocalização e interação social
2. Implementa conceitos avançados de desenvolvimento de software como arquitetura de microsserviços e DDD
3. Aplica princípios de gamificação para aumentar engajamento do usuário
4. Explora desafios técnicos como persistência de dados geoespaciais, autenticação segura e integração com APIs de mapas

### **Objetivos**

#### Objetivo Principal:
Desenvolver uma plataforma completa de geocaching com elementos de gamificação que permita aos usuários criar, localizar e registrar caches, além de um sistema de conquistas.

#### Objetivos Específicos:
- Implementar as regras oficiais e principais conceitos do geocaching
- Criar um sistema de gamificação com conquistas, níveis e recompensas
- Desenvolver uma plataforma responsiva e acessível em diferentes dispositivos
- Implementar funcionalidades sociais como rankings, eventos e compartilhamento

## 2. Descrição do Projeto

### **Tema do Projeto**

O CacheHunt é uma plataforma de geocaching que permitirá aos usuários:
- Criar e registrar novos geocaches com informações detalhadas (coordenadas, dicas, dificuldade, tipo)
- Buscar caches próximos com base na localização do usuário
- Registrar visitas e encontros de caches ("logs")
- Participar de um sistema de conquistas e progressão de nível
- Interagir com outros usuários através de funcionalidades sociais
- Visualizar estatísticas pessoais e rankings gerais

O sistema será desenvolvido com .NET Aspire no backend e Angular no frontend, proporcionando uma experiência moderna, responsiva e de alta performance.

### **Problemas a Resolver**

1. Falta de elementos de gamificação para manter usuários engajados a longo prazo
2. Necessidade de uma plataforma que implemente corretamente todas as regras e conceitos do geocaching
3. Carência de recursos sociais que promovam a formação de comunidades
5. Insuficiência de recursos para criadores de cache monitorarem e gerenciarem seus caches

### **Limitações**

Este projeto NÃO abordará:
- Desenvolvimento de aplicativos nativos para iOS ou Android (focará em web responsivo)
- Integração direta com plataformas de geocaching existentes para importação/exportação de dados
- Implementação de recursos de realidade aumentada
- Desenvolvimento de hardware específico para geocaching
- Implementação de um sistema de pagamento ou monetização

## 3. Especificação Técnica

### 3.1. Requisitos de Software

#### **Requisitos Funcionais (RF)**

1. **RF01**: O sistema deve permitir o cadastro de usuários com perfil, preferências e estatísticas
2. **RF02**: O sistema deve permitir a autenticação segura de usuários
3. **RF03**: O sistema deve permitir a criação e edição de caches por usuários autorizados
4. **RF04**: O sistema deve validar as coordenadas geográficas dos caches cadastrados
5. **RF05**: O sistema deve exibir caches próximos à localização atual do usuário
6. **RF06**: O sistema deve permitir filtrar caches por tipo, dificuldade, tamanho e distância
7. **RF07**: O sistema deve permitir ao usuário registrar o encontro de um cache (log)
8. **RF08**: O sistema deve permitir o upload de fotos nos logs de visita
9. **RF09**: O sistema deve calcular e atribuir conquistas automaticamente
10. **RF10**: O sistema deve disponibilizar um painel de estatísticas para o usuário
11. **RF11**: O sistema deve implementar um sistema de ranking e comparação entre usuários
12. **RF12**: O sistema deve permitir a criação e participação em eventos comunitários
13. **RF13**: O sistema deve fornecer mecanismos de denúncia de problemas com caches
14. **RF14**: O sistema deve permitir a troca de mensagens entre usuários

#### **Requisitos Não-Funcionais (RNF)**

1. **RNF01**: O sistema deve ser responsivo, adaptando-se a diferentes tamanhos de tela
2. **RNF02**: O sistema deve ter tempo de resposta menor que 3 segundos para operações comuns
3. **RNF03**: O sistema deve suportar pelo menos 1000 usuários simultâneos
4. **RNF04**: O sistema deve garantir a privacidade dos dados dos usuários conforme LGPD
5. **RNF05**: O sistema deve implementar medidas de segurança contra ataques comuns (XSS, CSRF, SQL Injection)
6. **RNF06**: O sistema deve funcionar nos principais navegadores modernos
7. **RNF07**: O sistema deve implementar cache eficiente para reduzir consumo de dados
8. **RNF08**: O sistema deve ser escalável horizontalmente para suportar crescimento de usuários

#### **Representação dos Requisitos**

**Diagrama de Casos de Uso (UML)**

Será desenvolvido um diagrama de casos de uso completo representando as interações entre os diferentes tipos de usuários e as funcionalidades do sistema, incluindo:

- Atores: Usuário não autenticado, Usuário autenticado, Criador de cache, Administrador
- Principais casos de uso: Cadastrar-se, Buscar caches, Registrar encontro, Criar cache, etc.

### 3.2. Arquitetura do Sistema

#### **Visão Geral da Arquitetura**

O CacheHunt será desenvolvido utilizando uma arquitetura de microsserviços orquestrada pelo .NET Aspire, com frontend em Angular. A escolha dessa arquitetura permite maior escalabilidade, manutenibilidade e separação de responsabilidades.

#### **Componentes Principais**

1. **Frontend (Angular)**
   - Interface de usuário responsiva e acessível
   - Comunicação com backend via REST API
   - Gerenciamento de estado com NGRX
   - Componentes reutilizáveis com Material Design e TailwindCSS

2. **Backend (.NET Aspire)**
   - **API Gateway**: Roteamento e orquestração de requisições
   - **Serviço de Autenticação**: Gestão de identidade e autorizações
   - **Serviço de Geocaches**: CRUD e busca de caches, incluindo operações geoespaciais
   - **Serviço de Usuários**: Gestão de perfis e preferências
   - **Serviço de Gamificação**: Sistema de conquistas, níveis e desafios
   - **Serviço de Comunicação**: Mensagens, notificações e eventos

3. **Persistência de Dados**
   - **SQL Server**: Armazenamento principal de dados estruturados
   - **Redis**: Cache distribuído para melhorar performance
   - **Blob Storage**: Armazenamento de mídia (fotos de logs)

4. **Infraestrutura**
   - **Service Bus**: Comunicação assíncrona entre serviços
   - **Logging Centralizado**: Monitoramento e rastreabilidade
   - **CDN**: Distribuição eficiente de conteúdo estático

#### **Padrões de Arquitetura**

- **Microsserviços**: Separação de responsabilidades e escalabilidade independente
- **Clean Architecture**: Separação clara entre camadas de aplicação
- **CQRS**: Separação entre operações de leitura e escrita
- **Event-Driven Architecture**: Comunicação via eventos entre serviços
- **Repository Pattern**: Abstração do acesso a dados
- **Domain-Driven Design**: Modelagem do domínio de geocaching

#### **Diagrama de Arquitetura**

Será desenvolvido um diagrama de arquitetura detalhado mostrando os componentes do sistema e suas interações, utilizando a notação C4 (Context, Container, Component, Code).

### 3.3. Stack Tecnológica

#### **Backend**

- **Linguagem**: C# 12
- **Framework**: .NET 8 com .NET Aspire
- **API**: ASP.NET Core Web API
- **ORM**: Entity Framework Core
- **Comunicação**: gRPC para comunicação entre serviços
- **Mensageria**: Azure Service Bus / RabbitMQ
- **Cache**: Redis
- **Geoespacial**: NetTopologySuite
- **Identidade**: IdentityServer / .NET Identity

#### **Frontend**

- **Framework**: Angular 17+
- **Linguagem**: TypeScript 5+
- **UI**: Angular Material + TailwindCSS
- **Estado**: NgRx
- **Mapas**: Leaflet / MapLibre GL
- **Gráficos**: ngx-charts / Chart.js
- **Responsive Design**: Flexbox / Grid / Media Queries

#### **DevOps & Infraestrutura**

- **CI/CD**: GitHub Actions / Azure DevOps
- **Containerização**: Docker
- **Orquestração**: Kubernetes
- **Monitoramento**: Prometheus / Grafana
- **Logging**: Serilog / Elastic Stack
- **Documentação API**: Swagger / OpenAPI

#### **Ferramentas de Desenvolvimento**

- **IDE**: JetBrains Rider / Visual Studio 2022
- **Editor**: Visual Studio Code
- **Versionamento**: Git / GitHub
- **Testes**: xUnit, Jest, Cypress
- **Diagramação**: Mermaid / PlantUML
- **Análise de Código**: SonarCloud / GitHub CodeQL

### 3.4. Considerações de Segurança

O CacheHunt implementará medidas de segurança abrangentes:

1. **Autenticação e Autorização**
   - OAuth 2.0 / OpenID Connect
   - JWT com rotação segura
   - Autorização baseada em roles e policies
   - MFA para operações sensíveis

2. **Proteção de Dados**
   - Criptografia de dados sensíveis
   - HTTPS/TLS em todas as comunicações
   - Anonimização de dados quando apropriado
   - Conformidade com LGPD

3. **Segurança da Aplicação**
   - Proteção contra OWASP Top 10
   - Rate limiting e proteção contra abuso
   - Validação e sanitização de entrada/saída
   - Security headers modernos

4. **Privacidade**
   - Controle granular de visibilidade de dados
   - Opções de privacidade para usuários
   - Localização precisa apenas para usuários autenticados
   - Mecanismos para exercício de direitos do titular

## 4. Plano de Implementação

O desenvolvimento do CacheHunt seguirá uma abordagem incremental, dividido em três fases principais ao longo de 6 meses:

### Fase 1: Fundação e Infraestrutura (2 meses)

- Refinamento dos requisitos e casos de uso
- Definição detalhada da arquitetura
- Configuração da infraestrutura em VPS
- Implementação do pipeline CI/CD
- Desenvolvimento do serviço de autenticação
- Criação da estrutura base do projeto .NET Aspire
- Desenvolvimento da estrutura base do frontend Angular

### Fase 2: Desenvolvimento do Backend (2 meses)

- Implementação do serviço de Geocaches
- Desenvolvimento do serviço de Usuários
- Implementação do serviço de Gamificação
- Desenvolvimento da API Gateway
- Integração entre microsserviços
- Implementação da camada de persistência
- Testes unitários e de integração

### Fase 3: Frontend e Integração (2 meses)

- Desenvolvimento da interface de usuário
- Implementação do sistema de mapas
- Desenvolvimento de componentes de gamificação
- Integração entre frontend e backend
- Testes de sistema e aceitação
- Otimização de performance
- Preparação para entrega

## 5. Métricas de Sucesso

O sucesso do projeto será avaliado pelas seguintes métricas:

1. **Funcionais**
   - 100% dos requisitos funcionais implementados
   - Navegação fluida entre as funcionalidades
   - Sistema de gamificação completo e engajante

2. **Técnicas**
   - Tempo de resposta abaixo de 3 segundos para operações comuns
   - Cobertura de testes acima de 80%
   - Zero vulnerabilidades críticas de segurança
   - Escalabilidade comprovada para suportar 1000+ usuários simultâneos

3. **Experiência do Usuário**
   - Interface intuitiva e responsiva
   - Feedback positivo dos usuários em testes de usabilidade
   - Fluxos de navegação otimizados

## 6. Referências

- Documentação oficial do .NET Aspire: [https://learn.microsoft.com/en-us/dotnet/aspire/](https://learn.microsoft.com/en-us/dotnet/aspire/)
- Documentação Angular: [https://angular.io/docs](https://angular.io/docs)
- Geocaching - Guia Oficial: [https://www.geocaching.com/help/index.php?pg=kb.chapter&id=141](https://www.geocaching.com/help/index.php?pg=kb.chapter&id=141)
- Deterding, S., Dixon, D., Khaled, R., & Nacke, L. (2011). From game design elements to gamefulness: defining "gamification". Proceedings of the 15th International Academic MindTrek Conference.
- Evans, Eric. (2003). Domain-Driven Design: Tackling Complexity in the Heart of Software. Addison-Wesley.
- Newman, Sam. (2021). Building Microservices: Designing Fine-Grained Systems. O'Reilly Media.
- OWASP Top Ten: [https://owasp.org/www-project-top-ten/](https://owasp.org/www-project-top-ten/)
- Lei Geral de Proteção de Dados (LGPD): [https://www.gov.br/cidadania/pt-br/acesso-a-informacao/lgpd](https://www.gov.br/cidadania/pt-br/acesso-a-informacao/lgpd)

## 7. Apêndices

[A serem desenvolvidos na próxima etapa]

## 8. Avaliações de Professores

### Orientador(a):

[Espaço reservado para considerações e assinatura]

### Professor(a) de Arquitetura de Software:

[Espaço reservado para considerações e assinatura]

### Professor(a) de Desenvolvimento Web:

[Espaço reservado para considerações e assinatura]

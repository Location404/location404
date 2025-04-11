# RFC - Location404: Aplicativo de Adivinhação Geográfica com Gamificação em .NET Aspire e Angular

* **Título do Projeto**: Location404 - Plataforma de Adivinhação Geográfica com Elementos de Gamificação
* **Nome do Estudante**: Ryan Gabriel Mazzei Bromati
* **Curso**: Engenharia de Software
* **Data de Entrega**: [Data]

## Resumo

Este documento apresenta a proposta de desenvolvimento do Location404, uma plataforma de adivinhação geográfica inspirada no GeoGuessr com elementos de gamificação desenvolvida em .NET Aspire e Angular. O projeto implementa uma solução focada para entusiastas de geografia, desafiando os usuários a identificar localizações com base em imagens panorâmicas. Este documento detalha a arquitetura, requisitos, stack tecnológica e considerações de design para este trabalho de conclusão de curso, adotando um escopo reduzido para garantir a viabilidade da implementação.

## 1. Introdução

### **Contexto**

Adivinhação geográfica é uma atividade recreativa que desafia os participantes a identificar localizações ao redor do mundo com base em imagens panorâmicas. O Location404 surge como uma solução que traz elementos de gamificação para aumentar o conhecimento geográfico dos usuários de forma divertida e competitiva.


TODO: Ajustar justificativas
### **Justificativa**

O desenvolvimento do Location404 é relevante por:

1. Integrar tecnologias modernas (.NET Aspire e Angular) para resolver problemas reais de geolocalização
2. Implementar conceitos essenciais de desenvolvimento de software
3. Aplicar princípios de gamificação para aumentar engajamento do usuário
4. Explorar desafios técnicos como integração com APIs de mapas e avaliação de precisão geográfica

### **Objetivos**

#### Objetivo Principal:
Desenvolver uma plataforma funcional de adivinhação geográfica com elementos básicos de gamificação que permita aos usuários identificar localizações ao redor do mundo e competir com outros jogadores.

#### Objetivos Secundários:
- Implementar um sistema de pontuação baseado na precisão das adivinhações
- Criar um sistema de gamificação com conquistas essenciais e níveis
- Desenvolver uma plataforma responsiva para dispositivos desktop e móveis
- Implementar funcionalidades básicas de competição como rankings e desafios entre amigos
- Permitir a criação de mapas personalizados simples

## 2. Descrição do Projeto

### **Tema do Projeto**

O Location404 é uma plataforma de adivinhação geográfica que permitirá aos usuários:
- Jogar rodadas de adivinhação geográfica com imagens panorâmicas
- Marcar no mapa onde acreditam estar a localização mostrada
- Receber pontuação baseada na precisão da adivinhação
- Participar de um sistema básico de conquistas e progressão
- Competir em rankings globais e entre amigos
- Visualizar estatísticas pessoais essenciais

### **Problemas a Resolver**

1. Necessidade de uma plataforma acessível para aprender geografia de forma divertida
2. Ausência de elementos de gamificação básicos para manter usuários engajados
3. Carência de recursos sociais que promovam a competição saudável
4. Falta de personalização para criar desafios específicos

### **Limitações**

Este projeto NÃO abordará:
- Desenvolvimento de aplicativos nativos para iOS ou Android
- Criação de imagens panorâmicas próprias
- Implementação de recursos avançados de socialização (chat, grupos, etc.)
- Sistema complexo de eventos e desafios temáticos
- Recursos educacionais detalhados
- Sistemas complexos de conquistas e recompensas

## 3. Especificação Técnica

### 3.1. Requisitos de Software

#### **Lista de Requisitos**

##### Requisitos Funcionais (RF) - Essenciais:

1. **RF01**: O sistema deve permitir o cadastro e autenticação de usuários
2. **RF02**: O sistema deve exibir imagens panorâmicas de localizações geográficas
3. **RF03**: O sistema deve permitir ao usuário marcar no mapa onde acredita estar a localização
4. **RF04**: O sistema deve calcular a distância entre o ponto marcado e a localização real
5. **RF05**: O sistema deve atribuir pontuação baseada na precisão da adivinhação
6. **RF06**: O sistema deve oferecer rodadas de 5 localizações aleatórias
7. **RF07**: O sistema deve permitir a criação de mapas personalizados básicos
8. **RF08**: O sistema deve calcular e atribuir conquistas básicas
9. **RF09**: O sistema deve disponibilizar estatísticas essenciais para o usuário
10. **RF10**: O sistema deve implementar um ranking global e entre amigos

##### Requisitos Não-Funcionais (RNF) - Essenciais:

1. **RNF01**: O sistema deve ser responsivo para desktop e dispositivos móveis
2. **RNF02**: O sistema deve ter tempo de resposta aceitável (< 5 segundos)
3. **RNF03**: O sistema deve garantir a privacidade básica dos dados dos usuários
4. **RNF04**: O sistema deve estar disponível em português e inglês
5. **RNF05**: O sistema deve implementar medidas básicas de segurança
6. **RNF06**: O sistema deve funcionar nos principais navegadores modernos

### 3.2. Considerações de Design

#### **Visão Simplificada da Arquitetura**

O Location404 será desenvolvido utilizando uma arquitetura simplificada com .NET Aspire no backend e Angular no frontend:

1. **Frontend (Angular)**
   - Interface de usuário responsiva
   - Integração com API de mapas (Leaflet ou Google Maps API)
   - Visualizador panorâmico
   - Comunicação com backend via REST API

2. **Backend (.NET Aspire - 3 serviços principais)**
   - **Serviço de Usuários e Autenticação**
     - Cadastro e autenticação
     - Perfis básicos de usuário
   - **Serviço de Jogo e Mapas**
     - Gerenciamento de rodadas
     - Cálculo de pontuação
     - Mapas personalizados básicos
   - **Serviço de Gamificação e Rankings**
     - Conquistas básicas
     - Níveis de progressão
     - Rankings e estatísticas
  <!-- - TODO: **Serviço de notificação** -->

3. **Persistência de Dados**
   - Banco de dados relacional (PostgreSQL)
   - Cache para melhorar performance (Redis)

4. **Integrações Externas Essenciais**
   - API de imagens panorâmicas (Google Street View API ou similar)
   - API de mapas (Leaflet ou Google Maps)

#### **Padrões de Arquitetura**

- **Arquitetura em camadas**: Para separação clara de responsabilidades
- **Repository Pattern**: Abstração do acesso a dados
- **MVC/MVVM**: Para organização do frontend e backend
- **REST API**: Para comunicação entre frontend e backend

### 3.3. Stack Tecnológica Simplificada

#### **Frontend**
- **Angular**: Framework para desenvolvimento de aplicações web
- **Leaflet/Google Maps API**: Biblioteca de mapas interativos
- **Bootstrap ou Angular Material**: Componentes de UI
- **RxJS**: Programação reativa

#### **Backend**
- **.NET Aspire**: Framework para desenvolvimento distribuído
- **ASP.NET Core**: Framework web para APIs
- **Entity Framework Core**: ORM para acesso a dados
- **SQL Server/PostgreSQL**: Banco de dados relacional
- **Identity Server/ASP.NET Identity**: Autenticação e autorização

#### **Ferramentas de Desenvolvimento**
- **Visual Studio/Rider**: IDEs para desenvolvimento
- **GitHub/Azure DevOps**: Controle de versão e CI/CD
- **Swagger**: Documentação de API
- **Docker**: Containerização básica

### 3.4. Considerações de Segurança

Implementação de medidas básicas de segurança:
- Autenticação segura com tokens JWT
- Proteção contra ataques comuns (XSS, CSRF, SQL Injection)
- TLS/SSL para comunicações
- Validação de entradas
- Proteção contra manipulação de pontuações

## 4. Cronograma de Desenvolvimento

O desenvolvimento será realizado em 4 fases:

### Fase 1
- Configuração do projeto e ambiente de desenvolvimento
- Implementação do frontend básico e visualização de mapas
- Desenvolvimento da funcionalidade core de jogo (exibir localização, marcar no mapa, calcular pontuação)

### Fase 2
- Implementação do sistema de autenticação e perfis de usuário
- Desenvolvimento das rodadas de jogo completas
- Armazenamento e exibição de resultados

### Fase 3
- Implementação de rankings e estatísticas básicas
- Desenvolvimento de conquistas essenciais
- Implementação de funcionalidade de amigos e comparação

### Fase 4
- Implementação de mapas personalizados básicos
- Testes e otimizações
- Refinamentos finais e documentação

## 5. Referências

- Documentação oficial do .NET Aspire: https://learn.microsoft.com/pt-br/dotnet/aspire/
- Documentação oficial do Angular: https://angular.io/docs
- Google Maps Platform Documentation: https://developers.google.com/maps/documentation
- Leaflet Documentation: https://leafletjs.com/reference.html

## 6. Apêndices (Opcionais)

[Espaço reservado para mockups iniciais da interface e diagramas simplificados]

## 7. Avaliações de Professores

[Espaço reservado para considerações e assinaturas]
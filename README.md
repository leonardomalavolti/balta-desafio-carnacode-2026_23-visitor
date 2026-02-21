![CO-11](https://github.com/user-attachments/assets/f6639a45-7212-49ad-b0b9-b61c6ac94dda)

## 🥁 CarnaCode 2026 - Desafio 23 - Visitor

Oi, eu sou o Leonardo Malavolti Monteiro e este é o espaço onde compartilho minha jornada de aprendizado durante o desafio **CarnaCode 2026**, realizado pelo [balta.io](https://balta.io). 👻

### Sobre este desafio
No desafio **Visitor** eu tive que resolver um problema real implementando o **Design Pattern Visitor**.
Neste processo eu aprendi:
* ✅ Boas Práticas de Software
* ✅ Código Limpo
* ✅ SOLID
* ✅ Design Patterns (Padrões de Projeto)

## Problema
Um sistema de documentos tem diferentes tipos de elementos (Parágrafo, Imagem, Tabela) e precisa realizar múltiplas operações (exportar HTML, PDF, contar palavras, validar). 
O código atual adiciona cada operação como método em cada classe, violando Open/Closed Principle.

## Solução com Visitor
- Elementos (`Paragraph`, `Image`, `Table`) implementam `Accept(Visitor)`
- Cada operação é um Visitor separado (`HtmlExportVisitor`, `PdfExportVisitor`, `WordCountVisitor`, `ValidationVisitor`)
- Adicionar novas operações = criar novo Visitor, sem alterar elementos
- Evita type checking e casting
- Código coeso, modular e extensível

## Benefícios
- Open/Closed Principle atendido
- Separação de responsabilidades
- Facilita manutenção e testes
- Possibilidade de múltiplas operações sem crescimento horizontal das classes de elementos

### eBook - Fundamentos dos Design Patterns
Minha principal fonte de conhecimento durante o desafio foi o eBook gratuito [Fundamentos dos Design Patterns](https://lp.balta.io/ebook-fundamentos-design-patterns).

### Veja meu progresso no desafio
[Incluir link para o repositório central]

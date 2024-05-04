# Explorando Meu Primeiro Projeto em .NET

Este projeto marca meu primeiro mergulho no mundo do .NET, uma jornada excitante para consolidar meus conhecimentos básicos e
 estabelecer as bases necessárias para futuros empreendimentos mais desafiadores.

Inicialmente, minha familiaridade com o uso de classes e namespaces era limitada, porém, ao longo do desenvolvimento, descobri sua importância fundamental. 
As classes oferecem uma estrutura organizada e modular para o código, facilitando a manutenção e o entendimento. Já os namespaces, ao fornecerem caminhos virtuais para os arquivos, 
desempenham um papel crucial na organização e na acessibilidade do código. Adotar uma nomenclatura consistente com a estrutura de diretórios não só mantém a ordem, mas também simplifica
 a colaboração com outros desenvolvedores no futuro.

Ao adentrar o mundo das classes e namespaces, deparei-me com desafios intrigantes. A determinação de namespaces adequados para as classes exigiu uma compreensão profunda da estrutura do 
projeto e uma visão clara sobre como elas seriam utilizadas em conjunto. Garantir a coesão entre classes e namespaces foi essencial para manter o código limpo e organizado.

Ao construir a estrutura do projeto, adote a abordagem de usar o comando `namespace` para especificar a localização das classes dentro do projeto. Isso proporcionou uma organização lógica e 
intuitiva, facilitando a navegação no código.
Exemplo do caminho no projeto `MeuProjeto/models`

````
namespace MeuProjeto.models;
````

# Pegando o arquivo
Para pegar o arquivo é Simples em `Program.cs` basta utilizar `using` para  garantir o uso correto de objetos. em seguida colocamos o nosso namespace.

```
using  MeuProjeto.models;
```
Pronto simples de usar uma classe com um namespace.

Além disso, ao compartilhar minha experiência com o projeto, busco não apenas destacar suas funcionalidades, mas também compartilhar os desafios enfrentados durante o desenvolvimento. 
A transparência sobre os obstáculos superados e as soluções encontradas contribui para o crescimento coletivo da comunidade de desenvolvedores.

# Boas praticas

A boa pratica que aprendi desenvolvendo esse projeto dentro do curso [DIO]("https://www.dio.me") foi usar nomenclaturas corretamente, em variaveis, classes, metodos, atributos, funções e muito mais, as que foram abordadas para o projeto foram a `camelCase` e `PascalCase`

### Camel case
deve começar com a primeira letra minuscula e cada palavra subsequente maiuscula


### Pascal case
Tambem conhecida como "upper camel case" ou "capital case", pascal combina palavras colocando todas as primeiras letras em maiusculo

# Tabela
confira essa tabela que mostra as principais convenções de nomenclatura que abordamos nessa leitura.

<table>
<thead>
<tr>
<td>Convenção</td>
<td>Exemplo</td>
</tr>
<tr>
<td>Camel case</td>
<td>primeiroNomePessoa</td>
</tr>
<tr>
<td>Pascal case</td>
<td>PrimeiroNomePessoa</td>
</tr>
<tr>
<td>Snake case</td>
<td>primeiro_nome_pessoa</td>
</tr>
<tr>
<td>Screaming snake case</td>
<td>PRIMEIRO_NOME_PESSOA</td>
</tr>
<tr>
<td>Kebab case</td>
<td>primeiro-nome-pessoa</td>
</tr>
<tr>
<td>Screaming kebab case</td>
<td>PRIMEIRO-NOME-PESSOA</td>
</tr>
</thead>
</table>

##

**Versão .NET usada:** net8.0

Você gostaria de explorar algum aspecto específico do projeto ou discutir mais sobre os desafios enfrentados durante o desenvolvimento?
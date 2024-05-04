# Desvendando os Segredos do .NET: Meu Primeiro Projeto

Neste projeto simples dentro do curso  [DIO]("https://www.dio.me/")  estou  apenas criando um  objeto chamado `Pessoa` atraves de uma namespace e atribuindo valores a ela. 

Este projeto marca meu primeiro mergulho no mundo do .NET, uma jornada excitante para consolidar meus conhecimentos básicos e
 estabelecer as bases necessárias para futuros empreendimentos mais desafiadores.

Inicialmente, minha familiaridade com o uso de classes e namespaces era limitada, porém, ao longo do desenvolvimento, descobri sua importância fundamental. 
As classes oferecem uma estrutura organizada e modular para o código, facilitando a manutenção e o entendimento. Já os namespaces, ao fornecerem caminhos virtuais para os arquivos, 
desempenham um papel crucial na organização e na acessibilidade do código. Adotar uma nomenclatura consistente com a estrutura de diretórios não só mantém a ordem, mas também simplifica
 a colaboração com outros desenvolvedores no futuro.
# Classe

Ao criar uma classe, definimos os atributos do nosso objeto, que serão o seu `Name` e `Age`. Além disso, é necessário fornecer um construtor para a classe, a fim de instanciá-la. Dentro do construtor, podemos passar valores opcionais para sua criação, embora não seja necessário neste projeto. Os métodos, listados abaixo, representam as ações que nossa `Person` pode executar, como se apresentar.

 ```
    public class Person
    {
        // Atributos
        public string Name { get; set; }
        public int Age { get; set; }


        // Constructor Item obrigario na criação do objeto
        public Person()
        {
        }

        // Metodos

        public void Presentation()
        {
            PrintDisplay($"Hi, my name is {Name},  i´m {Age} years old");
        }

        public void PrintDisplay(string text)
        {
            Console.WriteLine(text);
        }
    }
 ```

# Importando NameSpace
Para utilizar as classes definidas em seu projeto, é necessário importar o namespace correspondente. No exemplo fornecido, o namespace `MeuProjeto.models` é importado utilizando a instrução `using`. Isso permite que você acesse as classes dentro desse namespace sem precisar escrever o nome completo do namespace toda vez.

```
// Dentro do arquivo Person.cs
namespace MeuProjeto.models
{
  // Restante do codigo 
}

// Dentro do arquivo Program.cs
using  MeuProjeto.models;

```

# Instanciando Objetos

Dentro do arquivo `Program.cs` criamos um novo objeto de uma classe do projeto utilizamos palavra-chave `new` seguida do nome da classe e parênteses. No Exemplo a instrução `Person person  = new Person ("Joao"); ` para criar um novo objeto `Person`.
```
// Novo Objeto Person
Person person = new Person("Joao");
```

# Atribuindo Valores
As Propriedades de um objeto podem ser acessadas e modificadas utilizando o operador de ponto `.`. No exemplo, a instrução` person.Name ="João;"` atribui o valor `"João"` à propriedade `Name` do objetso `person`.

O mesmo podemos fazer com `Age`

```
// Determinar Idade
person.Name = "Joao";
// Determinar Idade
person.Age = 18;
```
# Executando Metodos
Os metodos podem ser acessados do mesmo jeito que um atributo utilizando o operador ponto `.`. No Exemplo, a instrução `person.Presentation();` Estamos pedindo para que o programa acesse e execute o metodo `Presentation`.

```
// Executar metodo de apresentação
person.Presentation();
```

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

# Autor

Este projeto foi desenvolvido por [JOAO VITOR PINHEIRO](https://github.com/joaovpinheirop).

## Sobre o Autor


Desenvolvedor de Software Apaixonado por Desafios e Aprendizado Contínuo
Com mais de 6 anos de experiência na área de desenvolvimento de software, sou um  apaixonado por criar e explorar novas tecnologias. Possuo um entusiasmo  por aprender e me atualizar, sempre buscando aprimorar minhas habilidades para entregar soluções inovadoras e eficientes.

Minhas áreas de expertise:

Linguagens de Programação: HTML, CSS, JavaScript, Node.js
Desenvolvimento Web: Criação de websites responsivos e interativos, com foco em usabilidade e experiência do usuário.
Desenvolvimento de Games: Unity e C#.

## Contato

- Website: [Portfólio](https://joaovpinheiros.com/)
- LinkedIn: [LinkedIn](https://www.linkedin.com/in/jo%C3%A3o-vitor-pinheiro-711863188/)

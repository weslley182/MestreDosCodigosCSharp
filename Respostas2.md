<h1>Perguntas e respostas</h1>

<h2>Utilizando POO</h2>
<h2>Responda e demonstre no código os itens abaixo:</h2>
<ol>
  <li><b>O que é POO?</b></li>
  <em>R: Programação Orientada a Objetos.</em>
  <p>
  <li><b>O que é polimorfismo?</b></li>
  <em>R: O princípio pelo qual duas ou mais classes derivadas da mesma superclasse podem invocar métodos que têm a mesma assinatura, 
  mas comportamentos distintos.</em>
  <p>
  <li><b>O que é abstração?</b></li>
  <em>R: Abstração é a habilidade de concentrar nos aspectos essenciais de um contexto qualquer, 
  ignorando características menos importantes ou acidentais. 
  Em modelagem orientada a objetos, uma classe é uma abstração de entidades existentes no domínio do sistema de software.</em>
  <p>
  <li><b>O que é encapsulamento?</b></li>
  <em>R: A técnica que faz com que detalhes internos do funcionamento dos métodos de uma classe permaneçam ocultos para os objetos.</em>
  <p>
  <li><b>Quando usar uma classe abstrata e quando devo usar uma interface?</b></li>
  <em>R: Classes abstratas e interfaces podem ser utilizadas em situações que várias classes possuem métodos em comum, 
  mas que também possuem suas particularidades. Então elas poderiam herdar de uma classes abstrata ou de interfaces. 
  Seria como utilizar uma herança multipla, evitando a Herança Diamante.</em>
  <p>
  <li><b>O que faz as interfaces IDisposable, IComparable, ICloneable e IEnumerable?</b></li>
  <ul>
    <li>IDisposable serve principalmente a liberar recursos não gerenciados utilizados em nosso código, 
    como conexões com banco de dados, arquivos e hardwares externos. Estes devem ser liberados manualmente.</li>
    <li>IComparable é usado para fornecer uma ordem de classificação padrão para seus objetos.</li>
    <li>ICloneable dá suporte à clonagem, que cria uma nova instância de uma classe com o mesmo valor de uma instância existente.</li>
    <li>IEnumerable permite iterarmos por uma coleção.</li>
  </ul>
  <p>
  <li><b>Existe herança múltipla (de classes) em C#?</b></li>
  <em>R: Não, pelo problema chamado herança diamante, uma ambiguidade devido a existecia de mesmo método em classes.</em>
</ol>

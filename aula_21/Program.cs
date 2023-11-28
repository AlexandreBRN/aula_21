using System;

/* Hierarquia Animal:
abstract class Animal
{
    public abstract void FazerSom();
}

class Cachorro : Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("Au Au!");
    }
}

class Gato : Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("Miau!");
    }
}

class Program
{
    static void Main()
    {
        Cachorro cachorro = new Cachorro();
        Gato gato = new Gato();

        Console.WriteLine("Cachorro faz:");
        cachorro.FazerSom();

        Console.WriteLine("Gato faz:");
        gato.FazerSom();
    }
}
*/



/* Calculadora de Formas:
abstract class Forma
{
    public abstract double CalcularÁrea();
}

class Círculo : Forma
{
    public double Raio { get; set; }

    public override double CalcularÁrea()
    {
        return Math.PI * Math.Pow(Raio, 2);
    }
}

class Retângulo : Forma
{
    public double Largura { get; set; }
    public double Altura { get; set; }

    public override double CalcularÁrea()
    {
        return Largura * Altura;
    }
}

class Program
{
    static void Main()
    {
        Círculo círculo = new Círculo { Raio = 5 };
        Retângulo retângulo = new Retângulo { Largura = 4, Altura = 6 };

        Console.WriteLine("Área do Círculo: " + círculo.CalcularÁrea());
        Console.WriteLine("Área do Retângulo: " + retângulo.CalcularÁrea());
    }
}
*/



/*Sistema de Veículos:
abstract class Veículo
{
    public abstract void IniciarMotor();
}

class Carro : Veículo
{
    public override void IniciarMotor()
    {
        Console.WriteLine("Carro: Motor ligado. Vrum Vrum!");
    }
}

class Motocicleta : Veículo
{
    public override void IniciarMotor()
    {
        Console.WriteLine("Motocicleta: Motor ligado. Rrrrrrrrr!");
    }
}

class Program
{
    static void Main()
    {
        Carro carro = new Carro();
        Motocicleta motocicleta = new Motocicleta();

        Console.WriteLine("Iniciar Motor do Carro:");
        carro.IniciarMotor();

        Console.WriteLine("\nIniciar Motor da Motocicleta:");
        motocicleta.IniciarMotor();
    }
}
*/



/*Hierarquia de Empregados:
abstract class Empregado
{
    public abstract void CalcularSalário();
}

class EmpregadoHorista : Empregado
{
    public override void CalcularSalário()
    {
        Console.WriteLine("Calculando salário por hora.");
    }
}

class EmpregadoAssalariado : Empregado
{
    public override void CalcularSalário()
    {
        Console.WriteLine("Calculando salário mensal.");
    }
}

class Program
{
    static void Main()
    {
        EmpregadoHorista empregadoHorista = new EmpregadoHorista();
        EmpregadoAssalariado empregadoAssalariado = new EmpregadoAssalariado();

        Console.WriteLine("Calcular Salário do Empregado Horista:");
        empregadoHorista.CalcularSalário();

        Console.WriteLine("\nCalcular Salário do Empregado Assalariado:");
        empregadoAssalariado.CalcularSalário();
    }
}
*/



/*Sistema de Desenho:

abstract class ObjetoDeDesenho
{
    public abstract void Desenhar();
}

class Linha : ObjetoDeDesenho
{
    public override void Desenhar()
    {
        Console.WriteLine("Desenhando uma linha.");
    }
}

class Círculo : ObjetoDeDesenho
{
    public override void Desenhar()
    {
        Console.WriteLine("Desenhando um círculo.");
    }
}

class Program
{
    static void Main()
    {
        Linha linha = new Linha();
        Círculo círculo = new Círculo();

        Console.WriteLine("Desenhar Linha:");
        linha.Desenhar();

        Console.WriteLine("\nDesenhar Círculo:");
        círculo.Desenhar();
    }
}
*/



/*Exercícios de Interfaces
interface IMovível
{
    void Mover();
}

class Animal : IMovível
{
    public void Mover()
    {
        Console.WriteLine("Animal se movendo.");
    }
}

class Veículo : IMovível
{
    public void Mover()
    {
        Console.WriteLine("Veículo se movendo.");
    }
}

class Program
{
    static void Main()
    {
        Animal animal = new Animal();
        Veículo veículo = new Veículo();

        Console.WriteLine("Mover Animal:");
        animal.Mover();

        Console.WriteLine("\nMover Veículo:");
        veículo.Mover();
    }
}
*/



/*Armazenamento de Dados:
interface IRepositórioDeDados
{
    void Salvar();
    void Carregar();
}

class ArmazenamentoEmArquivo : IRepositórioDeDados
{
    public void Salvar()
    {
        Console.WriteLine("Salvando dados em arquivo.");
    }

    public void Carregar()
    {
        Console.WriteLine("Carregando dados de arquivo.");
    }
}

class ArmazenamentoEmBancoDeDados : IRepositórioDeDados
{
    public void Salvar()
    {
        Console.WriteLine("Salvando dados no banco de dados.");
    }

    public void Carregar()
    {
        Console.WriteLine("Carregando dados do banco de dados.");
    }
}

class Program
{
    static void Main()
    {
        ArmazenamentoEmArquivo armazenamentoArquivo = new ArmazenamentoEmArquivo();
        ArmazenamentoEmBancoDeDados armazenamentoBancoDeDados = new ArmazenamentoEmBancoDeDados();

        Console.WriteLine("Salvar e Carregar dados em Armazenamento em Arquivo:");
        armazenamentoArquivo.Salvar();
        armazenamentoArquivo.Carregar();

        Console.WriteLine("\nSalvar e Carregar dados em Armazenamento em Banco de Dados:");
        armazenamentoBancoDeDados.Salvar();
        armazenamentoBancoDeDados.Carregar();
    }
}
*/



/*Interface Imprimível:
interface IImprimível
{
    void Imprimir();
}

class Documento : IImprimível
{
    public void Imprimir()
    {
        Console.WriteLine("Imprimindo documento.");
    }
}

class Imagem : IImprimível
{
    public void Imprimir()
    {
        Console.WriteLine("Imprimindo imagem.");
    }
}

class Program
{
    static void Main()
    {
        Documento documento = new Documento();
        Imagem imagem = new Imagem();

        Console.WriteLine("Imprimir Documento:");
        documento.Imprimir();

        Console.WriteLine("\nImprimir Imagem:");
        imagem.Imprimir();
    }
}
*/



/*Interface Reproduzível:
interface IReproduzível
{
    void Reproduzir();
    void Pausar();
    void Parar();
}

class TocadorDeMúsica : IReproduzível
{
    public void Reproduzir()
    {
        Console.WriteLine("Reproduzindo música.");
    }

    public void Pausar()
    {
        Console.WriteLine("Pausando música.");
    }

    public void Parar()
    {
        Console.WriteLine("Parando música.");
    }
}

class TocadorDeVídeo : IReproduzível
{
    public void Reproduzir()
    {
        Console.WriteLine("Reproduzindo vídeo.");
    }

    public void Pausar()
    {
        Console.WriteLine("Pausando vídeo.");
    }

    public void Parar()
    {
        Console.WriteLine("Parando vídeo.");
    }
}

class Program
{
    static void Main()
    {
        TocadorDeMúsica tocadorMúsica = new TocadorDeMúsica();
        TocadorDeVídeo tocadorVídeo = new TocadorDeVídeo();

        Console.WriteLine("Tocador de Música:");
        tocadorMúsica.Reproduzir();
        tocadorMúsica.Pausar();
        tocadorMúsica.Parar();

        Console.WriteLine("\nTocador de Vídeo:");
        tocadorVídeo.Reproduzir();
        tocadorVídeo.Pausar();
        tocadorVídeo.Parar();
    }
}
*/



/*Sistema de Sensores:
interface ISensor
{
    void LerValor();
}

class SensorDeTemperatura : ISensor
{
    public void LerValor()
    {
        Console.WriteLine("Lendo valor do sensor de temperatura.");
    }
}

class SensorDePressão : ISensor
{
    public void LerValor()
    {
        Console.WriteLine("Lendo valor do sensor de pressão.");
    }
}

class Program
{
    static void Main()
    {
        SensorDeTemperatura sensorTemperatura = new SensorDeTemperatura();
        SensorDePressão sensorPressão = new SensorDePressão();

        Console.WriteLine("Sensor de Temperatura:");
        sensorTemperatura.LerValor();

        Console.WriteLine("\nSensor de Pressão:");
        sensorPressão.LerValor();
    }
}
*/
/*
 
    1. Scrivere una classe cane e stampare a schermo “bau”. Scrivere una classe gatto e stampare a
    schermo “miao”.

    2. Scrivere la classe EsempioSomma con un metodo per stampare la somma di due numeri a
    piacere. Ripetere lo stesso esercizio con le altre 3 operazioni.

    3. Creare delle classi che rispecchiano degli oggetti del mondo reale: Per ognuna di queste classi
    scrivere almeno un paio di attributi, più il costruttore vuoto e almeno un costruttore parametrico. 
      Nello specifico:
    • Completare le classi create nel precedente esercizio: Animale, Automobile,Appartamento
    • Creare da zero le classi Cane, Albero, Telecomando

    4. Creare una classe con un metodo main ed un altro metodo che, date tre stringhe come
    parametri, stampi a schermo prima il terzo parametro, poi il secondo e poi il primo.
    Dentro al metodo main richiamare l’altro metodo per fornire un esempio.

    5. Creare una classe che contenga un metodo main ed un altro metodo chiamato “chiama”. Al
    metodo chiama dobbiamo passare un parametro di tipo String che rappresenta un numero di
    telefono. Il metodo chiama deve 
*/
namespace csharp_classi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ESERCIZIO 1
            Cane cane = new Cane();

            cane.Abbaia();

            Gatto gatto = new Gatto();

            gatto.Miagola();


            //ESERCIZIO 2
            EsempioSomma prova = new EsempioSomma();
            EsempioSottrazione prova1 = new EsempioSottrazione();
            EsempioProdotto prova2 = new EsempioProdotto();
            EsempioDivisione prova3 = new EsempioDivisione();

            Console.WriteLine("\nLa somma di due numeri int sarà:{0}", prova.Somma(21, 5));

            Console.WriteLine("La sottrazione di due numeri int sarà:{0}", prova1.Sottrazione(21, 5));

            Console.WriteLine("Il prodotto di due numeri int sarà:{0}", prova2.Prodotto(21, 5));

            Console.WriteLine("La divisione di due numeri double sarà:{0}", prova3.Divisione(21,5));


            //ESERCIZIO 3

            Automobile auto = new Automobile();

            auto.Marca = "audi";
            auto.Modello = "A4";
            auto.Anno = 2002;

            Automobile.Descrivi(auto.Marca,auto.Modello,auto.Anno);

            Automobile auto1 = new Automobile("audi","A4", 2002);


            //ESERCIZIO 4

            StampaStringhe stringa = new StampaStringhe();

            stringa.Main();

            //ESERCIZIO 5

            Call numero = new Call();

            numero.Main();
        }

        
    }

    public class Cane
    {
        public void Abbaia()
        {
            Console.WriteLine("bau");
        }
    }

    public class Gatto
    {
        public void Miagola()
        {
            Console.WriteLine("miao");
        }
    }

    public class EsempioSomma 
    { 
        public int Somma ( int num1, int num2)
        {
            return num1 + num2;
        }

    }

    public class EsempioSottrazione
    {
        public int Sottrazione(int num1, int num2)
        {
            return num1 - num2;
        }

    }

    public class EsempioProdotto
    {
        public int Prodotto(int num1, int num2)
        {
            return num1 * num2;
        }

    }

    public class EsempioDivisione
    {
        public double Divisione(double num1, double num2)
        {
            return num1 / num2;
        }
    }


    public class Animale
    {
        // Attributi
        public string Nome;
        public string Specie;
        public int Età;

        // Costruttore vuoto

        public Animale()
        {

        }

        // Costruttore parametrizzato
        public Animale(string nome, string specie, int età)
        {
            this.Nome = nome;
            this.Specie = specie;
            this.Età = età;
        }

        // Metodo per descrivere l'animale
        public void Descrivi()
        {
            Console.WriteLine($"\nQuesto è {Nome}, uno {Specie} di {Età} anni.");
        }
    }

    public class Automobile
    {
        // Attributi
        public string Marca;
        public string Modello;
        public int Anno;

        // Costruttore vuoto
        public Automobile() { 
        }

        // Costruttore parametrizzato
        public Automobile(string marca, string modello, int anno)
        {
            this.Marca = marca;
            this.Modello = modello;
            this.Anno = anno;
        }

        // Metodo statico per descrivere l'auto
        public static void Descrivi(string Marca, string Modello, int Anno)
        {
            Console.WriteLine($"\nQuesta è una {Marca} {Modello} del {Anno}.");
        }
    }

    public class Appartamento
    {
        // Attributi
        public string Indirizzo;
        public int NumeroStanze;
        public double Superficie;

        // Costruttore vuoto
        public Appartamento() 
        {
        
        }

        // Costruttore parametrizzato
        public Appartamento(string indirizzo, int numeroStanze, double superficie)
        {
            this.Indirizzo = indirizzo;
            this.NumeroStanze = numeroStanze;
            this.Superficie = superficie;
        }

        // Metodo per descrivere l'appartamento
        public void Descrivi()
        {
            Console.WriteLine($"\nAppartamento situato in {Indirizzo}, con {NumeroStanze} stanze e {Superficie} m².");
        }
    }

    public class Telecomando
    {
        // Attributi
        public string Marca;
        public int Funzionalità;
        public int Garanzia;

        // Costruttore vuoto
        public Telecomando()
        {

        }

        // Costruttore parametrizzato
        public Telecomando(string marca, int funzionalità, int garanzia)
        {
            this.Marca = marca;
            this.Funzionalità = funzionalità;
            this.Garanzia = garanzia;
        }

        // Metodo per descrivere il telecomando
        public void Descrivi()
        {
            Console.WriteLine($"\nQuesto telecomando è un {this.Marca}, con un numero di funzionalità pari a {this.Funzionalità} e una garanzia di {this.Garanzia}.");
        }
    }

    public class Albero
    {
        // Attributi
        public string Famiglia;
        public string Ecosistema;
        public int Altezza;

        // Costruttore vuoto
        public Albero()
        {

        }

        // Costruttore parametrizzato
        public Albero(string famiglia, string ecosistema, int altezza)
        {
            this.Famiglia = famiglia;
            this.Ecosistema = ecosistema;
            this.Altezza = altezza;
        }

        // Metodo per descrivere l'albero
        public void Descrivi()
        {
            Console.WriteLine($"\nQuesto albero appartiene è una {this.Famiglia}, lo si trova in un ecosistema di tipo {this.Ecosistema} raggiugngendo un'altezza massima di {this.Altezza} metri.");
        }
    }

    public class StampaStringhe
    {
        public void Main()
        {
            // Chiamata del metodo con tre stringhe come parametri
            StampaInOrdineInverso("Prima", "Seconda", "Terza");
        }

        // Metodo che stampa i parametri in ordine inverso
        static void StampaInOrdineInverso(string primo, string secondo, string terzo)
        {
            Console.WriteLine("\nStampa delle stringhe");
            Console.WriteLine(terzo);
            Console.WriteLine(secondo);
            Console.WriteLine(primo);
        }
    }

    public class Call
    {
        public void Main()
        {
            // Chiamata del metodo Chiamata
            Chiamata("123-987-5557");
        }

        // Metodo che prende come parametro una stringa e stampa a video la scritta con il numero
        static void Chiamata(string numeroTelefono)
        {
            Console.WriteLine($"\nSto chiamando il numero {numeroTelefono}");
        }
    }
}

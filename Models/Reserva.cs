namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public decimal DiasReservados { get; set; }

        public Reserva() { }

        /*public Reserva(int diasReservados = 0)
        {
            DiasReservados = diasReservados;
        }*/

        public void CadastrarHospedes()
        {
            Suite suite = new Suite();
            List<string> hospede = new List<string>();

            

            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            if (hospede.Count <= suite.Capacidade)
            {
                //Hospedes = hospedes;
                Console.WriteLine("Nome do hospede: ");
                string nome = Console.ReadLine();
                hospede.Add(nome);
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
                Console.WriteLine("Quantidade de hospedes não confere com a capacidade da suíte");
            }
        }

        public void CadastrarSuite()
        {

            Suite suite = new Suite();

            Console.WriteLine("Reservar Suíte");
            Console.WriteLine("1 - Básica");
            Console.WriteLine("2 - Média");
            Console.WriteLine("3 - Master");
            string nSuite = Console.ReadLine();

            if (nSuite == "1")
            { 
            suite = new Suite(tipoSuite: "Padrão", capacidade: 3, valorDiaria: 10);
            Console.WriteLine($"Tipo da suite: {suite.TipoSuite}\nCapacidade: {suite.Capacidade}\nValor da diária: {suite.ValorDiaria}");

            }
            if (nSuite == "2")
            { 
            suite = new Suite(tipoSuite: "Média", capacidade: 6, valorDiaria: 20);
            Console.WriteLine($"Tipo da suite: {suite.TipoSuite}\nCapacidade: {suite.Capacidade}\nValor da diária: {suite.ValorDiaria}");

            }

            if (nSuite == "3")
            { 
            suite = new Suite(tipoSuite: "Master", capacidade: 10, valorDiaria: 35);
            Console.WriteLine($"Tipo da suite: {suite.TipoSuite}\nCapacidade: {suite.Capacidade}\nValor da diária: {suite.ValorDiaria}");

            }
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            return 0;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal diasReservados;
            Console.WriteLine("Quantos dias de reserva: ");
            diasReservados = Convert.ToDecimal(Console.ReadLine());
            

            decimal valor = 0;

            valor = diasReservados * Suite.ValorDiaria;

            Console.WriteLine($"O valor da diária é: {valor}");

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (true)
            {
                valor = 0;
            }

            return valor;
        }
    }
}
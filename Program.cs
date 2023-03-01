namespace SingeltonVoteMachine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 5);

            Parallel.ForEach(numbers, i =>
            {
                var vm = VoteMachine.Instance;
                vm.RegisterVotee();
            });

            Console.WriteLine(VoteMachine.Instance.TotalVotes);
        }
    }
}
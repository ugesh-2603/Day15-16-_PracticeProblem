using System.Reflection;

namespace Day15___16_PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindNearest quiz = new FindNearest();
            int N = 17;

            int closestEven = quiz.FindClosestEvenNumber(N);
            Console.WriteLine($"Closest even number to {N} is {closestEven}");

            Type quizType = typeof(FindNearest);
            Console.WriteLine("Class Members:");
            foreach (MemberInfo member in quizType.GetMembers())
            {
                Console.WriteLine(member.Name);
            }

            object emptyObj = Activator.CreateInstance(quizType);
            Console.WriteLine("Empty Object Created");

            object[] constructorArgs = new object[] { 42 };
            object parameterizedObj = Activator.CreateInstance(quizType, constructorArgs);
            Console.WriteLine("Parameterized Object Created");

            MethodInfo methodInfo = quizType.GetMethod("FindClosestEvenNumber");
            object[] methodArgs = new object[] { 33 };
            int result = (int)methodInfo.Invoke(parameterizedObj, methodArgs);
            Console.WriteLine($"Invoked method FindClosestEvenNumber(33) and got result: {result}");
        }
    }
}
using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        // Create a list of Question objects
        List<Question> questions = new List<Question>()
        {
            new Question("Which country won the FIFA World Cup in 2018?", new List<string>() { "France", "Brazil", "Germany", "Argentina" }, "France"),
            new Question("Who is the all-time leading goal scorer in FIFA World Cup history?", new List<string>() { "Marta", "Cristiano Ronaldo", "Miroslav Klose", "Lionel Messi" }, "Miroslav Klose"),
            new Question("Which player has won the most Ballon d'Or awards?", new List<string>() { "Cristiano Ronaldo", "Lionel Messi", "Neymar", "Zinedine Zidane" }, "Lionel Messi"),
            new Question("Which country has won the most FIFA World Cup titles?", new List<string>() { "Germany", "Brazil", "Italy", "Argentina" }, "Brazil"),
            new Question("Which club has won the most UEFA Champions League titles?", new List<string>() { "Real Madrid", "Barcelona", "Bayern Munich", "Liverpool" }, "Real Madrid")
        };

        int score = 0;

        Console.WriteLine("Welcome to the Football Quiz!");
        Console.WriteLine("Answer the following questions:");

        // Iterate through each question
        foreach (Question question in questions) {
            Console.WriteLine("\n" + question.Text);

            // Display answer choices
            for (int i = 0; i < question.Choices.Count; i++) {
                Console.WriteLine($"{i + 1}. {question.Choices[i]}");
            }

            Console.Write("Enter your answer (1-4): ");
            int userAnswer = Convert.ToInt32(Console.ReadLine());

            // Validate the answer
            if (userAnswer >= 1 && userAnswer <= question.Choices.Count) {
                string selectedChoice = question.Choices[userAnswer - 1];

                if (selectedChoice == question.CorrectAnswer) {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else {
                    Console.WriteLine($"Incorrect! The correct answer is: {question.CorrectAnswer}");
                }
            }
            else {
                Console.WriteLine("Invalid answer!");
            }
        }

        Console.WriteLine("\nQuiz complete!");
        Console.WriteLine($"Your score: {score}/{questions.Count}");
    }
}

class Question {
    public string Text { get; set; }
    public List<string> Choices { get; set; }
    public string CorrectAnswer { get; set; }

    public Question(string text, List<string> choices, string correctAnswer) {
        Text = text;
        Choices = choices;
        CorrectAnswer = correctAnswer;
    }
}
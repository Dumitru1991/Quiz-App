using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralQuiz
{
    class Quiz
    {
        private string[,] questions = new string[20, 5];
        public Quiz()
        {
            questions[0, 0] = "How many human players are there on each side in a polo match?";
            questions[0, 1] = "Five";
            questions[0, 2] = "Six";
            questions[0, 3] = "*Four";
            questions[0, 4] = "Seven";
            //
            questions[1, 0] = "In which European country would you find the Rijksmuseum?";
            questions[1, 1] = "Iceland";
            questions[1, 2] = "*Netherlands";
            questions[1, 3] = "Sweden";
            questions[1, 4] = "Germany";
            //
            questions[2, 0] = "What is the smallest planet in our solar system?";
            questions[2, 1] = "*Mercury";
            questions[2, 2] = "Mars";
            questions[2, 3] = "Venus";
            questions[2, 4] = "Earth";
            //
            questions[3, 0] = "Which European city hosted the 1936 Summer Olympics?";
            questions[3, 1] = "*Berlin";
            questions[3, 2] = "Madrid";
            questions[3, 3] = "Paris";
            questions[3, 4] = "Roma";
            //
            questions[4, 0] = "Which colour pill does Neo swallow in The Matrix?";
            questions[4, 1] = "White";
            questions[4, 2] = "Blue";
            questions[4, 3] = "*Red";
            questions[4, 4] = "Purple";
            //
            questions[5, 0] = "Which US state was Donald Trump born in?";
            questions[5, 1] = "Chicago";
            questions[5, 2] = "*New York";
            questions[5, 3] = "Denver";
            questions[5, 4] = "San Francisco";
            //
            questions[6, 0] = "How many keys are there on a piano?";
            questions[6, 1] = "79";
            questions[6, 2] = "*88";
            questions[6, 3] = "92";
            questions[6, 4] = "65";
            //
            questions[7, 0] = "What is the best-selling novel of all time?";
            questions[7, 1] = "The Alchemist";
            questions[7, 2] = "Da Vinci Code";
            questions[7, 3] = "Lord of the Rings";
            questions[7, 4] = "*Don Quixote";
            //
            questions[8, 0] = "How many elements are in the periodic table?";
            questions[8, 1] = "115";
            questions[8, 2] = "116";
            questions[8, 3] = "117";
            questions[8, 4] = "*118";
            //
            questions[9, 0] = "In which year was the Microsoft XP operating system released?";
            questions[9, 1] = "*2001";
            questions[9, 2] = "2000";
            questions[9, 3] = "1999";
            questions[9, 4] = "2002";
            //
            questions[10, 0] = "How many Pirates of the Caribbean films have been released?";
            questions[10, 1] = "6";
            questions[10, 2] = "7";
            questions[10, 3] = "4";
            questions[10, 4] = "*5";
        }
        public string getQuestion(int i)
        {
            return questions[i, 0];
        }
        public string getAnswer(int i,int j)
        {
            return questions[i, j];
        }

    }
}

using ExercisesCore.Test_Monty_Hall.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercisesCore.Test_Monty_Hall
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Participant[] participants = new Participant[100];
        //    Random rand = new Random();

        //    for (int i = 0; i < participants.Length; i++)
        //    {
        //        participants[i] = new Participant(rand.Next(3));

        //        int moneyDoor = rand.Next(3);

        //        int aux = moneyDoor;

        //        if (participants[i].Choice == moneyDoor)
        //        {
        //            bool check;
        //            do
        //            {
        //                aux = rand.Next(3);
        //                check = aux != participants[i].Choice;
        //            } while (!check);
        //        }

        //        if (Switch(i)) participants[i].Choice = aux;

        //        participants[i].Result = participants[i].Choice == moneyDoor;
        //    }

        //    Participant[] switchParticipants = participants.Take(50).ToArray();
        //    Participant[] stayedParticipants = participants.Except(switchParticipants).ToArray();

        //    double winRate1 = WinRate(switchParticipants);
        //    double winRate2 = WinRate(stayedParticipants);

        //    Console.WriteLine($"\nWin rate of participants that switched: { winRate1.ToString("F2")}%");
        //    Console.WriteLine($"Win rate of participants that didn't switch: { winRate2.ToString("F2")}%");

        //}

        static bool Switch(int participantNum)
        {
            return participantNum < 50;
        }

        static double WinRate(Participant[] participantsHalf)
        {
            double wins = participantsHalf.Where(p => p.Result).Count();
            Console.WriteLine("Wins: " + wins);
            return wins / 50 * 100;
        }
    }
}

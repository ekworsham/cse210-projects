using System.ComponentModel;
using System.Runtime.InteropServices;
using System.IO;
using System.Drawing;


public class GoalManager
{

    private List<Goal> _goals;

    private int _score;
    
    public GoalManager()
    {
        _goals = new List<Goal>(); 
        _score = 0;
    }

    public void Start()
    {
        int response = 0;

        while (response < 6)
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            response = int.Parse (Console.ReadLine());
            Console.WriteLine();

            if (response == 1)
            {
                CreateGoals();    
            }
            else if (response == 2)
            {
                ListGoalDetails();
            }
            else if (response == 3)
            {
                SaveGoals();
            }
            else if (response == 4)
            {
                LoadGoals();
            }
            else if (response == 5)
            {
                RecordEvent();
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }
    public void ListGoalNames()
    {
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetName()}");
            i++;
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }
    }
    public void CreateGoals()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int userInput = int.Parse (Console.ReadLine());  
        if(userInput == 1)
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string goalDiscription = Console.ReadLine();
            Console.Write("What is amount of points associated with this goal? ");
            int goalPoints = int.Parse (Console.ReadLine());
            SimpleGoal s = new SimpleGoal(goalName, goalDiscription, goalPoints);
            _goals.Add(s);
        }
        else if(userInput == 2)
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string goalDiscription = Console.ReadLine();
            Console.Write("What is amount of points associated with this goal? ");
            int goalPoints = int.Parse (Console.ReadLine());
            EternalGoal s = new EternalGoal(goalName, goalDiscription, goalPoints);
            _goals.Add(s);
        }
        else if(userInput == 3)
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string goalDiscription = Console.ReadLine();
            Console.Write("What is amount of points associated with this goal? ");
            int goalPoints = int.Parse (Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplised for a bonus? ");
            int qntAccomplish = int.Parse (Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse (Console.ReadLine());
            ChecklistGoal s = new ChecklistGoal(goalName, goalDiscription, goalPoints, qntAccomplish, bonus);
            _goals.Add(s);
        }
    }
    public void RecordEvent()
    {   
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int userInput = int.Parse (Console.ReadLine());
        int earnedPoints = _goals[userInput - 1].RecordEvent();
        Console.WriteLine($"Congratulations! You have earned {earnedPoints} points!");
        _score = _score + earnedPoints;
        Console.WriteLine($"You now have {_score} points.");
        Console.WriteLine();
    }
    
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_score}");
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine (goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _score = int.Parse (lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string goalType = parts[0];
            string goalDetails = parts[1];
            if (goalType == "SimpleGoal")
            {
                string[] goalParts = goalDetails.Split(",");
                string name = goalParts[0];
                string description = goalParts[1];
                int points = int.Parse(goalParts[2]);
                string isComplete = goalParts[3];
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                if (isComplete == "True")
                {
                    simpleGoal.RecordEvent();
                }
                _goals.Add(simpleGoal);
            }
            else if (goalType == "EternalGoal")
            {
                string[] goalParts = goalDetails.Split(",");
                string name = goalParts[0];
                string description = goalParts[1];
                int points = int.Parse(goalParts[2]);
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
            }
            else if (goalType == "ChecklistGoal")
            {
                string[] goalParts = goalDetails.Split(",");
                string name = goalParts[0];
                string description = goalParts[1];
                int points = int.Parse(goalParts[2]);
                int bonus = int.Parse(goalParts[3]);
                int target = int.Parse(goalParts[4]);
                int amountCompete = int.Parse(goalParts[5]);
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                checklistGoal.SetAmountComplete(amountCompete);
                _goals.Add(checklistGoal);
            }
        }        
    }   
}
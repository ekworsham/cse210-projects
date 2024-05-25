using System.ComponentModel;
using System.Runtime.InteropServices;

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
            Console.Clear();
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
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
    }
    public void ListGoalDetails()
    {

    }
    public void CreateGoals()
    {
        Console.WriteLine("The types of Goals are:");
        ListGoalNames();
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

    }
    public void SaveGoals()
    {

    }
    public void LoadGoals()
    {

    }

    
}
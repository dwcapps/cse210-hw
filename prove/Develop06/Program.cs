class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}

// Attempted to exceed stretch goals by:
// - Adding option to delete a goal
// - Added point penalty if you delete a goal that you did not already complete (to discourage making unreasonable goals and giving up on goals)
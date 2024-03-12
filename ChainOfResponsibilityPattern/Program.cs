// See https://aka.ms/new-console-template for more information
ClaimApprover junior = new Manager();
ClaimApprover sukhpinder = new Manager();
ClaimApprover singh = new SeniorManager();
junior.SetSuccessor(sukhpinder);
sukhpinder.SetSuccessor(singh);

Claim c1 = new Claim() { amount = 999, Id = 1001 };
Claim c2 = new Claim() { amount = 10001, Id = 1002 };

junior.ApproveRequest(c1);
sukhpinder.ApproveRequest(c2);

public class Junior : ClaimApprover
{
    public override void ApproveRequest(Claim claim)
    {
        System.Console.WriteLine("Cannot approve");
    }
}
public class Manager : ClaimApprover
{
    public override void ApproveRequest(Claim claim)
    {
        if (claim.amount >= 100 && claim.amount <= 1000)
        {
            System.Console.WriteLine($"Claim reference {claim.Id} with amount {claim.amount} is approved by Manager");
        }
        else if (claimApprover != null)
        {
            claimApprover.ApproveRequest(claim);
        }
    }
}

public class SeniorManager : ClaimApprover
{
    public override void ApproveRequest(Claim claim)
    {
        if (claim.amount > 1000 && claim.amount <= 10000)
        {
            System.Console.WriteLine($"Claim reference {claim.Id} with amount {claim.amount} is approved by Senior Manager");
        }
        else
        {
            System.Console.WriteLine($"Exceptional approval for Claim reference {claim.Id} with amount {claim.amount} is approved by Senior Manager");
        }
    }
}
public class Claim
{
    public int Id { get; set; }
    public double amount { get; set; }
}

public abstract class ClaimApprover
{
    protected ClaimApprover claimApprover;
    public void SetSuccessor(ClaimApprover claimApprover)
    {
        this.claimApprover = claimApprover;
    }
    public abstract void ApproveRequest(Claim claim);
}

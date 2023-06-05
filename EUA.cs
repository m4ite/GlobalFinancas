public class EUADismissalProcess : DismissalProcess
{
    public override string Title => "Employee's Dismissal";
 
    public override void Apply(DismissalArgs args)
    {
        args.Company.Money -= 1 * args.Employe.Wage;
    }
}
 
public class EUAWagePaymentProcess : WagePaymentProcess
{
    public override string Title => "Salary Payment";
 
    public override void Apply(WagePaymentArgs args)
    {
        args.Company.Money -= 1.25m * args.Employe.Wage + 400;
    }
}

public class EUAHiringProcess : HiringProcess
{
    public override string Title => "Hiring";
 
    public override void Apply(HiringArgs args)
    {
        args.Company.Money -= 1.20m * args.Employe.Wage;
    }
}
 
public class EUAProcessFactory : IProcessFactory
{
    public DismissalProcess CreateDismissalProcess()
        => new EUADismissalProcess();
 
    public WagePaymentProcess CreateWagePaymentProcess()
        => new EUAWagePaymentProcess();
    public HiringProcess CreateHiringProcess()
        => new EUAHiringProcess();
}
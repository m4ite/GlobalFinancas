public interface IProcessFactory
{
  WagePaymentProcess CreateWagePaymentProcess();
  DismissalProcess CreateDismissalProcess();
  HiringProcess CreateHiringProcess();
  
}
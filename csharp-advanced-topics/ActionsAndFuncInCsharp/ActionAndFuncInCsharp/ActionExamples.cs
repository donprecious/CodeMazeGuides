namespace ActionAndFuncInCsharpConsole;
using  System;
public class ActionExamples
{
    public System.Action<string> LoggerInfo; 
    private Action Logger;
  
    private Action<string, string> Notify;
  
    public void Print()
    {
        LoggerInfo("logging message");

    }

    public void Print(string message)
    {
        LoggerInfo(message);
    }
    

    public void Compute2(System.Action<string> LoggerInfo )
    {
        LoggerInfo("Starting Job"); 
        // do some operation here 
        
        LoggerInfo("Job Operation Completed");
    }

    public void SendMessage(string message, string to, System.Action<string, string> Notify)
    {
        Notify(message, to);
    }
    
    public void DoSomeWork()
    {
        
        var message = "hello work done";
        var phone = "+1233333333";
        var email = "example@x.com"; 
        SendMessage(message, phone, SendSms);
        SendMessage(message, phone, SendEmail);
    }

    private void SendEmail(string message, string email)
    {
        // send some email
       LoggerInfo("send email completed");
    }
    
    private void SendSms(string message, string phone)
    {
        // send some email 
        LoggerInfo("send sms completed");
    }
    
    public void DoSomeWork2()
    {
        Compute2(Print);
    }
    
    // Action delegate with 0 parameters
    public delegate void Action();

    // Action delegate with 1 parameter
    public delegate void Action<T>(T obj);

    // Action delegate with 2 parameters
    public delegate void Action<T1, T2>(T1 arg1, T2 arg2);
    
    // ... up to 16 parameters

}
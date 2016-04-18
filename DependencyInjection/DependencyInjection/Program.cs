using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public interface INotificationAction
    {
        void ActOnNotification(string message);
    }

    #region concrete classes
    public class EventLogWriter : INotificationAction
    {
        public void ActOnNotification(string message)
        {
            //Write a event log here
            Console.WriteLine(message);
        }
    }

    public class EmailSender : INotificationAction
    {
        public void ActOnNotification(string message)
        {
            //Write a event log here
            Console.WriteLine(message);
        }
    }

    public class SMSSender : INotificationAction
    {
        public void ActOnNotification(string message)
        {
            //Write a event log here
            Console.WriteLine(message);
        }
    }

    #endregion
    class AppPoolWatcher
    {
        // Handle to EventLog writer to write to the logs
        INotificationAction action = null;

        #region Property Injection
        //public INotificationAction Action
        //{
        //    get
        //    {
        //        return action;
        //    }
        //    set
        //    {
        //        action = value;
        //    }
        //}

        //public void Notify(string message)
        //{
        //    if (action == null)
        //    {
        //        // Here we will match the abstraction i.e interface to concrete class
        //    }
        //    action.ActOnNotification(message);
        //}
        #endregion  

        #region Constructor Injection
        //public AppPoolWatcher(INotificationAction concreteImplementation)
        //{
        //    this.action = concreteImplementation;
        //}

        //// The function will be called when app pool has problem
        //public void Notify(string message)
        //{
        //    if (action == null)
        //    {
        //       // Here we will match the abstraction i.e interface to concrete class
        //    }
        //    action.ActOnNotification(message);
        //}
        #endregion

        #region Method Injection
         //The function will be called when app pool has problem
        public void Notify(INotificationAction concreteAction , string message)
        {
            this.action = concreteAction;
            if (action == null)
            {
                // Here we will match the abstraction i.e interface to concrete class
            }
            action.ActOnNotification(message);
        }
        #endregion
    }


    class Program 
    {

        static void Main(string[] args)
        {
            #region Constructor Injection
            //EventLogWriter writer = new EventLogWriter();
            //AppPoolWatcher watcher = new AppPoolWatcher(writer);
            //watcher.Notify("check this out eventlog");
            #endregion

            #region Method Injection
            EventLogWriter writer = new EventLogWriter();
            AppPoolWatcher watcher = new AppPoolWatcher();
            watcher.Notify(writer, "check this out eventlog");
            #endregion

            #region Property Injection
            //EventLogWriter writer = new EventLogWriter();
            //AppPoolWatcher watcher = new AppPoolWatcher();
            //watcher.Action = writer;
            //watcher.Notify("Event Log Writer ");
            #endregion
            Console.ReadLine();


        }
    }
}
